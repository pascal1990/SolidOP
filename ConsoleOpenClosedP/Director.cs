using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOpenClosedP
{
    public class Director : ICandidat
    {
        public ICompte Compte { get; set; } = new CompteDirector();
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}
