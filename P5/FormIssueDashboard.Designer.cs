
namespace P5
{
    partial class FormIssueDashboard
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
            this.totalIssues_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IssuesByMonth_listB = new System.Windows.Forms.ListBox();
            this.issuesByDiscoverer_listB = new System.Windows.Forms.ListBox();
            this.close_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalIssues_lb
            // 
            this.totalIssues_lb.AutoSize = true;
            this.totalIssues_lb.Location = new System.Drawing.Point(35, 58);
            this.totalIssues_lb.Name = "totalIssues_lb";
            this.totalIssues_lb.Size = new System.Drawing.Size(35, 13);
            this.totalIssues_lb.TabIndex = 0;
            this.totalIssues_lb.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issues by Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issues by Discoverer";
            // 
            // IssuesByMonth_listB
            // 
            this.IssuesByMonth_listB.FormattingEnabled = true;
            this.IssuesByMonth_listB.Location = new System.Drawing.Point(38, 116);
            this.IssuesByMonth_listB.Name = "IssuesByMonth_listB";
            this.IssuesByMonth_listB.Size = new System.Drawing.Size(284, 95);
            this.IssuesByMonth_listB.TabIndex = 3;
            // 
            // issuesByDiscoverer_listB
            // 
            this.issuesByDiscoverer_listB.FormattingEnabled = true;
            this.issuesByDiscoverer_listB.Location = new System.Drawing.Point(38, 261);
            this.issuesByDiscoverer_listB.Name = "issuesByDiscoverer_listB";
            this.issuesByDiscoverer_listB.Size = new System.Drawing.Size(284, 95);
            this.issuesByDiscoverer_listB.TabIndex = 4;
            // 
            // close_bt
            // 
            this.close_bt.Location = new System.Drawing.Point(233, 376);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(89, 25);
            this.close_bt.TabIndex = 5;
            this.close_bt.Text = "Close";
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 424);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.issuesByDiscoverer_listB);
            this.Controls.Add(this.IssuesByMonth_listB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalIssues_lb);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalIssues_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox IssuesByMonth_listB;
        private System.Windows.Forms.ListBox issuesByDiscoverer_listB;
        private System.Windows.Forms.Button close_bt;
    }
}