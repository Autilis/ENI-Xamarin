using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Mod7.services;
using Xamarin.Forms;

namespace TP_Mod7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.SubmitBtn.Clicked += SubmitBtn_Clicked;
        }


        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            TwitterService ts = new TwitterService();

            if (ts.Authenticate(this.Identifiant.Text, this.Password.Text))
            {
                this.Login.IsVisible = false;
                this.Tweet.IsVisible = true;
            }
            else
            {
                this.EIdentifiant.IsVisible = true;
                this.EPass.IsVisible = true;
                this.EIdentifiant.Text = "Identifiant trop court. Il doit faire au moins 3 caractères";
                this.EPass.Text = "Password trop court. Il doit faire au moins 6 caractères";
            }

            


        }
    }
}
