using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar13_DataBinding
{
    public partial class Form2 : Form
    {
        public Form2(List<Student> listaStudenti)
        {
            InitializeComponent();

            BindingSource bs=new BindingSource();
            bs.DataSource = listaStudenti;
            bindingNavigator1.BindingSource = bs;

            tbNume.DataBindings.Add(new Binding("Text", bs, "Nume", true));
            tbFacultate.DataBindings.Add(new Binding("Text", bs, "Facultate", true));
            tbMedie.DataBindings.Add(new Binding("Text", bs, "Medie", true));
            tbBuget.DataBindings.Add(new Binding("Text", bs, "EsteBuget", true));
        }
    }
}
