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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();

            // Iniciar el temporizador
            timer1.Start();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            // Cerrar automáticamente el formulario después de 3 segundos
            Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario cuando el usuario haga clic en el botón de cerrar
            Close();
        }
    }
}
