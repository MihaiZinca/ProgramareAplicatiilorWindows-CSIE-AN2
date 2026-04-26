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

namespace Ex_Sub1
{
    public partial class Form1 : Form
    {
        List<Student>listaStudenti=new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugareStud_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNume.Text;
                string prenume = tbPrenume.Text;
                int varsta=Convert.ToInt32(tbVarsta.Text);

                string matricol = tbMatricol.Text;
                double medie=Convert.ToDouble(tbMedie.Text);
                List<string> materii = tbMaterii.Text.Split(',').ToList();
                Student s = new Student(nume, prenume, varsta, matricol, medie, materii);
                listaStudenti.Add(s);
                MessageBox.Show("Student adaugat cu succes!");
            }
            catch(ValidareException ve)
            {
                MessageBox.Show(ve.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbPrenume.Clear();
                tbVarsta.Clear();
                tbMatricol.Clear();
                tbMedie.Clear();
                tbMaterii.Clear();
            }

        }

        private void btnAfisareStudTV_Click(object sender, EventArgs e)
        {
            tvStudenti.Nodes.Clear();
            foreach(Student s in listaStudenti)
            {
                TreeNode parinte = new TreeNode(s.Matricol);
                tvStudenti.Nodes.Add(parinte);

                TreeNode copil = new TreeNode(s.Nume + "-" + s.Prenume + "-" + s.Varsta);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode(s.Medie.ToString());
                copil.Nodes.Add(nepot);

                TreeNode mat = new TreeNode("Materii");
                foreach(string m in s.Materii)
                {
                    mat.Nodes.Add(m);
                }
                nepot.Nodes.Add(mat);

            }
            tvStudenti.ExpandAll();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.dat)|*.dat";
            if(saveFileDialog1.ShowDialog()== DialogResult.OK )
            {
                FileStream fs=new FileStream(saveFileDialog1.FileName,FileMode.Create,FileAccess.Write);
                BinaryFormatter bf=new BinaryFormatter();
                bf.Serialize(fs, listaStudenti);
                fs.Close();
                MessageBox.Show("Serializare realizata cu succes!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream(saveFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<Student> listaStud=(List<Student>)bf.Deserialize(fs);
            foreach(Student s in listaStud)
            {
                ListViewItem itm = new ListViewItem(s.Nume);
                itm.SubItems.Add(s.Prenume);
                itm.SubItems.Add(s.Varsta.ToString());
                itm.SubItems.Add(s.Matricol);
                itm.SubItems.Add(s.Medie.ToString());
                string materii = "";
                foreach (string m in s.Materii)
                {
                    materii += m + ",";
                }
                materii = materii.TrimEnd(',',' ');
                itm.SubItems.Add(materii);
               
                lvAfisareStud.Items.Add(itm);
            }
            fs.Close();
            MessageBox.Show("Deserializare realizata cu succes!");
        }
    }
}

