using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3D
{
    internal class Persona
    {
        
        //Propiedades:
        public string Dpi { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        

                                                 //Métodos:

        /*public int edad()
        {
              
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dateTimePicker1.Value.Year;
            if (fechaActual < dateTimePicker1.Value.AddYears(edad)) edad--;
            label1Edad.Text = "Tienes " + edad.ToString() + " años";
          

            return(0);                                                                                              
        }*/

    }
}
