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
    public partial class club : Form
    {
        public club()
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

        private void club_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данныхDataSet24.Список_кружков_секций". При необходимости она может быть перемещена или удалена.
            this.список_кружков_секцийTableAdapter.Fill(this.база_данныхDataSet24.Список_кружков_секций);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClub ac = new AddClub();
            ac.Show();
            this.Hide();
        }
    }
}
