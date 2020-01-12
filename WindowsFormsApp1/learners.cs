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
    public partial class learners : Form
    {
        Query Controller;
        public learners()
        {
            InitializeComponent();
            Controller = new Query(ConnectionString.ConnStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.Show();
            this.Hide();
        }

        private void learners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet7.Награды". При необходимости она может быть перемещена или удалена.
            this.наградыTableAdapter.Fill(this.база_данныхDataSet7.Награды);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet7.Достижения_обучающихся". При необходимости она может быть перемещена или удалена.
            this.достижения_обучающихсяTableAdapter.Fill(this.база_данныхDataSet7.Достижения_обучающихся);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet7.Список_обучающихся". При необходимости она может быть перемещена или удалена.
            this.список_обучающихсяTableAdapter.Fill(this.база_данныхDataSet7.Список_обучающихся);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLearners lr = new AddLearners();
            lr.Show();
            this.Hide();
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddReward rw = new AddReward();
            rw.Show();
            this.Hide();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAch aach = new AddAch();
            aach.Show();
            this.Hide();
        }
    }
}
