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

namespace exersare_test_
{
    public partial class Form1 : Form
    {
        List<Rezervare> listaRezervari=new List<Rezervare>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaCam_Click(object sender, EventArgs e)
        {
            AdaugareCamera cam=new AdaugareCamera();
            if(cam.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(tbNume.Text))
                        throw new Exception("Introduceti nume");
                    if (string.IsNullOrWhiteSpace(tbNrNopti.Text))
                        throw new Exception("Introduceti nr nopti");

                    string nume=tbNume.Text;
                    int nrNopti = Convert.ToInt32(tbNrNopti.Text);
                    

                    List<Camera> camera=new List<Camera>();
                    foreach(Camera c in cam.ListaCam)
                            camera.Add(c);

                    Rezervare rez = new Rezervare(nume, nrNopti, camera);
                    listaRezervari.Add(rez);
                    lbRezervare.Items.Add(rez);


                }catch( Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.dat)|*.dat";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                FileStream fs=new FileStream(saveFileDialog1.FileName,FileMode.Create,FileAccess.Write);
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(fs, listaRezervari);
                fs.Close();
                MessageBox.Show("Serializare realizata cu succes!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "(*.dat)|*.dat";
            if(openFileDialog1.ShowDialog()==DialogResult.OK )
            {
                FileStream fs=new FileStream(openFileDialog1.FileName, FileMode.Open,FileAccess.Read);
                BinaryFormatter bf=new BinaryFormatter();
                List<Rezervare> listRez= (List<Rezervare>)bf.Deserialize(fs);
                foreach(Rezervare r in listRez)
                {
                    ListViewItem itm=new ListViewItem(r.NumeClient);
                    itm.SubItems.Add(r.NrNopti.ToString());
                    itm.SubItems.Add(r.CalculCostTotal().ToString());

                    lvRez.Items.Add(itm);
                }
                fs.Close() ;
                MessageBox.Show("Deserializare realizata cu succes!");
            }

        }
    }
}
