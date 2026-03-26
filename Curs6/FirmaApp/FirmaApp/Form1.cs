using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaApp
{
    public partial class Form1 : Form
    {
        Firma obiectFirma;
        public Form1()
        {
            InitializeComponent();
            obiectFirma = new Firma("ASE_SRL"); //se apeleaza constructorul
            obiectFirma.Ev_Modificare_Firma += ObiectFirma_Ev_Modificare_Firma; //PT A AFISA CE AM ADAUGAT
        }

        private void ObiectFirma_Ev_Modificare_Firma(object sender, Firma_EvArgs e)
        {
            Firma aux = sender as Firma; //sender este this
            gv.Rows.Clear();//le eliminam pe toate
            foreach (Salariat s in aux.Salariati)
                gv.Rows.Add(s.Marca.ToString(), s.Nume, s.Nr_ore.ToString(), s.Sal_ora.ToString());

            if (aux.Numar_Salariati > 0)
                gv.Rows[e.Index_Salariat].Selected = true;
            
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes== MessageBox.Show("Esti sigur ?", "DaNu", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_actualizare fa = new Form_actualizare();
            fa.Text = "Adaugare Salariat";
            fa.button1.Text = "Adauga";
            if(DialogResult.OK==fa.ShowDialog()) //daca apas pe Adauga se construieste....
            {
                Salariat sal = new Salariat
                {
                    Marca = int.Parse(fa.tbMa.Text),
                    Nume = fa.tbNp.Text,
                    Nr_ore = int.Parse(fa.tbNo.Text),
                    Sal_ora = int.Parse(fa.tbSo.Text)
                };
                obiectFirma.Adauga_Salariat(sal); 
            }    

            //ma folosesc de TAG(properties) ca sa stiu de pe ce buton a apasat!
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += obiectFirma.Nume_Firma; //mai intai se apelaza constructorul si dupa in load se foloseste
        }
    }
}
