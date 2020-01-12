using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
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

        private void events_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet18.Результаты_мероприятий". При необходимости она может быть перемещена или удалена.
            this.результаты_мероприятийTableAdapter.Fill(this.база_данныхDataSet18.Результаты_мероприятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet18.Список_мероприятий". При необходимости она может быть перемещена или удалена.
            this.список_мероприятийTableAdapter.Fill(this.база_данныхDataSet18.Список_мероприятий);
          
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvents ae = new AddEvents();
            ae.Show();
            this.Hide();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddResult ar = new AddResult();
            ar.Show();
            this.Hide();
        }
    }
}
