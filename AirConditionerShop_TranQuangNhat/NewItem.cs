using AirConditionBusiness.DTO;
using AirConditionBusiness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirConditionerShop_TranQuangNhat
{
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private Boolean isValidAirConditioner(AirConditionerDTO airConditionerDTO)
        {

            return false;
        }

        private void txtAirConditionName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAirConditionName.Text))
            {
                e.Cancel = true;
            }

        }

        private void txtWarrantly_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtDollarPrice_Validated(object sender, EventArgs e)
        {

        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {

        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            messAir.Hide();
            messDollar.Hide();
            messQuantity.Hide();
            messFeature.Hide();
            messWarr.Hide();
            messSound.Hide();
           

        }
    }
}
