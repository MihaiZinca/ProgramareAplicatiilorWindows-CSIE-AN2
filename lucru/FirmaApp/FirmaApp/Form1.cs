using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            obiectFirma = new Firma("ASE_SRL");
            obiectFirma.Ev_Modificare_Firma += ObiectFirma_Ev_Modificare_Firma;
        }

        private void ObiectFirma_Ev_Modificare_Firma(object sender, Firma_EvArgs e)
        {
            Firma aux = sender as Firma;
            gv.Rows.Clear();
            foreach(Salariat s in aux.Salariati)
                gv.Rows.Add(s.Marca.ToString(),s.Nume,s.Nr_ore.ToString(),s.Sal_ora.ToString());
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
            string soptiune = ((ToolStripMenuItem)sender).Tag.ToString();
            if (soptiune == "A")
            {
                fa.Text = "Adaugare Salariat";
                fa.button1.Text = "Adauga";
            }
            else
            {
                fa.Text = "Modificare Salariat";
                fa.button1.Text = "Modifica";
                DataGridViewRow rd = gv.SelectedRows[0];
                fa.tbMa.Text = rd.Cells[0].Value.ToString();
                fa.tbNp.Text = rd.Cells[1].Value.ToString();
                fa.tbNo.Text=rd.Cells[2].Value.ToString();
                fa.tbSo.Text=rd.Cells[3].Value.ToString();
            }
            if (DialogResult.OK==fa.ShowDialog())
            {
                Salariat sal = new Salariat
                {
                    Marca = int.Parse(fa.tbMa.Text),
                    Nume = fa.tbNp.Text,
                    Nr_ore = int.Parse(fa.tbNo.Text),
                    Sal_ora = int.Parse(fa.tbSo.Text)
                };

                if (soptiune == "A") 
                    obiectFirma.Adauga_Salariat(sal);
                else
                    obiectFirma[gv.SelectedRows[0].Index] = sal;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += obiectFirma.Nume_Firma;
        }
    }
}
