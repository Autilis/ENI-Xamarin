using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TP_Mod7.models;
using TP_Mod7.services;

namespace TP_Mod7.services
{
    public class TwitterService : ITwitterService
    {
        public bool Authenticate(string utilisateur, string password)
        {
            bool isIdentifiant = false;
            bool isPassword = false;
            bool result = false;

            int LengthIdentifiant;
            int LengthPassword;

            if (String.IsNullOrEmpty(utilisateur))
            {
                LengthIdentifiant = 0;
            }
            else
            {
                LengthIdentifiant = utilisateur.Length;
            }

            if (String.IsNullOrEmpty(password))
            {
                LengthPassword = 0;
            }
            else
            {
                LengthPassword = password.Length;
            }

            //System.Diagnostics.Debug.WriteLine("TEST du click");
            //System.Diagnostics.Debug.WriteLine(this.Identifiant.Text + " - " + this.Password.Text + " - " + this.Memoriser.IsToggled);

            if (LengthIdentifiant < 3)
            {
                //System.Diagnostics.Debug.WriteLine("Identifiant trop court. Il doit faire au moins 3 caractères");
                //this.EIdentifiant.IsVisible = true;
                //this.EIdentifiant.Text = "Identifiant trop court. Il doit faire au moins 3 caractères";
            }
            else
            {
                //this.EIdentifiant.Text = "";
                //this.EIdentifiant.IsVisible = false;
                isIdentifiant = true;
            }

            if (LengthPassword < 6)
            {
                //System.Diagnostics.Debug.WriteLine("Password trop court. Il doit faire au moins 6 caractères");
                //this.EPass.IsVisible = true;
                //this.EPass.Text = "Password trop court. Il doit faire au moins 6 caractères";

            }
            else
            {
                //this.EPass.Text = "";
                //this.EPass.IsVisible = false;
                isPassword = true;
            }

            if (isIdentifiant && isPassword)
            {
                result = true;
            }

            return result;
        }

        public List<Tweet> GetTweets(string chaine)
        {
            //identifiant
            //date de création
            //texte,
            //nom de l’utilisateur,
            //identifiant de l’utilisateur
            //et pseudo de l’utilisateur
            List<Tweet> tw = new List<Tweet>();

            return tw;
        }
    }
}
