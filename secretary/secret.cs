using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace secretary
{
    public partial class secret : Form
    {
        public secret()
        {
            InitializeComponent();
        }

        private void incorectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incorectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.secretaryDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "secretaryDataSet1.incorect". При необходимости она может быть перемещена или удалена.
            this.incorectTableAdapter.Fill(this.secretaryDataSet1.incorect);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            incorectBindingSource.AddNew();
            passportTextBox.BackColor = Color.Aqua;
            fIOTextBox.BackColor = Color.Aqua;
            iNNTextBox.BackColor = Color.Aqua;
            snilsTextBox.BackColor = Color.Aqua;
            fIO_momTextBox.BackColor = Color.Aqua;
            fIO_dedTextBox.BackColor = Color.Aqua;
            scoreTextBox.BackColor = Color.Aqua;
            noteTextBox.BackColor = Color.Aqua;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем текущую редактируемую строку
                DataRowView currentRow = (DataRowView)incorectBindingSource.Current;

                currentRow["fIO"] = fIOTextBox.Text;
                currentRow["date_creation"] = date_creationDateTimePicker.Text;
                currentRow["application_status"] = comboBox1.Text;
                currentRow["passport"] = passportTextBox.Text;
                currentRow["FIO_mom"] = fIO_momTextBox.Text;
                currentRow["FIO_ded"] = fIO_dedTextBox.Text;
                currentRow["INN"] = iNNTextBox.Text;
                currentRow["snils"] = snilsTextBox.Text;
                currentRow["score"] = scoreTextBox.Text;
                currentRow["photo_certificate"] = photo_certificateTextBox.Text;
                currentRow["photo"] = photoTextBox.Text;
                currentRow["specialization_1"] = specialization_1TextBox.Text;
                currentRow["specialization_2"] = specialization_1TextBox.Text;
                currentRow["specialization_3"] = specialization_1TextBox.Text;
                currentRow["note"] = noteTextBox.Text;


                // Сохраняем изменения в базе данных
                incorectTableAdapter.Update(secretaryDataSet1.incorect);

                MessageBox.Show("Данные успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void received_Click(object sender, EventArgs e)
        {

            received received = new received(); 
            this.Hide();
            received.ShowDialog(); 
        }

        
    }
}
