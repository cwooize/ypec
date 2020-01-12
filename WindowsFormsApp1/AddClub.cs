using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1
{
    public partial class AddClub : Form
    {
        Query Controller;
        public AddClub()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            club cl = new club();
            cl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dataGridView1.DataSource = Controller.UpdateКС();
            dataGridView1.Sort(dataGridView1.Columns["кодксDataGridViewTextBoxColumn"], ListSortDirection.Descending);
        }

        private void AddClub_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet6.Список_кружков_секций". При необходимости она может быть перемещена или удалена.
            this.список_кружков_секцийTableAdapter.Fill(this.база_данныхDataSet6.Список_кружков_секций);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Вы оставили одно или несколько полей пустыми. Проверьте их и попробуйте ввести данные ещё раз.", "Ошибка добавления данных");
            }
            else
            {
                Controller.AddClub(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Данные о кружках и секциях были успешно внесены. \rВы можете закрыть форму добавления данных о кружках и секциях, либо продолжить внесение данных. \rДля того, чтобы очистить поля для ввода, обновить таблицу с кодами кружков, секций и отсортировать её в порядке убывания нажмите «Обновить».", "Уведомление");
            }
        }
    }
}
