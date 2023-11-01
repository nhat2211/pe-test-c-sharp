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
        private static string REQUIRED = "Required";
        private ISupplierCompanyRepository supplierCompanyRepository = new SupplierCompanyRepository();
        private IAirConditionerRepository airConditionerRepository = new AirConditionerRepository();
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
                string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Required all fields");
                messAir.Show();
                messAir.Text = REQUIRED;
                messAir.ForeColor = Color.Red;
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
            airConditioner.DollarPrice = int.Parse(txtDollarPrice.Text);
            airConditioner.FeatureFunction = txtFeatueFunction.Text;
            airConditioner.SoundPressureLevel = txtSound.Text;
            airConditioner.Quantity = int.Parse(txtQuantity.Text);
            airConditioner.SupplierId = supplierId;

            airConditionerRepository.create(airConditioner);

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
                messAir.Show();
                messAir.Text = REQUIRED;
            }

        }

        private void txtWarrantly_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtDollarPrice_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDollarPrice.Text))
            {

            }


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

            var supplierCompanies = supplierCompanyRepository.GetAll();

            supplierCompanies.ForEach(company =>
            {
                cbSupplierName.Items.Add(company.SupplierId + "-" + company.SupplierName);
            });




        }
    }
}
