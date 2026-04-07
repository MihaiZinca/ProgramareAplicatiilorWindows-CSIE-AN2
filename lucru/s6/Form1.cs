using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s6
{
    public partial class Form1 : Form
    {
        List<Student> listaStudenti=new List<Student>();
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
            while((linie=sr.ReadLine()) != null )
            {
                try
                {
                    int matricol = Convert.ToInt32(linie.Split(',')[0]);
                    string nume = linie.Split(',')[1];
                    float medie = float.Parse(linie.Split(',')[2], CultureInfo.InvariantCulture.NumberFormat);

                    Student s = new Student(matricol, nume, medie);
                    listaStudenti.Add(s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close(); 
        }

        private void tbnPopulareLV_Click(object sender, EventArgs e)
        {
            foreach(Student s in listaStudenti)
            {
               ListViewItem item=new ListViewItem(s.matricol.ToString());
                item.SubItems.Add(s.nume);
                item.SubItems.Add(s.medie.ToString());
                if (s.medie > 9) item.SubItems.Add("execelent");
                else item.SubItems.Add("bun");
                lvStudenti.Items.Add(item);
            }
        }

        private void btnStergeElementLV_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvStudenti.Items)
            {
                if(item.Checked)item.Remove(); //daca e bifat il sterge
            }
        }

        private void stergeElementLVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvStudenti.Items)
            {
                if (item.Checked) item.Remove(); 
            }

        }

        private void lvStudenti_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Red;
        }

        private void btnPopulareTV_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Studenti");
            tvStudenti.Nodes.Add(parinte);

            foreach(Student s in listaStudenti)
            {
                TreeNode copil = new TreeNode(s.matricol + "-" + s.nume + "-" + s.medie);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (s.medie > 9) nepot.Text = "excelent";
                else nepot.Text = "bun";

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

            foreach (Student s in listaStudenti)
            {
                if (s.matricol == matricol)
                    tbStudenti.Text += s.ToString() + Environment.NewLine;
            }
        }

        private void stergeElementTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode nodSelectat=tvStudenti.SelectedNode;
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
            tvStudenti.SelectedNode= nodSelectat;
        }
    }
}
