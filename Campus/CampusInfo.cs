using Business;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campus
{
    public partial class CampusInfo : Form
    {
        public CampusInfo()
        {
            InitializeComponent();
        }

        private void dgvCampus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCampus.Rows[e.RowIndex];
                row.Selected = true;
                txtCampusId.Text = row.Cells[0].Value.ToString();
                txtCampusName.Text = row.Cells[1].Value.ToString();
                txtCampusAddress.Text = row.Cells[2].Value.ToString();
                txtCampusEmail.Text = row.Cells[3].Value.ToString();
                txtCampusWebsite.Text = row.Cells[4].Value.ToString();
                

            }
        }

        private void CampusInfo_Load(object sender, EventArgs e)
        {
            ShowRecord();
        }
        public void SaveCampus()
        {
            CampusEntity entity = new CampusEntity();
            entity.CampusName = txtCampusName.Text;
            entity.CampusAddress = txtCampusAddress.Text;
            entity.CampusEmail = txtCampusEmail.Text;
            entity.CampusWebsite = txtCampusWebsite.Text;
        


            CampusBusiness obj = new CampusBusiness();
            obj.SaveCampus(entity);
        }
        public void DeleteCampus (int CampusId )
        {
            CampusInfo bal = new CampusInfo();

            bal.DeleteCampus(CampusId);
        }



       

      

     

      



    

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CampusEntity entity = new CampusEntity();
            entity.CampusId = Convert.ToInt32(txtCampusId.Text);
            entity.CampusName = txtCampusName.Text;
            entity.CampusAddress = txtCampusAddress.Text;
            entity.CampusEmail = txtCampusEmail.Text;
            entity.CampusWebsite = txtCampusWebsite.Text;



            CampusBusiness obj = new CampusBusiness();
            obj.UpdateCampus(entity);

            ShowRecord();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveCompany();
            ShowRecord();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteCampus(Convert.ToInt32(txtCampusId.Text));

            ShowRecord();
            clear();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            frmmain.Show();
            this.Hide();
        }
    }





    public void clear()
        {
            txtCampusId.Text = "";
            txtCampusName.Text = "";
            txtCampusAddress.Text = "";
            txtCompanyCity.Text = "";
            txtCompanyWebsite.Text = "";
            txtCompanyEmail.Text = "";

        }
        public void ShowRecord()
        {
            CompanyBusiness bal = new CompanyBusiness();

            DataTable CompanyTable = bal.GetCompany();

            dgvCompany.DataSource = CompanyTable;

            if (dgvCompany.Rows.Count > 0)
            {
                dgvCompany.Rows[0].Selected = true;
            }

        }
    
}
