using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2
{
    public partial class FormAdaugaCarte : Form
    {
   
        List<Carte>listaCarti=new List<Carte>();
        public FormAdaugaCarte()
        {
            InitializeComponent();
        }

        public List<Carte> ListaCarti { get => listaCarti; }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbTitlu.Text))
                    throw new Exception("Introduceti Titlu");
                string titlu = tbTitlu.Text;

                if (String.IsNullOrWhiteSpace(tbPret.Text))
                    throw new Exception("Introduceti Pret");
                double pret = double.Parse(tbPret.Text);

                if (String.IsNullOrWhiteSpace(tbISBN.Text))
                    throw new Exception("Introduceti ISBN");
                string isbn = tbISBN.Text;
                string categorie = cmbCategorie.SelectedItem.ToString();

                Carte c=new Carte(titlu,pret, isbn, categorie);
                listaCarti.Add(c);
                lbCarte.Items.Add(c);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbTitlu.Clear();
                tbPret.Clear();
                tbISBN.Clear();
    
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }
    }
}
