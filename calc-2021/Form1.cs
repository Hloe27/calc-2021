using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_2021
{
    public partial class Form1 : Form
    {
        double primero = 0; double segundo = 0;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtresultado.Text == "0")
                txtresultado.Text = "";

            txtresultado.Text += boton.Text;

        }

        private void tipoOperador(object sender, EventArgs e )
        {
            var boton = ((Button)sender);
            primero = Convert.ToDouble(txtresultado.Text);
            operador = Convert.ToString(boton.Tag);

            txtresultado.Text = "0";
        }
        //private void txtresultado_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtresultado.Text == "0")
        //        txtresultado.Text = "";
        //    txtresultado.Text += primero;
        //}

        private void btnc_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        //private void btndivision_Click(object sender, EventArgs e)
        //{
        //    if(txtresultado.Text.Trim() == string.Empty)
        //    {
        //        return;
        //    }
        //    primero = Convert.ToDouble(txtresultado.Text);
        //    operador = "÷";
        //    txtresultado.Clear();
           
        //}

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length == 1)
            {
                txtresultado.Text = "";
            }
            else
            {
                txtresultado.Text = txtresultado.Text.Substring(0, txtresultado.Text.Length - 1);
            }
        }

        //private void btnmultiplicar_Click(object sender, EventArgs e)
        //{
        //    if (txtresultado.Text.Trim() == string.Empty)
        //    {
        //        return;
        //    }
        //    primero = Convert.ToDouble(txtresultado.Text);
        //    operador = "*";
        //    txtresultado.Clear();
        //}

        //private void btnresta_Click(object sender, EventArgs e)
        //{
        //    primero = Convert.ToDouble(txtresultado.Text);
        //    operador = "-";
        //    txtresultado.Clear();

        //}

        //private void btnsuma_Click(object sender, EventArgs e)
        //{
        //    primero = Convert.ToDouble(txtresultado.Text);

        //    operador = "+";
        //    txtresultado.Clear();

        //}

     

        //private void btncero_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "0";
        //}

        //private void btnmasmenos_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text = "%";
        //}

        //private void btnuno_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "1";
        //}

        //private void btndos_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text +="2";
        //}

        //private void btntres_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "3";
        //}

        //private void btncuatro_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "4";
        //}

        //private void btncinco_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "5";
        //}

        //private void btnseis_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "6";
        //}

        //private void btnsiete_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "7";
        //}

        //private void btnocho_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "8";
        //}

        //private void btnnueve_Click(object sender, EventArgs e)
        //{
        //    txtresultado.Text += "9";
        //}

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Trim()==string.Empty)
            {
                return;
            }

            segundo = Convert.ToDouble(txtresultado.Text);

            switch (operador)
            {
                case "+":
                    txtresultado.Text = (primero + segundo).ToString();
                    break;
                case "-":
                    txtresultado.Text = (primero - segundo).ToString();
                    break;
                case "*":
                    txtresultado.Text = (primero * segundo).ToString();
                    break;
                case "÷":
                    txtresultado.Text = (primero / segundo).ToString();
                    break;
            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
        }

        private void btnpunto_Click_1(object sender, EventArgs e)
        {
    
            if (!txtresultado.Text.Contains("."))
            {
                txtresultado.Text += ".";
            }
           
        }

        private void txtresultado_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
           {
                    e.Handled = true;
           }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 43){
                primero = Convert.ToDouble(txtresultado.Text);
                txtresultado.Text = "0";
                txtresultado.Focus();
                txtresultado.SelectionLength = txtresultado.TextLength;
            }
            if (e.KeyChar == 13)
            {
                segundo = Convert.ToDouble(txtresultado.Text);
                double resultado;
                    resultado = primero + segundo;
                txtresultado.Text = resultado.ToString();
            }
            txtresultado.Focus();
        }
    }
}
