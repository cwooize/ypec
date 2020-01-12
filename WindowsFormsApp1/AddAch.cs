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
    public partial class AddAch : Form
    {
        Query Controller;
        public AddAch()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void AddAch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet2.Достижения_обучающихся". При необходимости она может быть перемещена или удалена.
            this.достижения_обучающихсяTableAdapter.Fill(this.база_данныхDataSet2.Достижения_обучающихся);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            learners lr = new learners();
            lr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dataGridView1.DataSource = Controller.UpdateДостижения();
            dataGridView1.Sort(dataGridView1.Columns["коддостиженияDataGridViewTextBoxColumn"], ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Вы оставили одно или несколько полей пустыми. Проверьте их и попробуйте ввести данные ещё раз.", "Ошибка добавления данных");
            }
            else
            {
                Controller.AddAch(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Данные о достижениях для обучающегося были успешно внесены. \rВы можете закрыть форму добавления данных о достижениях, либо продолжить внесение данных. \rДля того, чтобы очистить поля для ввода, обновить таблицу с кодами достижений и отсортировать её в порядке убывания нажмите «Обновить».", "Уведомление");
            }
        }
    }
}
