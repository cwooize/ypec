namespace WindowsFormsApp1
{
    partial class events
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(events));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодмероприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типмероприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокмероприятийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.база_данныхDataSet18 = new WindowsFormsApp1.База_данныхDataSet18();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокмероприятийРезультатымероприятийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_мероприятийTableAdapter = new WindowsFormsApp1.База_данныхDataSet18TableAdapters.Список_мероприятийTableAdapter();
            this.результаты_мероприятийTableAdapter = new WindowsFormsApp1.База_данныхDataSet18TableAdapters.Результаты_мероприятийTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокМероприятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоМероприятиямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыМероприятийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокмероприятийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокмероприятийРезультатымероприятийBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(23, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "К разделам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "СПИСОК МЕРОПРИЯТИЙ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(830, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмероприятияDataGridViewTextBoxColumn,
            this.типмероприятияDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.датапроведенияDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокмероприятийBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 253);
            this.dataGridView1.TabIndex = 7;
            // 
            // кодмероприятияDataGridViewTextBoxColumn
            // 
            this.кодмероприятияDataGridViewTextBoxColumn.DataPropertyName = "Код_мероприятия";
            this.кодмероприятияDataGridViewTextBoxColumn.HeaderText = "Код_мероприятия";
            this.кодмероприятияDataGridViewTextBoxColumn.Name = "кодмероприятияDataGridViewTextBoxColumn";
            // 
            // типмероприятияDataGridViewTextBoxColumn
            // 
            this.типмероприятияDataGridViewTextBoxColumn.DataPropertyName = "Тип_мероприятия";
            this.типмероприятияDataGridViewTextBoxColumn.HeaderText = "Тип_мероприятия";
            this.типмероприятияDataGridViewTextBoxColumn.Name = "типмероприятияDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // датапроведенияDataGridViewTextBoxColumn
            // 
            this.датапроведенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_проведения";
            this.датапроведенияDataGridViewTextBoxColumn.HeaderText = "Дата_проведения";
            this.датапроведенияDataGridViewTextBoxColumn.Name = "датапроведенияDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // списокмероприятийBindingSource
            // 
            this.списокмероприятийBindingSource.DataMember = "Список_мероприятий";
            this.списокмероприятийBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.база_данныхDataSet18;
            this.bindingSource1.Position = 0;
            // 
            // база_данныхDataSet18
            // 
            this.база_данныхDataSet18.DataSetName = "База_данныхDataSet18";
            this.база_данныхDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.местоDataGridViewTextBoxColumn,
            this.местоDataGridViewTextBoxColumn1,
            this.местоDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.списокмероприятийРезультатымероприятийBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(892, 52);
            this.dataGridView2.TabIndex = 8;
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "1 место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "1 место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            // 
            // местоDataGridViewTextBoxColumn1
            // 
            this.местоDataGridViewTextBoxColumn1.DataPropertyName = "2 место";
            this.местоDataGridViewTextBoxColumn1.HeaderText = "2 место";
            this.местоDataGridViewTextBoxColumn1.Name = "местоDataGridViewTextBoxColumn1";
            // 
            // местоDataGridViewTextBoxColumn2
            // 
            this.местоDataGridViewTextBoxColumn2.DataPropertyName = "3 место";
            this.местоDataGridViewTextBoxColumn2.HeaderText = "3 место";
            this.местоDataGridViewTextBoxColumn2.Name = "местоDataGridViewTextBoxColumn2";
            // 
            // списокмероприятийРезультатымероприятийBindingSource
            // 
            this.списокмероприятийРезультатымероприятийBindingSource.DataMember = "Список_мероприятийРезультаты_мероприятий";
            this.списокмероприятийРезультатымероприятийBindingSource.DataSource = this.списокмероприятийBindingSource;
            // 
            // список_мероприятийTableAdapter
            // 
            this.список_мероприятийTableAdapter.ClearBeforeFill = true;
            // 
            // результаты_мероприятийTableAdapter
            // 
            this.результаты_мероприятийTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(248, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "РЕЗУЛЬТАТЫ МЕРОПРИЯТИЯ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокМероприятийToolStripMenuItem,
            this.результатыМероприятийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокМероприятийToolStripMenuItem
            // 
            this.списокМероприятийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.отчетПоМероприятиямToolStripMenuItem});
            this.списокМероприятийToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._3069187_achivement_business_mission_winner_112709;
            this.списокМероприятийToolStripMenuItem.Name = "списокМероприятийToolStripMenuItem";
            this.списокМероприятийToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.списокМероприятийToolStripMenuItem.Text = "Список мероприятий";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.checkmark_circled_icon_icons_com_50431;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // отчетПоМероприятиямToolStripMenuItem
            // 
            this.отчетПоМероприятиямToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.отчетПоМероприятиямToolStripMenuItem.Name = "отчетПоМероприятиямToolStripMenuItem";
            this.отчетПоМероприятиямToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.отчетПоМероприятиямToolStripMenuItem.Text = "Отчет по мероприятиям";
            // 
            // результатыМероприятийToolStripMenuItem
            // 
            this.результатыМероприятийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.результатыМероприятийToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._3069188_achivement_mission_sport_winner_112715;
            this.результатыМероприятийToolStripMenuItem.Name = "результатыМероприятийToolStripMenuItem";
            this.результатыМероприятийToolStripMenuItem.Size = new System.Drawing.Size(174, 20);
            this.результатыМероприятийToolStripMenuItem.Text = "Результаты мероприятия";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.checkmark_circled_icon_icons_com_50431;
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "events";
            this.Text = "СПИСОК МЕРОПРИЯТИЙ";
            this.Load += new System.EventHandler(this.events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокмероприятийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокмероприятийРезультатымероприятийBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private База_данныхDataSet18 база_данныхDataSet18;
        private System.Windows.Forms.BindingSource списокмероприятийBindingSource;
        private База_данныхDataSet18TableAdapters.Список_мероприятийTableAdapter список_мероприятийTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмероприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типмероприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource списокмероприятийРезультатымероприятийBindingSource;
        private База_данныхDataSet18TableAdapters.Результаты_мероприятийTableAdapter результаты_мероприятийTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокМероприятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыМероприятийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоМероприятиямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
    }
}