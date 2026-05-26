using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar13_DataBinding
{
    public partial class Form1 : Form
    {
        List<Student> listaStudenti;
        public Form1()
        {
            InitializeComponent();
            
            listaStudenti=new List<Student>();
            listaStudenti.Add(new Student("Student1", "CSIE", 7.8f, false));
            listaStudenti.Add(new Student("Student2", "CSIE", 9.8f, false));
            listaStudenti.Add(new Student("Student3", "CSIE", (float)8.2, false));

            DataTable dt= new DataTable();
            dt.Columns.Add("Nume");
            dt.Columns.Add("Facultate");
            dt.Columns.Add("Medie");
            dt.Columns.Add("Este buget");
            

            //varianta de populare a DataGridView printr un ob de tip DataTable
            //foreach (Student student in listaStudenti)
            //    dt.Rows.Add(student.Nume, student.Facultate, student.Medie, student.EsteBuget);

            dgvStudenti.DataSource= listaStudenti; //setarea listei ca sursa de date
        }

        private void btnPopuleaza_Click(object sender, EventArgs e)
        {
            lbStudenti.DataSource = listaStudenti;
            lbStudenti.DataBindings.Add(new Binding("Text", listaStudenti, ""));
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag as string == "Prev")
                BindingContext[listaStudenti].Position -= 1;
            else
                BindingContext[listaStudenti].Position += 1;
        }

        private void btnAfisareDGV_Click(object sender, EventArgs e)
        {
            Student stud = (Student)dgvStudenti.CurrentRow.DataBoundItem;
            MessageBox.Show(stud.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listaStudenti);
            form2.Show();
        }
    }
}
