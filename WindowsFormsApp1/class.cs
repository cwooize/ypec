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
    public partial class @class : Form
    {
        Query Controller;
        public @class()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void class_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet5.Ученики". При необходимости она может быть перемещена или удалена.
            this.классыTableAdapter.Fill(this.база_данныхDataSet.Классы);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Controller.UpdateКлассы();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Вы оставили одно или несколько полей пустыми. Проверьте их и попробуйте ввести данные ещё раз.", "Ошибка добавления данных");
            }
            else
            {
                Controller.Addclass(textBox1.Text, textBox2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                классыBindingSource.Filter = "[Код_класса] LIKE '" + textBox3.Text + "*'";
            else
                классыBindingSource.Filter = null;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
