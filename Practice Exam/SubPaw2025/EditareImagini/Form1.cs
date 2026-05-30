using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditareImagini
{
    public partial class Form1 : Form
    {
        List<Poligon> lstPoligon= new List<Poligon>();
        public Form1()
        {
            InitializeComponent();
            ActualizareStatusBar();
        }

        private void btnAdaugareP_Click(object sender, EventArgs e)
        {
            FromPoligon fp= new FromPoligon();
            if(fp.ShowDialog() == DialogResult.OK )
            {
                lstPoligon.Add(fp.PoligonCreat);
                afisareLv();
                ActualizareStatusBar();
            }

        }

        public void afisareLv()
        {
            lvPoligon.Items.Clear();
            foreach(Poligon p in lstPoligon)
            {
                ListViewItem itm = new ListViewItem(p.Eticheta);
                itm.SubItems.Add(p.CodFigura.ToString());
                itm.Tag = p;
                lvPoligon.Items.Add(itm);
            }
        }

        public void ActualizareStatusBar()
        {
            double total = 0;
            foreach (Poligon p in lstPoligon)
                total += p.CalculPerimetru();
            toolStripStatusLabel1.Text = $"Perimetru total: {total}";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.dat)|*.dat";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                FileStream fs=new FileStream(saveFileDialog1.FileName,FileMode.Create,FileAccess.Write);
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(fs, lstPoligon);
                fs.Close();
                MessageBox.Show("Serializare realizata cu succes!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.dat)|*.dat";
            if(openFileDialog1.ShowDialog()== DialogResult.OK )
            {
                FileStream fs=new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                BinaryFormatter bf=new BinaryFormatter();
                List<Poligon>lsPoli=(List<Poligon>)bf.Deserialize(fs);
                afisareLv();
                fs.Close() ;
                MessageBox.Show("Deseralizare realizata cu succes!");
            }
        }

        private void btnAfisareGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fg = new FormGrafic(lstPoligon);
            fg.Show();
        }
    }
}
