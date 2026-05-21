using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs13_Drag_Drop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(tb.Text, DragDropEffects.Move);

        }

        private void lb_DragEnter(object sender, DragEventArgs e)
        {
            //data seminifica data care se afla in procesul de drag and drop
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;

        }

        private void lb_DragDrop(object sender, DragEventArgs e)
        {
            lb.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
            tb.Text = string.Empty;
            tb.Select();
        }
    }
}
