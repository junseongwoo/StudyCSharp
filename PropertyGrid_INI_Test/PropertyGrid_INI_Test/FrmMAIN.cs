using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGrid_INI_Test
{
    public partial class FrmMAIN : Form
    {
        public FrmpGridINI frmpGridINI = null;

        public FrmMAIN()
        {
            InitializeComponent();

            frmpGridINI = new FrmpGridINI();

            frmpGridINI.Owner = this;
        }

        private void FrmMAIN_Load(object sender, EventArgs e)
        {

            frmpGridINI.TopLevel = false;

            this.Controls.Add(frmpGridINI);

            frmpGridINI.StartPosition = FormStartPosition.Manual;
            frmpGridINI.Location = new Point(15, 60);
        }

        private void Btn_pGridForm_Click(object sender, EventArgs e)
        {
            frmpGridINI.Show();
        }


    }
}
