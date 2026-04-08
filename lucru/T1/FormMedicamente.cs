using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1
{
    public partial class FormMedicamente : Form
    {
        List<Medicament> listaMedicamente=new List<Medicament>();
        public FormMedicamente()
        {
            InitializeComponent();
        }

        public List<Medicament> ListaMedicamente { get=>listaMedicamente;}

        private void btnAdaugareMed_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbCod.Text))
                    throw new Exception("Intoruceti cod!");
                int cod = Convert.ToInt32(tbCod.Text);

                if(String.IsNullOrWhiteSpace(tbDen.Text))
                    throw new Exception("Introduceti Denumire!");
                string denumire=tbDen.Text;

                if (String.IsNullOrWhiteSpace(tbPret.Text))
                    throw new Exception("Introduceti Pret!");
                float pret=float.Parse(tbPret.Text);

                if(string.IsNullOrWhiteSpace(tbCant.Text))
                    throw new Exception("Introduceti Cantitate!");
                int cantitate=Convert.ToInt32(tbCant.Text);

                Medicament med = new Medicament(cod, denumire, pret, cantitate);
                listaMedicamente.Add(med);
                lbMedicamente.Items.Add(med);

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
             }
            finally
            {
                tbCod.Clear();
                tbDen.Clear();
                tbPret.Clear();
                tbCant.Clear();
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
        }
    }
}
