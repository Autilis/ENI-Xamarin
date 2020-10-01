using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Services;
using TP1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListeTweet : ContentPage
    {
        private ITwitterService twitterService;
        public ListeTweet()
        {
            this.twitterService = new TwitterService();
            InitializeComponent();
            this.LoadTweets(this.StacklayoutTweets);
        }

        private void LoadTweets(StackLayout stacklayoutTweets)
        {
            foreach (var item in twitterService.GetTweets())
            {
                //stacklayoutTweets.Children.Add(new TweetView().LoadData(item));
                stacklayoutTweets.Children.Add(new ListViewTweet());
            }
        }
    }
}