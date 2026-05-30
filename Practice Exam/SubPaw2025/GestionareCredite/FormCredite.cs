using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareCredite
{
    public partial class FormCredite : Form
    {
        List<Credit> listaCredite = new List<Credit>();
        public FormCredite()
        {
            InitializeComponent();
        }

        public List<Credit> ListaCredite { get => listaCredite; }
        private void btnAdaugare_Click(object sender, EventArgs e)
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
                    string client = tbClient.Text;
                    double valoare = double.Parse(tbValoare.Text);
                    double dobanda = double.Parse(tbDobanda.Text);
                    DateTime data = dtpAc.Value;
                    int perioada=int.Parse(tbPerioada.Text);

                    Credit c=new Credit(client,valoare,dobanda,data,perioada);
                    listaCredite.Add(c);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
