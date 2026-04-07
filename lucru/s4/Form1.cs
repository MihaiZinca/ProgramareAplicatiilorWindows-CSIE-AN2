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

namespace s4
{
    public partial class Form1 : Form
    {
        private List<Student> studenti=new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Se deschide {this.Text}...");
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string facultate = tbFacultate.Text;
                string[] noteString = tbNote.Text.Split(' ');
                int[] noteInt = new int[noteString.Length];
                for (int i = 0; i < noteString.Length; i++)
                    noteInt[i] = int.Parse(noteString[i]);

                Student s = new Student(nume, facultate, noteInt);
                s.CalculeazaMedie();
                MessageBox.Show(s.ToString());
                studenti.Add(s);
            }
            catch (StudentValidareException sve)
            {
                MessageBox.Show(sve.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbFacultate.Clear();
                tbNote.Clear();
            }

        }

        private void btnAfiseazaStud_Click(object sender, EventArgs e)
        {
            foreach(Student s in studenti)
            {
                tbStudenti.Text += s.ToString() + Environment.NewLine;
            }
        }

        private void btnAfiseazaStudLV_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Student s in studenti)
            {
                ListViewItem lvi = new ListViewItem(s.Nume);
                lvi.SubItems.Add(s.Facultate);
                lvi.SubItems.Add(s.Medie.ToString());
                listView1.Items.Add(lvi);
            }    
        }

        //scierea in fisier
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                foreach(Student s in studenti)
                    sw.WriteLine(s.ToString());
                sw.Close();
            }
        }

        //citirea din fisier
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                StreamReader sr=new StreamReader(openFileDialog1.FileName); 
                tbStudenti.Text=sr.ReadToEnd();
                sr.Close();
            }    
        }

        //scriere fisierBinar -serializare
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream("stud.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, studenti);
            fs.Close();

        }

        //citire fisierBinar -deserializare
        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("stud.dat",FileMode.Open, FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<Student> listaStud=(List<Student>)bf.Deserialize(fs);
            foreach (Student s in listaStud)
                tbStudenti.Text += s.ToString() + "\n";
            fs.Close();
        }
    }
}
