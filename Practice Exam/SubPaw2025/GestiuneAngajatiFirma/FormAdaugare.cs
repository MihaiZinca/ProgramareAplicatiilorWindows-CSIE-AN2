using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneAngajatiFirma
{
    public partial class FormAdaugare : Form
    {
        List<Angajat> listaAngajat=new List<Angajat>();
        List<Companie> companii;
        public FormAdaugare(List<Companie> comp)
        {
            InitializeComponent();
            this.companii = comp;
            cmbId.DataSource = companii;
            cmbId.DisplayMember = "Nume";
            cmbId.ValueMember = "Id";
        }

        public List<Angajat> ListaAngajat { get => listaAngajat; }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introdu numele");
            else if(tbNume.Text.Length<2)
                errorProvider1.SetError(tbNume, "Numele trebuie sa contina minim 3 litere!");
            else if(DateTime.Now.Year-dtN.Value.Year<20)
                errorProvider1.SetError(dtN, "Trebuie sa ai varsta mai mare sau egala cu 20 de ani!");
            else
            {
                try
                {
                    string nume=tbNume.Text;
                    DateTime data=dtN.Value;
                    int idC = ((Companie)cmbId.SelectedItem).Id;
                   

                    Angajat a=new Angajat(nume,data,idC);
                    listaAngajat.Add(a);
                    
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNume.Clear();
                    
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
