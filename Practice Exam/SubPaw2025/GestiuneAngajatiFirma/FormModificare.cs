using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneAngajatiFirma
{
    public partial class FormModificare : Form
    {
        Angajat angajat;
        List<Companie> companii;
        public FormModificare(Angajat a, List<Companie> companii)
        {
            InitializeComponent();
            this.angajat = a;
            this.companii = companii;
            cmbId.DataSource = companii;
            cmbId.DisplayMember = "Nume";
            cmbId.ValueMember = "Id";
            
        }

        public Angajat Angajat { get => angajat; }

        private void btnModificare_Click(object sender, EventArgs e)
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
                    angajat.IdCompanie = ((Companie)cmbId.SelectedItem).Id;
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
     
            }
        }
    }
}
