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
namespace app_elem
{
    public partial class Form1 : Form
    {
        Element obel;
        public Form1()
        {
            InitializeComponent();
            obel = new Element();
            obel.Ev_Mod_Valoare += Obel_Ev_Mod_Valoare;
        }

        private void Obel_Ev_Mod_Valoare(Element obj)
        {
            pel.Text = obj.Patrat.ToString();
            //construiesc sirul
            string s = $" {obj.Valoare,6} | {obj.Patrat,8}|";//obj.valoare,6 -retine val in 6 caractere
            lb.Items.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                obel.Valoare = int.Parse(el.Text);
                lb.SelectedIndex = -1;//schimba starea valoarea si ridica evenimentul
                err.SetError(el, null);
            }
            catch(FormatException ex)
            {
                err.SetError(el, "Trebuie numar!!");
                //MessageBox.Show(ex.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            el.Text = obel.Valoare.ToString();
            pel.Text = obel.Patrat.ToString();
        }

        private void el_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evenimentul keypress Retunr=Enter , adica verifica cand apesi enter
            if (e.KeyChar == (char)Keys.Return);//in momentul in care s-a apasat return incepe sa faca ceva
            {
                button1_Click(null, null);
                el.SelectAll();
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb.SelectedIndex!=-1)
            {
                string sel = lb.SelectedItem as string; //pt conversie echivalent ca (cast)
                el.Text = (sel.Split('|')[0]).Trim(); //vreau element[0] nu patratul
            }
            
        }
    }
}
