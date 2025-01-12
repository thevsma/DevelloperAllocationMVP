﻿namespace DeveloperAllocationMVP
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProject = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllocation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevEntries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjEntries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchive,
            this.mnuRegister,
            this.mnuEntries});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchive
            // 
            this.mnuArchive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuClose});
            this.mnuArchive.Name = "mnuArchive";
            this.mnuArchive.Size = new System.Drawing.Size(61, 20);
            this.mnuArchive.Text = "Arquivo";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(104, 22);
            this.mnuAbout.Text = "Sobre";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(104, 22);
            this.mnuClose.Text = "Sair";
            this.mnuClose.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuRegister
            // 
            this.mnuRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeveloper,
            this.mnuProject,
            this.mnuAllocation,
            this.mnuTask});
            this.mnuRegister.Name = "mnuRegister";
            this.mnuRegister.Size = new System.Drawing.Size(66, 20);
            this.mnuRegister.Text = "Cadastro";
            // 
            // mnuDeveloper
            // 
            this.mnuDeveloper.Name = "mnuDeveloper";
            this.mnuDeveloper.Size = new System.Drawing.Size(180, 22);
            this.mnuDeveloper.Text = "Desenvolvedor";
            this.mnuDeveloper.Click += new System.EventHandler(this.mnuDeveloper_Click);
            // 
            // mnuProject
            // 
            this.mnuProject.Name = "mnuProject";
            this.mnuProject.Size = new System.Drawing.Size(180, 22);
            this.mnuProject.Text = "Projeto";
            this.mnuProject.Click += new System.EventHandler(this.mnuProject_Click);
            // 
            // mnuAllocation
            // 
            this.mnuAllocation.Name = "mnuAllocation";
            this.mnuAllocation.Size = new System.Drawing.Size(180, 22);
            this.mnuAllocation.Text = "Alocação";
            this.mnuAllocation.Click += new System.EventHandler(this.mnuAllocation_Click);
            // 
            // mnuEntries
            // 
            this.mnuEntries.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDevEntries,
            this.mnuProjEntries});
            this.mnuEntries.Name = "mnuEntries";
            this.mnuEntries.Size = new System.Drawing.Size(67, 20);
            this.mnuEntries.Text = "Registros";
            // 
            // mnuDevEntries
            // 
            this.mnuDevEntries.Name = "mnuDevEntries";
            this.mnuDevEntries.Size = new System.Drawing.Size(163, 22);
            this.mnuDevEntries.Text = "Desenvolvedores";
            this.mnuDevEntries.Click += new System.EventHandler(this.mnuDevEntries_Click);
            // 
            // mnuProjEntries
            // 
            this.mnuProjEntries.Name = "mnuProjEntries";
            this.mnuProjEntries.Size = new System.Drawing.Size(163, 22);
            this.mnuProjEntries.Text = "Projetos";
            this.mnuProjEntries.Click += new System.EventHandler(this.mnuProjEntries_Click);
            // 
            // mnuTask
            // 
            this.mnuTask.Name = "mnuTask";
            this.mnuTask.Size = new System.Drawing.Size(180, 22);
            this.mnuTask.Text = "Tarefa";
            this.mnuTask.Click += new System.EventHandler(this.mnuTask_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArchive;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuDeveloper;
        private System.Windows.Forms.ToolStripMenuItem mnuProject;
        private System.Windows.Forms.ToolStripMenuItem mnuEntries;
        private System.Windows.Forms.ToolStripMenuItem mnuDevEntries;
        private System.Windows.Forms.ToolStripMenuItem mnuProjEntries;
        private System.Windows.Forms.ToolStripMenuItem mnuAllocation;
        private System.Windows.Forms.ToolStripMenuItem mnuTask;
    }
}