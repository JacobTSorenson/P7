namespace Builder
{
    partial class FormCreateFeature
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
            this.FeatureTitleLabel = new System.Windows.Forms.Label();
            this.FeatureTitleBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateFeatureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeatureTitleLabel
            // 
            this.FeatureTitleLabel.AutoSize = true;
            this.FeatureTitleLabel.Location = new System.Drawing.Point(42, 35);
            this.FeatureTitleLabel.Name = "FeatureTitleLabel";
            this.FeatureTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.FeatureTitleLabel.TabIndex = 0;
            this.FeatureTitleLabel.Text = "Title:";
            // 
            // FeatureTitleBox
            // 
            this.FeatureTitleBox.Location = new System.Drawing.Point(78, 32);
            this.FeatureTitleBox.Name = "FeatureTitleBox";
            this.FeatureTitleBox.Size = new System.Drawing.Size(457, 20);
            this.FeatureTitleBox.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(279, 83);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(107, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateFeatureButton
            // 
            this.CreateFeatureButton.Location = new System.Drawing.Point(428, 83);
            this.CreateFeatureButton.Name = "CreateFeatureButton";
            this.CreateFeatureButton.Size = new System.Drawing.Size(107, 23);
            this.CreateFeatureButton.TabIndex = 3;
            this.CreateFeatureButton.Text = "Create Feature";
            this.CreateFeatureButton.UseVisualStyleBackColor = true;
            this.CreateFeatureButton.Click += new System.EventHandler(this.CreateFeatureButton_Click);
            // 
            // FormCreateFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 144);
            this.Controls.Add(this.CreateFeatureButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FeatureTitleBox);
            this.Controls.Add(this.FeatureTitleLabel);
            this.Name = "FormCreateFeature";
            this.Text = "Create Feature";
            this.Load += new System.EventHandler(this.FormCreateFeature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeatureTitleLabel;
        private System.Windows.Forms.TextBox FeatureTitleBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateFeatureButton;
    }
}