using System.Globalization;

namespace Campus
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CampusInfo form2 = new CampusInfo();
            form2.Show();
            this.Hide();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            Department form2 = new Department();
            form2.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

            Student form2 = new Student();
            form2.Show();
            this.Hide();
        }
    }
}