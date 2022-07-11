using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birtday { get; set; }

        public Client()
            {
            }

        public Client(string name, string email, DateTime birtday)
        {
            Name = name;
            Email = email;
            Birtday = birtday;
        }
    }
}
