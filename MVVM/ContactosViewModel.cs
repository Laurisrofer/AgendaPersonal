using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgendaPersonal.MVVM
{
    public class ContactosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Contacto> Contactos { get; set; }

        private Contacto _contactoSeleccionado;


        public ContactosViewModel()
        {
            Contactos = new ObservableCollection<Contacto>()
            {
                new Contacto("Ana", "Lopez", "Martinez", DateTime.Now, "Femenino"),
                new Contacto("Luis","Garcia","Hernandez",DateTime.Now.AddDays(1), "Masculino")
            };

            // Asignamos el comando al método AgregarContacto
            AgregarContactoCommand = new RelayCommand(AgregarContacto);
        }


        //CREAR UN GETTER Y SETTER PARA CONTACTO SELECCIONADO
        public Contacto ContactoSeleccionado
        {
            get => _contactoSeleccionado;
            set
            {
                _contactoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarContactoCommand { get; }

        private void AgregarContacto(object parameter)
        {
            Contactos.Add(
                new Contacto("NuevoNombre", "NuevoApellido1", "NuevoApellido2", DateTime.Now, "NuevoGenero")
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string nombre = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}