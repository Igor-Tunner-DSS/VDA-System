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
            foreach (System.Collections.DictionaryEntry e in Environment.GetEnvironmentVariables())
            {
                if (e.Key.ToString().StartsWith("DB_"))
                    Console.WriteLine($"{e.Key}={e.Value}");
            }
            string _host = Environment.GetEnvironmentVariable("DB_HOST");
            string _username = Environment.GetEnvironmentVariable("DB_USER");
            string _password = Environment.GetEnvironmentVariable("DB_PASS");
            string _database = Environment.GetEnvironmentVariable("DB_NAME");

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
            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Employee employee = new Employee
                (
                    reader.GetInt16(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    DateOnly.FromDateTime(reader.GetDateTime(3)),
                    DateOnly.FromDateTime(reader.GetDateTime(4)),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetInt16(8)
                );
                employees.Add(employee);
            }
            return employees;
        }
    }
}
