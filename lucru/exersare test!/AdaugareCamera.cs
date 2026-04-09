using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exersare_test_
{
    
    public partial class AdaugareCamera : Form
    {
        List<Camera> listaCam = new List<Camera>();
        public AdaugareCamera()
        {
            InitializeComponent();
        }
       
        public List<Camera> ListaCam { get => listaCam; }

        private void AdaugareCamera_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbCod.Text))
                    throw new Exception("Introduceti cod!");
                int cod = Convert.ToInt32(tbCod.Text);

                if (String.IsNullOrWhiteSpace(cmbTip.Text))
                    throw new Exception("TIP");
                string tip = cmbTip.SelectedItem.ToString();

                if (String.IsNullOrWhiteSpace(tbPret.Text))
                    throw new Exception("Introduceti Pret");
                double pret = double.Parse(tbPret.Text);

                bool disp;
                if (!bool.TryParse(tbDisp.Text, out disp))
                    throw new Exception("Disponibilitate invalida(true/false)");

                Camera c = new Camera(cod, tip, pret, disp);
                listaCam.Add(c);
                lbCamera.Items.Add(c);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbPret.Clear();
                tbDisp.Clear();
            }

        }
    }
}
