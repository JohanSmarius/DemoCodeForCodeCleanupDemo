using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        private string name;
        private string email;
        public int Id { get; set; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
    }
}
