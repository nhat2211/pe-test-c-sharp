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

    public partial class frmAirConditionerManage : Form
    {
        private AirConditionerRepository airConditionerRepository = new AirConditionerRepository();
        private BindingSource airSource;
        public frmAirConditionerManage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadAirCondition()
        {

            var airs = airConditionerRepository.findAll();
            //foreach (var air in airs)
            //{
            //    txtSuppId.Text = air.Supplier.SupplierId;

            //    ;                air.Supplier.SupplierName
            //}
            airSource = new BindingSource();

            airSource.DataSource = airs;

            txtAirConditionId.DataBindings.Clear();
            txtAirConditionName.DataBindings.Clear();
            txtWarrantly.DataBindings.Clear();
            txtSoundPress.DataBindings.Clear();
            txtFeatFun.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtDollar.DataBindings.Clear();
            txtSuppId.DataBindings.Clear();
            txtSupplyName.DataBindings.Clear();


            txtAirConditionName.DataBindings.Add("Text", airSource, "AirConditionerName");
            txtAirConditionId.DataBindings.Add("Text", airSource, "AirConditionerId");
            txtWarrantly.DataBindings.Add("Text", airSource, "Warranty");
            txtSoundPress.DataBindings.Add("Text", airSource, "SoundPressureLevel");
            txtFeatFun.DataBindings.Add("Text", airSource, "FeatureFunction");
            txtQuantity.DataBindings.Add("Text", airSource, "Quantity");
            txtDollar.DataBindings.Add("Text", airSource, "DollarPrice");

            dgvAirCon.DataSource = null;
            dgvAirCon.DataSource = airSource;

        }

        private void frmAirConditionerManage_Load(object sender, EventArgs e)
        {
            loadAirCondition();
        }

        private void dgvAirCon_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txtAirConditionName.Text);
            AirConditioner airConditioner = airConditionerRepository.findById(int.Parse(txtAirConditionId.Text));
            var supplyCompany = airConditionerRepository.findCompanyByAirConditoner(airConditioner.SupplierId);

            txtSuppId.Text = supplyCompany.SupplierId;
            txtSupplyName.Text = supplyCompany.SupplierName;


        }
    }
}
