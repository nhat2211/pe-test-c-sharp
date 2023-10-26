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
            AirConditionerRepository airConditionerRepository = new AirConditionerRepository();
            var airs = airConditionerRepository.findAll();
            //foreach (var air in airs)
            //{
            //    txtSuppId.Text = air.Supplier.SupplierId;

            //    ;                air.Supplier.SupplierName
            //}
            airSource = new BindingSource();

            airSource.DataSource = airs;

            txtAirConditionName.DataBindings.Clear();
            txtWarrantly.DataBindings.Clear();
            txtSoundPress.DataBindings.Clear();
            txtFeatFun.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtDollar.DataBindings.Clear();
            txtSuppId.DataBindings.Clear();
            txtSupplyName.DataBindings.Clear();

            txtAirConditionName.DataBindings.Add("Text", airSource, "AirConditionerName");
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
            MessageBox.Show(txtAirConditionName.Text);
        }
    }
}
