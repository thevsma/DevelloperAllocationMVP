﻿namespace DeveloperAllocationMVP.Forms
{
    partial class frmDevRegistration
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
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblActive = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbLevel);
            this.panel1.Controls.Add(this.txtConfirmPwd);
            this.panel1.Controls.Add(this.lblConfirmPwd);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cbActive);
            this.panel1.Controls.Add(this.lblActive);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.cbAdmin);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.dtpBirthday);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.lblPwd);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.lblBirthday);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 311);
            this.panel1.TabIndex = 0;
            // 
            // cbbLevel
            // 
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.Location = new System.Drawing.Point(173, 111);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(200, 21);
            this.cbbLevel.TabIndex = 8;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(173, 190);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(200, 21);
            this.txtConfirmPwd.TabIndex = 11;
            this.txtConfirmPwd.TextChanged += new System.EventHandler(this.txtConfirmPwd_TextChanged);
            this.txtConfirmPwd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPwd_KeyUp);
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPwd.Location = new System.Drawing.Point(34, 188);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(133, 20);
            this.lblConfirmPwd.TabIndex = 16;
            this.lblConfirmPwd.Text = "Confirmar Senha:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 20);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Cadastro de Desenvolvedores";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Location = new System.Drawing.Point(173, 237);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(15, 14);
            this.cbActive.TabIndex = 13;
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.Location = new System.Drawing.Point(114, 232);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(53, 20);
            this.lblActive.TabIndex = 13;
            this.lblActive.Text = "Ativo?";
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(265, 255);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 37);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(173, 217);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(15, 14);
            this.cbAdmin.TabIndex = 12;
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(173, 163);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(200, 21);
            this.txtPwd.TabIndex = 10;
            this.txtPwd.Click += new System.EventHandler(this.txtPwd_Click);
            this.txtPwd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyUp);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(173, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 21);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Location = new System.Drawing.Point(173, 85);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 21);
            this.dtpBirthday.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 21);
            this.txtName.TabIndex = 6;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(51, 212);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(116, 20);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Administrador?";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(107, 163);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(60, 20);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(115, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(121, 109);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Nível:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(9, 85);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(158, 20);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "Data de Nascimento:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(112, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // frmDevRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 311);
            this.Controls.Add(this.panel1);
            this.Name = "frmDevRegistration";
            this.Text = "Cadastro de Desenvolvedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.ComboBox cbbLevel;
    }
}