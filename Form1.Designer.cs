namespace DomaciZadatak13
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.champDataSet = new DomaciZadatak13.ChampDataSet();
            this.champBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.champTableAdapter = new DomaciZadatak13.ChampDataSetTableAdapters.ChampTableAdapter();
            this.tableAdapterManager = new DomaciZadatak13.ChampDataSetTableAdapters.TableAdapterManager();
            this.champDataGridView = new System.Windows.Forms.DataGridView();
            this.champDataSet1 = new DomaciZadatak13.ChampDataSet();
            this.findBy = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.ComboBox();
            this.textBoxClass = new System.Windows.Forms.ComboBox();
            this.textBoxOrigin = new System.Windows.Forms.ComboBox();
            this.comboListBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.champDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIme.Location = new System.Drawing.Point(85, 53);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(108, 23);
            this.textBoxIme.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(85, 178);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 34);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ADD CHAMP";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // champDataSet
            // 
            this.champDataSet.DataSetName = "ChampDataSet";
            this.champDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // champBindingSource
            // 
            this.champBindingSource.DataMember = "Champ";
            this.champBindingSource.DataSource = this.champDataSet;
            // 
            // champTableAdapter
            // 
            this.champTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChampTableAdapter = this.champTableAdapter;
            this.tableAdapterManager.UpdateOrder = DomaciZadatak13.ChampDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // champDataGridView
            // 
            this.champDataGridView.AllowUserToAddRows = false;
            this.champDataGridView.AllowUserToDeleteRows = false;
            this.champDataGridView.AutoGenerateColumns = false;
            this.champDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.champDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.champDataGridView.DataSource = this.champBindingSource;
            this.champDataGridView.Location = new System.Drawing.Point(421, 12);
            this.champDataGridView.Name = "champDataGridView";
            this.champDataGridView.ReadOnly = true;
            this.champDataGridView.Size = new System.Drawing.Size(427, 437);
            this.champDataGridView.TabIndex = 4;
            // 
            // champDataSet1
            // 
            this.champDataSet1.DataSetName = "ChampDataSet";
            this.champDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // findBy
            // 
            this.findBy.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBy.Location = new System.Drawing.Point(234, 287);
            this.findBy.Name = "findBy";
            this.findBy.Size = new System.Drawing.Size(164, 26);
            this.findBy.TabIndex = 6;
            this.findBy.Text = "List Champions";
            this.findBy.UseVisualStyleBackColor = true;
            this.findBy.Click += new System.EventHandler(this.findBy_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(14, 319);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 130);
            this.listBox1.TabIndex = 7;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(124, 287);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(104, 26);
            this.comboBox.Sorted = true;
            this.comboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cost";
            // 
            // textBoxCost
            // 
            this.textBoxCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxCost.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.FormattingEnabled = true;
            this.textBoxCost.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.textBoxCost.Location = new System.Drawing.Point(86, 146);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(63, 26);
            this.textBoxCost.Sorted = true;
            this.textBoxCost.TabIndex = 15;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxClass.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClass.FormattingEnabled = true;
            this.textBoxClass.Items.AddRange(new object[] {
            "Cloud",
            "Crystal",
            "Desert",
            "Electric",
            "Glacial",
            "Inferno",
            "Light",
            "Lunar",
            "Mountain",
            "Ocean",
            "Poison",
            "Shadow",
            "Steel",
            "Woodland"});
            this.textBoxClass.Location = new System.Drawing.Point(86, 114);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(136, 26);
            this.textBoxClass.Sorted = true;
            this.textBoxClass.TabIndex = 16;
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxOrigin.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrigin.FormattingEnabled = true;
            this.textBoxOrigin.Items.AddRange(new object[] {
            "Alchemist",
            "Assassin",
            "Avatar",
            "Berserker",
            "Blademaster",
            "Druid",
            "Mage",
            "Mystic",
            "Predator",
            "Ranger",
            "Soulbound",
            "Summoner",
            "Warden"});
            this.textBoxOrigin.Location = new System.Drawing.Point(85, 82);
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(107, 26);
            this.textBoxOrigin.Sorted = true;
            this.textBoxOrigin.TabIndex = 17;
            // 
            // comboListBy
            // 
            this.comboListBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboListBy.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboListBy.FormattingEnabled = true;
            this.comboListBy.Items.AddRange(new object[] {
            "Class",
            "Cost",
            "Origin"});
            this.comboListBy.Location = new System.Drawing.Point(14, 288);
            this.comboListBy.Name = "comboListBy";
            this.comboListBy.Size = new System.Drawing.Size(104, 26);
            this.comboListBy.Sorted = true;
            this.comboListBy.TabIndex = 18;
            this.comboListBy.SelectedIndexChanged += new System.EventHandler(this.comboListBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Choose origin, class or cost and then select available valuse:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Origin";
            this.dataGridViewTextBoxColumn3.HeaderText = "Origin";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn4.HeaderText = "Class";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Add New Champion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboListBy);
            this.Controls.Add(this.textBoxOrigin);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.findBy);
            this.Controls.Add(this.champDataGridView);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Domaći Zadatak 13";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.champDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button buttonAdd;
        private ChampDataSet champDataSet;
        private System.Windows.Forms.BindingSource champBindingSource;
        private ChampDataSetTableAdapters.ChampTableAdapter champTableAdapter;
        private ChampDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView champDataGridView;
        private ChampDataSet champDataSet1;
        private System.Windows.Forms.Button findBy;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox textBoxCost;
        private System.Windows.Forms.ComboBox textBoxClass;
        private System.Windows.Forms.ComboBox textBoxOrigin;
        private System.Windows.Forms.ComboBox comboListBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label6;
    }
}

