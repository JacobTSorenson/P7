namespace P5
{
    partial class FormSelectProject
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
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.buttonSelectProject = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 16;
            this.listBoxProjects.Location = new System.Drawing.Point(33, 34);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(534, 244);
            this.listBoxProjects.TabIndex = 0;
            // 
            // buttonSelectProject
            // 
            this.buttonSelectProject.Location = new System.Drawing.Point(406, 317);
            this.buttonSelectProject.Name = "buttonSelectProject";
            this.buttonSelectProject.Size = new System.Drawing.Size(160, 37);
            this.buttonSelectProject.TabIndex = 1;
            this.buttonSelectProject.Text = "Select Project";
            this.buttonSelectProject.UseVisualStyleBackColor = true;
            this.buttonSelectProject.Click += new System.EventHandler(this.buttonSelectProject_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(188, 317);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 37);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PreferenceSelectProject
            // 
            this.AcceptButton = this.buttonSelectProject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(606, 383);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectProject);
            this.Controls.Add(this.listBoxProjects);
            this.Name = "PreferenceSelectProject";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.PreferenceSelectProject_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.Button buttonSelectProject;
        private System.Windows.Forms.Button buttonCancel;
    }
}