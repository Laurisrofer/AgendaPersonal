using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Contacto> ListaContactos;
        public Contactos()
        {
            InitializeComponent();

            //Asignar una lista con valores por defecto
             ListaContactos = new ObservableCollection<Contacto>
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaContactos.Add(new Contacto(nombre: TxtNombreContacto.Text, apellido1: TxtApellido1.Text, apellido2: TxtApellido2.Text, creacion: DatePickerContacto.SelectedDate ?? DateTime.Now, genero: TxtGenero.Text));
            TxtNombreContacto.Clear();
            TxtApellido1.Clear();
            TxtApellido2.Clear();
            DatePickerContacto.SelectedDate = null;
            TxtGenero.Clear();
        }
    }
}
