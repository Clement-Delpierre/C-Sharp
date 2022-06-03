using ProgrammePrincipal;

namespace SuiviBancaire
{
    internal class Program
    {
        static void Main()
        {
            // Création de la personne Jean-Régis de sexe masculin
            Personne jr = new("Jean-Régis", Sexe.M);


            // Création du compte du Jean-Régis
            Compte compte = new(jr);

            // Opérations sur le compte de Jean-Régis et affiche de l'évolution du compte

            // Compte initial
            compte.Affiche();

            // Ajout de 65€ au compte
            compte.Versement(65);
            compte.Affiche();

            // Retrait de 20€ du compte
            compte.Retrait(20);
            compte.Affiche();

            // Retrait de 80€ du compte, refusé
            compte.Retrait(80);
            compte.Affiche();

            // Calcule et ajout des intérêts au compte
            compte.VersementInteret();
            compte.Affiche();
        }
    }
}