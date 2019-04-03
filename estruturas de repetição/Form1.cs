using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)  // a resposta é 64
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }

            MessageBox.Show("A soma dos números de um até mil é: " + soma);
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)

                {

                    MessageBox.Show("O número " + i, " é  mutiplo de 3");
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e) // A RESPOSTA É 3367
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0) // se fosse para somar os múltiplos usaria == 
                {
                    soma += i;
                }
            }
            MessageBox.Show("O total é: " + soma);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)

             {
               MessageBox.Show("os números " + i ," são divisíveis por 3 ou 4");

             }

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
             for (int n = 1; n <= 10; n++)
                {
                  fatorial = fatorial * n;
                  MessageBox.Show("fatorial de" + n + " = " + fatorial);
                 }
        }

        private void Button7_Click(object sender, EventArgs e) //while ate quando a condição for verdadeira
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            for (int proximo = atual; atual <= 100; anterior = atual, atual = proximo, proximo = anterior + atual)
            {
                serieFibonacci += atual + " ";
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 10;
             string poligono= "";
             for (int linha = 1; linha <= qtdLinhas; linha++)
                 {
                     for (int coluna = 1; coluna <= linha; coluna++)
                         {
                             poligono += (linha * coluna) + " ";
                         }
                     poligono += "\n"; // dar quebra de linha 
                 }
             MessageBox.Show(poligono);
        }
    }
}