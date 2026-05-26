using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar14_UserControl
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        public Tara SelectedTara
        {
            get
            {
                return (Tara)cbTara.SelectedItem;
            }
        }


        //public TaraEnum SelectedTaraEnum
        //{
        //    get
        //    {
        //        return (TaraEnum)cbTara.SelectedItem;
        //    }
        //}

        private void UserControl1_Load(object sender, EventArgs e)
        {
            List<Tara> listaTari=new List<Tara>();
            listaTari.Add(new Tara() { ID = 1, Nume = "Romania" });
            listaTari.Add(new Tara() { ID = 2, Nume = "Germania" });
            listaTari.Add(new Tara() { ID = 3, Nume = "Italia" });


            cbTara.DataSource = listaTari;
            cbTara.ValueMember = "ID";
            cbTara.DisplayMember = "Nume";

            //alternativa dea folosi enum in loc de o clasa Tara
            //List<TaraEnum> listaTariE=Enum.GetValues(typeof(TaraEnum)).Cast<TaraEnum>().ToList();
            //cbTara.DataSource=listaTariE
        }
    }

    public class Tara
    {
        public int ID { get; set; }
        public string Nume { get; set; }
    }

    //public enum TaraEnum
    //{
    //    Romania=1,
    //    Germania=2,
    //    Italia=3,
    //    Anglia=4
    //}
}
