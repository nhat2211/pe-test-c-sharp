using AirConditionBusiness.Models;
using DataAccess.enums;
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
            var authenStaff = authenticate(txtEmail.Text, txtPassword.Text);

            if (authenStaff == null)
            {
                //You have no permission to access this function
                MessageBox.Show("Login fail!");

            }else if (authenStaff != null && !authenStaff.Role.Equals((int)Roles.Administrator))
            {
                MessageBox.Show("You have no permission to access this function");
            }
            else if (authenStaff.Role.Equals((int)Roles.Administrator))
            {
                this.Hide();
                frmAirConditionerManage frmAirConditionerManage = new frmAirConditionerManage();
                frmAirConditionerManage.ShowDialog();
                this.Close();
            }



        }

        private StaffMember authenticate(string username, string password)
        {
            return staffMember.findStaffByEmailAndPassword(username, password);
         
        }

        private Boolean authorized(StaffMember staff)
        {
           return staff.Role.Equals((int)Roles.Administrator) ? true : false;
        }

      

      
    }
}