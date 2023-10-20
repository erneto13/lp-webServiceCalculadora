using lp_webService.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lp_webService
{
    public partial class designWScalc : Form
    {
        public designWScalc()
        {
            InitializeComponent();
        }

        // Se hace la instancia global
        // Instancia del proxy para el web service
        ServiceReference.CalculatorSoapClient calculadora = new ServiceReference.CalculatorSoapClient();

        private void btnSumar_Click(object sender, EventArgs e)
        {

            // Verificar que no haya cadena vacía en el txtNúmeroA & txtNúmeroB
            if (string.IsNullOrEmpty(txtNumeroA.Text) ) {
                MessageBox.Show("Rellena el campo del Número A.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Cuadro de error de cadena vacia
            }
            else if (string.IsNullOrEmpty(txtNumeroB.Text) ) // Verificació para cadena vacía de txtNúmeroB
            {
                MessageBox.Show("Rellena el campo del Número B.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Se convierten a entero las entradas de los txtBox
                    int valorA = Int32.Parse(txtNumeroA.Text);
                    int valorB = Int32.Parse(txtNumeroB.Text);

                    // Llamar al método sumar del web service
                    int result = calculadora.Add(valorA, valorB);
                    lblResultado.Text = "Resultado: " + result.ToString();
                }
                catch (FormatException)
                {
                    // Error por un número no válido
                    MessageBox.Show("La entrada no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumeroA.Text))
            {
                MessageBox.Show("Rellena el campo del Número A.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtNumeroB.Text))
            {
                MessageBox.Show("Rellena el campo del Número B.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Se convierten a entero las entradas de los txtBox
                    int valorA = Int32.Parse(txtNumeroA.Text);
                    int valorB = Int32.Parse(txtNumeroB.Text);

                    // Llamar al método sumar del web service
                    int result = calculadora.Subtract(valorA, valorB);
                    lblResultado.Text = "Resultado: " + result.ToString();
                }
                catch (FormatException)
                {
                    // Error por un número no válido
                    MessageBox.Show("La entrada no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNumeroA.Text))
            {
                MessageBox.Show("Rellena el campo del Número A.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtNumeroB.Text))
            {
                MessageBox.Show("Rellena el campo del Número B.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Se convierten a entero las entradas de los txtBox
                    int valorA = Int32.Parse(txtNumeroA.Text);
                    int valorB = Int32.Parse(txtNumeroB.Text);

                    // Llamar al método sumar del web service
                    int result = calculadora.Multiply(valorA, valorB);
                    lblResultado.Text = "Resultado: " + result.ToString();
                }
                catch (FormatException)
                {
                    // Error por un número no válido
                    MessageBox.Show("La entrada no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroA.Text))
            {
                MessageBox.Show("Rellena el campo del Número A.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtNumeroB.Text))
            {
                MessageBox.Show("Rellena el campo del Número B.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Se convierten a entero las entradas de los txtBox
                    int valorA = Int32.Parse(txtNumeroA.Text);
                    int valorB = Int32.Parse(txtNumeroB.Text);

                    // Llamar al método sumar del web service
                    int result = calculadora.Divide(valorA, valorB);
                    lblResultado.Text = "Resultado: " + result.ToString();
                }
                catch (FormatException)
                {
                    // Error por un número no válido
                    MessageBox.Show("La entrada no es un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
