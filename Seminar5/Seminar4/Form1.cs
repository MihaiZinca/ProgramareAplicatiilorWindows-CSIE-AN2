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


//Form1 clasa, are atribute,proprietati,metode... 

namespace Seminar4
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
            //Form1 form=(Form1)sender -> form.Text 
            MessageBox.Show($"Se deschide {this.Text}...");//aceasta proprietate text tine de form1 .<=> this.Text 
        }

        private void tbAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNume.Text == "")
                {//daca este gol
                    throw new Exception("Numele este invalid!");
                }
                if(string.IsNullOrEmpty(tbFacultate.Text))
                {
                    throw new StudentValidareException("Facultatea nu e introdusa");
                }
                string nume = tbNume.Text;
                string facultate = tbFacultate.Text;
                string[] noteString = tbNote.Text.Split(',');
                int[] noteInt = new int[noteString.Length];
                for (int i = 0; i < noteString.Length; i++)
                {
                    noteInt[i] = int.Parse(noteString[i]);
                }
                Student s = new Student(nume, facultate, noteInt);
                s.CalculeazaMedie();
                MessageBox.Show(s.ToString());
                studenti.Add(s); //adaug studentul meu in lista de studenti
            }
            catch (StudentValidareException sve)
            {
                MessageBox.Show(sve.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message,"EROARE",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbFacultate.Clear();
                tbNote.Clear();
            }

            //trb sa am minim un catch
            
        }

        private void btnAfiseazaStud_Click(object sender, EventArgs e)
        {
            foreach(Student s in studenti)
            {
                tbStudenti.Text += s.ToString() + Environment.NewLine; //ENVIROMENT.NewLine Enviroment-clasa,  NewLine-proprietate returneaza \n
            }
        }

        
        private void btnAfiseazaStudLV_Click(object sender, EventArgs e) //pt listView gen
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

        //scrierea in fisier
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt"; //ce am in stanga barii asta va aparea pt save as ,ce am in dreapta este extensia
            //stg ii arat cum salvez, dreapta salvez
            if(saveFileDialog1.ShowDialog()==DialogResult.OK) //istantez dialogul si verific raspunsul - save e preluat ca ok
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach(Student s in studenti)
                {
                    sw.WriteLine(s.ToString());
                    
                }

                sw.Close();
                MessageBox.Show($"S-a salvat fisierul {saveFileDialog1.FileName}");
            }
        }

        //citirea in fisier
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                tbStudenti.Text = sr.ReadToEnd();//citeste tot ce am in fisier
                sr.Close();
            }
        }



    }
}
