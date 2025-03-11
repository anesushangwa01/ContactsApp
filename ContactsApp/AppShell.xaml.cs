namespace ContactsApp
{
    public partial class AppShell : Shell
    {
    	public AppShell()
    	{
    		InitializeComponent();
    		Routing.RegisterRoute(nameof(Views.ContactsPage), typeof(Views.ContactsPage));
    			Routing.RegisterRoute(nameof(Views.DelectContactPage), typeof(Views.DelectContactPage)); 
					Routing.RegisterRoute(nameof(Views.EditContactPage), typeof(Views.EditContactPage)); 
					Routing.RegisterRoute(nameof(Views.AddContacts), typeof(Views.AddContacts)); 
    	}
    }
}
