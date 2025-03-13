  namespace ContactsApp.Models
{
    public static class ContactRepo
    {
        public static List<Contact> contacts = new List<Contact>()
        {
            new Contact { 
                Id = 1, 
                Name = "Anesu", 
                Email = "anesushangwa@gmail.com",
                Phone = "+1234567890",
                Address = "123 Main St",
                Status = "Family"
            },
            new Contact { 
                Id = 2, 
                Name = "Anesu", 
                Email = "anesushangwa@gmail.co",
                Phone = "+0987654321",
                Address = "456 Oak Ave",
                Status = "Work"
            },
            new Contact { 
                Id = 3, 
                Name = "Shangwa", 
                Email = "anesushangwa@gmail.co",
                Phone = "+1122334455",
                Address = "789 Pine Rd",
                Status = "Friend"
            },
            new Contact { 
                Id = 4, 
                Name = "Shangwa", 
                Email = "anesushangwa@gmail.co",
                Phone = "+5544332211",
                Address = "321 Elm St",
                Status = "Other"
            }
        };

        public static List<Contact> GetContacts() => contacts;

        public static Contact? GetContactById(int Id)
        {
            return contacts.FirstOrDefault(x => x.Id == Id);
        }

        public static void UpdateContact(Contact updatedContact)
        {
            var existingContact = contacts.FirstOrDefault(x => x.Id == updatedContact.Id);
            if (existingContact != null)
            {
                existingContact.Name = updatedContact.Name;
                existingContact.Email = updatedContact.Email;
                existingContact.Phone = updatedContact.Phone;
                existingContact.Address = updatedContact.Address;
                existingContact.Status = updatedContact.Status;
            }
        }
    }
}