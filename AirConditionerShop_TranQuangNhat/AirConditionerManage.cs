using AirConditionBusiness.DTO;
using AirConditionBusiness.Mapper;
using AirConditionBusiness.Models;
using AutoMapper;
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
        private Boolean isAuthor;
        public frmAirConditionerManage()
        {
            InitializeComponent();
        }

        public frmAirConditionerManage(Boolean isAuthor)
        {
            InitializeComponent();
            this.isAuthor = isAuthor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadAirCondition(List<AirConditioner> airConditioners)
        {
            airSource = new BindingSource();
            if (airConditioners != null && airConditioners.Count == 0)
            {
                dgvAirCon.DataSource = null;
                return;
            }

            airConditioners = airConditioners == null ? airConditionerRepository.findAll() : airConditioners;
            var config = new MapperConfiguration(cfg =>
            {
                AirConditionerConfig.createMap(cfg);
            });

            var mapperAirCon = config.CreateMapper();

            var airDtos = airConditioners.Select(
                air => mapperAirCon
                .Map<AirConditioner, AirConditionerDTO>(air)
                );




            airSource.DataSource = airDtos;

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
            txtSupplyName.DataBindings.Add("Text", airSource, "SupplierName");

            dgvAirCon.DataSource = null;
            dgvAirCon.DataSource = airSource;

        }


        private void frmAirConditionerManage_Load(object sender, EventArgs e)
        {
            loadAirCondition(null);

        }

        private void dgvAirCon_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(txtAirConditionName.Text);
            AirConditioner airConditioner = airConditionerRepository.findById(int.Parse(txtAirConditionId.Text));
            var supplyCompany = airConditionerRepository.findCompanyByAirConditoner(airConditioner.SupplierId);

            txtSuppId.Text = supplyCompany.SupplierId;
            txtSupplyName.Text = supplyCompany.SupplierName;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var airs = airConditionerRepository.findByFeatureAndQuantity(txtFeaFunSearch.Text,
              string.IsNullOrEmpty(txtQuantitySearch.Text)
              ? -1 : int.Parse(txtQuantitySearch.Text));

            if (airs.Count == 0 || airs == null)
            {
                MessageBox.Show("Not Found!");
                loadAirCondition(new List<AirConditioner>());
                return;
            }
            loadAirCondition(airs);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to delete?";
            string title = "Delete Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                airConditionerRepository.delete(int.Parse(txtAirConditionId.Text));
                loadAirCondition(null);

            }
            else
            {
                return;
            }


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadAirCondition(null);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem();
            newItem.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            var airUpdate = airConditionerRepository.findById(int.Parse(txtAirConditionId.Text));

            NewItem updateForm = new NewItem(airUpdate);
            updateForm.Text = "Update";
            updateForm.ShowDialog();

        }
    }
}
