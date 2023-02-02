using DeveloperAllocationMVP.Entities;
using DeveloperAllocationMVP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAllocationMVP.Forms
{
    public partial class frmTask : Form
    {
        private static frmTask _instance;
        public Allocation SelectedAllocation { get; set; }
        public frmTask()
        {
            InitializeComponent();
        }

        public static frmTask GetInstance()
        {
            if(_instance == null || _instance.IsDisposed) _instance = new frmTask();
            return _instance;
        }

        private void txtAllocation_TextChanged(object sender, EventArgs e)
        {
            lstAllocation.DataSource = AllocationRepository.FindByDevOrProj(txtAllocation.Text);
        }

        private void lstAllocation_DoubleClick(object sender, EventArgs e)
        {
            SelectedAllocation = (Allocation)lstAllocation.SelectedItem;
            lblAllocation.Text = String.Format("Desenvolvedor: {0} / Projeto: {1}", SelectedAllocation.Developer, SelectedAllocation.Project);
            lstTask.DataSource = TaskRepository.FindAllTasksByAlloc(SelectedAllocation.Id);
        }

        private void txtTask_Enter(object sender, EventArgs e)
        {
            txtTask.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectedAllocation.Id != 0)
            {
                if (txtTask.Text != null)
                {
                    ProjectTasks t = new ProjectTasks(txtTask.Text, SelectedAllocation.Id);
                    TaskRepository.Save(SelectedAllocation, t);

                    lstTask.DataSource = TaskRepository.FindAllTasksByAlloc(SelectedAllocation.Id);
                }
                else MessageBox.Show("Não há nenhuma tarefa descrita!");
            }
            else MessageBox.Show("Não há uma alocação selecionada!");
        }
    }
}
