using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string nume = tbNume.Text;
            string facultate=tbFacultate.Text;
            string[] noteString = tbNote.Text.Split(',');
            int[] noteInt=new int[noteString.Length];
            for (int i = 0; i < noteString.Length;i++)
            {
                noteInt[i]=int.Parse(noteString[i]);
            }
            Student s=new Student(nume,facultate, noteInt);
            s.CalculeazaMedie();
            MessageBox.Show(s.ToString());
            studenti.Add(s); //adaug studentul meu in lista de studenti
        }

        private void btnAfiseazaStud_Click(object sender, EventArgs e)
        {
            foreach(Student s in studenti)
            {
                tbStudenti.Text += s.ToString() + Environment.NewLine; //ENVIROMENT.NewLine Enviroment-clasa,  NewLine-proprietate returneaza \n
            }
        }

        
    }
}
