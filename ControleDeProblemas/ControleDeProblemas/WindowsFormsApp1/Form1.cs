using Controle;
using Entidade;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.Descricao = txtDescricao.Text;

            if (new tipoDB().insert(tipo))
            {
                MessageBox.Show("Inserido!");            
            } else
            {
                MessageBox.Show("ERRO ao Inserir!");
            }
        }
    }
}
