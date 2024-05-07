using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_tela
{
    class model
    {
        model modelo;
        public model()
        {

        }//fim do contrutor
            
        public int Somar(int num1, int num2) 
        { 
            return num1 + num2;
        }//fim do somar 

        public int subtrair (int num1, int num2) 
        {
            return num1 - num2;
        }//fim do subtrair

        public int multiplicar(int num1, int num2) 
        {
            return num1 * num2;
        }//fim do subtrair 

        public double dividir(int num1, int num2) 
        {
            if(num2 == 0) 
            {
                return -1;
            }
            else
            {
                return num1 / num2;
            }



        }//fim do dividir
    }//fim da classe
}//fim do projeto
