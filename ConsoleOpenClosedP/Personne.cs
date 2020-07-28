using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleOpenClosedP
{
    public class Personne : ICandidat
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public ICompte Compte { get; set; } = new Compte();


    }
}
