namespace DIU
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
            this.sid_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sid_tb
            // 
            this.sid_tb.Location = new System.Drawing.Point(153, 40);
            this.sid_tb.Margin = new System.Windows.Forms.Padding(2);
            this.sid_tb.Name = "sid_tb";
            this.sid_tb.Size = new System.Drawing.Size(167, 20);
            this.sid_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(153, 75);
            this.name_tb.Margin = new System.Windows.Forms.Padding(2);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(167, 20);
            this.name_tb.TabIndex = 2;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(153, 112);
            this.email_tb.Margin = new System.Windows.Forms.Padding(2);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(167, 20);
            this.email_tb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.save_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_btn.Location = new System.Drawing.Point(11, 188);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(80, 37);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Lime;
            this.search_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_btn.Location = new System.Drawing.Point(104, 188);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(80, 37);
            this.search_btn.TabIndex = 13;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(355, 215);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Yellow;
            this.update_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_btn.Location = new System.Drawing.Point(205, 188);
            this.update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(80, 37);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(73, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(615, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Designed & Developed by Shahriar Aziz Aakash";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(301, 188);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(80, 37);
            this.delete_btn.TabIndex = 17;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 366);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sid_tb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sid_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_btn;
    }
}

