using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneAngajati
{
    public partial class FormModificare : Form
    {
        private Angajat angajat;
        public FormModificare(Angajat a)
        {
            InitializeComponent();
            angajat= a;

            tbNume.Text = a.Nume;
            dtN.Value = a.DataNasterii;
            tbIdCompanie.Text=a.IdCompanie.ToString();


        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introdu numele");
            else if (tbNume.Text.Length < 2)
                errorProvider1.SetError(tbNume, "Numele trebuie sa contina minim 3 litere!");
            else if (DateTime.Now.Year - dtN.Value.Year < 20)
                errorProvider1.SetError(dtN, "Trebuie sa ai varsta mai mare sau egala cu 20 de ani!");
            else
            {
                try
                {


                    angajat.Nume = tbNume.Text;
                    angajat.DataNasterii = dtN.Value;
                    angajat.IdCompanie = Convert.ToInt32(tbIdCompanie.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNume.Clear();

                    tbIdCompanie.Clear();
                }
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
