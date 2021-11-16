
namespace P5
{
    partial class FormModifyIssue
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
            this.button1 = new System.Windows.Forms.Button();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.Title_tb = new System.Windows.Forms.TextBox();
            this.component_tb = new System.Windows.Forms.TextBox();
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.Discoverer_cb = new System.Windows.Forms.ComboBox();
            this.status_cb = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Component:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discoverer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discovery Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Title:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Modify Issue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_tb
            // 
            this.ID_tb.Location = new System.Drawing.Point(100, 33);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(199, 20);
            this.ID_tb.TabIndex = 8;
            // 
            // Title_tb
            // 
            this.Title_tb.Location = new System.Drawing.Point(101, 56);
            this.Title_tb.Name = "Title_tb";
            this.Title_tb.Size = new System.Drawing.Size(199, 20);
            this.Title_tb.TabIndex = 9;
            // 
            // component_tb
            // 
            this.component_tb.Location = new System.Drawing.Point(102, 132);
            this.component_tb.Name = "component_tb";
            this.component_tb.Size = new System.Drawing.Size(199, 20);
            this.component_tb.TabIndex = 10;
            // 
            // desc_tb
            // 
            this.desc_tb.Location = new System.Drawing.Point(15, 210);
            this.desc_tb.Multiline = true;
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(285, 128);
            this.desc_tb.TabIndex = 11;
            // 
            // Discoverer_cb
            // 
            this.Discoverer_cb.FormattingEnabled = true;
            this.Discoverer_cb.Location = new System.Drawing.Point(101, 105);
            this.Discoverer_cb.Name = "Discoverer_cb";
            this.Discoverer_cb.Size = new System.Drawing.Size(200, 21);
            this.Discoverer_cb.TabIndex = 12;
            // 
            // status_cb
            // 
            this.status_cb.FormattingEnabled = true;
            this.status_cb.Location = new System.Drawing.Point(100, 155);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(200, 21);
            this.status_cb.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormModifyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.Discoverer_cb);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.component_tb);
            this.Controls.Add(this.Title_tb);
            this.Controls.Add(this.ID_tb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormModifyIssue";
            this.Text = "ModifyIssue";
            this.Load += new System.EventHandler(this.FormModifyIssue_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.TextBox Title_tb;
        private System.Windows.Forms.TextBox component_tb;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.ComboBox Discoverer_cb;
        private System.Windows.Forms.ComboBox status_cb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}