using DataAccess.Repository;

namespace AirConditionerShop_TranQuangNhat
{
    public partial class frmLogin : Form
    {
        private StaffMemberRepository staffMember = new StaffMemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!authenticate(txtEmail.Text, txtPassword.Text))
            {
                MessageBox.Show("Login Fail!");

            }
            else
            {
                this.Hide();
                frmAirConditionerManage frmAirConditionerManage = new frmAirConditionerManage();
                frmAirConditionerManage.ShowDialog();
                this.Close();
            }



        }

        private Boolean authenticate(string username, string password)
        {
            return staffMember.findStaffByEmailAndPassword(username, password) != null ?
                true : false;
        }
    }
}