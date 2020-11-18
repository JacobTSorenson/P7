namespace Builder
{
    partial class FormSelectFeature
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
            this.FeatureList = new System.Windows.Forms.DataGridView();
            this.SelectFeatureButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeatureList)).BeginInit();
            this.SuspendLayout();
            // 
            // FeatureList
            // 
            this.FeatureList.AllowUserToAddRows = false;
            this.FeatureList.AllowUserToDeleteRows = false;
            this.FeatureList.AllowUserToResizeColumns = false;
            this.FeatureList.AllowUserToResizeRows = false;
            this.FeatureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeatureList.Location = new System.Drawing.Point(37, 40);
            this.FeatureList.Name = "FeatureList";
            this.FeatureList.ReadOnly = true;
            this.FeatureList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeatureList.Size = new System.Drawing.Size(664, 383);
            this.FeatureList.TabIndex = 0;
            // 
            // SelectFeatureButton
            // 
            this.SelectFeatureButton.Location = new System.Drawing.Point(583, 449);
            this.SelectFeatureButton.Name = "SelectFeatureButton";
            this.SelectFeatureButton.Size = new System.Drawing.Size(118, 23);
            this.SelectFeatureButton.TabIndex = 1;
            this.SelectFeatureButton.Text = "Select Feature";
            this.SelectFeatureButton.UseVisualStyleBackColor = true;
            this.SelectFeatureButton.Click += new System.EventHandler(this.SelectFeatureButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(439, 449);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormSelectFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 506);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectFeatureButton);
            this.Controls.Add(this.FeatureList);
            this.Name = "FormSelectFeature";
            this.Text = "Select Feature";
            this.Load += new System.EventHandler(this.FormSelectFeature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeatureList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FeatureList;
        private System.Windows.Forms.Button SelectFeatureButton;
        private System.Windows.Forms.Button CancelButton;
    }
}