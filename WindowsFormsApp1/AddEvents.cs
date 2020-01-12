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
    public partial class AddEvents : Form
    {
        Query Controller;
        public AddEvents()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dataGridView1.DataSource = Controller.UpdateМероприятия();
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
                Controller.AddEvents(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Данные о мероприятиях были успешно внесены. \rВы можете закрыть форму добавления данных о мероприятиях, либо продолжить внесение данных. \rДля того, чтобы очистить поля для ввода, обновить таблицу с кодами мероприятий и отсортировать её в порядке убывания нажмите «Обновить».", "Уведомление");
            }
        }

        private void AddEvents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet4.Список_мероприятий". При необходимости она может быть перемещена или удалена.
            this.список_мероприятийTableAdapter.Fill(this.база_данныхDataSet4.Список_мероприятий);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            events ev = new events();
            ev.Show();
            this.Hide();
        }
    }
}
