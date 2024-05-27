using ProyectoMauiApp.Models;
using System.Collections.ObjectModel;

namespace ProyectoMauiApp
{
    public partial class MainPage : ContentPage
    {
      
        public ObservableCollection<Pelicula> Peliculas { get; set; }
        public MainPage()
        {
            InitializeComponent();
            InitializeTales();
            BindingContext = this;
        }

        private void InitializeTales()
        {
            Peliculas = new ObservableCollection<Pelicula>
            {
                new Pelicula { Name="Joker", ReadTime=new TimeSpan(0,30,0), Imagen = "joker.png"},
                new Pelicula { Name="Joker", ReadTime=new TimeSpan(0,30,0), Imagen = "joker.png"},
                new Pelicula { Name="Joker", ReadTime=new TimeSpan(0,30,0), Imagen = "joker.png"}



            };
        }

        
    }
}
