using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotitoSE
{
    public partial class Player2Name : Form
    {
        public string PlayerName2 { get; private set; } = "Jugador #2";
        public Player2Name()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            PlayerName2 = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
