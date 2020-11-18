namespace Builder
{
    partial class FormSelectRequirement
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
            this.FeatureLabel = new System.Windows.Forms.Label();
            this.RequirementsLabel = new System.Windows.Forms.Label();
            this.FeatureSelectionBox = new System.Windows.Forms.ComboBox();
            this.RequirementsList = new System.Windows.Forms.DataGridView();
            this.SelectRequirementButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RequirementsList)).BeginInit();
            this.SuspendLayout();
            // 
            // FeatureLabel
            // 
            this.FeatureLabel.AutoSize = true;
            this.FeatureLabel.Location = new System.Drawing.Point(41, 34);
            this.FeatureLabel.Name = "FeatureLabel";
            this.FeatureLabel.Size = new System.Drawing.Size(46, 13);
            this.FeatureLabel.TabIndex = 0;
            this.FeatureLabel.Text = "Feature:";
            // 
            // RequirementsLabel
            // 
            this.RequirementsLabel.AutoSize = true;
            this.RequirementsLabel.Enabled = false;
            this.RequirementsLabel.Location = new System.Drawing.Point(12, 67);
            this.RequirementsLabel.Name = "RequirementsLabel";
            this.RequirementsLabel.Size = new System.Drawing.Size(75, 13);
            this.RequirementsLabel.TabIndex = 1;
            this.RequirementsLabel.Text = "Requirements:";
            // 
            // FeatureSelectionBox
            // 
            this.FeatureSelectionBox.FormattingEnabled = true;
            this.FeatureSelectionBox.Location = new System.Drawing.Point(93, 31);
            this.FeatureSelectionBox.Name = "FeatureSelectionBox";
            this.FeatureSelectionBox.Size = new System.Drawing.Size(628, 21);
            this.FeatureSelectionBox.TabIndex = 2;
            this.FeatureSelectionBox.Text = "<Make Selection>";
            this.FeatureSelectionBox.SelectedIndexChanged += new System.EventHandler(this.FeatureSelectionBox_SelectedIndexChanged);
            // 
            // RequirementsList
            // 
            this.RequirementsList.AllowUserToAddRows = false;
            this.RequirementsList.AllowUserToDeleteRows = false;
            this.RequirementsList.AllowUserToResizeColumns = false;
            this.RequirementsList.AllowUserToResizeRows = false;
            this.RequirementsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequirementsList.Enabled = false;
            this.RequirementsList.Location = new System.Drawing.Point(93, 67);
            this.RequirementsList.Name = "RequirementsList";
            this.RequirementsList.ReadOnly = true;
            this.RequirementsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequirementsList.Size = new System.Drawing.Size(628, 321);
            this.RequirementsList.TabIndex = 3;
            // 
            // SelectRequirementButton
            // 
            this.SelectRequirementButton.Enabled = false;
            this.SelectRequirementButton.Location = new System.Drawing.Point(595, 405);
            this.SelectRequirementButton.Name = "SelectRequirementButton";
            this.SelectRequirementButton.Size = new System.Drawing.Size(126, 23);
            this.SelectRequirementButton.TabIndex = 4;
            this.SelectRequirementButton.Text = "Select Requirement";
            this.SelectRequirementButton.UseVisualStyleBackColor = true;
            this.SelectRequirementButton.Click += new System.EventHandler(this.SelectRequirementButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(440, 405);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(126, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormSelectRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 451);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectRequirementButton);
            this.Controls.Add(this.RequirementsList);
            this.Controls.Add(this.FeatureSelectionBox);
            this.Controls.Add(this.RequirementsLabel);
            this.Controls.Add(this.FeatureLabel);
            this.Name = "FormSelectRequirement";
            this.Text = "Select Requirement";
            this.Load += new System.EventHandler(this.FormSelectRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RequirementsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeatureLabel;
        private System.Windows.Forms.Label RequirementsLabel;
        private System.Windows.Forms.ComboBox FeatureSelectionBox;
        private System.Windows.Forms.DataGridView RequirementsList;
        private System.Windows.Forms.Button SelectRequirementButton;
        private System.Windows.Forms.Button CancelButton;
    }
}