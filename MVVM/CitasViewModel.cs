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
    public class CitasViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Cita> Citas { get; set; }

        private Cita _citaSeleccionada;


        public CitasViewModel()
        {
            Citas = new ObservableCollection<Cita>()
            {
                new Cita("Médico", DateTime.Now, "Recoger recetas tata"),
                new Cita("Taller",DateTime.Now.AddDays(1), "LLevar pre ITV")
            };

            // Asignamos el comando al método AgregarCita
            AgregarCitaCommand = new RelayCommand(AgregarCita);
        }


        //CREAR UN GETTER Y SETTER PARA CITA SELECCIONADA
        public Cita CitaSeleccionada
        {
            get => _citaSeleccionada;
            set
            {
                _citaSeleccionada = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarCitaCommand { get; }

        private void AgregarCita(object parameter)
        {
            Citas.Add(
                new Cita("NuevoTítulo", DateTime.Now, "NuevaDescripción")
            );
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string nombre = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}