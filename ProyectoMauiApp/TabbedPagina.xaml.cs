using ProyectoMauiApp.Models;
using System.Collections.ObjectModel;

namespace ProyectoMauiApp;

public partial class TabbedPagina : TabbedPage
{
	public TabbedPagina()
	{
		InitializeComponent();
        InitializeTales();
        BindingContext = this;
    }
    public ObservableCollection<Pelicula> Peliculas { get; set; }
  

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