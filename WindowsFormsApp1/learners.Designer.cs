namespace WindowsFormsApp1
{
    partial class learners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(learners));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодобучающегосяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклассаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокобучающихсяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.база_данныхDataSet7 = new WindowsFormsApp1.База_данныхDataSet7();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.списокОбучающихсяДостиженияОбучающихсяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_обучающихсяTableAdapter = new WindowsFormsApp1.База_данныхDataSet7TableAdapters.Список_обучающихсяTableAdapter();
            this.достижения_обучающихсяTableAdapter = new WindowsFormsApp1.База_данныхDataSet7TableAdapters.Достижения_обучающихсяTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.списокОбучающихсяНаградыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наградыTableAdapter = new WindowsFormsApp1.База_данныхDataSet7TableAdapters.НаградыTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьОбучающегосяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоОбучающимсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.достиженияОбучающегосяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.наградыОбучающегосяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаполученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаполученияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокобучающихсяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОбучающихсяДостиженияОбучающихсяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОбучающихсяНаградыBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(431, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "СПИСОК ОБУЧАЮЩИХСЯ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "К разделам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1114, 503);
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
            this.кодобучающегосяDataGridViewTextBoxColumn,
            this.кодклассаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокобучающихсяBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1187, 275);
            this.dataGridView1.TabIndex = 8;
            // 
            // кодобучающегосяDataGridViewTextBoxColumn
            // 
            this.кодобучающегосяDataGridViewTextBoxColumn.DataPropertyName = "Код_обучающегося";
            this.кодобучающегосяDataGridViewTextBoxColumn.HeaderText = "Код_обучающегося";
            this.кодобучающегосяDataGridViewTextBoxColumn.Name = "кодобучающегосяDataGridViewTextBoxColumn";
            // 
            // кодклассаDataGridViewTextBoxColumn
            // 
            this.кодклассаDataGridViewTextBoxColumn.DataPropertyName = "Код_класса";
            this.кодклассаDataGridViewTextBoxColumn.HeaderText = "Код_класса";
            this.кодклассаDataGridViewTextBoxColumn.Name = "кодклассаDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // списокобучающихсяBindingSource
            // 
            this.списокобучающихсяBindingSource.DataMember = "Список_обучающихся";
            this.списокобучающихсяBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.база_данныхDataSet7;
            this.bindingSource1.Position = 0;
            // 
            // база_данныхDataSet7
            // 
            this.база_данныхDataSet7.DataSetName = "База_данныхDataSet7";
            this.база_данныхDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn,
            this.датаполученияDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.списокОбучающихсяДостиженияОбучающихсяBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 383);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(560, 112);
            this.dataGridView2.TabIndex = 9;
            // 
            // списокОбучающихсяДостиженияОбучающихсяBindingSource
            // 
            this.списокОбучающихсяДостиженияОбучающихсяBindingSource.DataMember = "Список обучающихсяДостижения обучающихся";
            this.списокОбучающихсяДостиженияОбучающихсяBindingSource.DataSource = this.списокобучающихсяBindingSource;
            // 
            // список_обучающихсяTableAdapter
            // 
            this.список_обучающихсяTableAdapter.ClearBeforeFill = true;
            // 
            // достижения_обучающихсяTableAdapter
            // 
            this.достижения_обучающихсяTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "ДОСТИЖЕНИЯ ОБУЧАЮЩЕГОСЯ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn1,
            this.местоDataGridViewTextBoxColumn,
            this.датаполученияDataGridViewTextBoxColumn1,
            this.примечаниеDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.списокОбучающихсяНаградыBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(597, 383);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(602, 112);
            this.dataGridView3.TabIndex = 11;
            // 
            // списокОбучающихсяНаградыBindingSource
            // 
            this.списокОбучающихсяНаградыBindingSource.DataMember = "Список обучающихсяНаграды";
            this.списокОбучающихсяНаградыBindingSource.DataSource = this.списокобучающихсяBindingSource;
            // 
            // наградыTableAdapter
            // 
            this.наградыTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(684, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "НАГРАДЫ ОБУЧАЮЩЕГОСЯ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОбучающегосяToolStripMenuItem,
            this.достиженияОбучающегосяToolStripMenuItem,
            this.наградыОбучающегосяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьОбучающегосяToolStripMenuItem
            // 
            this.добавитьОбучающегосяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.отчетПоОбучающимсяToolStripMenuItem});
            this.добавитьОбучающегосяToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.university_cap_icon_icons_com_66109;
            this.добавитьОбучающегосяToolStripMenuItem.Name = "добавитьОбучающегосяToolStripMenuItem";
            this.добавитьОбучающегосяToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.добавитьОбучающегосяToolStripMenuItem.Text = "Список обучающихся";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.checkmark_circled_icon_icons_com_50431;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // отчетПоОбучающимсяToolStripMenuItem
            // 
            this.отчетПоОбучающимсяToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.отчетПоОбучающимсяToolStripMenuItem.Name = "отчетПоОбучающимсяToolStripMenuItem";
            this.отчетПоОбучающимсяToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.отчетПоОбучающимсяToolStripMenuItem.Text = "Отчет по обучающимся";
            // 
            // достиженияОбучающегосяToolStripMenuItem
            // 
            this.достиженияОбучающегосяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.достиженияОбучающегосяToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._3069187_achivement_business_mission_winner_112709;
            this.достиженияОбучающегосяToolStripMenuItem.Name = "достиженияОбучающегосяToolStripMenuItem";
            this.достиженияОбучающегосяToolStripMenuItem.Size = new System.Drawing.Size(190, 20);
            this.достиженияОбучающегосяToolStripMenuItem.Text = "Достижения обучающегося";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.checkmark_circled_icon_icons_com_50431;
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // наградыОбучающегосяToolStripMenuItem
            // 
            this.наградыОбучающегосяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.наградыОбучающегосяToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._3069188_achivement_mission_sport_winner_112715;
            this.наградыОбучающегосяToolStripMenuItem.Name = "наградыОбучающегосяToolStripMenuItem";
            this.наградыОбучающегосяToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.наградыОбучающегосяToolStripMenuItem.Text = "Награды обучающегося";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Image = global::WindowsFormsApp1.Properties.Resources.checkmark_circled_icon_icons_com_50431;
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.добавитьToolStripMenuItem2_Click);
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.FillWeight = 167.7429F;
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // датаполученияDataGridViewTextBoxColumn
            // 
            this.датаполученияDataGridViewTextBoxColumn.DataPropertyName = "Дата_получения";
            this.датаполученияDataGridViewTextBoxColumn.FillWeight = 83.76438F;
            this.датаполученияDataGridViewTextBoxColumn.HeaderText = "Дата_получения";
            this.датаполученияDataGridViewTextBoxColumn.Name = "датаполученияDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.FillWeight = 67.27441F;
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.FillWeight = 179.4253F;
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.FillWeight = 74.22257F;
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            // 
            // датаполученияDataGridViewTextBoxColumn1
            // 
            this.датаполученияDataGridViewTextBoxColumn1.DataPropertyName = "Дата_получения";
            this.датаполученияDataGridViewTextBoxColumn1.FillWeight = 110.7094F;
            this.датаполученияDataGridViewTextBoxColumn1.HeaderText = "Дата_получения";
            this.датаполученияDataGridViewTextBoxColumn1.Name = "датаполученияDataGridViewTextBoxColumn1";
            // 
            // примечаниеDataGridViewTextBoxColumn1
            // 
            this.примечаниеDataGridViewTextBoxColumn1.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn1.FillWeight = 63.45177F;
            this.примечаниеDataGridViewTextBoxColumn1.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn1.Name = "примечаниеDataGridViewTextBoxColumn1";
            // 
            // learners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "learners";
            this.Text = "СПИСОК ОБУЧАЮЩИХСЯ";
            this.Load += new System.EventHandler(this.learners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокобучающихсяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОбучающихсяДостиженияОбучающихсяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокОбучающихсяНаградыBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private База_данныхDataSet7 база_данныхDataSet7;
        private System.Windows.Forms.BindingSource списокобучающихсяBindingSource;
        private База_данныхDataSet7TableAdapters.Список_обучающихсяTableAdapter список_обучающихсяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодобучающегосяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклассаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource списокОбучающихсяДостиженияОбучающихсяBindingSource;
        private База_данныхDataSet7TableAdapters.Достижения_обучающихсяTableAdapter достижения_обучающихсяTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource списокОбучающихсяНаградыBindingSource;
        private База_данныхDataSet7TableAdapters.НаградыTableAdapter наградыTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьОбучающегосяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem достиженияОбучающегосяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem наградыОбучающегосяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem отчетПоОбучающимсяToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаполученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаполученияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn1;
    }
}