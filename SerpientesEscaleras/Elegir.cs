using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerpientesEscaleras
{
    public partial class Elegir : Form
    {
        public Elegir()
        {
            InitializeComponent();
        }
        
        public int cuantos()
        {
            return Convert.ToInt32(txtCuantos.Text);
        }

        private void Elegir_Load(object sender, EventArgs e)
        {

        }
    }
}
