using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class PhoneContacts : IContact
    {
        public int Id { get; set; } = ListOfContacts.Contacts.Count + 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DOB DateOfBirth { get; set; }
    }
}
