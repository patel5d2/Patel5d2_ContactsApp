using Patel5d2_ContactsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Patel5d2_ContactsApp.Services
{
    public class ContactsService
    {
        public List<Patel5d2_ContactsApp.Models.Contact> GetContacts()
        {
            return new List<Patel5d2_ContactsApp.Models.Contact>
                {
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Alice Smith", Email = "alice.s@example.com", PhoneNumber = "111-222-3333", Description = "Software Engineer", PhotoUrl = "pic1.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Andrew White", Email = "andrew.w@example.com", PhoneNumber = "111-222-4444", Description = "Project Manager", PhotoUrl = "pic2.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Aaron Brown", Email = "aaron.b@example.com", PhoneNumber = "111-222-5555", Description = "UX Designer", PhotoUrl = "pic3.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Benjamin Green", Email = "ben.g@example.com", PhoneNumber = "222-333-4444", Description = "Product Owner", PhotoUrl = "pic4.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Bella Johnson", Email = "bella.j@example.com", PhoneNumber = "222-333-5555", Description = "Data Scientist", PhotoUrl = "pic3.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Brian Davis", Email = "brian.d@example.com", PhoneNumber = "222-333-6666", Description = "DevOps Engineer", PhotoUrl = "pic1.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Catherine Wilson", Email = "catherine.w@example.com", PhoneNumber = "333-444-5555", Description = "QA Tester", PhotoUrl = "pic2.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Charles Clark", Email = "charles.c@example.com", PhoneNumber = "333-444-6666", Description = "System Administrator", PhotoUrl = "pic3.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Chloe Lewis", Email = "chloe.l@example.com", PhoneNumber = "333-444-7777", Description = "Business Analyst", PhotoUrl = "pic4.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "David Martinez", Email = "david.m@example.com", PhoneNumber = "444-555-6666", Description = "Mobile Developer", PhotoUrl = "pic2.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Diana Rodriguez", Email = "diana.r@example.com", PhoneNumber = "444-555-7777", Description = "Frontend Developer", PhotoUrl = "pic1.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Daniel Taylor", Email = "daniel.t@example.com", PhoneNumber = "444-555-8888", Description = "Backend Developer", PhotoUrl = "pic2.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Emily Anderson", Email = "emily.a@example.com", PhoneNumber = "555-666-7777", Description = "Scrum Master", PhotoUrl = "pic3.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Ethan Thomas", Email = "ethan.t@example.com", PhoneNumber = "555-666-8888", Description = "UI Designer", PhotoUrl = "pic4.png" },
                    new Patel5d2_ContactsApp.Models.Contact { Name = "Emma Moore", Email = "emma.m@example.com", PhoneNumber = "555-666-9999", Description = "Technical Lead", PhotoUrl = "pic3.png" }
                };
        }
    }
}