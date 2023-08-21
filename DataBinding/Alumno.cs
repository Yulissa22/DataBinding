using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding
{
    public class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //se declara una variable que es donde se va almacenar
        //el nombre del alumno.
        string nombre = string.Empty; 

        public string Nombre
        {
            get => nombre; //Devuelve el valor "nombre"
            set //verifica cuando hay cambios 
            {
                if (nombre == value)
                    return;
                nombre = value;
                //se llama al metodo para notificar cuando hay cambios 
                onPropertyChanged(nameof(Nombre)); 
                onPropertyChanged(nameof(MostrarNombre));
            }
        }

        public string MostrarNombre => $"Nombre ingresado:{Nombre}";
        
        void onPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
