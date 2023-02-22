using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class Personal
    {
        private string _name;
        private string _email;
        private string _pw;
        private string _address;
        private string _phone;
        private int _pin;
        public string Name { get; set; }
        public int Pin { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Personal()
        {
            Name = _name;
            Password = _pw;
            Email = _email;
            Pin = _pin;
            Address = _address;
            Phone = _phone;

        }
    }
}
