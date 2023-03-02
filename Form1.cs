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
            MessageBox.Show("Olá mundo!");
            MessageBox.Show("Sejam bem vindos!");
            MessageBox.Show("Criando tags");
            MessageBox.Show("Criando tags: 0.0.2");
            MessageBox.Show("Criando tags: 0.0.3");
        }
    }
}
