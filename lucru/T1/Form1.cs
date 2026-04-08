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

namespace T1
{
    public partial class Form1 : Form
    {
        List<FisaPacient> listaFisePacienti= new List<FisaPacient>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaMedicament_Click(object sender, EventArgs e)
        {
            FormMedicamente fm=new FormMedicamente();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(tbNume.Text))
                        throw new Exception("Nume gol");
                    if (string.IsNullOrWhiteSpace(tbDurataTr.Text))
                        throw new Exception("DurataTratament goala");
                    string nume = tbNume.Text;
                    string simptome = cmbSimptome.SelectedItem.ToString();
                    int durataTratament = Convert.ToInt32(tbDurataTr.Text);

                    List<Medicament> medicamente = new List<Medicament>();
                    foreach (Medicament m in fm.ListaMedicamente)
                        medicamente.Add(m);

                    FisaPacient fisaPacient = new FisaPacient(nume, simptome, durataTratament, medicamente);
                    listaFisePacienti.Add(fisaPacient);
                    lbFisaPacient.Items.Add(fisaPacient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void racealaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<FisaPacient> listaRaceala=new List<FisaPacient>();
            foreach (FisaPacient f in listaFisePacienti)
            {
                if(f.Simptome=="Raceala")
                         listaRaceala.Add(f);
            }
           
           lbFisaPacient.Items.Clear();
            foreach (FisaPacient el in listaRaceala)
                lbFisaPacient.Items.Add(el);
        }

        private void febraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<FisaPacient>listaFebra=new List<FisaPacient>();
            foreach(FisaPacient f in listaFisePacienti)
                if(f.Simptome=="Febra")
                    listaFebra.Add(f);
            lbFisaPacient.Items.Clear();
            foreach (FisaPacient el in listaFebra)
                lbFisaPacient.Items.Add(el);
        }

        private void greataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<FisaPacient> listaGreata = new List<FisaPacient>();
            foreach (FisaPacient f in listaFisePacienti)
                if (f.Simptome == "Greata")
                    listaGreata.Add(f);
            lbFisaPacient.Items.Clear();
            foreach (FisaPacient el in listaGreata)
                lbFisaPacient.Items.Add(el);
        }

        private void toateSimpomeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<FisaPacient> listaTotala=new List<FisaPacient>();
            foreach (FisaPacient f in listaFisePacienti)
                listaTotala.Add(f);
            lbFisaPacient.Items.Clear(); 

            foreach (FisaPacient el in listaTotala)
                lbFisaPacient.Items.Add(el);
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileStream fs=new FileStream("fis.dat",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(fs, listaFisePacienti);
            fs.Close();
            MessageBox.Show("Serializare realizata cu succes!");
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs=new FileStream("fis.dat",FileMode.Open,FileAccess.Read);
            BinaryFormatter bf=new BinaryFormatter();
            List<FisaPacient> listFs=(List < FisaPacient >)bf.Deserialize(fs);
            foreach(FisaPacient f in listFs)
            {
                ListViewItem itm=new ListViewItem(f.Nume);
                itm.SubItems.Add(f.Durata_tratament.ToString());
                itm.SubItems.Add(f.Simptome.ToString());
                itm.SubItems.Add(f.CalculPretTratament().ToString()); 
                lvF.Items.Add(itm);
            }
            fs.Close();
            MessageBox.Show("Fisier restaurat cu succes!");

        }
    }
}
