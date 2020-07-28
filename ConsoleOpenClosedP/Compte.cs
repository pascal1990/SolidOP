using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOpenClosedP
{
    public class Compte : ICompte
    {
        public Employee createEmployee(ICandidat candidat)
        {
            Employee emp = new Employee();
            emp.Nom = candidat.Nom;
            emp.Prenom = candidat.Prenom;
            emp.Email = candidat.Prenom + "." + candidat.Nom + "@jas.com";

            return emp;
        }
    }
}
