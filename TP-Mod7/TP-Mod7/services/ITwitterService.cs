using System;
using System.Collections.Generic;
using System.Text;
using TP_Mod7.models;

namespace TP_Mod7.services
{
    interface ITwitterService
    {

        bool Authenticate(String utilisateur, String password);
        List<Tweet> GetTweets(String chaine);

        /*
        public bool Authenticate(String utilisateur, String password) {
            return false;
        }

        public List<Tweet> GetTweets(string chaine) {
            return List<Tweet>;
        }
        */
    }
}
