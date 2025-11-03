using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using DotNetEnv;
using VDA_Core.Model.Entities;
using System.DirectoryServices;
using System.CodeDom;

namespace VDA_Core.Model
{
    public class DatabaseContext
    {
        private static NpgsqlDataSource? dataSource;
        private readonly string schemaName = "public";
        public DatabaseContext()
        {
            Env.TraversePath().Load();
            string? _host = Environment.GetEnvironmentVariable("DB_HOST_POOLER");
            string? _username = Environment.GetEnvironmentVariable("DB_USER_POOLER");
            string? _password = Environment.GetEnvironmentVariable("DB_PASS");
            string? _database = Environment.GetEnvironmentVariable("DB_NAME");

            string connString = $"Host={_host};Username={_username};Password={_password};Database={_database}";
            dataSource = NpgsqlDataSource.Create(connString);
        }

        // --- INSERT Operations
        public async void InsertEmployee(Employee employee)
        {
            using var cmd = dataSource.CreateCommand(
                "INSERT INTO employees (last_name, first_name, birth_date, hire_date, address, city, country, reports_to) " +
                "VALUES (@last_name, @first_name, @birth_date, @hire_date, @address, @city, @country, @reports_to)");
            cmd.Parameters.AddWithValue("last_name", employee.last_name);
            cmd.Parameters.AddWithValue("first_name", employee.first_name);
            cmd.Parameters.AddWithValue("birth_date", employee.birth_date);
            cmd.Parameters.AddWithValue("hire_date", employee.hire_date);
            cmd.Parameters.AddWithValue("address", employee.address);
            cmd.Parameters.AddWithValue("city", employee.city);
            cmd.Parameters.AddWithValue("country", employee.country);
            cmd.Parameters.AddWithValue("reports_to", employee.reports_to);
            await cmd.ExecuteNonQueryAsync();
        }

        public async void InsertUser(AppUser user)
        {
            using var cmd = dataSource.CreateCommand(
                "INSERT INTO users (id, password_hash, password_salt, login) " +
                "VALUES (@id, @password_hash, @password_salt, @login)");
            cmd.Parameters.AddWithValue("id", user.id);
            cmd.Parameters.AddWithValue("password_hash", user.passwordHash);
            cmd.Parameters.AddWithValue("password_salt", user.passwordSalt);
            cmd.Parameters.AddWithValue("login", user.login);
            await cmd.ExecuteNonQueryAsync();
        }

        
        // --- DELETE Operations
        public async void DeleteRowById<T>(int id)
        {
            var type = typeof(T);
            string query = "";
            if (type == typeof(Employee)) 
                { query = "DELETE FROM employees WHERE employee_id = @id"; }
            else if (type == typeof(AppUser)) 
                { query = "DELETE FROM users WHERE id = @id"; }

            await using var cmd = dataSource.CreateCommand(query);
            cmd.Parameters.AddWithValue("id", id);
            await cmd.ExecuteNonQueryAsync();
        }


