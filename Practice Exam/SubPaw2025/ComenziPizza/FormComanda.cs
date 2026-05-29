using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComenziPizza
{
    public partial class FormComanda : Form
    {
        List<ComandaPizza> lstComanda=new List<ComandaPizza>();
        public FormComanda()
        {
            InitializeComponent();
        }

        public List<ComandaPizza> LstComanda { get=>lstComanda;}
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string blat = cmbBlat.SelectedItem.ToString();
                int durata=int.Parse(tbDurata.Text);

                ComandaPizza c = new ComandaPizza(nume, blat, durata);
                lstComanda.Add(c);
                MessageBox.Show("Comanda Adaugata");

            }
            catch(ValidareEx vex)
            {
                MessageBox.Show(vex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbDurata.Clear();
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
