using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace CosCumparaturi
{
    public partial class FormProdus : Form
    {
        List<Produs> listaProduse=new List<Produs>();
        public FormProdus()
        {
            InitializeComponent();
        }

        public List<Produs> ListaProduse { get => listaProduse; }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                int id=int.Parse(tbId.Text);
                string denumire = tbDenumire.Text;
                double pret = double.Parse(tbPret.Text);
                int cantitate=int.Parse(tbCantitate.Text);

                Produs p = new Produs(id, denumire, pret, cantitate);
                listaProduse.Add(p);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
