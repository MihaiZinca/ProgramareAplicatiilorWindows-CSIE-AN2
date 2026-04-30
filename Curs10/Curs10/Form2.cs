using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs10
{
    public partial class Form2 : Form
    {
        BindingSource bds;
        public Form2(BindingSource fbds)
        {
            
            InitializeComponent();
            bds = fbds;
            tbMarca.DataBindings.Add("Text", bds, "Marca"); //ii adaug o legatura
            tbNume.DataBindings.Add("Text", bds, "Nume");
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bds.RemoveCurrent();
            bds.MoveFirst();
            Close();
        }
    }
}
