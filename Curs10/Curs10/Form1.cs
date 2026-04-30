using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//concept de DATE BIND 
//leggat elemente de date de controale(fara libertate,mai limitata)
namespace Curs10
{
    public partial class Form1 : Form
    {
        Modificare fm;

        public Form1()
        {
            InitializeComponent();
            bdsPersoana.Add(new Persoana { Marca = 100, Nume = "Vasile" });
            bdsPersoana.Add(new Persoana { Marca = 200, Nume = "Valentina" });
            bdsPersoana.Add(new Persoana { Marca = 300, Nume = "Marcel" });
            fm= new Modificare(bdsPersoana);
            fm.TopMost = true; // fereastra ramane peste toate feresrele!!
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form2 fadd = new Form2(bdsPersoana);
            fadd.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            if (!fm.Visible) fm.Show();
        }
    }
}
