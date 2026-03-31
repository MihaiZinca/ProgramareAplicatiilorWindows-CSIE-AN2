using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar6
{
    public partial class Form1 : Form
    {
        List<Student> listaStudenti = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            incarcareDate();
            lvStudenti.ContextMenuStrip = contextMenuStrip1;
            lvStudenti.ContextMenuStrip = contextMenuStrip2;
        }

        private void incarcareDate()
        {
            StreamReader sr = new StreamReader("Studenti.txt");
            string linie;
            while((linie=sr.ReadLine())!=null) //citire linie cu linie din fisier
            {
                try
                {
                    int matricol = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    float medie = float.Parse(linie.Split(',')[2],
                        CultureInfo.InvariantCulture.NumberFormat); 
                    //pt a putea programul sa citeasac punctul de la medie(conversie in float)

                    Student s = new Student(matricol, nume, medie);
                    listaStudenti.Add(s);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            sr.Close();
            MessageBox.Show("Datele au fost incarcate!");
        }

        private void btnPreluareLV_Click(object sender, EventArgs e)
        {

            foreach(Student s in listaStudenti)
            {
                ListViewItem item = new ListViewItem(s.matricol.ToString());
                item.SubItems.Add(s.nume);
                item.SubItems.Add(s.medie.ToString());

                if (s.medie > 9) //populare ult coloanei din LV cu un text
                    item.SubItems.Add("Excelent");
                else
                    item.SubItems.Add("Bun");

                lvStudenti.Items.Add(item);
            }
        }

        private void btnStergeElemLV_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvStudenti.Items)
            {
                if (itm.Checked) itm.Remove();
            }
        }

        private void stergeElemtLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvStudenti.Items)
            {
                if (itm.Checked) itm.Remove();
            }
        }

        private void lvStudenti_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Red;
            // pentru a pune culoarea roșu pe fundalul unui rând din ListView,
            // atunci când acesta este selectat.
        }

        private void btnPopulareTV_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            //se creaza nodul parinte(prin cls TreeNode) dupa se atribuie tvStudenti
            tvStudenti.Nodes.Add(parinte);
            
            foreach(Student s in listaStudenti)
            {
                TreeNode copil = new TreeNode(s.matricol + "-" + s.nume + "-" + s.medie);
                parinte.Nodes.Add(copil);

                //pt fiecare stud din lista se creeaza un nod copil cu date despre student,
                //iar apoi se adauga la nodul parinte(se real leg dintre cele 2 noduri)

                TreeNode nepot = new TreeNode();

                if (s.medie > 9)
                    nepot.Text = "Excelent";
                else
                    nepot.Text = "Bun";

                copil.Nodes.Add(nepot);
            }
            tvStudenti.ExpandAll();
        }

        private void tvStudenti_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodSelectat = tvStudenti.SelectedNode;
            int matricol;
            try
            {
                matricol = Convert.ToInt32(nodSelectat.Text.Split('-')[0]);

            }
            catch
            {
                matricol = 0;
            }

            foreach(Student s in listaStudenti)
            {
                if (s.matricol == matricol)
                    tbStudenti.Text += s.ToString() + Environment.NewLine;
            }
        }

        private void stergeElementTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat = tvStudenti.SelectedNode;
            if(nodSelectat.NextNode!=null)
            {
                nodSelectat = tvStudenti.SelectedNode.NextNode;
            }
            else
            {
                if (nodSelectat.PrevNode != null)
                    nodSelectat = tvStudenti.SelectedNode.PrevNode;
            }

            tvStudenti.SelectedNode.Remove();
            tvStudenti.SelectedNode = nodSelectat;
        }
    }
}
