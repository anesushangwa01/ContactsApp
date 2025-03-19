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
          
                    contact.Name = ContactForm.Name;
                    contact.Email = ContactForm.Email;
                    contact.Phone = ContactForm.Phone;
                    contact.Address = ContactForm.Address;
                    contact.Status = ContactForm.Status;
                    
                    ContactRepo.UpdateContact(contact);
                    await Shell.Current.GoToAsync((".."));
                }
            
        }

     public new string Id
{
    set
    {
        if (int.TryParse(value, out int id))
        {
            contact = ContactRepo.GetContactById(id);
            if (contact is not null)
            {
                ContactForm.Name = contact.Name;
                ContactForm.Email = contact.Email;
                ContactForm.Phone = contact.Phone;
                ContactForm.Address = contact.Address;
                ContactForm.Status = contact.Status;
            }
        }
    }
}

        private async void ShowErrorMessage(object sender, string message)
        {
            await DisplayAlert("Error", message, "OK");
        }
    }
}
