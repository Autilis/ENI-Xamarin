using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewTweet : ContentPage
    {
        private ObservableCollection<Tweet> tweets;
        private Tweet currentTweet;

        public ListViewTweet()
        {
            InitializeComponent();
            tweets = new ObservableCollection<Tweet>();

            for (int i = 0; i < 20; i++)
            {
                tweets.Add(new Tweet { CreationDate = "", Identifiant = "TOT" + i, Text = "blabla" + i, UserId = "", UserName = "username1" + i, UserPseudo = "pseudo" + i });
            }

            this.TweetList.ItemsSource = tweets;
        }
    }
}