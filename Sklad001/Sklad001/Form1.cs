using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklad001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet.Dil'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.dilTableAdapter.Fill(this.database1DataSet.Dil);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
