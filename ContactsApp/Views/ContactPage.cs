namespace ContactsApp.Views
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent(); 
            
        List<Contact> contacts = new List<Contact>()
        {
          
            new Contact { Name="Anesu", Email="anesushangwa@gmail.com"},
             new Contact { Name="Anesu", Email="anesushangwa@gmail.co"},
              new Contact { Name="Shangwa", Email="anesushangwa@gmail.co"}
        };

         listContacts.ItemsSource = contacts;
        }

        // private void btnEditContact_Clicked(object sender, EventArgs e)
        // {
        //     Shell.Current.GoToAsync(nameof(EditContactPage ));
          
        // }

     private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
{
    if (listContacts.SelectedItem != null)
    {
        await Shell.Current.GoToAsync(nameof(EditContactPage));
        
    }
}


        public class Contact {
            public required string Name {get; set;}
              public required string Email {get; set;}
        }
        
    }
}




