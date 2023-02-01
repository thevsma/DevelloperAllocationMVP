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
            this.lstProject = new System.Windows.Forms.ListBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lstDeveloper = new System.Windows.Forms.ListBox();
            this.txtDeveloper = new System.Windows.Forms.TextBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelectedDev = new System.Windows.Forms.Label();
            this.lblSelectedProj = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblFinish = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.lblHours = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtPay);
            this.panel1.Controls.Add(this.lblPay);
            this.panel1.Controls.Add(this.numHours);
            this.panel1.Controls.Add(this.lblHours);
            this.panel1.Controls.Add(this.dtpFinish);
            this.panel1.Controls.Add(this.lblFinish);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.lblSelectedProj);
            this.panel1.Controls.Add(this.lblSelectedDev);
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
            this.panel1.Size = new System.Drawing.Size(562, 351);
            this.panel1.TabIndex = 0;
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.Location = new System.Drawing.Point(405, 67);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(120, 95);
            this.lstProject.TabIndex = 6;
            this.lstProject.DoubleClick += new System.EventHandler(this.lstProject_DoubleClick);
            // 
            // txtProject
            // 
            this.txtProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProject.Location = new System.Drawing.Point(405, 40);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(120, 21);
            this.txtProject.TabIndex = 5;
            this.txtProject.TextChanged += new System.EventHandler(this.txtProject_TextChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(336, 38);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(63, 20);
            this.lblProject.TabIndex = 4;
            this.lblProject.Text = "Projeto:";
            // 
            // lstDeveloper
            // 
            this.lstDeveloper.FormattingEnabled = true;
            this.lstDeveloper.Location = new System.Drawing.Point(136, 65);
            this.lstDeveloper.Name = "lstDeveloper";
            this.lstDeveloper.Size = new System.Drawing.Size(120, 95);
            this.lstDeveloper.TabIndex = 3;
            this.lstDeveloper.DoubleClick += new System.EventHandler(this.lstDeveloper_DoubleClick);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(189, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Criação de Alocação";
            // 
            // lblSelectedDev
            // 
            this.lblSelectedDev.AutoSize = true;
            this.lblSelectedDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDev.Location = new System.Drawing.Point(13, 163);
            this.lblSelectedDev.Name = "lblSelectedDev";
            this.lblSelectedDev.Size = new System.Drawing.Size(161, 15);
            this.lblSelectedDev.TabIndex = 7;
            this.lblSelectedDev.Text = "Desenvolvedor selecionado:";
            // 
            // lblSelectedProj
            // 
            this.lblSelectedProj.AutoSize = true;
            this.lblSelectedProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProj.Location = new System.Drawing.Point(337, 165);
            this.lblSelectedProj.Name = "lblSelectedProj";
            this.lblSelectedProj.Size = new System.Drawing.Size(119, 15);
            this.lblSelectedProj.TabIndex = 8;
            this.lblSelectedProj.Text = "Projeto selecionado:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(32, 224);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(50, 20);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "Início:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(88, 223);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(187, 20);
            this.dtpStart.TabIndex = 10;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(12, 255);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(70, 20);
            this.lblFinish.TabIndex = 11;
            this.lblFinish.Text = "Término:";
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(88, 255);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(187, 20);
            this.dtpFinish.TabIndex = 12;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(336, 224);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(56, 20);
            this.lblHours.TabIndex = 13;
            this.lblHours.Text = "Horas:";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(398, 224);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(127, 20);
            this.numHours.TabIndex = 14;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(362, 250);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(30, 20);
            this.lblPay.TabIndex = 15;
            this.lblPay.Text = "R$";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(398, 250);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(127, 20);
            this.txtPay.TabIndex = 16;
            this.txtPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPay_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(438, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 32);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 351);
            this.Controls.Add(this.panel1);
            this.Name = "frmAllocation";
            this.Text = "Criação de Alocação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
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
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblSelectedProj;
        private System.Windows.Forms.Label lblSelectedDev;
        private System.Windows.Forms.Button btnSave;
    }
}