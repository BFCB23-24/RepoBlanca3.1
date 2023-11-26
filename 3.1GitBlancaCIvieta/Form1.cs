using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1GitBlancaCIvieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //Blanca Felisa Civieta Bermejo 23/24
            string textoTelegrama;
            int numPalabras = 0;
            double coste;

            //Leo el telegrama  
            textoTelegrama = txtTelegrama.Text;
 
            //Obtengo el número de palabras que forma el telegrama 
            numPalabras = 0;
            for (int i = 0; i < textoTelegrama.Length; i++) 
            {
                if (textoTelegrama[i] == ' ' || textoTelegrama[i] == '.' || textoTelegrama[i] == ',')
                {
                    numPalabras++;
                }
            }
            int longCadena = textoTelegrama.Length - 1;
            if (textoTelegrama[longCadena] != '.' || textoTelegrama[longCadena] != ' ')
                numPalabras++;
            //Si el telegrama es ordinario 
            if (rbOrdinario.Checked)
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 + (0.5 *( numPalabras -10));
            else
            //Si el telegrama es urgente 
            if (rbUrgente.Checked)
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + (0.75 * (numPalabras - 10));
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
