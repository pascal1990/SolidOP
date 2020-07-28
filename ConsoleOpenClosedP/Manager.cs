using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOpenClosedP
{
    public class Manager : ICandidat
    {
        public ICompte Compte { get; set; } = new CompteManager();
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
