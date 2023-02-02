namespace DeveloperAllocationMVP.Forms
{
    partial class frmTask
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTask = new System.Windows.Forms.ListBox();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblAllocation = new System.Windows.Forms.Label();
            this.lstAllocation = new System.Windows.Forms.ListBox();
            this.txtAllocation = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.lstTask);
            this.pnlMain.Controls.Add(this.txtTask);
            this.pnlMain.Controls.Add(this.lblAllocation);
            this.pnlMain.Controls.Add(this.lstAllocation);
            this.pnlMain.Controls.Add(this.txtAllocation);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(291, 407);
            this.pnlMain.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(168, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 27);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTask
            // 
            this.lstTask.FormattingEnabled = true;
            this.lstTask.Location = new System.Drawing.Point(44, 276);
            this.lstTask.Name = "lstTask";
            this.lstTask.Size = new System.Drawing.Size(208, 95);
            this.lstTask.TabIndex = 5;
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(44, 249);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(208, 21);
            this.txtTask.TabIndex = 4;
            // 
            // lblAllocation
            // 
            this.lblAllocation.AutoSize = true;
            this.lblAllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocation.Location = new System.Drawing.Point(12, 172);
            this.lblAllocation.Name = "lblAllocation";
            this.lblAllocation.Size = new System.Drawing.Size(142, 15);
            this.lblAllocation.TabIndex = 3;
            this.lblAllocation.Text = "Desenvolvedor: / Projeto:";
            // 
            // lstAllocation
            // 
            this.lstAllocation.FormattingEnabled = true;
            this.lstAllocation.Location = new System.Drawing.Point(44, 74);
            this.lstAllocation.Name = "lstAllocation";
            this.lstAllocation.Size = new System.Drawing.Size(208, 95);
            this.lstAllocation.TabIndex = 2;
            this.lstAllocation.DoubleClick += new System.EventHandler(this.lstAllocation_DoubleClick);
            // 
            // txtAllocation
            // 
            this.txtAllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllocation.Location = new System.Drawing.Point(44, 47);
            this.txtAllocation.Name = "txtAllocation";
            this.txtAllocation.Size = new System.Drawing.Size(208, 21);
            this.txtAllocation.TabIndex = 1;
            this.txtAllocation.TextChanged += new System.EventHandler(this.txtAllocation_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(67, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Criação de Tarefas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Insira a tarefa aqui:";
            // 
            // frmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 407);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmTask";
            this.Text = "Criação de Tarefas";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ListBox lstTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label lblAllocation;
        private System.Windows.Forms.ListBox lstAllocation;
        private System.Windows.Forms.TextBox txtAllocation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}