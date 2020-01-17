namespace WcfClient
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
            this.F4Button = new System.Windows.Forms.Button();
            this.xBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GetAllButton = new System.Windows.Forms.Button();
            this.GetIDButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.IDbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // F4Button
            // 
            this.F4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.F4Button.Location = new System.Drawing.Point(52, 115);
            this.F4Button.Name = "F4Button";
            this.F4Button.Size = new System.Drawing.Size(186, 77);
            this.F4Button.TabIndex = 0;
            this.F4Button.Text = "F4";
            this.F4Button.UseVisualStyleBackColor = true;
            this.F4Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // xBox
            // 
            this.xBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xBox.Location = new System.Drawing.Point(52, 65);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(186, 34);
            this.xBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "lnput x:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GetAllButton
            // 
            this.GetAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetAllButton.Location = new System.Drawing.Point(337, 115);
            this.GetAllButton.Name = "GetAllButton";
            this.GetAllButton.Size = new System.Drawing.Size(186, 77);
            this.GetAllButton.TabIndex = 5;
            this.GetAllButton.Text = "Get All Elements";
            this.GetAllButton.UseVisualStyleBackColor = true;
            this.GetAllButton.Click += new System.EventHandler(this.GetAllButton_Click);
            // 
            // GetIDButton
            // 
            this.GetIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetIDButton.Location = new System.Drawing.Point(630, 115);
            this.GetIDButton.Name = "GetIDButton";
            this.GetIDButton.Size = new System.Drawing.Size(186, 77);
            this.GetIDButton.TabIndex = 6;
            this.GetIDButton.Text = "Get element by ID";
            this.GetIDButton.UseVisualStyleBackColor = true;
            this.GetIDButton.Click += new System.EventHandler(this.GetIDButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 425);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(625, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "lnput ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDbox.Location = new System.Drawing.Point(630, 65);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(186, 34);
            this.IDbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 648);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GetIDButton);
            this.Controls.Add(this.GetAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.F4Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F4Button;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetAllButton;
        private System.Windows.Forms.Button GetIDButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDbox;
    }
}

