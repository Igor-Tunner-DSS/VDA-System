using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Configuration;
using System.Diagnostics;
using VDA_Core.Model;
using VDA_Core.Model.Entities;

namespace CLIADM
{
    public class CLIADM
    {
        private static readonly DatabaseContext _db = new DatabaseContext();
        private static List<string> tableNames = new List<string>();
        private static List<AppUser> users = new List<AppUser>();
        private static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.WriteLine("Querying database information...");
            Initialize();
            Console.WriteLine("All done!");
            Thread.Sleep(400);
            ShowMainMenu();
        }

        private async static void Initialize()
        {
            tableNames = await _db.GetTables();
            users = await _db.GetUsers();
            employees = await _db.GetEmployees();
        }

        // --- Main menu ---
        static void ShowMainMenu()
        {
            Console.Clear();

            // Fancy header
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine("║              USER MANAGEMENT MENU            ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            // Menu options
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" [1]  ➜  Add User");
            Console.WriteLine(" [2]  ➜  Delete User");
            Console.WriteLine(" [3]  ➜  List Users");
            Console.WriteLine(" [4]  ➜  List Employees");
            Console.WriteLine(" [5]  ➜  List Other Tables");
            Console.WriteLine(" [6]  ➜  Open Application");
            Console.WriteLine(" [0]  ➜  Exit");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Select an option: ");
            Console.ResetColor();

            string choice = Console.ReadLine()?.Trim();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    RemoveUser();
                    break;
                case "3":
                    ListUsers();
                    break;
                case "4":
                    ListEmployees();
                    break;
                case "5":
                    ListTables();
                    break;
                case "6":
                    OpenApplication();
                    break;
                case "0":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n👋 Goodbye! Thanks for using the User Manager.");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("⚠️  Invalid option. Press Enter to try again.");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
            }
        }

        // --- Add a new user ---
        static async void AddUser()
        {
            Console.Clear();
            Console.WriteLine("--- Add New User ---");
            Console.Write("Enter company ID: ");
            string idString = Console.ReadLine().Trim();
            int id;
            if (idString.Equals(""))
            {
                Console.WriteLine("User cannot have an empty ID. Refer to your company for employee identification");
                Console.ReadLine();
                AddUser();
                return;
            }
            bool isNumeric = int.TryParse(idString, out id);
            if (!isNumeric)
            {
                Console.WriteLine("Invalid ID value. The ID can only be an integer value");
                Console.ReadLine();
                AddUser();
                return;
            }
            if (!IdExists(id))
            {
                Console.WriteLine("Invalid ID value. There is no employee matching this ID");
                Console.ReadLine();
                AddUser();
                return;
            }



            Console.Write("Enter login: ");
            string login = Console.ReadLine().Trim();

            if (login.Trim().Equals(""))
            {
                Console.WriteLine("User cannot have an empty login");
                Console.ReadLine();
                AddUser();
                return;
            }

            string password = ReadPassword("Enter password: ").Trim();
            string passwordConfirm = ReadPassword("Confirm password: ").Trim();


            if (password.Trim().Equals(""))
            {
                Console.WriteLine("User cannot have an empty password");
                Console.ReadLine();
                AddUser();
                return;
            }
            if (password != passwordConfirm)
            {
                Console.WriteLine("\nPasswords do not match. Press Enter to try again.");
                Console.ReadLine();
                AddUser();
                return;
            }


            (string hash, string salt) hashedPasword = PasswordHasher.Hash(password);

            try
            {
                _db.InsertUser(new AppUser(id, login, hashedPasword.hash, hashedPasword.salt));

                Console.WriteLine("\nUser added successfully! Press Enter to continue.");
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Communicating changes to database...");
                users = await _db.GetUsers();
                Console.WriteLine("\nAll done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }

            Console.ReadLine();
        }

        private static async void RemoveUser()
        {
            Console.Clear();
            Console.WriteLine("--- Remove User ---");
            Console.Write("Enter company ID: ");
            string idString = Console.ReadLine().Trim();
            int id;
            if (idString.Equals(""))
            {
                Console.WriteLine("User cannot have an empty ID. Refer to your company for employee identification");
                Console.ReadLine();
                AddUser();
                return;
            }
            bool isNumeric = int.TryParse(idString, out id);
            if (!isNumeric)
            {
                Console.WriteLine("Invalid ID value. The ID can only be an integer value");
                Console.ReadLine();
                AddUser();
                return;
            }
            if (!IdExists(id))
            {
                Console.WriteLine("Invalid ID value. There is no employee matching this ID");
                Console.ReadLine();
                AddUser();
                return;
            }

            AppUser? userDeleted = null;
            foreach (AppUser user in users)
            {
                if (user.id == id)
                {
                    userDeleted = user;
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("DELETING THE FOLLOWING USER:");
            int[] widths = { 5, 30, 40, 30 };
            PrintLine(widths);
            PrintRow(new string[] { "ID", "Login", "Password Hash", "Password Salt" }, widths);
            PrintLine(widths);

            string[] row = {
            userDeleted.id.ToString(),
            userDeleted.login,
            userDeleted.passwordHash,
            userDeleted.passwordSalt
        };
            PrintRow(row, widths);
            PrintLine(widths);

            Console.WriteLine("\n\nProceed? (y/N)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y") return;

            try
            {
                _db.DeleteRowById<AppUser>(id);

                Console.WriteLine("\nUser added successfully! Press Enter to continue.");
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Communicating changes to database...");
                users = await _db.GetUsers();
                Console.WriteLine("\nAll done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }

            Console.ReadLine();
        }

        private static bool IdExists(int id)
        {
            bool result = false;

            foreach (Employee employee in employees)
            {
                if (employee.id == id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        // --- List all users ---
        static async void ListUsers()
        {
            Console.Clear();
            PrintAppUsersTable(users);

            Console.WriteLine("\nPress Enter to return to menu.");
            Console.ReadLine();
        }

        static async void ListTables()
        {
            Console.Clear();

            // Wait in case tableNames isn't populated yet
            if (tableNames == null || tableNames.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No tables found in the schema.\n");
                Console.ResetColor();
                Console.WriteLine("Press Enter to return to menu.");
                Console.ReadLine();
                return;
            }

            // Define column headers and width
            string[] headers = { "Table Name" };
            int[] widths = { 40 }; // you can increase this if your table names are long

            // Calculate total width
            int totalWidth = widths.Sum() + widths.Length + 1;
            string title = "DATABASE TABLES";

            // Draw centered title box
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔" + new string('═', totalWidth - 2) + "╗");

            int padding = (totalWidth - 2 - title.Length) / 2;
            string centeredTitle = "║" + new string(' ', padding) + title + new string(' ', totalWidth - 2 - title.Length - padding) + "║";
            Console.WriteLine(centeredTitle);

            Console.WriteLine("╚" + new string('═', totalWidth - 2) + "╝");
            Console.ResetColor();

            // Print header
            PrintLine(widths);
            PrintRow(headers, widths, ConsoleColor.Green);
            PrintLine(widths);

            // Print table names
            foreach (var table in tableNames)
            {
                PrintRow(new string[] { table }, widths);
            }

            PrintLine(widths);
            Console.ResetColor();

            Console.WriteLine("\nPress Enter to return to menu.");
            Console.ReadLine();
        }

        static async void ListEmployees()
        {
            PrintEmployeesTable(employees);

            Console.WriteLine("\nPress Enter to return to menu.");
            Console.ReadLine();
        }

        private static async void OpenApplication()
        {
            try
            {
                RunDotNetCommand("run --project ../../../../VDA-Application/VDA-Application.csproj");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        public static void PrintAppUsersTable(List<AppUser> users)
        {

            // Define columns and widths
            string[] headers = { "ID", "Login", "Password Hash", "Password Salt" };
            int[] widths = { 5, 30, 40, 30 };

            int totalWidth = widths.Sum() + widths.Length + 1; // columns + '|' separators
            string title = "APPLICATION USERS";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔" + new string('═', totalWidth - 2) + "╗");

            // Dynamically center the title
            int padding = (totalWidth - 2 - title.Length) / 2;
            string centeredTitle = "║" + new string(' ', padding) + title + new string(' ', totalWidth - 2 - title.Length - padding) + "║";
            Console.WriteLine(centeredTitle);

            Console.WriteLine("╚" + new string('═', totalWidth - 2) + "╝");
            Console.ResetColor();

            if (users == null || users.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No users found.\n");
                Console.ResetColor();
                return;
            }

            PrintLine(widths);
            PrintRow(headers, widths, ConsoleColor.Green);
            PrintLine(widths);

            foreach (var user in users)
            {
                string[] row = {
            user.id.ToString(),
            user.login,
            user.passwordHash,
            user.passwordSalt
        };
                PrintRow(row, widths);
            }

            PrintLine(widths);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Total users: {users.Count}");
            Console.ResetColor();
        }

        public static void PrintEmployeesTable(List<Employee> employees)
        {
            Console.Clear();

            // Column headers and widths
            string[] headers = { "ID", "Last Name", "First Name", "Birth Date", "Hire Date", "City", "Country", "Reports To" };
            int[] widths = { 5, 15, 15, 12, 12, 15, 15, 12 };

            // Calculate total width dynamically (columns + separators)
            int totalWidth = widths.Sum() + widths.Length + 1;
            string title = "EMPLOYEE DIRECTORY";

            // Draw header box with dynamically centered title
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔" + new string('═', totalWidth - 2) + "╗");

            int padding = (totalWidth - 2 - title.Length) / 2;
            string centeredTitle = "║" + new string(' ', padding) + title + new string(' ', totalWidth - 2 - title.Length - padding) + "║";
            Console.WriteLine(centeredTitle);

            Console.WriteLine("╚" + new string('═', totalWidth - 2) + "╝");
            Console.ResetColor();

            // Handle no employees
            if (employees == null || employees.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No employees found.\n");
                Console.ResetColor();
                return;
            }

            // Print table header
            PrintLine(widths);
            PrintRow(headers, widths, ConsoleColor.Green);
            PrintLine(widths);

            // Print employee rows
            foreach (Employee emp in employees)
            {
                string[] row = {
            emp.id.ToString(),
            emp.last_name,
            emp.first_name,
            emp.birth_date?.ToString("yyyy-MM-dd") ?? "-",
            emp.hire_date?.ToString("yyyy-MM-dd") ?? "-",
            emp.city ?? "-",
            emp.country ?? "-",
            emp.reports_to?.ToString() ?? "-"
        };
                PrintRow(row, widths);
            }

            // Footer
            PrintLine(widths);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Total employees: {employees.Count}");
            Console.ResetColor();
        }

        private static void PrintLine(int[] widths)
        {
            Console.WriteLine("+" + string.Join("+", widths.Select(w => new string('-', w))) + "+");
        }

        private static void PrintRow(string[] columns, int[] widths, ConsoleColor? color = null)
        {
            if (color.HasValue)
                Console.ForegroundColor = color.Value;

            for (int i = 0; i < columns.Length; i++)
            {
                string value = columns[i].Length > widths[i]
                    ? columns[i].Substring(0, widths[i] - 4) + "..."
                    : columns[i];

                Console.Write($"| {value.PadRight(widths[i] - 1)}");
            }

            Console.WriteLine("|");
            Console.ResetColor();
        }

        // --- Read password securely ---
        static string ReadPassword(string prompt)
        {
            Console.Write(prompt);
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password[0..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }

        public static void RunDotNetCommand(string arguments, string workingDirectory = null)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "dotnet", // The executable for the .NET CLI
                Arguments = arguments,
                RedirectStandardOutput = true, // Capture output
                RedirectStandardError = true,  // Capture errors
                UseShellExecute = false,       // Do not use the OS shell
                CreateNoWindow = false          // Do not create a new window
            };

            if (!string.IsNullOrEmpty(workingDirectory))
            {
                startInfo.WorkingDirectory = workingDirectory;
            }

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Read the output and error streams
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit(); // Wait for the process to complete

                Console.WriteLine($"Command: dotnet {arguments}");
                if (!string.IsNullOrEmpty(output))
                {
                    Console.WriteLine("Output:");
                    Console.WriteLine(output);
                }
                if (!string.IsNullOrEmpty(error))
                {
                    Console.WriteLine("Error:");
                    Console.WriteLine(error);
                }
                Console.WriteLine($"Exit Code: {process.ExitCode}");
            }
        }

    }
}
