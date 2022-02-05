using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo3D
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {            
            persona.Dpi = textBoxDPI.Text;
            persona.Nombre = textBoxNombre.Text;
            persona.Apellido = textBoxApellido.Text;
            persona.Telefono = textBoxTelefono.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
            
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            //labelNombre.Text.Trim();
             //System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(labelNombre.Text);

            labelDPI.Text = "El No.de DPI es: "+ persona.Dpi.Trim();
            labelNombre.Text = "Nombre: " +
                System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Nombre).Trim()
                .Replace("!", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("/", "")
                .Replace("(", "").Replace(")", "").Replace("=", "").Replace("?", "").Replace("¡", "")
                .Replace("¿", "").Replace("+", "").Replace("*", "").Replace("}", "").Replace("]", "")
                .Replace("{", "").Replace("[", "").Replace(",", "").Replace(";", "").Replace(".", "")
                .Replace(":", "").Replace("-", "").Replace("_", "").Replace("<", "").Replace(">", "")
                .Replace("°", "").Replace("|", "");




            labelApellido.Text = "Apellidos: "+
                System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(persona.Apellido).Trim()
                .Replace("!", "").Replace("#", "").Replace("$", "").Replace("%", "").Replace("/", "")
                .Replace("(", "").Replace(")", "").Replace("=", "").Replace("?", "").Replace("¡", "")
                .Replace("¿", "").Replace("+", "").Replace("*", "").Replace("}", "").Replace("]", "")
                .Replace("{", "").Replace("[", "").Replace(",", "").Replace(";", "").Replace(".", "")
                .Replace(":", "").Replace("-", "").Replace("_", "").Replace("<", "").Replace(">", "")
                .Replace("°", "").Replace("|", "");
            labelTelefono.Text = "No. de celular: "+persona.Telefono.Trim();
            //labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            label1Edad.Visible = true;  
            //persona.edad().ToString();
            label7.Visible = true;  
            labelDPI.Visible = true;  
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelTelefono.Visible = true;

           
        }

        private void buttonAbrirCuentas_Click(object sender, EventArgs e)
        {
            FormCuenta formularioCuenta = new FormCuenta();
            formularioCuenta.Show();
        }

        private void labelDPI_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - dateTimePicker1.Value.Year;
            if (fechaActual < dateTimePicker1.Value.AddYears(edad)) edad--;
            
            label1Edad.Text = "Tienes " + edad.ToString() + " años";
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
