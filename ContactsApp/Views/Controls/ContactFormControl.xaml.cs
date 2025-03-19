using ContactsApp.Models;

namespace ContactsApp.Controls
{
    public partial class ContactFormControl : ContentView
    {
        public event EventHandler<string>? OnErrorMessage;
        public event EventHandler? OnContactSaved;
        public event EventHandler? OnContactCancelled;
        public event EventHandler? OnContactDeleted;
        public ContactFormControl()
        {
            InitializeComponent();
        }
        public string Name
        {
            get => NameEntry.Text;
            set => NameEntry.Text = value;
        }
        public string Email
        {
            get => EmailEntry.Text;
            set => EmailEntry.Text = value;
        }
        public string Phone
        {
            get => PhoneEntry.Text;
            set => PhoneEntry.Text = value;
        }
        public string Address
        {
            get => AddressEntry.Text;
            set => AddressEntry.Text = value;
        }    
        public string Status
        {
            get => StatusEntry.Text;
            set => StatusEntry.Text = value;
        }       

       private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            // Shell.Current.GoToAsync("..");
            OnContactCancelled?.Invoke(sender, e);
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {

              if (NameValidationBehavior.IsNotValid)
            {
                // await DisplayAlert("Error", "Name is required and must be between 3 and 50 characters.", "OK");
                 OnErrorMessage?.Invoke(sender, "Name is required and must be between 3 and 50 characters.");
                return;
            }

            if (EmailValidationBehavior.IsNotValid)
            { 
                OnErrorMessage?.Invoke(sender, "Please enter a valid email address.");
                // await DisplayAlert("Error", "Please enter a valid email address.", "OK");
                return;
            }

            if (PhoneValidationBehavior.IsNotValid)
            {
                OnErrorMessage?.Invoke(sender, "Please enter a valid phone number.");
                // await DisplayAlert("Error", "Please enter a valid phone number.", "OK");
                return;
            }

            if (StatusValidationBehavior.IsNotValid)
            {
                OnErrorMessage?.Invoke(sender, "Status must be one of: Friend, Family, Work, or Other.");
                // await DisplayAlert("Error", "Status must be one of: Friend, Family, Work, or Other.", "OK");
                return;
            }

            OnContactSaved?.Invoke(sender, e);
        }
        
}
}