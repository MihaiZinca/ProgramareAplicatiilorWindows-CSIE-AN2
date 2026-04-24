using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Sala
{
    public partial class t : Form
    {
        List<Client> listaCl=new List<Client>();
        List<Abonament> abonamente=new List<Abonament>();
        public t()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbId.Text);
                string nume = tbNume.Text;
                int varsta=Convert.ToInt32(tbVarsta.Text);

                Client c=new Client(id, nume, varsta);
                listaCl.Add(c);
                lbClienti.Items.Add(c);

            }
            catch(Validare v)
            {
                MessageBox.Show(v.Message,"EROARE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbId.Clear();
                tbNume.Clear();
                tbVarsta.Clear();
            }

        }

        private void btnCreeazaAbonament_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valid = true;
            if(string.IsNullOrEmpty(tbCodA.Text))
            {
                errorProvider1.SetError(tbCodA,"Cod neintrodus");
                valid = false;
            }
            if(string.IsNullOrEmpty(tbTipA.Text))
            {
                errorProvider1.SetError(tbTipA, "Tip neintrodus");
                valid = false;
            }
            if(string.IsNullOrEmpty(tbPretA.Text))
            {
                errorProvider1.SetError(tbTipA, "Pret neintrodus");
                valid = false;
            }
            if (!valid) return;
            try
            {
                int codA=Convert.ToInt32(tbCodA.Text);
                string tipA=tbTipA.Text;
                double pretA=double.Parse(tbPretA.Text);

                List<Client> clientiSelectati=new List<Client>();
             
                foreach (Client c in lbClienti.SelectedItems)
                {
                    clientiSelectati.Add(c);
                   
                }

                Abonament a=new Abonament(codA,tipA,pretA,clientiSelectati);

                if(!a.EsteValid())
                {
                    MessageBox.Show("Selectati clientul");
                    return;
                }
                abonamente.Add(a);

                ListViewItem itm=new ListViewItem(a.Cod.ToString());
                itm.SubItems.Add(a.Tip.ToString());
                itm.SubItems.Add(a.CalculeazaCost().ToString());
                lvAbonament.Items.Add(itm);               

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void saveTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
                foreach (Abonament a in abonamente)
                    sw.WriteLine(a.ToString());
                sw.Close();
                MessageBox.Show(".txt salvat cu succes!");
            }
        }

        private void openTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr=new StreamReader(openFileDialog1.FileName);
                lvAbonament.Items.Clear();
                string linie;
                while((linie=sr.ReadLine()) != null)
                {
                    string cod = linie.Split('|')[0];
                    string tip = linie.Split('|')[1];
                    string pret=linie.Split('|')[2];

                    ListViewItem itm = new ListViewItem(cod);
                    itm.SubItems.Add(tip);
                    itm.SubItems.Add(pret);
                    lvAbonament.Items.Add(itm);
                }
                sr.Close();
                MessageBox.Show(".txt deschis cu succes!");
            }
        }

        private void saveBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ab.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, abonamente);
            fs.Close();
            MessageBox.Show("ab.dat salvat cu succes!");
        }

        private void openBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("ab.dat",FileMode.Open, FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<Abonament> listA = (List<Abonament>)bf.Deserialize(fs);
            foreach(Abonament a in listA)
            {
                ListViewItem itm = new ListViewItem(a.Cod.ToString());
                itm.SubItems.Add(a.Tip);
                itm.SubItems.Add(a.CalculeazaCost().ToString());
                lvAbonament.Items.Add(itm);
            }
            fs.Close();
            MessageBox.Show("ab.dat deschis cu succes!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