        // --- SELECT Operations

        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            await using var cmd = dataSource.CreateCommand("SELECT employee_id, last_name, first_name, birth_date, hire_date, address, city, country, reports_to FROM employees");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Employee employee = new Employee
                (
                    id: reader.GetInt16(0),
                    last_name: reader.GetString(1),
                    first_name: reader.GetString(2),
                    birth_date: Extensions.FromDateTimeSafe(reader.GetValueSafe<DateTime>(3)),
                    hire_date: Extensions.FromDateTimeSafe(reader.GetValueSafe<DateTime>(4)),
                    address: reader.GetValueSafeRef<string>(5),
                    city: reader.GetValueSafeRef<string>(6),
                    country: reader.GetValueSafeRef<string>(7),
                    reports_to: reader.GetValueSafe<int>(8)
                );
                employees.Add(employee);
            }
            return employees;
        }

        public async Task<List<Category>> GetCategories()
        {
            List<Category> categories = new ();
            await using var cmd = dataSource.CreateCommand("SELECT category_id, name, description, parent_category_id FROM categories");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Category category = new 
                (
                    category_id: reader.GetInt16(0),
                    name: reader.GetString(1),
                    description: reader.GetValueSafeRef<string>(2),
                    parent_category_id: reader.GetValueSafe<int>(3)
                );
                categories.Add(category);
            }
            return categories;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            List<Customer> customers = new();
            await using var cmd = dataSource.CreateCommand("SELECT customer_id, contact_name, contact_email, company_name, address, city, country FROM customers");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Customer customer = new
                (
                    id: reader.GetInt16(0),
                    contact_name: reader.GetString(1),
                    contact_email: reader.GetString(2),
                    company_name: reader.GetValueSafeRef<string>(3),
                    address: reader.GetValueSafeRef<string>(4),
                    city: reader.GetValueSafeRef<string>(5),
                    country: reader.GetValueSafeRef<string>(6)
                );
                customers.Add(customer);
            }
            return customers;
        }

        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = new();
            await using var cmd = dataSource.CreateCommand("SELECT product_id, product_name, category_id, quantity_per_unit, unit_price, units_in_stock, discontinued FROM products");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Product product = new
                (
                    product_id: reader.GetInt16(0),
                    product_name: reader.GetString(1),
                    category_id: reader.GetInt16(2),
                    quantity_per_unit: reader.GetValueSafe<int>(3),
                    unit_price: reader.GetValueSafe<int>(4),
                    units_in_stock: reader.GetValueSafe<int>(5),
                    discontinued: reader.GetValueSafe<bool>(6)
                );
                products.Add(product);
            }
            return products;
        }
        public async Task<List<Purchase>> GetPurchases()
        {
            List<Purchase> purchases = new();
            await using var cmd = dataSource.CreateCommand("SELECT purchase_id, customer_id, employee_id, total_price, purchase_date, shipped_date, ship_address, ship_city, ship_country FROM purchases");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Purchase purchase = new
                (
                    purchase_id: reader.GetInt16(0),
                    customer_id: reader.GetInt16(1),
                    employee_id: reader.GetInt16(2),
                    total_price: reader.GetFloat(3),
                    purchase_date: Extensions.FromDateTimeSafe(reader.GetValueSafe<DateTime>(4)),
                    shipped_date: Extensions.FromDateTimeSafe(reader.GetValueSafe<DateTime>(5)),
                    ship_address: reader.GetValueSafeRef<string>(6),
                    ship_city: reader.GetValueSafeRef<string>(7),
                    ship_country: reader.GetValueSafeRef<string>(8)
                );
                purchases.Add(purchase);
            }
            return purchases;
        }

        public async Task<List<PurchaseItem>> GetPurchaseItens()
        {
            List<PurchaseItem> purchases = new();
            await using var cmd = dataSource.CreateCommand("SELECT purchase_id, product_id, quantity, unit_price FROM purchase_itens");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                PurchaseItem purchase = new
                (
                    purchase_id: reader.GetInt16(0),
                    product_id: reader.GetInt16(1),
                    quantity: reader.GetInt16(2),
                    unit_price: reader.GetFloat(3)
                );
                purchases.Add(purchase);
            }
            return purchases;
        }

        



        public async Task<Employee?> GetEmployee(int id)
        {
            Employee employee;
            await using var cmd = dataSource.CreateCommand("SELECT employee_id, last_name, first_name, birth_date, hire_date, address, city, country, reports_to FROM employees WHERE employee_id = @id");
            cmd.Parameters.AddWithValue("id", id);
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                employee = new Employee
                (
                    id: reader.GetInt16(0),
                    last_name: reader.GetString(1),
                    first_name: reader.GetString(2),
                    birth_date: Extensions.FromDateTimeSafe(reader.GetValueSafe<DateTime>(3)),
                    hire_date: Extensions.FromDateTimeSafe(reader.GetValueSafe<DateTime>(4)),
                    address: reader.GetValueSafeRef<string>(5),
                    city: reader.GetValueSafeRef<string>(6),
                    country: reader.GetValueSafeRef<string>(7),
                    reports_to: reader.GetValueSafe<int>(8)
                );
                return employee;
            }
            return null;
        }

        public async Task<List<AppUser>> GetUsers()
        {
            List<AppUser> appUsers = new List<AppUser>();
            await using var cmd = dataSource.CreateCommand("SELECT id, password_hash, password_salt, login FROM users");
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                AppUser user = new AppUser
                (
                    id: reader.GetInt16(0),
                    passwordHash: reader.GetString(1),
                    passwordSalt: reader.GetString(2),
                    login: reader.GetString(3)
                );
                appUsers.Add(user);
            }
            return appUsers;
        }

        public async Task<List<string>> GetTables()
        {
            List<string> tableNames = new ();
            await using var cmd = dataSource.CreateCommand(@"
            SELECT table_name
            FROM information_schema.tables
            WHERE table_schema = @schemaName
              AND table_type = 'BASE TABLE';");
            cmd.Parameters.AddWithValue("@schemaname", schemaName);
            await using NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                tableNames.Add(reader.GetString(0));
            }
            return tableNames;
        }
    }
}
