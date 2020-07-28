using System;
using System.Collections.Generic;

namespace ConsoleOpenClosedP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<ICandidat> personnes = new List<ICandidat>()
            {
                new Personne(){Nom = "Fossouo", Prenom = "Pascal" },
                new Manager(){Nom = "Steward", Prenom = "Thom"},
                new Director() {Nom = "Kamdem", Prenom = "Martial"}
            };

            List<Employee> employees = new List<Employee>();

            foreach(var personne in personnes)
            {
                employees.Add(personne.Compte.createEmployee(personne));
            }
           
            
            foreach(Employee emp in employees)
            {
                Console.WriteLine($"{emp.Prenom} {emp.Nom} : {emp.Email} , Manager : {emp.isManager} , Director : {emp.isDirector}");
            }

            Console.ReadKey();
        }

       
    }
}
