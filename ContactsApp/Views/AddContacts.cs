using ContactsApp.Models; // Add this line to include the namespace where ContactsRepo is defined

namespace ContactsApp.Views
{
      public partial class AddContacts : ContentPage
    {
        public AddContacts()
        {
            InitializeComponent(); // This should be automatically generated by the XAML compiler
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync((".."));
        }


         private void BtnSave_Clicked(object sender, EventArgs e)
        {
          ContactRepo.contacts.Add(new ContactsApp.Models.Contact
            {
                Name  =   ContactForm.Name,
                Email =    ContactForm.Email,
                Phone =   ContactForm.Phone,
                Address =  ContactForm.Address,
                Status =   ContactForm.Status
            });
            Shell.Current.GoToAsync((".."));
        }
      
        private async void ShowErrorMessage(object sender, string message)
        {
            await DisplayAlert("Error", message, "OK");
        }
    }}