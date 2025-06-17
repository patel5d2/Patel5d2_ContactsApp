using Patel5d2_ContactsApp.Models;
using Patel5d2_ContactsApp.Services;
using System.Collections.ObjectModel;


namespace Patel5d2_ContactsApp.ViewModels
{
    public class ContactsViewModel
    {
        public ObservableCollection<Grouping<string, Patel5d2_ContactsApp.Models.Contact>> ContactGroups { get; set; } // Fully qualify 'Contact' here

        public ContactsViewModel()
        {
            var contactsService = new ContactsService();
            var contacts = contactsService.GetContacts();

            var groupedContacts = contacts.OrderBy(c => c.Name)
                                          .GroupBy(c => c.Name[0].ToString().ToUpper())
                                          .Select(g => new Grouping<string, Patel5d2_ContactsApp.Models.Contact>(g.Key, g)); // Fully qualify 'Contact' here as well

            ContactGroups = new ObservableCollection<Grouping<string, Patel5d2_ContactsApp.Models.Contact>>(groupedContacts); // Fully qualify 'Contact' here
        }
    }

    public class Grouping<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public Grouping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}