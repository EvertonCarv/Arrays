using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];
            System.Array.Sort(vetor);
            for (int index = 0; index < 4; index++)
                MessageBox.Show(vetor[index].ToString(), "Array");

            /*Declarar e instanciar vetor
             * Atribuição de valores de acordo com cada índice
             * Declara variável "valor" para acessar o vetor
             * System.Array.Sort - Esta classe ordena o vetor
             * Comando for - Percorre o vetor em cada índice.
             * Condição - Para index menor que 4 (de 0 a 3), ele exibe uma msg com o vetor na MessageBox.
             */

        }
    }
}
