using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareCredite
{
    public partial class FormEditare : Form
    {
        Credit credit;
        public FormEditare(Credit c)
        {
            InitializeComponent();
            credit = c;
            tbClient.Text = c.Client;
            tbValoare.Text=c.Valoare.ToString();
            tbDobanda.Text=c.Dobanda.ToString();
            dtpAc.Value = c.DataAcordare; //VALUE NEAP!
            tbPerioada.Text=c.Perioada.ToString();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(tbClient.Text))
            {
                errorProvider1.SetError(tbClient, "Client obligatoriu");
                ok = false;
            }

            if (!decimal.TryParse(tbValoare.Text, out _))
            {
                errorProvider1.SetError(tbValoare, "Valoare invalidă");
                ok = false;
            }

            if (!double.TryParse(tbDobanda.Text, out _))
            {
                errorProvider1.SetError(tbDobanda, "Dobândă invalidă");
                ok = false;
            }

            if (!int.TryParse(tbPerioada.Text, out _))
            {
                errorProvider1.SetError(tbPerioada, "Perioadă invalidă");
                ok = false;
            }

            if (ok)
            {
                try
                {
                    credit.Client = tbClient.Text;
                    credit.Valoare = double.Parse(tbValoare.Text);
                    credit.Dobanda = double.Parse(tbDobanda.Text);
                    credit.DataAcordare = dtpAc.Value;
                    credit.Perioada = int.Parse(tbPerioada.Text);

                   
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
