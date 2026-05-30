using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliografice
{
    public partial class Form1 : Form
    {
        List<Carte> publicatii=new List<Carte>();
        List<Autor> autori=new List<Autor>();
        public Form1()
        {
            InitializeComponent();
            autori.Add(new Autor("Popescu Ion", "Prof.", 1));
            autori.Add(new Autor("Ionescu Maria", "Conf.", 2));
            autori.Add(new Autor("Georgescu Ana", "Lect.", 3));

            afisareAutori();
        }

        private void adaugaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarte fc=new FormCarte();
            if(fc.ShowDialog()==DialogResult.OK)
            {
                publicatii = fc.ListaCarti;
                afisarePublicatii();
            }
        }

        public void afisarePublicatii()
        {
            lvPublicatii.Items.Clear();
            foreach(Carte c in publicatii.OrderBy(x=>x.Titlu))
            {
                ListViewItem itm =new ListViewItem(c.Titlu);
                itm.SubItems.Add(c.Pret.ToString());
                itm.SubItems.Add(c.ISBN1);
                itm.SubItems.Add(c.Categorie);

                itm.Tag = c;
                lvPublicatii.Items.Add(itm);
            }
        }


        public void afisareAutori()
        {
            lvAutori.Items.Clear();
            foreach(Autor a in autori)
            {
                ListViewItem itm = new ListViewItem(a.Nume);
                itm.SubItems.Add(a.Grad_didactic);
                itm.SubItems.Add(a.Marca.ToString());
                itm.Tag = a;
                lvAutori.Items.Add(itm);
            }
        }

        private void importDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDB fdb=new FormDB();
            if(fdb.ShowDialog() == DialogResult.OK)
            {
                foreach (Autor a in fdb.AutoriSelecati)
                    autori.Add(a);
                afisareAutori();
            }
        }

        private void lvPublicatii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPublicatii.SelectedItems.Count == 0) return;

            Carte c = (Carte)lvPublicatii.SelectedItems[0].Tag;

            tbAutori.Text = "";
            foreach (Autor a in c.Autori)
                tbAutori.Text += a.Nume + Environment.NewLine;
        }

        private void lvAutori_MouseDown(object sender, MouseEventArgs e)
        {
            if(lvAutori.SelectedItems.Count > 0)
            {
                lvAutori.DoDragDrop(lvAutori.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void tbAutori_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect= DragDropEffects.Copy;
        }

        private void tbAutori_DragDrop(object sender, DragEventArgs e)
        {
            if (lvPublicatii.SelectedItems.Count == 0)
                return;

            // autorul tras
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            Autor a = (Autor)item.Tag;

            // cartea selectata
            Carte c = (Carte)lvPublicatii.SelectedItems[0].Tag;


            // RELATIE 1:M
            if (!c.Autori.Contains(a))
                c.Autori.Add(a);

            // refresh textbox
            tbAutori.Text = "";
            foreach (Autor aut in c.Autori)
            {
                tbAutori.Text += aut.Nume + Environment.NewLine;
            }
        }
    }
}
