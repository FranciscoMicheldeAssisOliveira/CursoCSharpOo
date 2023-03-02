using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bannco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeCarlos = 20;
            int idadeAlisson = 30;


            int media = (idadeAlisson + idadeCarlos + idadeJoao) / 3;

            MessageBox.Show("Média das idades: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // int pi = 3.14;
            MessageBox.Show("O número 3.14 e do tipo Flooat, e int espera o numero inteiro. " +
                "O código não compila, pois 3.14 não cabe dentro de um inteiro");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int) pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }
    }
}
