using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VDA_Core.Model.Entities
{
    public class AppUser
    {
        public int id { get; private set; }
        public string login { get; private set; }
        public string passwordHash { get; private set; }
        public string passwordSalt { get; private set; }

        public AppUser(int id, string login, string passwordHash, string passwordSalt) {
            this.id = id;
            this.login = login;
            this.passwordHash = passwordHash;
            this.passwordSalt = passwordSalt;
        }

    }
}
