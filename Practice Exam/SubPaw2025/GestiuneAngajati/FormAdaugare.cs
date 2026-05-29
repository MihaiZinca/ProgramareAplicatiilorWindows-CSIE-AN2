using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestiuneAngajati
{
    public partial class FormAdaugare : Form
    {
        List<Angajat> listaAngajati=new List<Angajat> ();
        public FormAdaugare()
        {
            InitializeComponent();
        }

        public List<Angajat> ListaAngajati { get => listaAngajati; }
        private void btnAdaugare_Click(object sender, EventArgs e)
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


                    string nume = tbNume.Text;
                    DateTime data = dtN.Value;
                    int idCompanie = Convert.ToInt32(tbIdCompanie.Text);
                    Angajat a = new Angajat(nume, data, idCompanie);
                    listaAngajati.Add(a);

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
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
