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

namespace AcessPack
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        List<AccessP> listaPack=new List<AccessP>();
        public Form1()
        {
            InitializeComponent();
            IncarcareDate();
        }

        public void IncarcareDate()
        {
            StreamReader sr = new StreamReader("Access.txt");
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                int id = int.Parse(linie.Split(',')[0]);
                string nume=linie.Split(',')[1];
                double price=double.Parse(linie.Split(',')[2]);

                AccessP p=new AccessP(id, nume, price);
                listaPack.Add(p);
            }
            sr.Close();
            MessageBox.Show("Incarcare date cu succes!");
        }

        private void btnDeschide_Click(object sender, EventArgs e)
        {
            Form fr = new Form(listaPack);
            fr.ShowDialog();
        }
    }
}
