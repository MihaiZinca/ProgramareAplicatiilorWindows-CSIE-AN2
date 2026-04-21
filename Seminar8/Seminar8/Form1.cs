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
using System.Xml;

namespace Seminar8
{
    public partial class Form1 : Form
    {
        Carte c;
        Biblioteca biblioteca;
        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca("ASE");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"Carti.xml");
            XmlNodeList xnList = xmlDoc.SelectNodes("/catalog");
            foreach(XmlNode xn in xnList)
            {
                XmlNodeList xmlNodeList = xn.ChildNodes;
                foreach(XmlNode node in xmlNodeList)
                {

                    string id = node.Attributes["id"].Value;
                    string autor = node["author"].InnerText;
                    string titlu = node["title"].InnerText;
                    string domeniu = node["genre"].InnerText;
                    double pret = Convert.ToDouble(node["price"].InnerText);
                    string descriere = node["description"].InnerText;

                    Carte carte = new Carte(autor, titlu, domeniu, (float)pret, descriere);
                    lbCarti.Items.Add(id + carte.Autor +carte.Pret);
                    biblioteca.adaugaCarte(carte);

                }
            }
            tbTitlu.Text = biblioteca.Nume;
        }

        private void lbCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbCarti.SelectedIndex;
            c = biblioteca.ListaCarti[index];
            tbPlata.Text = (c.Pret * 0.9).ToString();
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            tbPlata.Text = c.Pret.ToString();
        }

        private void rbDa_CheckedChanged(object sender, EventArgs e)
        {
            tbPlata.Text = (c.Pret * 0.9).ToString();
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            string titulatura = cbTitulatura.GetItemText(cbTitulatura.SelectedItem);
            string nume = tbNume.Text;
            string adresa = tbAdresa.Text;
            bool student = rbDa.Checked == true ? true : false;
            float plata = float.Parse(tbPlata.Text);

            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("=== DATE CLIENT ===");
                sw.WriteLine("Titulatura: " +titulatura);
                sw.WriteLine("Nume: " + nume);
                sw.WriteLine("Adresa: " + adresa);
                sw.WriteLine("Student: " + (student ? "Da" : "Nu"));

                sw.WriteLine("\n=== CARTE ===");
                sw.WriteLine("Autor: " + c.Autor);
                sw.WriteLine("Titlu: " + c.Title);
                sw.WriteLine("Pret: " + c.Pret);

                sw.WriteLine("\n=== PLATA ===");
                sw.WriteLine("Total: " + plata);

                sw.Close();
                MessageBox.Show("Salvat");
            }
        }
    }
}
