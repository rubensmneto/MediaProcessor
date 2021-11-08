using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MediaProcessor.UI
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnProcessamentoUnico_Click(object sender, EventArgs e)
        {

            Hide();

            var formUnico = new FormArquivo();

            formUnico.ShowDialog(this);

            Show();

        }

        private void btnProcessamentoMultiplo_Click(object sender, EventArgs e)
        {

            Hide();

            var formMultiplo = new frmPrincipal();

            formMultiplo.ShowDialog(this);

            Show();

        }
    }
}
