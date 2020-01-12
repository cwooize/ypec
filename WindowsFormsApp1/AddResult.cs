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
    public partial class AddResult : Form
    {
        Query Controller;
        public AddResult()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            events ev = new events();
            ev.Show();
            this.Hide();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet5.Список_мероприятий". При необходимости она может быть перемещена или удалена.
            this.список_мероприятийTableAdapter.Fill(this.база_данныхDataSet5.Список_мероприятий);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dataGridView1.DataSource = Controller.UpdateРезультаты();
            dataGridView1.Sort(dataGridView1.Columns["кодмероприятияDataGridViewTextBoxColumn"], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Вы оставили одно или несколько полей пустыми. Проверьте их и попробуйте ввести данные ещё раз.", "Ошибка добавления данных");
            }
            else
            {
                Controller.AddResult(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                MessageBox.Show("Данные о результатах мероприятий были успешно внесены. \rВы можете закрыть форму добавления данных о результатах мероприятий, либо продолжить внесение данных. \rДля того, чтобы очистить поля для ввода, обновить таблицу с кодами мероприятий и отсортировать её в порядке убывания нажмите «Обновить».", "Уведомление");
            }
        }
    }
}
