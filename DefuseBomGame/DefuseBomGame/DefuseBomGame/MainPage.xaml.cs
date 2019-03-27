using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DefuseBomGame
{
    public partial class MainPage : ContentPage
    {
        //initializing variables
        static string bomb = new Random().Next(1, 10).ToString();
        static int score = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        //not returning anythiing we will use 
        async void ButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //Game Over
            if (button.Text == bomb)
            {
                await DisplayAlert("Bomb Exploded !", "Game Over", "Retry");
                bomb = new Random().Next(1, 10).ToString();
                score = 0;
            }//end of if statement
            else
            {
                score += 1;
                await DisplayAlert("Bomb Defused !", "Scores" + score, "Continue");
                bomb = new Random().Next(1, 10).ToString();
            }//end of else statement
        }

    }
}
