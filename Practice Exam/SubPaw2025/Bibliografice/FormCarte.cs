using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliografice
{
    public partial class FormCarte : Form
    {
       List<Carte> listaCarti= new List<Carte>();   
        public FormCarte()
        {
            InitializeComponent();
            cmbCategorie.Items.Add("IT");
            cmbCategorie.Items.Add("Economie");
            cmbCategorie.Items.Add("Matematica");
            cmbCategorie.Items.Add("Literatura");
        }

        public List<Carte> ListaCarti { get => listaCarti; }
        
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                string titlu = tbTitlu.Text;
                float pret=float.Parse(tbPret.Text);
                string isbn=tbISBN.Text;
                string categorie=cmbCategorie.SelectedItem.ToString();

                if (isbn.Length < 5)
                    throw new Exception("ISBN invalid!");

                Carte c = new Carte(isbn, categorie, titlu, pret);
                listaCarti.Add(c);
                MessageBox.Show("Carte adaugata");
                
            }
            catch(Exception ex)
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
