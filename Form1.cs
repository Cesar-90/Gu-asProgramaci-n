using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1guia5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(txtnombre.Text);
            Console.WriteLine(nombre);
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtnum.Text);
            Console.WriteLine(numero);
        }   
        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1.Checked == true)
            {
            }
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn2.Checked == true) 
            { 
            }
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn3.Checked == true) 
            { 
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double sueldo, descuento1, descuento2, descuento3, result1, result2, result3, total1, total2, total3;
            sueldo = Convert.ToDouble(txtnum.Text);
            descuento1 = Convert.ToDouble(txtnum.Text);
            descuento2 = Convert.ToDouble(txtnum.Text);
            descuento3 = Convert.ToDouble(txtnum.Text);
            
            descuento1 = 0.20;
            descuento2 = 0.15;
            descuento3 = 0.05;

            result1 = sueldo * descuento1;
            result2 = sueldo * descuento2;
            result3 = sueldo * descuento3;

            total1 = (sueldo - result1);
            total2 = (sueldo - result2);
            total3 = (sueldo - result3);

            if (rbtn1.Checked == true) 
            {
                MessageBox.Show("Gerente, su sueldo inicial es de $" + sueldo + " el descuento realizado es de: $" + descuento1 + " , el total de su salario es de: $" + total1 + " Feliz día");
            }
            if (rbtn2.Checked == true) 
            {
                MessageBox.Show("SubGerente, su sueldo inicial es de $" + sueldo + " el descuento realizado es de: $" + descuento2+ " , el total de su salario es de: $" + total2 + " Feliz día");
            }
            if (rbtn3.Checked == true) 
            {
                MessageBox.Show("Secretaria/o, su sueldo inicial es de $" + sueldo + " el descuento realizado es de: $" + descuento3+ " , el total de su salario es de: $" + total3 + " Feliz día");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
