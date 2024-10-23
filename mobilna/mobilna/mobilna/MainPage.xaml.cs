using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage 
    {
        string[] stringsArray = new string[3] {"Dzień dobry", "Good morning", "Buenos dias" };
        uint currentIndex = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            textLabel.Text = stringsArray[++currentIndex % stringsArray.Length].ToString();
        }
    }
}
