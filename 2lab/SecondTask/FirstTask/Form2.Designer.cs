namespace FirstTask
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.AddingCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdatingCheckBox = new System.Windows.Forms.CheckBox();
            this.DeletingCheckBox = new System.Windows.Forms.CheckBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GettingCheckBox = new System.Windows.Forms.CheckBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddingCheckBox
            // 
            this.AddingCheckBox.AutoSize = true;
            this.AddingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingCheckBox.Location = new System.Drawing.Point(588, 64);
            this.AddingCheckBox.Name = "AddingCheckBox";
            this.AddingCheckBox.Size = new System.Drawing.Size(193, 27);
            this.AddingCheckBox.TabIndex = 1;
            this.AddingCheckBox.Text = "Додати категорію";
            this.AddingCheckBox.UseVisualStyleBackColor = true;
            this.AddingCheckBox.CheckedChanged += new System.EventHandler(this.AddingCheckBox_CheckedChanged);
            // 
            // UpdatingCheckBox
            // 
            this.UpdatingCheckBox.AutoSize = true;
            this.UpdatingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdatingCheckBox.Location = new System.Drawing.Point(588, 97);
            this.UpdatingCheckBox.Name = "UpdatingCheckBox";
            this.UpdatingCheckBox.Size = new System.Drawing.Size(218, 27);
            this.UpdatingCheckBox.TabIndex = 2;
            this.UpdatingCheckBox.Text = "Оновлення категорії";
            this.UpdatingCheckBox.UseVisualStyleBackColor = true;
            this.UpdatingCheckBox.CheckedChanged += new System.EventHandler(this.UpdatingCheckBox_CheckedChanged);
            // 
            // DeletingCheckBox
            // 
            this.DeletingCheckBox.AutoSize = true;
            this.DeletingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletingCheckBox.Location = new System.Drawing.Point(588, 130);
            this.DeletingCheckBox.Name = "DeletingCheckBox";
            this.DeletingCheckBox.Size = new System.Drawing.Size(223, 31);
            this.DeletingCheckBox.TabIndex = 3;
            this.DeletingCheckBox.Text = "Вилучення категорії";
            this.DeletingCheckBox.UseVisualStyleBackColor = true;
            this.DeletingCheckBox.CheckedChanged += new System.EventHandler(this.DeletingCheckBox_CheckedChanged);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(81, 229);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.IDTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(258, 229);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(447, 229);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Опис";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "Виконати запит";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(81, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Результат останного запиту";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 286);
            this.dataGridView1.TabIndex = 26;
            // 
            // GettingCheckBox
            // 
            this.GettingCheckBox.AutoSize = true;
            this.GettingCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GettingCheckBox.Location = new System.Drawing.Point(588, 31);
            this.GettingCheckBox.Name = "GettingCheckBox";
            this.GettingCheckBox.Size = new System.Drawing.Size(458, 27);
            this.GettingCheckBox.TabIndex = 27;
            this.GettingCheckBox.Text = "Отримання всіх категорій медичних препаратів";
            this.GettingCheckBox.UseVisualStyleBackColor = true;
            this.GettingCheckBox.CheckedChanged += new System.EventHandler(this.GettingCheckBox_CheckedChanged);
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxRes.Location = new System.Drawing.Point(447, 591);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(394, 22);
            this.textBoxRes.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1092, 625);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.GettingCheckBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.DeletingCheckBox);
            this.Controls.Add(this.UpdatingCheckBox);
            this.Controls.Add(this.AddingCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Категорії медичних препаратів";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox AddingCheckBox;
        private System.Windows.Forms.CheckBox UpdatingCheckBox;
        private System.Windows.Forms.CheckBox DeletingCheckBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox GettingCheckBox;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}