using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace secretary
{
    public partial class rating : Form
    {
        private BindingSource bindingSource;

        public rating()
        {
            InitializeComponent();
            this.Load += rating_Load;
        }

        private void rating_Load(object sender, EventArgs e)
        {
            // Загрузка данных
            this.incorectTableAdapter.Fill(this.secretaryDataSet1.incorect);

            // Инициализация BindingSource
            bindingSource = new BindingSource();
            bindingSource.DataSource = this.secretaryDataSet1.incorect;

            // Указываем столбец, по которому будет происходить сортировка
            int columnIndex = 7;

            // Указываем тип сортировки (по убыванию)
            ListSortDirection sortDirection = ListSortDirection.Descending;

            // Вызываем метод сортировки
            incorectDataGridView.Sort(incorectDataGridView.Columns[columnIndex], sortDirection);

            // Заполняем выпадающие списки
            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            // Заполняем выпадающие списки уникальными значениями из столбцов
            FillComboBox(comboBoxSpecialization1, "specialization_1");
            FillComboBox(comboBoxSpecialization2, "specialization_2");
            FillComboBox(comboBoxSpecialization3, "specialization_3");
        }

        private void FillComboBox(ComboBox comboBox, string columnName)
        {
            // Получаем DataView из BindingSource
            DataView dataView = (DataView)bindingSource.List;

            // Получаем уникальные значения из столбца
            DataTable distinctValues = dataView.ToTable(true, columnName);

            // Заполняем выпадающий список уникальными значениями
            comboBox.DataSource = distinctValues;
            comboBox.DisplayMember = columnName;
            comboBox.SelectedIndex = -1; // Очищаем выбор
        }

        private void ApplyFilter()
        {
            // Строка фильтрации
            string filter = $"specialization_1 = '{comboBoxSpecialization1.Text}' AND " +
                            $"specialization_2 = '{comboBoxSpecialization2.Text}' AND " +
                            $"specialization_3 = '{comboBoxSpecialization3.Text}'";

            // Применяем фильтр к BindingSource
            bindingSource.Filter = filter;

            // Обновляем отображение данных в DataGridView
            incorectDataGridView.DataSource = bindingSource;
        }

        private void comboBoxSpecialization1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void comboBoxSpecialization2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void comboBoxSpecialization3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void back_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            this.Hide();
            admin.ShowDialog();
        }
    }
}
