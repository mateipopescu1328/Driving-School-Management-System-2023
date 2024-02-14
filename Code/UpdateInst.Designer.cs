namespace Driving_School
{
    partial class UpdateInst
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_button = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.DataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Înregistrare = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.textBox_Idang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Cat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Exp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Magenta;
            this.search_button.Location = new System.Drawing.Point(25, 253);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(97, 38);
            this.search_button.TabIndex = 53;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(128, 255);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(131, 22);
            this.textBox_search.TabIndex = 52;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.DarkGreen;
            this.update_button.Location = new System.Drawing.Point(423, 249);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(145, 44);
            this.update_button.TabIndex = 49;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // DataGridView_student
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_student.BackgroundColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_student.ColumnHeadersHeight = 25;
            this.DataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.Location = new System.Drawing.Point(10, 308);
            this.DataGridView_student.Name = "DataGridView_student";
            this.DataGridView_student.RowHeadersVisible = false;
            this.DataGridView_student.RowHeadersWidth = 51;
            this.DataGridView_student.RowTemplate.Height = 24;
            this.DataGridView_student.Size = new System.Drawing.Size(938, 285);
            this.DataGridView_student.TabIndex = 48;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_student.ThemeStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.DataGridView_student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_student.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridView_student.ThemeStyle.ReadOnly = false;
            this.DataGridView_student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_student.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_student_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Înregistrare);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 76);
            this.panel1.TabIndex = 47;
            // 
            // Înregistrare
            // 
            this.Înregistrare.AutoSize = true;
            this.Înregistrare.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Înregistrare.Location = new System.Drawing.Point(275, 21);
            this.Înregistrare.Name = "Înregistrare";
            this.Înregistrare.Size = new System.Drawing.Size(173, 37);
            this.Înregistrare.TabIndex = 0;
            this.Înregistrare.Text = "Modificare";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.HotTrack;
            this.delete_button.Location = new System.Drawing.Point(725, 247);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(145, 44);
            this.delete_button.TabIndex = 46;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Red;
            this.clear_button.Location = new System.Drawing.Point(574, 247);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(145, 44);
            this.clear_button.TabIndex = 45;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // textBox_Idang
            // 
            this.textBox_Idang.Location = new System.Drawing.Point(637, 136);
            this.textBox_Idang.Name = "textBox_Idang";
            this.textBox_Idang.Size = new System.Drawing.Size(158, 22);
            this.textBox_Idang.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "ID Angajat";
            // 
            // textBox_Cat
            // 
            this.textBox_Cat.Location = new System.Drawing.Point(128, 181);
            this.textBox_Cat.Name = "textBox_Cat";
            this.textBox_Cat.Size = new System.Drawing.Size(162, 22);
            this.textBox_Cat.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Categorie";
            // 
            // textBox_Exp
            // 
            this.textBox_Exp.Location = new System.Drawing.Point(128, 130);
            this.textBox_Exp.Name = "textBox_Exp";
            this.textBox_Exp.Size = new System.Drawing.Size(162, 22);
            this.textBox_Exp.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Experienta";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(637, 184);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(158, 22);
            this.textBox_id.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "ID";
            // 
            // UpdateInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 804);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Idang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Cat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Exp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.DataGridView_student);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Name = "UpdateInst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateInst";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_student)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button update_button;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_student;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Înregistrare;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox textBox_Idang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Cat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Exp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label6;
    }
}