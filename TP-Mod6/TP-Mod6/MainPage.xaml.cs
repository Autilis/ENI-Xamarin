using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP_Mod6
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
            bool isIdentifiant = false;
            bool isPassword = false;

            int LengthIdentifiant;
            int LengthPassword;

            if (String.IsNullOrEmpty(this.Identifiant.Text))
            {
                LengthIdentifiant = 0;
            }
            else
            {
                LengthIdentifiant = this.Identifiant.Text.Length;
            }

            if (String.IsNullOrEmpty(this.Password.Text))
            {
                LengthPassword = 0;
            }
            else
            {
                LengthPassword = this.Password.Text.Length;
            }

            System.Diagnostics.Debug.WriteLine("TEST du click");
            System.Diagnostics.Debug.WriteLine(this.Identifiant.Text + " - " + this.Password.Text + " - " + this.Memoriser.IsToggled);
            
            if (LengthIdentifiant < 3)
            {
                System.Diagnostics.Debug.WriteLine("Identifiant trop court. Il doit faire au moins 3 caractères");
                this.EIdentifiant.IsVisible = true;
                this.EIdentifiant.Text = "Identifiant trop court. Il doit faire au moins 3 caractères";
            }
            else
            {
                //this.EIdentifiant.Text = "";
                this.EIdentifiant.IsVisible = false;
                isIdentifiant = true;
            }

            if (LengthPassword < 6)
            {
                System.Diagnostics.Debug.WriteLine("Password trop court. Il doit faire au moins 6 caractères");
                this.EPass.IsVisible = true;
                this.EPass.Text = "Password trop court. Il doit faire au moins 6 caractères";

            }
            else
            {
                //this.EPass.Text = "";
                this.EPass.IsVisible = false;
                isPassword = true;
            }

            if (isIdentifiant && isPassword)
            {
                this.Login.IsVisible = false;
                this.Tweet.IsVisible = true;
            }
        }
    }
}
