using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using DotNetEnv;

namespace VDA_Application.Model
{
    internal class DatabaseContext
    {
        private static NpgsqlDataSource? dataSource;
        public DatabaseContext()
        {
            Env.TraversePath().Load();
            string? _host = Environment.GetEnvironmentVariable("DB_HOST");
            string? _username = Environment.GetEnvironmentVariable("DB_USER");
            string? _password = Environment.GetEnvironmentVariable("DB_PASS");
            string? _database = Environment.GetEnvironmentVariable("DB_NAME");

            string connString = $"Host={_host};Username={_username};Password={_password};Database={_database}";
            dataSource = NpgsqlDataSource.Create(connString);
        }

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

        
    }
}
