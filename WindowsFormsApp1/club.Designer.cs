namespace WindowsFormsApp1
{
    partial class club
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(club));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодКСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеДеятельностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.руководительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дниНеделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списоккружковсекцийBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.база_данныхDataSet24 = new WindowsFormsApp1.База_данныхDataSet24();
            this.button2 = new System.Windows.Forms.Button();
            this.список_кружков_секцийTableAdapter = new WindowsFormsApp1.База_данныхDataSet24TableAdapters.Список_кружков_секцийTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.списокКружковСекцийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоКружкамСекциямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списоккружковсекцийBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet24)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "СПИСОК КРУЖКОВ, СЕКЦИЙ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1012, 233);
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
            this.кодКСDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.направлениеДеятельностиDataGridViewTextBoxColumn,
            this.руководительDataGridViewTextBoxColumn,
            this.дниНеделиDataGridViewTextBoxColumn,
            this.времяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списоккружковсекцийBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1074, 168);
            this.dataGridView1.TabIndex = 7;
            // 
            // кодКСDataGridViewTextBoxColumn
            // 
            this.кодКСDataGridViewTextBoxColumn.DataPropertyName = "Код_КС";
            this.кодКСDataGridViewTextBoxColumn.FillWeight = 67.43951F;
            this.кодКСDataGridViewTextBoxColumn.HeaderText = "Код_КС";
            this.кодКСDataGridViewTextBoxColumn.Name = "кодКСDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.FillWeight = 102.3075F;
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // направлениеДеятельностиDataGridViewTextBoxColumn
            // 
            this.направлениеДеятельностиDataGridViewTextBoxColumn.DataPropertyName = "Направление деятельности";
            this.направлениеДеятельностиDataGridViewTextBoxColumn.FillWeight = 103.6619F;
            this.направлениеДеятельностиDataGridViewTextBoxColumn.HeaderText = "Направление деятельности";
            this.направлениеДеятельностиDataGridViewTextBoxColumn.Name = "направлениеДеятельностиDataGridViewTextBoxColumn";
            // 
            // руководительDataGridViewTextBoxColumn
            // 
            this.руководительDataGridViewTextBoxColumn.DataPropertyName = "Руководитель";
            this.руководительDataGridViewTextBoxColumn.FillWeight = 137.0558F;
            this.руководительDataGridViewTextBoxColumn.HeaderText = "Руководитель";
            this.руководительDataGridViewTextBoxColumn.Name = "руководительDataGridViewTextBoxColumn";
            // 
            // дниНеделиDataGridViewTextBoxColumn
            // 
            this.дниНеделиDataGridViewTextBoxColumn.DataPropertyName = "Дни недели";
            this.дниНеделиDataGridViewTextBoxColumn.FillWeight = 94.76764F;
            this.дниНеделиDataGridViewTextBoxColumn.HeaderText = "Дни недели";
            this.дниНеделиDataGridViewTextBoxColumn.Name = "дниНеделиDataGridViewTextBoxColumn";
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.FillWeight = 94.76764F;
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            // 
            // списоккружковсекцийBindingSource
            // 
            this.списоккружковсекцийBindingSource.DataMember = "Список_кружков_секций";
            this.списоккружковсекцийBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.база_данныхDataSet24;
            this.bindingSource1.Position = 0;
            // 
            // база_данныхDataSet24
            // 
            this.база_данныхDataSet24.DataSetName = "База_данныхDataSet24";
            this.база_данныхDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(23, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "К разделам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // список_кружков_секцийTableAdapter
            // 
            this.список_кружков_секцийTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКружковСекцийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // списокКружковСекцийToolStripMenuItem
            // 
            this.списокКружковСекцийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.отчетПоКружкамСекциямToolStripMenuItem});
            this.списокКружковСекцийToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources._3069189_design_education_learning_pencil_tool_112718;
            this.списокКружковСекцийToolStripMenuItem.Name = "списокКружковСекцийToolStripMenuItem";
            this.списокКружковСекцийToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.списокКружковСекцийToolStripMenuItem.Text = "Список кружков, секций";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.checkmark_circled_icon_icons_com_50431;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // отчетПоКружкамСекциямToolStripMenuItem
            // 
            this.отчетПоКружкамСекциямToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.menu;
            this.отчетПоКружкамСекциямToolStripMenuItem.Name = "отчетПоКружкамСекциямToolStripMenuItem";
            this.отчетПоКружкамСекциямToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.отчетПоКружкамСекциямToolStripMenuItem.Text = "Отчет по кружкам, секциям";
            // 
            // club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 280);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "club";
            this.Text = "СПИСОК КРУЖКОВ, СЕКЦИЙ";
            this.Load += new System.EventHandler(this.club_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списоккружковсекцийBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данныхDataSet24)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private База_данныхDataSet24 база_данныхDataSet24;
        private System.Windows.Forms.BindingSource списоккружковсекцийBindingSource;
        private База_данныхDataSet24TableAdapters.Список_кружков_секцийTableAdapter список_кружков_секцийTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеДеятельностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn руководительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дниНеделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem списокКружковСекцийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоКружкамСекциямToolStripMenuItem;
    }
}