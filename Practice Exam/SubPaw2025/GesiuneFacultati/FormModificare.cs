using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesiuneFacultati
{
    public partial class FormModificare : Form
    {
        private Student student;
        public FormModificare(Student s)
        {
            InitializeComponent();
            student = s;

            tbNrMat.Text = s.Matricol.ToString();
            tbNume.Text = s.Nume;
            tbMedie.Text=s.Medie.ToString();

        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            try
            {

                student.Medie = Convert.ToSingle(tbMedie.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbNrMat.Clear();
                tbNume.Clear();
                tbMedie.Clear();
            }

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
