using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Biblioteca
{
    public partial class Form1 : Form
    {
        List<Carte> listaCarti=new List<Carte>();
        List<Imprumut>listaImprumuturi=new List<Imprumut>();
        public Form1()
        {
            InitializeComponent();
            lvImprumuturi.ContextMenuStrip = contextMenuStrip1;
        }

        private void btnAdaugareCarte_Click(object sender, EventArgs e)
        {
            try
            {
                int cod=Convert.ToInt32(tbCodCarte.Text);
                string titlu=tbTitlu.Text;
                string autor=tbAutor.Text;
                double pret=double.Parse(tbPret.Text);
                Carte c=new Carte(cod,titlu,autor,pret);
                listaCarti.Add(c);
                lbCartiDisponibile.Items.Add(c);
                
            }
            catch(Validare v)
            {
                MessageBox.Show(v.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message,"EROARE",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbCodCarte.Clear();
                tbTitlu.Clear();
                tbAutor.Clear();    
                tbPret.Clear();

            }
        }

        private void btnImprumut_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;
            if(string.IsNullOrEmpty(tbNumeCit.Text))
            {
                throw new Exception("Nume cit invalid");
                valid = false;
            }
            if (string.IsNullOrEmpty(tbVarsta.Text))
            {
                throw new Exception("Varsta invalid");
                valid = false;
            }
            if (string.IsNullOrEmpty(tbZile.Text))
            {
                throw new Exception("Zile imprumut invalid");
                valid = false;
            }
            if (!valid) return;
            try
            {
                string numeCiti=tbNumeCit.Text;
                int varsta=Convert.ToInt32(tbVarsta.Text);
                int zileImprumut=Convert.ToInt32(tbZile.Text);
                int id_cit = 1;
                Cititor cit = new Cititor(id_cit, numeCiti,varsta);
                Imprumut imp = new Imprumut(listaImprumuturi.Count + 1, cit, zileImprumut);

                foreach (Carte c in lbCartiDisponibile.SelectedItems)
                    imp += c;
                if(imp.EsteValid())
                {
                    listaImprumuturi.Add(imp);

                    ListViewItem itm = new ListViewItem(numeCiti);
                    itm.SubItems.Add(imp.CalculeazaCost().ToString());
                    lvImprumuturi.Items.Add(itm);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK )
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                foreach (Imprumut i in listaImprumuturi)
                    sw.WriteLine(i.ToString());
                sw.Close();
                MessageBox.Show(".txt salvat cu succes!");
            }
        }

        private void openTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                lvImprumuturi.Items.Clear();
                string linie;
                while ((linie = sr.ReadLine()) != null)
                {
                    ListViewItem itm = new ListViewItem(linie.Split(' ')[0]);
                    itm.SubItems.Add(linie.Split(' ')[1]);
                    lvImprumuturi.Items.Add(itm);
                }
                sr.Close();
                MessageBox.Show(".txt deschis cu succes!");
            }
        }

        private void saveBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("imp.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs,listaImprumuturi);
            fs.Close();
            MessageBox.Show("imp.dat salvat cu succes!");
        }

        private void openBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("imp.dat",FileMode.Open,FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<Imprumut> listaImp= (List<Imprumut>)bf.Deserialize(fs);
            foreach (Imprumut imp in listaImp)
            {
                ListViewItem itm = new ListViewItem(imp.Cititor.Nume);
                itm.SubItems.Add(imp.CalculeazaCost().ToString());
                lvImprumuturi.Items.Add(itm);
            }
            fs.Close();
            MessageBox.Show("imp.dat deschis cu succes!");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvImprumuturi_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Red;
        }
        private void stergeImprumutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in lvImprumuturi.Items)
                if (itm.Checked) itm.Remove();
        }

        private void detaliiImprumutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in lvImprumuturi.Items)
            {
                if(itm.Checked)
                {
                    string nume = itm.Text;
                    string cost = itm.SubItems[1].Text;

                    MessageBox.Show($"Cititor: {nume}\nCost: {cost}");
                }
            }
        }

        private void btnPopulareTV_Click(object sender, EventArgs e)
        {
            tvT.Nodes.Clear();  
            
            foreach(Imprumut imp in listaImprumuturi)
            {
                TreeNode parinte = new TreeNode(imp.Cititor.Nume);
                tvT.Nodes.Add(parinte);

                TreeNode copil = new TreeNode("Cost: "+imp.CalculeazaCost());
                parinte.Nodes.Add(copil);

                foreach(Carte c in listaCarti)
                {
                    TreeNode nepot = new TreeNode(c.Titlu + "-" + c.Pret);
                    copil.Nodes.Add(nepot);
                }
                
            }
            tvT.ExpandAll();
        }
    }
}
