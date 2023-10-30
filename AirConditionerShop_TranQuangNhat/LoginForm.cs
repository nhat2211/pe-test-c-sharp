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
                MessageBox.Show("You have no permission to access this function!");

            }
            else
            {
                this.Hide();
                frmAirConditionerManage frmAirConditionerManage = new frmAirConditionerManage(authorized(authenStaff));
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