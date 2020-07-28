using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOpenClosedP
{
    public class Employee
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public bool isManager { get; set; } = false;
        public bool isDirector { get; set; } = false;
    }
}
