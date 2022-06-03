namespace ProgrammePrincipal
{
    internal class Personne
    {
        #region Propriété

        /// <summary>
        /// Le prénom de la personne
        /// </summary>
        public string Prénom { get; }

        /// <summary>
        /// Le sexe de la personne
        /// </summary>
        public Sexe Sexe { get; }

        #endregion

        #region Constructeur

        /// <param name="prenom">Le prénom de la personne</param>
        /// <param name="sexe">Le sexe de la personne</param>
        public Personne(string prenom, Sexe sexe)
        {
            Prénom = prenom;
            Sexe = sexe;
        }

        #endregion


    }
}
