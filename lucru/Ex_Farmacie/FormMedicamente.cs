using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Farmacie
{
    public partial class FormMedicamente : Form
    {
        List<Medicament> listaMedicamente=new List<Medicament>();
        public FormMedicamente()
        {
            InitializeComponent();
        }

        internal List<Medicament> ListaMedicamente { get => listaMedicamente; }

        private void btnAdaugareMed_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbCod.Text))
                    throw new Exception("Introduceti cod!");
                int cod = Convert.ToInt32(tbCod.Text);

                if (String.IsNullOrEmpty(tbDen.Text))
                    throw new Exception("Introduceti Denumire!");
                string denumire = tbDen.Text;

                if (String.IsNullOrWhiteSpace(tbPret.Text))
                    throw new Exception("Introduceti Pret!");
                float pret = float.Parse(tbPret.Text);


                if (String.IsNullOrEmpty(tbCant.Text))
                    throw new Exception("introduceti cantitate");
                int cantitate = Convert.ToInt32(tbCant.Text);

                Medicament med = new Medicament(cod, denumire, pret, cantitate);
                listaMedicamente.Add(med);
                lbMedicamente.Items.Add(med);
            }
            catch(Validare v)
            {
                MessageBox.Show(v.Message,"Eroare",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
