﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio5_CompararNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);

            if (Funciones.MayorMenor(numero1, numero2) != 0)
            {
                MessageBox.Show(Convert.ToString("El mayor numero es: " + Funciones.MayorMenor(numero1, numero2)));
            }
            else
            {
                MessageBox.Show("Los numeros son iguales");     
            }
            
        }
    }
}
