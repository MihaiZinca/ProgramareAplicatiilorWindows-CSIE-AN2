using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RezervareHotel
{
    public partial class FormHotel : Form
    {
        List<Rezervare> listaRezervari=new List<Rezervare>();
        List<Hotel> listaHoteluri=new List<Hotel>();
        public FormHotel()
        {
            InitializeComponent();

            listaRezervari.Add(new Rezervare(1, "Ana", 'S', 3, 300, "01.01.2025"));
            listaRezervari.Add(new Rezervare(2, "Ion", 'D', 2, 500, "02.01.2025"));
            listaRezervari.Add(new Rezervare(3, "Maria", 'S', 1, 150, "03.01.2025"));
            listaRezervari.Add(new Rezervare(4, "Paul", 'D', 5, 1000, "04.01.2025"));
            listaRezervari.Add(new Rezervare(5, "Elena", 'S', 2, 250, "05.01.2025"));

            lbRezevari.DataSource = listaRezervari;
        }

        public List<Hotel> ListaHoteluri { get => listaHoteluri; }

        private void btnCreareHotel_Click(object sender, EventArgs e)
        {
            try
            {
                string locatie=tbLocatie.Text;
                int nrStele=int.Parse(tbNrStele.Text);
                
                List<Rezervare> selectate=new List<Rezervare>();
                foreach(Rezervare r in lbRezevari.SelectedItems)
                    selectate.Add(r);

                Hotel h=new Hotel(locatie, nrStele, selectate);
                listaHoteluri.Add(h);

                MessageBox.Show("Hotel creat!");

            }catch(ValidareEx vex)
            {
                MessageBox.Show(vex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                tbLocatie.Clear();
                tbNrStele.Clear();
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
