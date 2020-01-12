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
    public partial class AddLearners : Form
    {
        Query Controller;
        public AddLearners()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            learners lr = new learners();
            lr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Вы оставили одно или несколько полей пустыми. Проверьте их и попробуйте ввести данные ещё раз.", "Ошибка добавления данных");
            }
            else
            {
                Controller.AddLearners(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                MessageBox.Show("Данные об обучающемся были успешно внесены. \rВы можете закрыть форму добавления данных об обучающихся, либо продолжить внесение данных.", "Уведомление");
            }
            }

        private void AddLearners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet3.Список_обучающихся". При необходимости она может быть перемещена или удалена.
            this.список_обучающихсяTableAdapter.Fill(this.база_данныхDataSet3.Список_обучающихся);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
                списокобучающихсяBindingSource.Filter = "[Код_обучающегося] LIKE '" + textBox8.Text + "*'";
            else
                списокобучающихсяBindingSource.Filter = null;
        }
    }
}
