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

namespace Ex_Farmacie
{
    public partial class Form1 : Form
    {
        List<FisaPacient> listaPacienti=new List<FisaPacient>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaMedicament_Click(object sender, EventArgs e)
        {
            FormMedicamente fm=new FormMedicamente();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(tbNume.Text))
                        throw new Exception("Nume gol");
                    if (String.IsNullOrWhiteSpace(tbSimptome.Text))
                        throw new Exception("Fara simptome");
                    if (string.IsNullOrWhiteSpace(tbDurataTr.Text))
                        throw new Exception("DurataTratament goala");
                    string nume = tbNume.Text;
                    string simptome=tbSimptome.Text;
                    int durataTratament = Convert.ToInt32(tbDurataTr.Text);

                    List<Medicament> medicamente=new List<Medicament>();
                    foreach(Medicament m in fm.ListaMedicamente)
                        medicamente.Add(m);

                    FisaPacient fisa=new FisaPacient(nume,simptome,durataTratament,medicamente);
                    listaPacienti.Add(fisa);
                    lbFisaPacient.Items.Add(fisa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                foreach(FisaPacient f in listaPacienti)
                    sw.WriteLine(f.ToString());
                sw.Close();
                MessageBox.Show("Scriere in fisier.txt realizat cu succes");
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr=new StreamReader(openFileDialog1.FileName);
                string linie;
                while((linie=sr.ReadLine()) != null)
                {
                    
                 
                        string nume = linie.Split(' ')[0];
                        int durata = Convert.ToInt32(linie.Split(' ')[1]);
                        string simptome=linie.Split(' ')[2];

                        FisaPacient f = new FisaPacient();
                        f.Nume= nume;
                        f.Durata_tratament = durata;
                        f.Simptome= simptome;
                        listaPacienti.Add(f);

                        ListViewItem itm = new ListViewItem(f.Nume);
                        itm.SubItems.Add(f.Durata_tratament.ToString());
                        itm.SubItems.Add(f.CalculPretTratament().ToString());
                        lvF.Items.Add(itm);

                 
                }
                sr.Close();
                
            }
        }

        //scriere in fisier binar
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fis.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, listaPacienti);
            fs.Close();
            MessageBox.Show("Serializare realizata cu succes!");
        }

        //citire din fisier binar
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("fis.dat",FileMode.Open, FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<FisaPacient> list=(List<FisaPacient>)bf.Deserialize(fs);
            foreach(FisaPacient f in list)
            {
                ListViewItem itm=new ListViewItem(f.Nume);
                itm.SubItems.Add(f.Durata_tratament.ToString());
                itm.SubItems.Add(f.Simptome.ToString());
                itm.SubItems.Add(f.CalculPretTratament().ToString());
                lvF.Items.Add(itm);
            }
            fs.Close();
            MessageBox.Show("Fisier restaurat cu succes!");
        }
    }
}
