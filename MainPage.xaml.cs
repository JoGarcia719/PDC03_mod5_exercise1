using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_Module05_Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            DateTime date = datePicker.Date;
            bool wantsNewsletter = newsletterSwitch.IsToggled;

            string message = $"Thank you, {name}! Your date of birth is {date.ToShortDateString()}.";

            if (wantsNewsletter)
            {
                message += " You have opted to receive our newsletter.";
            }

            DisplayAlert("Confirmation", message, "OK");
        }
    }
}
