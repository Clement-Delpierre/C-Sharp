namespace ProgrammePrincipal
{
    internal class Compte
    {
        #region Propriété

        /// <summary>
        /// Le titulaire du compte
        /// </summary>
        public Personne Titulaire { get; }

        /// <summary>
        /// Le solde du compte
        /// </summary>
        public double Solde { get; private set; }

        /// <summary>
        ///  La taux d'intérêt versé par la banque au client
        /// </summary>
        public double TauxRemuneration { get; }

        #endregion

        #region Constructeur

        /// <param name="titulaire">Le titulaire du compte</param>
        public Compte(Personne titulaire)
        {
            Titulaire = titulaire;
            Solde = 0;
            TauxRemuneration = CalculTauxRemuneration(titulaire);
        }

        /// <param name="titulaire">Le titulaire du compte</param>
        /// <param name="soldeInitial">Le versement initial à la création du compte</param>
        public Compte(Personne titulaire, double soldeInitial)
        {
            Titulaire = titulaire;
            Solde = soldeInitial;
            TauxRemuneration = CalculTauxRemuneration(titulaire);

        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Fournit le taux de rémunération selon le sexe de la personne
        /// </summary>
        /// <param name="p">La personne concernée</param>
        static protected double CalculTauxRemuneration(Personne p)
        {
            if (p.Sexe == Sexe.M)
                return 0.001;
            else
                return 0.002;
        }

        /// <summary>
        /// Ajoute le montant indiqué au compte
        /// </summary>
        /// <param name="montant">Montant à ajouter</param>
        public void Versement(double montant)
        {
            Solde += montant;
        }

        /// <summary>
        /// Retire le montant indiqué du compte
        /// </summary>
        /// <param name="montant">Montant à retirer</param>
        public void Retrait(double montant)
        {
            if ((Solde - montant) < 0)
                return;
            Solde -= montant;
        }

        /// <summary>
        /// Calcule et ajoute le montant des intérêts touchés au compte
        /// </summary>
        public void VersementInteret()
        {
            Solde *= (1 + TauxRemuneration);
        }

        /// <summary>
        /// Affiche le prénom du titulaire du compte ainsi que son sexe et la somme d'argent dont il dispose
        /// </summary>
        public void Affiche()
        {
            Console.WriteLine($"Compte de {Titulaire.Prénom} ({Titulaire.Sexe})");
            Console.WriteLine($"Solde : {Solde:F2} euros");
        }   

        #endregion
    }
}