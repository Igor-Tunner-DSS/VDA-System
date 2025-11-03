using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDA_Core.Model;
using VDA_Core.Model.Entities;

namespace VDA_Core.Controller
{
    public class AuthController
    {
        private static readonly DatabaseContext _db = new DatabaseContext();
        public static (AppUser currentUser, Employee currentEmployee) currentSession = new();

        public static async Task<bool> ValidateCredentials(string login, string password, string id)
        {
            login = login.Trim();
            password = password.Trim();
            id = id.Trim();
            bool validUser = false;

            if (login.Equals("") || password.Equals("") || id.Equals(""))
            {
                MessageBox.Show("Please fill all the necessary fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validUser;
            }
            bool isValidInt = int.TryParse(id, out int _);
            if (!isValidInt)
            {
                MessageBox.Show("Not a valid employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return validUser;
            }

            List<AppUser> users = await _db.GetUsers();

            foreach (AppUser user in users)
            {
                if (user.id.ToString() == id)
                {
                    bool passwordMatches = PasswordHasher.Verify(password, user.passwordHash, user.passwordSalt);
                    bool loginMatches = login == user.login;
                    if (!loginMatches)
                    {
                        MessageBox.Show("Login not correct for this user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (!passwordMatches)
                    {
                        MessageBox.Show("Password not correct for this user", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    if (loginMatches && passwordMatches)
                    {
                        currentSession.currentUser = user;
                        currentSession.currentEmployee = await _db.GetEmployee(user.id);
                        validUser = true;
                    }
                }
            }

            return validUser;
        }
    }
}
