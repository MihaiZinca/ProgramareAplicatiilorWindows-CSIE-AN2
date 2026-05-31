using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traseu
{
    public partial class FormLocatie : Form
    {
        Locatie locCurenta;

        public Locatie LocCurenta { get => locCurenta; }

        public FormLocatie()
        {
            InitializeComponent();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                int X = int.Parse(tbX.Text);
                int Y = int.Parse(tbY.Text);

                Locatie loc = new Locatie(X,Y);
                locCurenta = loc;
                this.DialogResult = DialogResult.OK;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
