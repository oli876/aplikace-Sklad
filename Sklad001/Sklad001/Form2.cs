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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'database1DataSet1.Dodavatel'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.dodavatelTableAdapter.Fill(this.database1DataSet1.Dodavatel);

        }
    }
}
