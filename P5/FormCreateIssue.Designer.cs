namespace Builder
{
    partial class FormCreateIssue
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
            this.IssueIDBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DiscovererBox = new System.Windows.Forms.ComboBox();
            this.ComponentBox = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateIssueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discovery Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Discoverer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Component:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Initial Description";
            // 
            // IssueIDBox
            // 
            this.IssueIDBox.Enabled = false;
            this.IssueIDBox.Location = new System.Drawing.Point(101, 34);
            this.IssueIDBox.Name = "IssueIDBox";
            this.IssueIDBox.Size = new System.Drawing.Size(63, 20);
            this.IssueIDBox.TabIndex = 7;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(101, 60);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(400, 20);
            this.TitleBox.TabIndex = 8;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(101, 86);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(400, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // DiscovererBox
            // 
            this.DiscovererBox.FormattingEnabled = true;
            this.DiscovererBox.Location = new System.Drawing.Point(101, 112);
            this.DiscovererBox.Name = "DiscovererBox";
            this.DiscovererBox.Size = new System.Drawing.Size(400, 21);
            this.DiscovererBox.TabIndex = 10;
            // 
            // ComponentBox
            // 
            this.ComponentBox.Location = new System.Drawing.Point(101, 138);
            this.ComponentBox.Name = "ComponentBox";
            this.ComponentBox.Size = new System.Drawing.Size(400, 20);
            this.ComponentBox.TabIndex = 11;
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(101, 164);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(400, 21);
            this.StatusBox.TabIndex = 12;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(101, 209);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(400, 262);
            this.DescriptionBox.TabIndex = 13;
            this.DescriptionBox.Text = "";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(252, 513);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 27);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateIssueButton
            // 
            this.CreateIssueButton.Location = new System.Drawing.Point(398, 513);
            this.CreateIssueButton.Name = "CreateIssueButton";
            this.CreateIssueButton.Size = new System.Drawing.Size(103, 27);
            this.CreateIssueButton.TabIndex = 15;
            this.CreateIssueButton.Text = "Create Issue";
            this.CreateIssueButton.UseVisualStyleBackColor = true;
            this.CreateIssueButton.Click += new System.EventHandler(this.CreateIssueButton_Click);
            // 
            // FormCreateIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 565);
            this.Controls.Add(this.CreateIssueButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.ComponentBox);
            this.Controls.Add(this.DiscovererBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.IssueIDBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateIssue";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormCreateIssue_Load);
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
        private System.Windows.Forms.TextBox IssueIDBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox DiscovererBox;
        private System.Windows.Forms.TextBox ComponentBox;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateIssueButton;
    }
}