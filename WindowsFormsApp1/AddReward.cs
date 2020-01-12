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
    public partial class AddReward : Form
    {
        Query Controller;
        public AddReward()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void AddReward_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet1.Награды". При необходимости она может быть перемещена или удалена.
            this.наградыTableAdapter.Fill(this.база_данныхDataSet1.Награды);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            learners lr = new learners();
            lr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Вы оставили одно или несколько полей пустыми. Проверьте их и попробуйте ввести данные ещё раз.", "Ошибка добавления данных");
            }
            else
            {
                Controller.AddReward(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                MessageBox.Show("Данные о наградах для обучающегося были успешно внесены. \rВы можете закрыть форму добавления данных о наградах, либо продолжить внесение данных. \rДля того, чтобы очистить поля для ввода, обновить таблицу с кодами наград и отсортировать её в порядке убывания нажмите «Обновить».", "Уведомление");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            dataGridView1.DataSource = Controller.UpdateНаграды();
            dataGridView1.Sort(dataGridView1.Columns["коднаградыDataGridViewTextBoxColumn"], ListSortDirection.Descending);
        }
    }
}
