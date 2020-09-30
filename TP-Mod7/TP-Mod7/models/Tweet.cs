using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Mod7.models
{
    public class Tweet
    {
        // identifiant, 
        private string identifiant;

        public string Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        //date de création,
        private string dateCreation;

        public string DateCreation
        {
            get { return dateCreation; }
            set { dateCreation = value; }
        }

        //texte, 
        private string texte;

        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

        //nom de l’utilisateur, 
        private string nomUtilisateur;

        public string NomUtilisateur
        {
            get { return nomUtilisateur; }
            set { nomUtilisateur = value; }
        }

        //identifiant de l’utilisateur
        private string idUtilisateur;

        public string IdUtilisateur
        {
            get { return idUtilisateur; }
            set { idUtilisateur = value; }
        }

        //et pseudo de l’utilisateur
        private string pseudo;

        public string Pseudo
        {
            get { return pseudo; }
            set { pseudo = value; }
        }
    }
}
