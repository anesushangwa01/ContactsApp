using ContactsApp.Models;
using Contact = ContactsApp.Models.Contact;
using System.Collections.ObjectModel;

namespace ContactsApp.Views
{
    public partial class ContactsPage : ContentPage
    {
        private ObservableCollection<Contact> contacts = new();

        public ContactsPage() 
        {
            InitializeComponent();
            LoadContacts();
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            LoadContacts();
        }

        private void LoadContacts()
        {
            contacts.Clear();
            foreach (var contact in ContactRepo.GetContacts())
            {
                contacts.Add(contact);
            }
            listContacts.ItemsSource = contacts;
        }

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listContacts.SelectedItem != null)
            {
                await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)listContacts.SelectedItem).Id}");
                listContacts.SelectedItem = null;
            }
        }
        private async void Add_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AddContacts));
        }
    }
}
