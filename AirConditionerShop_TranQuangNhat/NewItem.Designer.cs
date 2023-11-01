namespace AirConditionerShop_TranQuangNhat
{
    partial class NewItem
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
            cbSupplierName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtAirConditionName = new TextBox();
            label3 = new Label();
            txtWarrantly = new TextBox();
            label4 = new Label();
            txtSound = new TextBox();
            label5 = new Label();
            txtFeatueFunction = new TextBox();
            btnSave = new Button();
            txtDollarPrice = new TextBox();
            txtQuantity = new TextBox();
            label6 = new Label();
            label7 = new Label();
            messAir = new Label();
            messWarr = new Label();
            messSound = new Label();
            messFeature = new Label();
            messDollar = new Label();
            messQuantity = new Label();
            txtAirID = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // cbSupplierName
            // 
            cbSupplierName.FormattingEnabled = true;
            cbSupplierName.Location = new Point(246, 48);
            cbSupplierName.Name = "cbSupplierName";
            cbSupplierName.Size = new Size(151, 28);
            cbSupplierName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "SupplierName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 129);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 2;
            label2.Text = "AirConditionName";
            // 
            // txtAirConditionName
            // 
            txtAirConditionName.Location = new Point(246, 129);
            txtAirConditionName.Name = "txtAirConditionName";
            txtAirConditionName.Size = new Size(151, 27);
            txtAirConditionName.TabIndex = 3;
            txtAirConditionName.Validating += txtAirConditionName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 211);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Warrantly";
            // 
            // txtWarrantly
            // 
            txtWarrantly.Location = new Point(246, 204);
            txtWarrantly.Name = "txtWarrantly";
            txtWarrantly.Size = new Size(151, 27);
            txtWarrantly.TabIndex = 5;
            txtWarrantly.TextChanged += textBox2_TextChanged;
            txtWarrantly.Validating += txtWarrantly_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 294);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 6;
            label4.Text = "SoundPressureLevel";
            // 
            // txtSound
            // 
            txtSound.Location = new Point(246, 294);
            txtSound.Name = "txtSound";
            txtSound.Size = new Size(151, 27);
            txtSound.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 375);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 8;
            label5.Text = "FeatureFunction";
            // 
            // txtFeatueFunction
            // 
            txtFeatueFunction.Location = new Point(246, 375);
            txtFeatueFunction.Name = "txtFeatueFunction";
            txtFeatueFunction.Size = new Size(151, 27);
            txtFeatueFunction.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(284, 455);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDollarPrice
            // 
            txtDollarPrice.Location = new Point(780, 44);
            txtDollarPrice.Name = "txtDollarPrice";
            txtDollarPrice.Size = new Size(125, 27);
            txtDollarPrice.TabIndex = 11;
            txtDollarPrice.Validated += txtDollarPrice_Validated;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(780, 118);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 12;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 52);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 13;
            label6.Text = "Dollar Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(632, 132);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 14;
            label7.Text = "Quantity";
            // 
            // messAir
            // 
            messAir.AutoSize = true;
            messAir.Location = new Point(429, 132);
            messAir.Name = "messAir";
            messAir.Size = new Size(50, 20);
            messAir.TabIndex = 16;
            messAir.Text = "label9";
            // 
            // messWarr
            // 
            messWarr.AutoSize = true;
            messWarr.Location = new Point(429, 207);
            messWarr.Name = "messWarr";
            messWarr.Size = new Size(58, 20);
            messWarr.TabIndex = 17;
            messWarr.Text = "label10";
            // 
            // messSound
            // 
            messSound.AutoSize = true;
            messSound.Location = new Point(429, 297);
            messSound.Name = "messSound";
            messSound.Size = new Size(50, 20);
            messSound.TabIndex = 18;
            messSound.Text = "label8";
            // 
            // messFeature
            // 
            messFeature.AutoSize = true;
            messFeature.Location = new Point(429, 382);
            messFeature.Name = "messFeature";
            messFeature.Size = new Size(58, 20);
            messFeature.TabIndex = 19;
            messFeature.Text = "label11";
            // 
            // messDollar
            // 
            messDollar.AutoSize = true;
            messDollar.Location = new Point(949, 48);
            messDollar.Name = "messDollar";
            messDollar.Size = new Size(58, 20);
            messDollar.TabIndex = 20;
            messDollar.Text = "label12";
            // 
            // messQuantity
            // 
            messQuantity.AutoSize = true;
            messQuantity.Location = new Point(949, 125);
            messQuantity.Name = "messQuantity";
            messQuantity.Size = new Size(58, 20);
            messQuantity.TabIndex = 21;
            messQuantity.Text = "label13";
            // 
            // txtAirID
            // 
            txtAirID.Location = new Point(780, 200);
            txtAirID.Name = "txtAirID";
            txtAirID.Size = new Size(125, 27);
            txtAirID.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(632, 207);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 23;
            label8.Text = "AirConditionerID";
            // 
            // NewItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 545);
            Controls.Add(label8);
            Controls.Add(txtAirID);
            Controls.Add(messQuantity);
            Controls.Add(messDollar);
            Controls.Add(messFeature);
            Controls.Add(messSound);
            Controls.Add(messWarr);
            Controls.Add(messAir);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtQuantity);
            Controls.Add(txtDollarPrice);
            Controls.Add(btnSave);
            Controls.Add(txtFeatueFunction);
            Controls.Add(label5);
            Controls.Add(txtSound);
            Controls.Add(label4);
            Controls.Add(txtWarrantly);
            Controls.Add(label3);
            Controls.Add(txtAirConditionName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSupplierName);
            Name = "NewItem";
            Text = "NewItem";
            Load += NewItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSupplierName;
        private Label label1;
        private Label label2;
        private TextBox txtAirConditionName;
        private Label label3;
        private TextBox txtWarrantly;
        private Label label4;
        private TextBox txtSound;
        private Label label5;
        private TextBox txtFeatueFunction;
        private Button btnSave;
        private TextBox txtDollarPrice;
        private TextBox txtQuantity;
        private Label label6;
        private Label label7;
        private Label messAir;
        private Label messWarr;
        private Label messSound;
        private Label messFeature;
        private Label messDollar;
        private Label messQuantity;
        private TextBox txtAirID;
        private Label label8;
    }
}