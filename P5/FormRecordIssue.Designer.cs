
namespace P5
{
    partial class FormRecordIssue
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Id_tb = new System.Windows.Forms.TextBox();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.Component_tb = new System.Windows.Forms.TextBox();
            this.Desc_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Discoverer_dd = new System.Windows.Forms.ComboBox();
            this.status_dd = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Component:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discoverer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discovery Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Initial Description";
            // 
            // Id_tb
            // 
            this.Id_tb.Enabled = false;
            this.Id_tb.Location = new System.Drawing.Point(104, 17);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(188, 20);
            this.Id_tb.TabIndex = 7;
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(104, 44);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(188, 20);
            this.title_tb.TabIndex = 8;
            // 
            // Component_tb
            // 
            this.Component_tb.Location = new System.Drawing.Point(104, 114);
            this.Component_tb.Name = "Component_tb";
            this.Component_tb.Size = new System.Drawing.Size(188, 20);
            this.Component_tb.TabIndex = 9;
            // 
            // Desc_tb
            // 
            this.Desc_tb.Location = new System.Drawing.Point(24, 189);
            this.Desc_tb.Multiline = true;
            this.Desc_tb.Name = "Desc_tb";
            this.Desc_tb.Size = new System.Drawing.Size(268, 152);
            this.Desc_tb.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Discoverer_dd
            // 
            this.Discoverer_dd.FormattingEnabled = true;
            this.Discoverer_dd.Location = new System.Drawing.Point(104, 89);
            this.Discoverer_dd.Name = "Discoverer_dd";
            this.Discoverer_dd.Size = new System.Drawing.Size(188, 21);
            this.Discoverer_dd.TabIndex = 12;
            // 
            // status_dd
            // 
            this.status_dd.FormattingEnabled = true;
            this.status_dd.Location = new System.Drawing.Point(104, 142);
            this.status_dd.Name = "status_dd";
            this.status_dd.Size = new System.Drawing.Size(188, 21);
            this.status_dd.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel_bt
            // 
            this.Cancel_bt.Location = new System.Drawing.Point(71, 383);
            this.Cancel_bt.Name = "Cancel_bt";
            this.Cancel_bt.Size = new System.Drawing.Size(99, 23);
            this.Cancel_bt.TabIndex = 15;
            this.Cancel_bt.Text = "Cancel";
            this.Cancel_bt.UseVisualStyleBackColor = true;
            this.Cancel_bt.Click += new System.EventHandler(this.Cancel_bt_Click);
            // 
            // FormRecordIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.Cancel_bt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status_dd);
            this.Controls.Add(this.Discoverer_dd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Desc_tb);
            this.Controls.Add(this.Component_tb);
            this.Controls.Add(this.title_tb);
            this.Controls.Add(this.Id_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRecordIssue";
            this.Text = "Record Issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Id_tb;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox Component_tb;
        private System.Windows.Forms.TextBox Desc_tb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Discoverer_dd;
        private System.Windows.Forms.ComboBox status_dd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Cancel_bt;
    }
}