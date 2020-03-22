using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double operando1 = 0;
        String operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if(label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else
            { 
            label1.Text = label1.Text + boton.Text;         
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            operando1 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double operando2 = Convert.ToDouble(label1.Text);
            double resultado = 0;

            if (operacion == "+")
            {
                resultado = operando1 + operando2;
            }

            else if (operacion == "-")
            {
                resultado = operando1 - operando2;
            }

            else if (operacion == "*")
            {
                resultado = operando1 * operando2;
            }

            else if(operacion == "/")
            {
                resultado = operando1 / operando2;
            }

            // Esta operacion funciona como un exponente, es decir el numero que le indicamos, 
            // será elevado a 2 en este caso, es decir multiplicado 2 veces por si mismo.
            else if (operacion == "x^2")
            {
                resultado = operando1 * operando1;
            }

            // Del mismo modo que el anterior, el numero que indicamos se elevará a 3, es decir 
            // se multiplica por si mismo 3 veces.
            else if (operacion == "x^3")
            {
                resultado = operando1 * operando1 * operando1;
            }

            label1.Text = Convert.ToString(resultado);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Al pulsar "C" se resetea a 0 la calculadora, tiene un fallo 
            // no resetea las operaciones, unicamente pone la pantalla a "0"
            // pero si pulsamos un número "X", seguidamente una operacion,
            // seguidamente la "C" (esta pondrá la pantalla a "0",
            // pero al pulsar el igual, si es una division, esta nos dará su resultado,
            // es decir infinito.
            Button boton = (Button)sender;
            label1.Text = "0";
        }

    }
}
