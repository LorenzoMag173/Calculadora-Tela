using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_tela
{
    public partial class Form1 : Form
    {
        model modelo;
        public Form1()
        {
            InitializeComponent();
            modelo = new model();
        }//fim do contrutor

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numeroUm_TextChanged(object sender, EventArgs e)
        {

        }//fim do imput numeroUm

        private void numeroDois_TextChanged(object sender, EventArgs e)
        {

        }//fim do imput numeroDois

        private void somar_Click(object sender, EventArgs e)
        {
            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.Somar(num1, num2);
            }
        
        }//fim do somar

        private void dividir_Click(object sender, EventArgs e)
        {

            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            {
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.dividir(num1, num2);
            
            if(modelo.dividir(num1, num2) == -1)
            {
                resultado.Text = "Impossivel Dividir"; 
            }
            else
            {
                resultado.Text = "" + modelo.dividir(num1, num2);
            }
           }
        }//fim do dividir

        private void subtrair_Click(object sender, EventArgs e)
        {

            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            { 
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.subtrair(num1, num2);
            }  
        }//fim do subtrair

        private void multiplicar_Click(object sender, EventArgs e)
        {


            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            { 
                int num1 = Convert.ToInt32(numeroUm.Text);
                int num2 = Convert.ToInt32(numeroDois.Text);
                resultado.Text = "" + modelo.multiplicar(num1, num2);
            }
        }//fim do multiplicar

        private void limpar_Click(object sender, EventArgs e)
        {

            if (numeroUm.Text == "" || numeroDois.Text == "")
            {
                resultado.Text = "Preencha os campos númericos";
            }
            else
            { 
               numeroUm.Text = "";
               numeroDois.Text = "";
               resultado.Text = "";
            }

        }//fim do limpar
    }//fim da classe 
}//fim do project
