using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubTranzactie
{
    public partial class FormExtras : System.Windows.Forms.Form
    {
        List<Tranzactie> listaTranzactii=new List<Tranzactie>();
        List<ExtrasCont> listaExtrase=new List<ExtrasCont>();
        public FormExtras()
        {
            InitializeComponent();
            incarcareDate();
            cmbTranzactie.DataSource = listaTranzactii;
        }
        public List<ExtrasCont> ListaExtrase { get => listaExtrase; }

        public void incarcareDate()
        {
            StreamReader sr = new StreamReader("Tranzactii.txt");
            string line;
            while( (line=sr.ReadLine())!=null)
            {
                try
                {
                    int idTranzactie = int.Parse(line.Split(',')[0]);
                    string iban = line.Split(',')[1];
                    string detalii = line.Split(',')[2];
                    double suma=double.Parse(line.Split(',')[3]);
                    string dataTranzactie = line.Split(',')[4];

                    Tranzactie t=new Tranzactie(idTranzactie,iban,detalii, suma,dataTranzactie);
                    listaTranzactii.Add(t);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                
                string numeClient = tbNume.Text;
                if (string.IsNullOrWhiteSpace(numeClient))
                    throw new Exception("Numele este obligatoriu");
                string adresa = tbAdresa.Text;
                if (string.IsNullOrWhiteSpace(adresa))
                    throw new Exception("Adresa este obligatorie");

                List<Tranzactie> select=new List<Tranzactie>(); 
                select.Add((Tranzactie)cmbTranzactie.SelectedItem);

                ExtrasCont ec=new ExtrasCont(numeClient, adresa,select);
                listaExtrase.Add(ec);

            }
            catch(ValidareEx vex)
            {
                MessageBox.Show(vex.Message, "Erorare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbNume.Clear();
                tbAdresa.Clear();
            }

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
