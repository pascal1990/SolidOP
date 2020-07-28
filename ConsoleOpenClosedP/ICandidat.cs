namespace ConsoleOpenClosedP
{
    public interface ICandidat
    {
        ICompte Compte { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
    }
}