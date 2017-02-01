using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void Bproxina_Click(object sender, EventArgs e)
        {
            if (RB4.Checked == true)
                MessageBox.Show("Errou", "É o contrario");
            else
                MessageBox.Show("Errou");

        }
    }
}
