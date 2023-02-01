using DeveloperAllocationMVP.Entities;
using DeveloperAllocationMVP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP.Forms
{
    public partial class frmAllocation : Form
    {
        private static frmAllocation _instance;
        public frmAllocation()
        {
            InitializeComponent();
        }

        public static frmAllocation GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmAllocation();
            return _instance;
        }

        private void txtDeveloper_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    lstDeveloper.DataSource = DeveloperRepository.FindByPartialName(txtDeveloper.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtProject_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using(Repository repos = new Repository())
                {
                    lstProject.DataSource = ProjectRepository.FindByPartialName(txtProject.Text);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //verifies if the typed characters are numeric/backspace - made by: https://youtu.be/noXo45-GFlo
        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty) w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))
                    w = w.Substring(0, w.Length - 1);
                else
                    w += e.KeyChar;

                t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void lstDeveloper_DoubleClick(object sender, EventArgs e)
        {
            lblSelectedDev.Text = String.Format("Desenvolvedor selecionado: {0}", lstDeveloper.SelectedItem);
        }

        private void lstProject_DoubleClick(object sender, EventArgs e)
        {
            lblSelectedProj.Text = String.Format("Projeto selecionado: {0}", lstProject.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lstDeveloper.SelectedItem != null && lstProject.SelectedItems != null)
            {
                if(numHours.Value > 0)
                {
                    Allocation a = new Allocation(dtpStart.Value, dtpFinish.Value, Convert.ToByte(numHours.Value), Convert.ToDecimal(txtPay.Text), (Developer)lstDeveloper.SelectedItem, (Project)lstProject.SelectedItem);

                    AllocationRepository.Save(a);

                    MessageBox.Show(String.Format("Alocação criada com sucesso!"));
                    txtDeveloper.Clear();
                    txtPay.Clear();
                    txtProject.Clear();
                    lstDeveloper.SelectedIndex = 0;
                    lstProject.SelectedIndex = 0;
                    numHours.Value = 0;
                }
            }
        }
    }
}
