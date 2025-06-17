using Patel5d2_ContactsApp.Models;

namespace Patel5d2_ContactsApp.Views
{
    public partial class ContactDetailsPage : ContentPage
    {
        private Models.Contact selectedContact; 

        public ContactDetailsPage(Models.Contact contact) 
        {
            InitializeComponent();
            this.BindingContext = contact;
            this.selectedContact = contact; 
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}