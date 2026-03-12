using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//font Consolas are aceiasi matrice de pixeli.. sa putem sa asezam textul frumos aliniat
namespace Curs4
{
    public partial class Form1 : Form
    {
        Element obel;
        public Form1()
        {
            InitializeComponent();
            obel = new Element();
            obel.eveniment_modificare_valoare += Obel_eveniment_modificare_valoare;
        }

        private void Obel_eveniment_modificare_valoare(Element obj)
        {
            pel.Text=obj.Patrat.ToString();
            //construiesc sirul
            string s = $"{obj.Valoare,6} | {obj.Patrat,8}|"; //obj.valoare,6 -retine val in 6 caractere
            lb.Items.Add(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            el.Text=obel.Valoare.ToString();
            pel.Text=obel.Patrat.ToString();
        }

        private void el_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                obel.Valoare = int.Parse(el.Text); //schimba starea valoarea si ridica evenimentul
                lb.SelectedIndex = -1;
           


        }

        private void el_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evenimentul keypress Retunr=Enter , adica verifica cand apesi enter
            if (e.KeyChar == (char)Keys.Return)//in momentul in care s-a apasat return incepe sa faca ceva
            {
                button1_Click(null, null);
                el.SelectAll();
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb.SelectedIndex != -1)
            {
                string sel = lb.SelectedItem as string; //pt conversie echivalent ca (cast)
                el.Text = sel.Split('|')[0].Trim();//vreau element[0] nu patratul
            }
        }
    }
}
