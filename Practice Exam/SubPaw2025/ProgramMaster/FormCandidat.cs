using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMaster
{
    public partial class FormCandidat : Form
    {
        Candidat candidat=new Candidat();
        public FormCandidat()
        {
            InitializeComponent();
            candidat = new Candidat();
        }

        public FormCandidat(Candidat c)
        {
            InitializeComponent();
            candidat = c;

            tbCod.Text = c.CodCandidat.ToString();
            tbNume.Text = c.NumeCandidat;
            tbMedie.Text = c.MedieConcurs.ToString();
            tbOptiuni.Text = string.Join(";", c.VectorOptiuni);
        }

        public Candidat CandidatNou { get => candidat; }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {

            try
            {
                errorProvider1.Clear();
                bool valid = true;

                if (string.IsNullOrWhiteSpace(tbCod.Text))
                {
                    errorProvider1.SetError(tbCod, "Intorudceti cod valid");
                    valid = false;
                }

                if (string.IsNullOrWhiteSpace(tbNume.Text))
                {
                    errorProvider1.SetError(tbNume, "Intorudceti nume valid");
                    valid = false;
                }

                if (string.IsNullOrWhiteSpace(tbMedie.Text))
                {
                    errorProvider1.SetError(tbMedie, "Intorudceti medie valid");
                    valid = false;
                }

                if (string.IsNullOrWhiteSpace(tbOptiuni.Text))
                {
                    errorProvider1.SetError(tbOptiuni, "Intorudceti optiuni valid");
                    valid = false;
                }

                if (valid)
                {

                    candidat.CodCandidat = int.Parse(tbCod.Text);
                    candidat.NumeCandidat = tbNume.Text;
                    candidat.MedieConcurs = float.Parse(tbMedie.Text);
                    string[] optString = tbOptiuni.Text.Split(';');
                    int[] optInt = new int[optString.Length];
                    for (int i = 0; i < optString.Length; i++)
                        optInt[i] = int.Parse(optString[i].Trim());
                    candidat.VectorOptiuni = optInt;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

       
    }
}
