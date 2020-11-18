namespace Builder
{
    partial class FormCreateRequirement
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
            this.FeatureSelectionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StatementBox = new System.Windows.Forms.RichTextBox();
            this.CreateRequirementButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feature:";
            // 
            // FeatureSelectionBox
            // 
            this.FeatureSelectionBox.FormattingEnabled = true;
            this.FeatureSelectionBox.Location = new System.Drawing.Point(95, 43);
            this.FeatureSelectionBox.Name = "FeatureSelectionBox";
            this.FeatureSelectionBox.Size = new System.Drawing.Size(444, 21);
            this.FeatureSelectionBox.TabIndex = 1;
            this.FeatureSelectionBox.Text = "<Make Selection>";
            this.FeatureSelectionBox.SelectedIndexChanged += new System.EventHandler(this.FeatureSelectionBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Statement:";
            // 
            // StatementBox
            // 
            this.StatementBox.Enabled = false;
            this.StatementBox.Location = new System.Drawing.Point(95, 82);
            this.StatementBox.Name = "StatementBox";
            this.StatementBox.Size = new System.Drawing.Size(444, 249);
            this.StatementBox.TabIndex = 3;
            this.StatementBox.Text = "";
            // 
            // CreateRequirementButton
            // 
            this.CreateRequirementButton.Enabled = false;
            this.CreateRequirementButton.Location = new System.Drawing.Point(395, 353);
            this.CreateRequirementButton.Name = "CreateRequirementButton";
            this.CreateRequirementButton.Size = new System.Drawing.Size(144, 23);
            this.CreateRequirementButton.TabIndex = 4;
            this.CreateRequirementButton.Text = "Create Requirement";
            this.CreateRequirementButton.UseVisualStyleBackColor = true;
            this.CreateRequirementButton.Click += new System.EventHandler(this.CreateRequirementButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(218, 353);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormCreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 413);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateRequirementButton);
            this.Controls.Add(this.StatementBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FeatureSelectionBox);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateRequirement";
            this.Text = "Create Requirement";
            this.Load += new System.EventHandler(this.FormCreateRequirement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FeatureSelectionBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox StatementBox;
        private System.Windows.Forms.Button CreateRequirementButton;
        private System.Windows.Forms.Button CancelButton;
    }
}