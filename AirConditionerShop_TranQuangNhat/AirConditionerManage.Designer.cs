namespace AirConditionerShop_TranQuangNhat
{
    partial class frmAirConditionerManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAirConditionName = new TextBox();
            txtSoundPress = new TextBox();
            txtSuppId = new TextBox();
            txtDollar = new TextBox();
            txtFeatFun = new TextBox();
            txtQuantity = new TextBox();
            txtWarrantly = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvAirCon = new DataGridView();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label8 = new Label();
            txtSupplyName = new TextBox();
            txtAirConditionId = new TextBox();
            label9 = new Label();
            btnSearch = new Button();
            txtFeaFunSearch = new TextBox();
            txtQuantitySearch = new TextBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAirCon).BeginInit();
            SuspendLayout();
            // 
            // txtAirConditionName
            // 
            txtAirConditionName.Location = new Point(244, 40);
            txtAirConditionName.Name = "txtAirConditionName";
            txtAirConditionName.ReadOnly = true;
            txtAirConditionName.Size = new Size(125, 27);
            txtAirConditionName.TabIndex = 0;
            // 
            // txtSoundPress
            // 
            txtSoundPress.Location = new Point(244, 115);
            txtSoundPress.Name = "txtSoundPress";
            txtSoundPress.ReadOnly = true;
            txtSoundPress.Size = new Size(125, 27);
            txtSoundPress.TabIndex = 1;
            // 
            // txtSuppId
            // 
            txtSuppId.Enabled = false;
            txtSuppId.Location = new Point(244, 254);
            txtSuppId.Name = "txtSuppId";
            txtSuppId.ReadOnly = true;
            txtSuppId.Size = new Size(125, 27);
            txtSuppId.TabIndex = 2;
            // 
            // txtDollar
            // 
            txtDollar.Location = new Point(628, 186);
            txtDollar.Name = "txtDollar";
            txtDollar.ReadOnly = true;
            txtDollar.Size = new Size(125, 27);
            txtDollar.TabIndex = 3;
            // 
            // txtFeatFun
            // 
            txtFeatFun.Location = new Point(628, 111);
            txtFeatFun.Name = "txtFeatFun";
            txtFeatFun.ReadOnly = true;
            txtFeatFun.Size = new Size(125, 27);
            txtFeatFun.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(244, 190);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 5;
            // 
            // txtWarrantly
            // 
            txtWarrantly.Location = new Point(628, 36);
            txtWarrantly.Name = "txtWarrantly";
            txtWarrantly.ReadOnly = true;
            txtWarrantly.Size = new Size(125, 27);
            txtWarrantly.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 43);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 7;
            label1.Text = "AirConditionName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 8;
            label2.Text = "Warranty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 111);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 9;
            label3.Text = "SoundPressureLevel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 115);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "FeatureFunction";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 197);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 11;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(520, 193);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 12;
            label6.Text = "DollarPrice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 261);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 13;
            label7.Text = "SupplierId";
            // 
            // dgvAirCon
            // 
            dgvAirCon.AllowUserToAddRows = false;
            dgvAirCon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAirCon.Location = new Point(104, 416);
            dgvAirCon.Name = "dgvAirCon";
            dgvAirCon.RowHeadersWidth = 51;
            dgvAirCon.RowTemplate.Height = 29;
            dgvAirCon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAirCon.Size = new Size(922, 265);
            dgvAirCon.TabIndex = 14;
            dgvAirCon.SelectionChanged += dgvAirCon_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(440, 362);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 15;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(704, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(581, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(502, 261);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 19;
            label8.Text = "SupplierName";
            // 
            // txtSupplyName
            // 
            txtSupplyName.Enabled = false;
            txtSupplyName.Location = new Point(628, 254);
            txtSupplyName.Name = "txtSupplyName";
            txtSupplyName.ReadOnly = true;
            txtSupplyName.Size = new Size(125, 27);
            txtSupplyName.TabIndex = 18;
            // 
            // txtAirConditionId
            // 
            txtAirConditionId.Location = new Point(244, 312);
            txtAirConditionId.Name = "txtAirConditionId";
            txtAirConditionId.ReadOnly = true;
            txtAirConditionId.Size = new Size(125, 27);
            txtAirConditionId.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(92, 319);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 21;
            label9.Text = "AirConditionId";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(932, 175);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFeaFunSearch
            // 
            txtFeaFunSearch.Location = new Point(884, 55);
            txtFeaFunSearch.Name = "txtFeaFunSearch";
            txtFeaFunSearch.PlaceholderText = "FeatureFunction";
            txtFeaFunSearch.Size = new Size(175, 27);
            txtFeaFunSearch.TabIndex = 23;
            // 
            // txtQuantitySearch
            // 
            txtQuantitySearch.Location = new Point(884, 117);
            txtQuantitySearch.Name = "txtQuantitySearch";
            txtQuantitySearch.PlaceholderText = "Quantity";
            txtQuantitySearch.Size = new Size(175, 27);
            txtQuantitySearch.TabIndex = 24;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(306, 362);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 25;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmAirConditionerManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 705);
            Controls.Add(btnLoad);
            Controls.Add(txtQuantitySearch);
            Controls.Add(txtFeaFunSearch);
            Controls.Add(btnSearch);
            Controls.Add(label9);
            Controls.Add(txtAirConditionId);
            Controls.Add(label8);
            Controls.Add(txtSupplyName);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dgvAirCon);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWarrantly);
            Controls.Add(txtQuantity);
            Controls.Add(txtFeatFun);
            Controls.Add(txtDollar);
            Controls.Add(txtSuppId);
            Controls.Add(txtSoundPress);
            Controls.Add(txtAirConditionName);
            Name = "frmAirConditionerManage";
            Text = "AirConditionerManage";
            Load += frmAirConditionerManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAirCon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAirConditionName;
        private TextBox txtSoundPress;
        private TextBox txtSuppId;
        private TextBox txtDollar;
        private TextBox txtFeatFun;
        private TextBox txtQuantity;
        private TextBox txtWarrantly;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvAirCon;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label8;
        private TextBox txtSupplyName;
        private TextBox txtAirConditionId;
        private Label label9;
        private Button btnSearch;
        private TextBox txtFeaFunSearch;
        private TextBox txtQuantitySearch;
        private Button btnLoad;
    }
}