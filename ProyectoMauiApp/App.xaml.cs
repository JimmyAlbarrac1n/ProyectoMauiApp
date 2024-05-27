namespace ProyectoMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();

            //MainPage = new TabbedPagina();
            MainPage = new NavigationPage(new TabbedPagina());
        }
    }
}
