namespace ProyectoMauiApp;

public partial class Acceder : ContentPage
{
	public Acceder()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new TabbedPagina());
	}
}