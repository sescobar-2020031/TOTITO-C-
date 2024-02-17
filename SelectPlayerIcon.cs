using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TotitoSE
{
    public partial class SelectPlayerIcon : Form
    {
        public string CurrentIcon { get; private set; } = "X";
        public SelectPlayerIcon(string playerName)
        {
            InitializeComponent();
            label1.Text = "Hola, " + playerName + ", selecciona tu icono.";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CurrentIcon = button1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CurrentIcon = button2.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
