using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaPersonal
{
    /// <summary>
    /// Lógica de interacción para Contactos.xaml
    /// </summary>
    public partial class Contactos : Page
    {
        public Contactos()
        {
            InitializeComponent();

            //Asignar una lista con valores por defecto
            List<Contacto> ListaContactos = new List<Contacto>
            {
                new Contacto(nombre: "Laura1", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura2", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura3", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura4", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura5", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura6", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura7", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino"),
                new Contacto(nombre: "Laura8", apellido1: "Rodriguez", apellido2: "Fernandez", creacion: DateTime.Now, genero: "Femenino")
            };
            //Asignamos la lista al ListBox(llamado ListaCitasInterfaz en el XAML)
            ListaContactosInterfaz.ItemsSource = ListaContactos;
        }
    }
}
