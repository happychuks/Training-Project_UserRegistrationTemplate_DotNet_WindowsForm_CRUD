using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDatabase
{
    public partial class Form1 : Form
    {

        TraineeDataClass traineeDataClass = new TraineeDataClass();
        TraineeInfo traineeInfo = new TraineeInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void bttnInsertStm_Click(object sender, EventArgs e)
        {
            traineeInfo.TraineeID = Convert.ToInt32(txtTraineeID.Text);
            traineeInfo.Surname = txtSurname.Text;
            traineeInfo.OtherNames = txtOtherNames.Text;
            traineeInfo.Gender = comboBoxGender.Text;
            traineeInfo.MobileNo = txtMobileNo.Text;
            traineeInfo.Email = txtEmail.Text;
            traineeInfo.Address = txtResidAdd.Text;
            traineeInfo.DateEmployed = Convert.ToDateTime(txtDEmp.Value);
            traineeInfo.DateOfBirth = Convert.ToDateTime(txtDOB.Value);
            traineeInfo.DateCreated = DateTime.Now;
            traineeDataClass.InsertEmployeeDetails( traineeInfo );
            clear();

            bttnReadStm.PerformClick();

        }
        void clear()
        {
            txtTraineeID.Text = String.Empty;
            txtResidAdd.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtOtherNames.Text = String.Empty;
            txtSurname.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtDOB.Value = DateTime.Today;
            txtDEmp.Value = DateTime.Today;
            comboBoxGender.Text = String.Empty;
        }

        private void bttnReadStm_Click(object sender, EventArgs e)
        {
            dgView.DataSource = traineeDataClass.ReadEmployeeDetails();
        }

        private void bttnCustomRead_Click(object sender, EventArgs e)
            
        {
            
            dgView.DataSource = traineeDataClass.ReadEmployeeDetails(txtTraineeID.Text);
        }

        private void bttnUpdStm_Click(object sender, EventArgs e)
        {

            traineeInfo.TraineeID = Convert.ToInt32(txtTraineeID.Text);
            traineeInfo.Surname = txtSurname.Text;
            traineeInfo.OtherNames = txtOtherNames.Text;
            traineeInfo.Gender = comboBoxGender.Text;
            traineeInfo.MobileNo = txtMobileNo.Text;
            traineeInfo.Email = txtEmail.Text;
            traineeInfo.Address = txtResidAdd.Text;
            traineeInfo.DateEmployed = Convert.ToDateTime(txtDEmp.Value);
            traineeInfo.DateOfBirth = Convert.ToDateTime(txtDOB.Value);


            traineeDataClass.UpdateEmployeeDetails(traineeInfo);
            clear();
            bttnReadStm.PerformClick();
           

        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            int row = dgView.CurrentCell.RowIndex;
            txtTraineeID.Text = dgView.Rows[row].Cells[0].Value.ToString();
            txtSurname.Text = dgView.Rows[row].Cells[1].Value.ToString();
            txtOtherNames.Text = dgView.Rows[row].Cells[2].Value.ToString();
            comboBoxGender.Text = dgView.Rows[row].Cells[3].Value.ToString();
            txtMobileNo.Text = dgView.Rows[row].Cells[4].Value.ToString();
            txtEmail.Text = dgView.Rows[row].Cells[5].Value.ToString();
            txtResidAdd.Text = dgView.Rows[row].Cells[6].Value.ToString();
            txtDEmp.Text = dgView.Rows[row].Cells[7].Value.ToString();
            txtDOB.Text = dgView.Rows[row].Cells[8].Value.ToString();
        }
           
        private void bttnDltStm_Click(object sender, EventArgs e)
        {
            traineeInfo.TraineeID = Convert.ToInt32(txtTraineeID.Text);
            traineeInfo.Surname = txtSurname.Text;
            traineeInfo.OtherNames = txtOtherNames.Text;
            traineeInfo.Gender = comboBoxGender.Text;
            traineeInfo.MobileNo = txtMobileNo.Text;
            traineeInfo.Email = txtEmail.Text;
            traineeInfo.Address = txtResidAdd.Text;
            traineeInfo.DateEmployed = Convert.ToDateTime(txtDEmp.Value);
            traineeInfo.DateOfBirth = Convert.ToDateTime(txtDOB.Value);


            traineeDataClass.DELETEEmployeeDetails(traineeInfo);
            clear();

            bttnReadStm.PerformClick();
           
        }

       
    }
}

