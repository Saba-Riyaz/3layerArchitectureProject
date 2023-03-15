using System.Globalization;

namespace Campus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CampusInfo form2 = new CampusInfo();
            form2.Show();
            this.Hide();
        }
    }
}