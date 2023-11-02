using AirConditionBusiness.DTO;
using AirConditionBusiness.Models;
using DataAccess.Repository;
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
      
        private ISupplierCompanyRepository supplierCompanyRepository = new SupplierCompanyRepository();
        private IAirConditionerRepository airConditionerRepository = new AirConditionerRepository();

        private ErrorProvider errorDollarPrice = new ErrorProvider();
        private ErrorProvider errorQuantity = new ErrorProvider();
        private ErrorProvider errorAirConName = new ErrorProvider();
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
            if (string.IsNullOrEmpty(txtAirConditionName.Text) ||
                string.IsNullOrEmpty(txtWarrantly.Text) ||
                string.IsNullOrEmpty(txtSound.Text) ||
                string.IsNullOrEmpty(txtFeatueFunction.Text) ||
                string.IsNullOrEmpty(txtDollarPrice.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text)
                || string.IsNullOrEmpty(cbSupplierName.Text))
            {
                MessageBox.Show("Required all fields");
                return;

            }


            var supplierStr = cbSupplierName.SelectedItem.ToString();

            var arrSupplier = supplierStr.Split("-");
            var supplierId = arrSupplier[0];
            var supplierName = arrSupplier[1];

            SupplierCompany supplier = new SupplierCompany();
            supplier.SupplierId = supplierId;
            supplier.SupplierName = supplierName;

            var airConditioner = new AirConditioner();
            airConditioner.AirConditionerId = int.Parse(txtAirID.Text);
            airConditioner.AirConditionerName = txtAirConditionName.Text;
            airConditioner.Warranty = txtWarrantly.Text;
            airConditioner.DollarPrice = double.Parse(txtDollarPrice.Text);
            airConditioner.FeatureFunction = txtFeatueFunction.Text;
            airConditioner.SoundPressureLevel = txtSound.Text;
            airConditioner.Quantity = int.Parse(txtQuantity.Text);
            airConditioner.SupplierId = supplierId;

            if (isValidAirConditioner(airConditioner))
            {
                airConditionerRepository.create(airConditioner);
                MessageBox.Show("Save Successfully!");
            }

        }

        private Boolean isValidAirConditioner(AirConditioner airConditioner)
        {

            return isValidConditionName(txtAirConditionName.Text) 
                && isValidDollarPriceOrQuantity(txtDollarPrice.Text)
                && isValidDollarPriceOrQuantity(txtQuantity.Text) ? true : false;
        }

        private Boolean isValidConditionName(string name)
        {

            return Enumerable.Range(5, 90).Contains(name.Length)
                && Char.IsUpper(name.First()) ? true : false;

        }



        private void txtAirConditionName_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "length 5 – 90,Each word must begin with the capital letter";
            if (!isValidConditionName(txtAirConditionName.Text))
            {

                this.errorAirConName.SetError(txtAirConditionName, errorMessage);
            }
            else
            {

                errorAirConName.SetError(txtAirConditionName, "");

            }


        }

        private void txtWarrantly_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = "Quantity greater than or equal to 0 and less than 4 000 000";
            if (!isValidDollarPriceOrQuantity(txtQuantity.Text))
            {

                this.errorQuantity.SetError(txtQuantity, errorMessage);
            }
            else
            {

                errorQuantity.SetError(txtQuantity, "");

            }

        }

        private void NewItem_Load(object sender, EventArgs e)
        {


            var supplierCompanies = supplierCompanyRepository.GetAll();

            supplierCompanies.ForEach(company =>
            {
                cbSupplierName.Items.Add(company.SupplierId + "-" + company.SupplierName);
            });




        }

        private void txtDollarPrice_Validating(object sender, CancelEventArgs e)
        {
            
            string errorMessage= "DollarPrice greater than or equal to 0 and less than 4 000 000";
            if (!isValidDollarPriceOrQuantity(txtDollarPrice.Text))
            {

                this.errorDollarPrice.SetError(txtDollarPrice, errorMessage);
            }
            else
            {

                errorDollarPrice.SetError(txtDollarPrice, "");

            }
        }

        private Boolean isValidDollarPriceOrQuantity(string value)
        {
                return !string.IsNullOrEmpty(value) && !(double.Parse(value) < 0 ||
                double.Parse(value) == 4000000
               || double.Parse(value) > 4000000) ? true : false;
          
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAirID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDollarPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
    }

  
}
