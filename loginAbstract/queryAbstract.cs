using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginAbstract
{
    public partial class queryAbstract : Form
    {
        public queryAbstract()
        {
            InitializeComponent();
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            this.Hide();
            newPurchaseAbstract purchase = new newPurchaseAbstract();
            purchase.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            informAbstract inform = new informAbstract();
            inform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            queryAbstract query = new queryAbstract();
            query.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            referencesAbstract references = new referencesAbstract();
            references.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAbstract login = new LoginAbstract();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void queryAbstract_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aBSTRACTDataSet.CONSULTA' Puede moverla o quitarla según sea necesario.
            this.cONSULTATableAdapter.Fill(this.aBSTRACTDataSet.CONSULTA);

        }
    }
}
