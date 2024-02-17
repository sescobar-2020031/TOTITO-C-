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
    public partial class Player1Name : Form
    {
        public string PlayerName1 { get; private set; } = "Jugador #1";
        public Player1Name()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PlayerName1 = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
