using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace secretary
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void incorectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incorectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.secretaryDataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "secretaryDataSet1.incorect". При необходимости она может быть перемещена или удалена.
            this.incorectTableAdapter.Fill(this.secretaryDataSet1.incorect);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            incorectBindingSource.EndEdit();
            incorectTableAdapter.Update(secretaryDataSet1.incorect);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rating rating = new rating();
            this.Hide();
            rating.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            received received = new received();
            this.Hide();
            received.ShowDialog();
        }
    }
}
