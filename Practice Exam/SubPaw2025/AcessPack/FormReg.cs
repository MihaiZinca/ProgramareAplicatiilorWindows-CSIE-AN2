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

namespace AcessPack
{

      public partial class Form : System.Windows.Forms.Form
    {
        List<Registration> listaReg=new List<Registration>();
        List<AccessP> listaPack;
        public Form(List<AccessP> p)
        {
            InitializeComponent();
            listaPack = p;

            cmbAccesPack.DataSource = listaPack;
            cmbAccesPack.DisplayMember = "Nume";
            cmbAccesPack.ValueMember = "Id";

            OpenBin();
            AfisareGrid();
        }

        private void AfisareGrid()
        {
            dgvReg.DataSource = null;
            dgvReg.DataSource = listaReg;

            Total();

        }

        private void Total()
        {
            double total = 0;
            foreach (Registration r in listaReg)
                total += (double)r;
            stripCost.Text = "Cost total: " + total;
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(tbNumeC.Text))
                    throw new ValidareEx("Introduceti nume valid");
                if (string.IsNullOrEmpty(tbPasses.Text))
                    throw new ValidareEx("Intorudceti pass valid");
                string numeC=tbNumeC.Text;
                int pass=int.Parse(tbPasses.Text);
                AccessP cmb=(AccessP)cmbAccesPack.SelectedItem;

                Registration r = new Registration(numeC, pass, cmb.Id);
                r.Pack = cmb;

                listaReg.Add(r);
                MessageBox.Show("Reg adaugat cu succes!");

                AfisareGrid();


            }catch(ValidareEx vex)
            {
                MessageBox.Show(vex.Message,"eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgvReg.CurrentRow!=null)
            {
                listaReg.RemoveAt(dgvReg.CurrentRow.Index);
                AfisareGrid();
                
            }
        }

        private void dgvReg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            Registration r = listaReg[e.RowIndex];

            tbNumeC.Text = r.CompanyName;
            tbPasses.Text=r.NoOfPasses.ToString();
            cmbAccesPack.SelectedValue = r.AccessId;

        }

        private void SalvareBin()
        {
            FileStream fs=new FileStream("bin.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, listaReg);
            fs.Close();
            MessageBox.Show("Serializare realizata cu succes!");
        }

        private void OpenBin()
        {
            if (!File.Exists("bin.dat")) return;
            FileStream fs=new FileStream("bin.dat",FileMode.Open,FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<Registration> lR=(List<Registration>)bf.Deserialize(fs);
            listaReg = lR;
            fs.Close();
            

            foreach (Registration r in listaReg)
            {
                r.Pack = listaPack.First(p => p.Id == r.AccessId);
            }
            AfisareGrid();

            MessageBox.Show("Deserializare realizata cu succes!");
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvareBin();
        }

        private void sortareNumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaReg.Sort(new CompNume());
            AfisareGrid();
        }

        private void sortarePackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaReg.Sort(new CompPack());
            AfisareGrid();
        }
    }
}
