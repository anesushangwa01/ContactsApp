using ContactsApp.Models;
using Contact = ContactsApp.Models.Contact;

namespace ContactsApp.Views
{
    [QueryProperty(nameof(Id), "Id")]
    public partial class EditContactPage : ContentPage
    {
        private Contact? contact;

        public EditContactPage()
        {
            InitializeComponent();
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync((".."));
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            if (contact != null)
            {
                contact.Name = NameEntry.Text;
                contact.Email = EmailEntry.Text;
                contact.Phone = PhoneEntry.Text;
                contact.Address = AddressEntry.Text;
                contact.Status = StatusEntry.Text;
                ContactRepo.UpdateContact(contact);
                await Shell.Current.GoToAsync((".."));
            }
        }

        public string Id 
        {
            set
            {
                if (int.TryParse(value, out int id))
                {
                    contact = ContactRepo.GetContactById(id);
                    if (contact is not null)
                    {
                        NameEntry.Text = contact.Name;
                        EmailEntry.Text = contact.Email;
                        PhoneEntry.Text = contact.Phone;
                        AddressEntry.Text = contact.Address;
                        StatusEntry.Text = contact.Status;
                    }
                }
            }
        }
    }
}
