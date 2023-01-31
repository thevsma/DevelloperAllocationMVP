namespace DeveloperAllocationMVP.Forms
{
    partial class frmAllocation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lstDeveloper = new System.Windows.Forms.ListBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lstProject = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstProject);
            this.panel1.Controls.Add(this.txtProject);
            this.panel1.Controls.Add(this.lblProject);
            this.panel1.Controls.Add(this.lstDeveloper);
            this.panel1.Controls.Add(this.txtDeveloper);
            this.panel1.Controls.Add(this.lblDeveloper);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 561);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(78, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Criação de Alocação";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(12, 38);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(118, 20);
            this.lblDeveloper.TabIndex = 1;
            this.lblDeveloper.Text = "Desenvolvedor:";
            // 
            // txtDeveloper
            // 
            this.txtDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeveloper.Location = new System.Drawing.Point(136, 38);
            this.txtDeveloper.Name = "txtDeveloper";
            this.txtDeveloper.Size = new System.Drawing.Size(120, 21);
            this.txtDeveloper.TabIndex = 2;
            this.txtDeveloper.TextChanged += new System.EventHandler(this.txtDeveloper_TextChanged);
            // 
            // lstDeveloper
            // 
            this.lstDeveloper.FormattingEnabled = true;
            this.lstDeveloper.Location = new System.Drawing.Point(136, 65);
            this.lstDeveloper.Name = "lstDeveloper";
            this.lstDeveloper.Size = new System.Drawing.Size(120, 95);
            this.lstDeveloper.TabIndex = 3;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(262, 38);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(63, 20);
            this.lblProject.TabIndex = 4;
            this.lblProject.Text = "Projeto:";
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(331, 40);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(120, 21);
            this.txtProject.TabIndex = 5;
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(331, 67);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(120, 95);
            this.lstProject.TabIndex = 6;
            // 
            // frmAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 561);
            this.Controls.Add(this.panel1);
            this.Name = "frmAllocation";
            this.Text = "Criação de Alocação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ListBox lstDeveloper;
        private System.Windows.Forms.TextBox txtDeveloper;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.TextBox txtProject;
    }
}