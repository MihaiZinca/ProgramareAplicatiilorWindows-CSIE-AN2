using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditareImagini
{
    public partial class FromPoligon : Form
    {
        Poligon poligonCurent;
        public FromPoligon()
        {
            InitializeComponent();
        }

        public Poligon PoligonCreat { get => poligonCurent; }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbX.Text))
                    throw new ValidareEx("X nu este introdus");
                if (string.IsNullOrEmpty(tbY.Text))
                    throw new ValidareEx("Y nu este introdus");
                int x=int.Parse(tbX.Text);
                int y=int.Parse(tbY.Text);

                if (x < 0 || y < 0)
                    throw new ValidareEx("Coordonatele trebuie sa fie pozitive!");

                if (string.IsNullOrEmpty(tbCuloare.Text))
                    throw new ValidareEx("Culoare nu este introdusa");
                if(string.IsNullOrEmpty(tbGrosime.Text))
                        throw new ValidareEx("Grosimea nu este introdusa");
                if (string.IsNullOrEmpty(tbCodF.Text))
                    throw new ValidareEx("CodF nu este introdusa");
                if (string.IsNullOrEmpty(tbEticheta.Text))
                    throw new ValidareEx("Eticheta nu este introdusa");

                string culoare = tbCuloare.Text;
                int grosime = int.Parse(tbGrosime.Text);
                int cod=int.Parse(tbCodF.Text);
                string eticheta=tbEticheta.Text;

                if (poligonCurent == null)
                {
                    poligonCurent = new Poligon(culoare, grosime, cod, eticheta);
                    tbCuloare.Enabled = false;
                    tbEticheta.Enabled = false;
                    tbGrosime.Enabled = false;
                    tbCodF.Enabled = false;
                }

                Punct pct = new Punct(x, y);
                poligonCurent.AdaugaPunct(pct);
                MessageBox.Show("Adaugare cu succes!");
            }
            catch(ValidareEx vex)
            {
                MessageBox.Show(vex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tbX.Clear();
                tbY.Clear();
                
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {

            if (poligonCurent == null || poligonCurent.Puncte.Count < 3)
            {
                MessageBox.Show("Poligon invalid (minim 3 puncte)");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
