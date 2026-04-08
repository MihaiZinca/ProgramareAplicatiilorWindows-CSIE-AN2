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

namespace T2
{
    public partial class Form1 : Form
    {
        List<Carte>publicatii=new List<Carte>();
        List<Autor> autori=new List<Autor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autori.Add(new Autor("Ion Creanga","1",3));
            autori.Add(new Autor("Mihai Eminescu","2",4));
            autori.Add(new Autor("George Calinescu","3",5));
            lbAutori.DataSource = null;
            lbAutori.DataSource = autori;

        }

        private void adaugaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdaugaCarte fa = new FormAdaugaCarte();
            if(DialogResult.OK == fa.ShowDialog())
            {
                try
                {
                    List<Carte> listaCarti=new List<Carte>();
                    foreach(Carte c in fa.ListaCarti)
                        listaCarti.Add(c);
                    foreach (Carte c in listaCarti)
                    {
                        ListViewItem itm = new ListViewItem(c.Titlu);
                        itm.SubItems.Add(c.Pret.ToString());
                        itm.SubItems.Add(c.ISBN.ToString());
                        itm.SubItems.Add(c.Categorie.ToString());
                        lv.Items.Add(itm);

                        publicatii.Add(c);
                    }
                    AfiseazaPub();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void AfiseazaPub()
        {
            var listaSortat=publicatii.OrderBy(c=>c.Titlu).ToList();
            lbPublicatii.DataSource = null;
            foreach(var item in listaSortat)
                lbPublicatii.Items.Add(item);
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.dat)|*.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, publicatii);
                fs.Close();
                MessageBox.Show("serializare realz cu succes!");
            }
            
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "(*.dat)|*.dat";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                FileStream fs=new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                List<Carte> listaPub = (List<Carte>)bf.Deserialize(fs);
                foreach(Carte c in listaPub)
                {
                    ListViewItem item = new ListViewItem(c.Titlu);
                    item.SubItems.Add(c.Pret.ToString());
                    item.SubItems.Add(c.ISBN.ToString());
                    item.SubItems.Add(c.Categorie.ToString());
                    lv.Items.Add(item);
                }
                fs.Close();
                MessageBox.Show("deserializare realizata cu succes!");
            }
        }
    }
}
