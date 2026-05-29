using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosCumparaturi
{
    public partial class FormEditare : Form
    {
       private Produs produs;
        public FormEditare(Produs p)
        {
            InitializeComponent();
            produs = p;

            tbId.Text = p.Id.ToString();
            tbDenumire.Text = p.DenumireP;
            tbPret.Text = p.Pret.ToString();
            tbCantitate.Text = p.Cantitate.ToString();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                produs.Id = int.Parse(tbId.Text);
                produs.DenumireP = tbDenumire.Text;
                produs.Pret = double.Parse(tbPret.Text);
                produs.Cantitate = int.Parse(tbCantitate.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
