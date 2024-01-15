using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretary
{
    public partial class received : Form
    {
        public received()
        {
            InitializeComponent();
        }

        private void received_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "secretaryDataSet1.received". При необходимости она может быть перемещена или удалена.
            this.receivedTableAdapter.Fill(this.secretaryDataSet1.received);

        }

        private void back_Click(object sender, EventArgs e)
        {
            secret Form5 = new secret(); // Создаем экземпляр формы Form5Form
            this.Hide();
            Form5.ShowDialog(); // Открываем форму Form5Form
        }

        
    }
}
