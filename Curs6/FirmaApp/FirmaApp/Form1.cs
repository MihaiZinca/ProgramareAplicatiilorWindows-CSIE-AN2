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
        

        void show_hide(bool val_bool)
        {
            //ne da popupuri   conversie pt a acesa subitems
            ((ToolStripMenuItem)men.Items[0]).DropDownItems[1].Enabled = val_bool; //stocheaza
            ((ToolStripMenuItem)men.Items[1]).DropDownItems[1].Enabled = val_bool; //modifca
            ((ToolStripMenuItem)men.Items[1]).DropDownItems[2].Enabled = val_bool; //sterge
        }
        private void ObiectFirma_Ev_Modificare_Firma(object sender, Firma_EvArgs e)
        {
            Firma aux = sender as Firma; //sender este this
            gv.Rows.Clear();//le eliminam pe toate
            sbfs.Text = aux.Fond_Sal.ToString(); //fac legatura dintre model si form1 pt fond salarii sincronizare
            foreach (Salariat s in aux.Salariati)
                gv.Rows.Add(s.Marca.ToString(), s.Nume, s.Nr_ore.ToString(), s.Sal_ora.ToString());

            if (aux.Numar_Salariati > 0)
            {
                gv.Rows[e.Index_Salariat].Selected = true;
                show_hide(true);
            }
            else show_hide(false);
            
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
                fa.tbNp.Text=rd.Cells[1].Value.ToString();
                fa.tbNo.Text= rd.Cells[2].Value.ToString();
                fa.tbSo.Text=rd.Cells[3].Value.ToString();


            }
            if(DialogResult.OK==fa.ShowDialog()) //daca apas pe Adauga se construieste....
            {
                Salariat sal = new Salariat
                {
                    Marca = int.Parse(fa.tbMa.Text),
                    Nume = fa.tbNp.Text,
                    Nr_ore = int.Parse(fa.tbNo.Text),
                    Sal_ora = int.Parse(fa.tbSo.Text)
                };
                if (soptiune == "A") obiectFirma.Adauga_Salariat(sal);
                else
                    obiectFirma[gv.SelectedRows[0].Index] = sal;
            }    

            //ma folosesc de TAG(properties) ca sa stiu de pe ce buton a apasat! daca pe adauga/modifica
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += obiectFirma.Nume_Firma; //mai intai se apelaza constructorul si dupa in load se foloseste
            show_hide(false);
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd=new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Fisiere de date|*.dat|Toate fisierele|*.*";
            if (DialogResult.OK == ofd.ShowDialog())
                obiectFirma.Deserializeaza(ofd.FileName);

           // obiectFirma.Deserializeaza("fsal.dat"); nu l mai dau asa, ci sa l prelucrez de undeva
        }

        private void stocheazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:\\";
            sfd.Filter = "Fisiere de date|*.dat|Toate fisierele|*.*";

            if (DialogResult.OK == sfd.ShowDialog())
            {
                obiectFirma.Serializeaza(sfd.FileName);
            }

            //obiectFirma.Serializeaza("fsal.dat");

        }
    }
    //serializare -salvarea datelor intr un fisier
    //deserializarea -restaurarea datelor intr un fisier
    //in prima etapa trebuie sa definesc starea obiectului!! 

    
    
}
