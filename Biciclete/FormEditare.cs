using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciclete
{
    public partial class FormEditare : Form
    {
        Utilizator utilizatorC;
        public FormEditare(Utilizator u)
        {
            InitializeComponent();
            utilizatorC = u;
            tbCodU.Text = u.CodU.ToString();
            tbNume.Text = u.Nume;
            tbCodB.Text= u.CodB.ToString();
            tbDurata.Text=u.DurataUtilizare.ToString(); 
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;

   
            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                errorProvider1.SetError(tbNume, "Introduceti un nume valid");
                valid = false;
            }
            
            if (!int.TryParse(tbDurata.Text,out int rez) || rez<0)
            {
                errorProvider1.SetError(tbDurata, "Introduceti o val numerica");
                valid = false;
            }

            if(valid)
            {
                
                utilizatorC.Nume = tbNume.Text;
                utilizatorC.DurataUtilizare = rez;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
