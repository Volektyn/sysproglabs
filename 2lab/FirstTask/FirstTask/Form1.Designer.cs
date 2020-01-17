namespace FirstTask
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
            this.gettingCheckBox = new System.Windows.Forms.CheckBox();
            this.addingCheckBox = new System.Windows.Forms.CheckBox();
            this.updatingCheckBox = new System.Windows.Forms.CheckBox();
            this.deletingCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.IDCheckBox = new System.Windows.Forms.CheckBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.LegalityTextBox = new System.Windows.Forms.TextBox();
            this.RecipeTextBox = new System.Windows.Forms.TextBox();
            this.InstructionTextBox = new System.Windows.Forms.TextBox();
            this.ScopeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.aptekaDataSet = new FirstTask.AptekaDataSet();
            this.drug_CategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drug_CategoryTableAdapter = new FirstTask.AptekaDataSetTableAdapters.Drug_CategoryTableAdapter();
            this.tableAdapterManager = new FirstTask.AptekaDataSetTableAdapters.TableAdapterManager();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drug_CategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gettingCheckBox
            // 
            this.gettingCheckBox.AutoSize = true;
            this.gettingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gettingCheckBox.Location = new System.Drawing.Point(500, 49);
            this.gettingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gettingCheckBox.Name = "gettingCheckBox";
            this.gettingCheckBox.Size = new System.Drawing.Size(361, 31);
            this.gettingCheckBox.TabIndex = 0;
            this.gettingCheckBox.Text = "Отримання областей засотування";
            this.gettingCheckBox.UseVisualStyleBackColor = true;
            this.gettingCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addingCheckBox
            // 
            this.addingCheckBox.AutoSize = true;
            this.addingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addingCheckBox.Location = new System.Drawing.Point(500, 88);
            this.addingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.addingCheckBox.Name = "addingCheckBox";
            this.addingCheckBox.Size = new System.Drawing.Size(214, 31);
            this.addingCheckBox.TabIndex = 1;
            this.addingCheckBox.Text = "Додавання області";
            this.addingCheckBox.UseVisualStyleBackColor = true;
            this.addingCheckBox.CheckedChanged += new System.EventHandler(this.addingCheckBox_CheckedChanged);
            // 
            // updatingCheckBox
            // 
            this.updatingCheckBox.AutoSize = true;
            this.updatingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatingCheckBox.Location = new System.Drawing.Point(500, 127);
            this.updatingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.updatingCheckBox.Name = "updatingCheckBox";
            this.updatingCheckBox.Size = new System.Drawing.Size(221, 31);
            this.updatingCheckBox.TabIndex = 2;
            this.updatingCheckBox.Text = "Оновлення області ";
            this.updatingCheckBox.UseVisualStyleBackColor = true;
            this.updatingCheckBox.CheckedChanged += new System.EventHandler(this.updatingCheckBox_CheckedChanged);
            // 
            // deletingCheckBox
            // 
            this.deletingCheckBox.AutoSize = true;
            this.deletingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletingCheckBox.Location = new System.Drawing.Point(500, 166);
            this.deletingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.deletingCheckBox.Name = "deletingCheckBox";
            this.deletingCheckBox.Size = new System.Drawing.Size(210, 31);
            this.deletingCheckBox.TabIndex = 3;
            this.deletingCheckBox.Text = "Вилучення області";
            this.deletingCheckBox.UseVisualStyleBackColor = true;
            this.deletingCheckBox.CheckedChanged += new System.EventHandler(this.deletingCheckBox_CheckedChanged);
            // 
            // CategoryCheckBox
            // 
            this.CategoryCheckBox.AutoSize = true;
            this.CategoryCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCheckBox.Location = new System.Drawing.Point(905, 51);
            this.CategoryCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryCheckBox.Name = "CategoryCheckBox";
            this.CategoryCheckBox.Size = new System.Drawing.Size(269, 31);
            this.CategoryCheckBox.TabIndex = 4;
            this.CategoryCheckBox.Text = "За категорією препарату";
            this.CategoryCheckBox.UseVisualStyleBackColor = true;
            this.CategoryCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // IDCheckBox
            // 
            this.IDCheckBox.AutoSize = true;
            this.IDCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCheckBox.Location = new System.Drawing.Point(1206, 51);
            this.IDCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDCheckBox.Name = "IDCheckBox";
            this.IDCheckBox.Size = new System.Drawing.Size(167, 31);
            this.IDCheckBox.TabIndex = 5;
            this.IDCheckBox.Text = "за ID області";
            this.IDCheckBox.UseVisualStyleBackColor = true;
            this.IDCheckBox.CheckedChanged += new System.EventHandler(this.IDCheckBox_CheckedChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(15, 260);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(165, 28);
            this.IDTextBox.TabIndex = 6;
            // 
            // LegalityTextBox
            // 
            this.LegalityTextBox.Location = new System.Drawing.Point(681, 260);
            this.LegalityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LegalityTextBox.Name = "LegalityTextBox";
            this.LegalityTextBox.Size = new System.Drawing.Size(165, 28);
            this.LegalityTextBox.TabIndex = 7;
            // 
            // RecipeTextBox
            // 
            this.RecipeTextBox.Location = new System.Drawing.Point(464, 260);
            this.RecipeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecipeTextBox.Name = "RecipeTextBox";
            this.RecipeTextBox.Size = new System.Drawing.Size(165, 28);
            this.RecipeTextBox.TabIndex = 8;
            // 
            // InstructionTextBox
            // 
            this.InstructionTextBox.Location = new System.Drawing.Point(894, 260);
            this.InstructionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InstructionTextBox.Name = "InstructionTextBox";
            this.InstructionTextBox.Size = new System.Drawing.Size(165, 28);
            this.InstructionTextBox.TabIndex = 9;
            // 
            // ScopeTextBox
            // 
            this.ScopeTextBox.Location = new System.Drawing.Point(249, 260);
            this.ScopeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ScopeTextBox.Name = "ScopeTextBox";
            this.ScopeTextBox.Size = new System.Drawing.Size(165, 28);
            this.ScopeTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1101, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 48);
            this.label2.TabIndex = 13;
            this.label2.Text = "Категорія медичних \r\n        препаратів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(234, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Область застосування";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(510, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Рецепт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(718, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Легальність";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(929, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Інструкція";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 67);
            this.button1.TabIndex = 18;
            this.button1.Text = "Виконати запит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 67);
            this.button2.TabIndex = 19;
            this.button2.Text = "Категорії медичних препаратів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(1105, 260);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(174, 30);
            this.CategoryComboBox.TabIndex = 20;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // aptekaDataSet
            // 
            this.aptekaDataSet.DataSetName = "AptekaDataSet";
            this.aptekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drug_CategoryBindingSource
            // 
            this.drug_CategoryBindingSource.DataMember = "Drug_Category";
            this.drug_CategoryBindingSource.DataSource = this.aptekaDataSet;
            // 
            // drug_CategoryTableAdapter
            // 
            this.drug_CategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Drug_CategoryTableAdapter = this.drug_CategoryTableAdapter;
            this.tableAdapterManager.Scope_Of_Drug_Using_Of_Specified_CategoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FirstTask.AptekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(811, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Результат останного запиту";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 354);
            this.dataGridView1.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxRes.Location = new System.Drawing.Point(708, 749);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(466, 28);
            this.textBoxRes.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 185);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1571, 908);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScopeTextBox);
            this.Controls.Add(this.InstructionTextBox);
            this.Controls.Add(this.RecipeTextBox);
            this.Controls.Add(this.LegalityTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.IDCheckBox);
            this.Controls.Add(this.CategoryCheckBox);
            this.Controls.Add(this.deletingCheckBox);
            this.Controls.Add(this.updatingCheckBox);
            this.Controls.Add(this.addingCheckBox);
            this.Controls.Add(this.gettingCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Області застосування препаратів вказаної категорії";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aptekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drug_CategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox gettingCheckBox;
        private System.Windows.Forms.CheckBox addingCheckBox;
        private System.Windows.Forms.CheckBox updatingCheckBox;
        private System.Windows.Forms.CheckBox deletingCheckBox;
        private System.Windows.Forms.CheckBox CategoryCheckBox;
        private System.Windows.Forms.CheckBox IDCheckBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox LegalityTextBox;
        private System.Windows.Forms.TextBox RecipeTextBox;
        private System.Windows.Forms.TextBox InstructionTextBox;
        private System.Windows.Forms.TextBox ScopeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private AptekaDataSet aptekaDataSet;
        private System.Windows.Forms.BindingSource drug_CategoryBindingSource;
        private AptekaDataSetTableAdapters.Drug_CategoryTableAdapter drug_CategoryTableAdapter;
        private AptekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

