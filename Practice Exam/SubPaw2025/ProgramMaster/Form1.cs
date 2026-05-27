using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMaster
{
    public partial class Form1 : Form
    {
        List<Candidat> lstCandidati=new List<Candidat>();
        List<ProgramStudiu> lstPrograme=new List<ProgramStudiu> ();
        public Form1()
        {
            InitializeComponent();
            incarcareCandidati();
            incarcarePrograme();
            AfisareLV();
            AfisareLB();
            lvCandidati.ContextMenuStrip = contextMenuStrip1;
        }

        public void incarcareCandidati()
        {
            StreamReader sr = new StreamReader("Candidati.txt");
            string linie;
            while( (linie=sr.ReadLine() )!=null)
            {
                try
                {
                    string[] p = linie.Split(',');
                    int codC=int.Parse(p[0]);
                    string nume=p[1];
                    float medieC = float.Parse(p[2]);
                    string[] optString = p[3].Split(';');
                    int[] optInt=new int[optString.Length];
                    for(int i=0;i<optString.Length;i++)
                        optInt[i]=int.Parse(optString[i]);

                    Candidat c=new Candidat(codC, nume, medieC, optInt);
                    lstCandidati.Add(c);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Candidati incarcati cu succes!");
        }

        public void incarcarePrograme()
        {
            StreamReader sr = new StreamReader("Programe.txt");
            string linie;
            while((linie=sr.ReadLine())!=null)
            {
                try
                {
                    int cod = int.Parse(linie.Split(',')[0]);
                    string denumire = linie.Split(',')[1];
                    int nrB = int.Parse(linie.Split(',')[2]);
                    int nrT = int.Parse(linie.Split(',')[3]);

                    ProgramStudiu ps=new ProgramStudiu(cod,denumire,nrB,nrT);
                    lstPrograme.Add(ps);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            MessageBox.Show("Programe incarcate cu succes!");
        }

        public void AfisareLV()
        {
            lvCandidati.Items.Clear();
            foreach(Candidat c in lstCandidati)
            {
                ListViewItem itm =new ListViewItem(c.CodCandidat.ToString());
                itm.SubItems.Add(c.NumeCandidat);
                itm.SubItems.Add(c.MedieConcurs.ToString());
                itm.SubItems.Add(string.Join(";", c.VectorOptiuni));
                itm.Tag = c;
                lvCandidati.Items.Add(itm);
            }
        }

        public void AfisareLB()
        {
            lbPrograme.Items.Clear();
            foreach (ProgramStudiu ps in lstPrograme)
                lbPrograme.Items.Add(ps);
        }

        private void lbPrograme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCandidati.Items.Count == 0) return;

            Candidat c = (Candidat)lvCandidati.SelectedItems[0].Tag;
            ProgramStudiu p = (ProgramStudiu)lbPrograme.SelectedItem;

            List<int> opt = c.VectorOptiuni.ToList();

            if (!opt.Contains(p.CodProgram))
            {
                opt.Add(p.CodProgram);
                c.VectorOptiuni = opt.ToArray();
                AfisareLV();
            }
        }

        private void btnAdaugareCandidat_Click(object sender, EventArgs e)
        {
            FormCandidat fc=new FormCandidat();
            if(fc.ShowDialog() == DialogResult.OK)
            {
                lstCandidati.Add(fc.CandidatNou);
                AfisareLV();
            }    
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvCandidati.SelectedItems.Count==0) return;

            Candidat c = (Candidat)lvCandidati.SelectedItems[0].Tag;
            lstCandidati.Remove(c);
            AfisareLV();
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidat c = (Candidat)lvCandidati.SelectedItems[0].Tag;
            FormCandidat fc=new FormCandidat(c);
            if (fc.ShowDialog() == DialogResult.OK)
            {
                AfisareLV();
            }

        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            FormGrafic fg = new FormGrafic(lstCandidati, lstPrograme);
            fg.Show();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd=new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog pdlg = new PrintPreviewDialog { Document = pd };
            pdlg.ShowDialog();
        }


        private void pp(Object sender, PrintPageEventArgs e)
        {
            Font fontTitlu = new Font("Arial", 12, FontStyle.Bold);
            Font fontText = new Font("Arial", 10);
            float y = 20;

            foreach (ProgramStudiu p in lstPrograme)
            {
                e.Graphics.DrawString($"Program:{p.CodProgram}", fontTitlu, Brushes.Black, 20, y);
                y += 25;

                foreach (Candidat c in lstCandidati)
                {
                    e.Graphics.DrawString($"-{c.NumeCandidat}", fontText, Brushes.Black, 40, y);
                    y += 25;
                }
                y += 10;
            }
        }

        private void serializareCandidatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("candidati.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs,lstCandidati);
            fs.Close();
            MessageBox.Show("Serializare realizata  cu succes!");
        }

        private void serializareProgrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("programe.dat",FileMode.Create, FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, lstPrograme);
            fs.Close();
            MessageBox.Show("Serializare utilizatori.dat realizata  cu succes!");
        }
    }
}
