using Patel5d2_ContactsApp.Models;
using Patel5d2_ContactsApp.Views;

namespace Patel5d2_ContactsApp
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private async void OnContactSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Models.Contact selectedContact)
            {
                await Navigation.PushAsync(new ContactDetailsPage(selectedContact));
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}