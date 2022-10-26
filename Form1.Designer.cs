namespace RentalApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPropAgent = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.btnAgencies = new System.Windows.Forms.Button();
            this.btnProperties = new System.Windows.Forms.Button();
            this.btnPropType = new System.Windows.Forms.Button();
            this.btnSurbubs = new System.Windows.Forms.Button();
            this.btnCities = new System.Windows.Forms.Button();
            this.btnProvince = new System.Windows.Forms.Button();
            this.ucLogIn1 = new RentalApp.ucLogIn();
            this.ucAdmins1 = new RentalApp.ucAdmins();
            this.ucAgent1 = new RentalApp.ucAgent();
            this.ucCities1 = new RentalApp.ucCities();
            this.ucProperties1 = new RentalApp.ucProperties();
            this.ucPropertyAgent1 = new RentalApp.ucPropertyAgent();
            this.ucPropertyType1 = new RentalApp.ucPropertyType();
            this.ucProvince1 = new RentalApp.ucProvince();
            this.ucRental1 = new RentalApp.ucRental();
            this.ucSignUp1 = new RentalApp.ucSignUp();
            this.ucSurburbs1 = new RentalApp.ucSurburbs();
            this.ucTenant1 = new RentalApp.ucTenant();
            this.usAgencies1 = new RentalApp.usAgencies();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSurbubs);
            this.groupBox1.Controls.Add(this.btnCities);
            this.groupBox1.Controls.Add(this.btnProvince);
            this.groupBox1.Controls.Add(this.btnPropAgent);
            this.groupBox1.Controls.Add(this.ucLogIn1);
            this.groupBox1.Controls.Add(this.ucAdmins1);
            this.groupBox1.Controls.Add(this.ucAgent1);
            this.groupBox1.Controls.Add(this.ucCities1);
            this.groupBox1.Controls.Add(this.ucProperties1);
            this.groupBox1.Controls.Add(this.ucPropertyAgent1);
            this.groupBox1.Controls.Add(this.ucPropertyType1);
            this.groupBox1.Controls.Add(this.ucProvince1);
            this.groupBox1.Controls.Add(this.ucRental1);
            this.groupBox1.Controls.Add(this.ucSignUp1);
            this.groupBox1.Controls.Add(this.ucSurburbs1);
            this.groupBox1.Controls.Add(this.ucTenant1);
            this.groupBox1.Controls.Add(this.usAgencies1);
            this.groupBox1.Controls.Add(this.btnAdmin);
            this.groupBox1.Controls.Add(this.btnRental);
            this.groupBox1.Controls.Add(this.btnTenant);
            this.groupBox1.Controls.Add(this.btnAgent);
            this.groupBox1.Controls.Add(this.btnAgencies);
            this.groupBox1.Controls.Add(this.btnProperties);
            this.groupBox1.Controls.Add(this.btnPropType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 622);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnPropAgent
            // 
            this.btnPropAgent.Location = new System.Drawing.Point(27, 515);
            this.btnPropAgent.Name = "btnPropAgent";
            this.btnPropAgent.Size = new System.Drawing.Size(176, 32);
            this.btnPropAgent.TabIndex = 25;
            this.btnPropAgent.Text = "Property Agent";
            this.btnPropAgent.UseVisualStyleBackColor = true;
            this.btnPropAgent.Click += new System.EventHandler(this.btnPropAgent_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(27, 51);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(176, 30);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(27, 565);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(176, 30);
            this.btnRental.TabIndex = 9;
            this.btnRental.Text = "Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.Location = new System.Drawing.Point(27, 461);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(176, 30);
            this.btnTenant.TabIndex = 7;
            this.btnTenant.Text = "Tenant";
            this.btnTenant.UseVisualStyleBackColor = true;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.Location = new System.Drawing.Point(27, 408);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(176, 30);
            this.btnAgent.TabIndex = 6;
            this.btnAgent.Text = "Agent";
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnAgencies
            // 
            this.btnAgencies.Location = new System.Drawing.Point(27, 357);
            this.btnAgencies.Name = "btnAgencies";
            this.btnAgencies.Size = new System.Drawing.Size(176, 30);
            this.btnAgencies.TabIndex = 5;
            this.btnAgencies.Text = "Agencies";
            this.btnAgencies.UseVisualStyleBackColor = true;
            this.btnAgencies.Click += new System.EventHandler(this.btnAgencies_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(27, 301);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(176, 30);
            this.btnProperties.TabIndex = 1;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // btnPropType
            // 
            this.btnPropType.Location = new System.Drawing.Point(27, 91);
            this.btnPropType.Name = "btnPropType";
            this.btnPropType.Size = new System.Drawing.Size(176, 30);
            this.btnPropType.TabIndex = 0;
            this.btnPropType.Text = "Property Type";
            this.btnPropType.UseVisualStyleBackColor = true;
            this.btnPropType.Click += new System.EventHandler(this.btnPropType_Click);
            // 
            // btnSurbubs
            // 
            this.btnSurbubs.Location = new System.Drawing.Point(27, 245);
            this.btnSurbubs.Name = "btnSurbubs";
            this.btnSurbubs.Size = new System.Drawing.Size(176, 30);
            this.btnSurbubs.TabIndex = 28;
            this.btnSurbubs.Text = "Surbubs";
            this.btnSurbubs.UseVisualStyleBackColor = true;
            this.btnSurbubs.Click += new System.EventHandler(this.btnSurbubs_Click_1);
            // 
            // btnCities
            // 
            this.btnCities.Location = new System.Drawing.Point(27, 195);
            this.btnCities.Name = "btnCities";
            this.btnCities.Size = new System.Drawing.Size(176, 30);
            this.btnCities.TabIndex = 27;
            this.btnCities.Text = "Cities";
            this.btnCities.UseVisualStyleBackColor = true;
            this.btnCities.Click += new System.EventHandler(this.btnCities_Click_1);
            // 
            // btnProvince
            // 
            this.btnProvince.Location = new System.Drawing.Point(27, 140);
            this.btnProvince.Name = "btnProvince";
            this.btnProvince.Size = new System.Drawing.Size(176, 30);
            this.btnProvince.TabIndex = 26;
            this.btnProvince.Text = "Province";
            this.btnProvince.UseVisualStyleBackColor = true;
            this.btnProvince.Click += new System.EventHandler(this.btnProvince_Click_1);
            // 
            // ucLogIn1
            // 
            this.ucLogIn1.Location = new System.Drawing.Point(231, 9);
            this.ucLogIn1.Name = "ucLogIn1";
            this.ucLogIn1.Size = new System.Drawing.Size(930, 613);
            this.ucLogIn1.TabIndex = 24;
            // 
            // ucAdmins1
            // 
            this.ucAdmins1.Location = new System.Drawing.Point(250, 59);
            this.ucAdmins1.Name = "ucAdmins1";
            this.ucAdmins1.Size = new System.Drawing.Size(845, 544);
            this.ucAdmins1.TabIndex = 23;
            // 
            // ucAgent1
            // 
            this.ucAgent1.Location = new System.Drawing.Point(250, 67);
            this.ucAgent1.Name = "ucAgent1";
            this.ucAgent1.Size = new System.Drawing.Size(854, 544);
            this.ucAgent1.TabIndex = 22;
            // 
            // ucCities1
            // 
            this.ucCities1.Location = new System.Drawing.Point(258, 67);
            this.ucCities1.Name = "ucCities1";
            this.ucCities1.Size = new System.Drawing.Size(854, 544);
            this.ucCities1.TabIndex = 21;
            // 
            // ucProperties1
            // 
            this.ucProperties1.Location = new System.Drawing.Point(250, 59);
            this.ucProperties1.Name = "ucProperties1";
            this.ucProperties1.Size = new System.Drawing.Size(854, 544);
            this.ucProperties1.TabIndex = 20;
            // 
            // ucPropertyAgent1
            // 
            this.ucPropertyAgent1.Location = new System.Drawing.Point(258, 67);
            this.ucPropertyAgent1.Name = "ucPropertyAgent1";
            this.ucPropertyAgent1.Size = new System.Drawing.Size(854, 544);
            this.ucPropertyAgent1.TabIndex = 19;
            // 
            // ucPropertyType1
            // 
            this.ucPropertyType1.Location = new System.Drawing.Point(250, 59);
            this.ucPropertyType1.Name = "ucPropertyType1";
            this.ucPropertyType1.Size = new System.Drawing.Size(854, 544);
            this.ucPropertyType1.TabIndex = 18;
            // 
            // ucProvince1
            // 
            this.ucProvince1.Location = new System.Drawing.Point(242, 51);
            this.ucProvince1.Name = "ucProvince1";
            this.ucProvince1.Size = new System.Drawing.Size(854, 544);
            this.ucProvince1.TabIndex = 17;
            // 
            // ucRental1
            // 
            this.ucRental1.Location = new System.Drawing.Point(242, 51);
            this.ucRental1.Name = "ucRental1";
            this.ucRental1.Size = new System.Drawing.Size(854, 544);
            this.ucRental1.TabIndex = 16;
            // 
            // ucSignUp1
            // 
            this.ucSignUp1.Location = new System.Drawing.Point(242, 59);
            this.ucSignUp1.Name = "ucSignUp1";
            this.ucSignUp1.Size = new System.Drawing.Size(854, 544);
            this.ucSignUp1.TabIndex = 15;
            // 
            // ucSurburbs1
            // 
            this.ucSurburbs1.Location = new System.Drawing.Point(258, 67);
            this.ucSurburbs1.Name = "ucSurburbs1";
            this.ucSurburbs1.Size = new System.Drawing.Size(854, 544);
            this.ucSurburbs1.TabIndex = 14;
            // 
            // ucTenant1
            // 
            this.ucTenant1.Location = new System.Drawing.Point(250, 59);
            this.ucTenant1.Name = "ucTenant1";
            this.ucTenant1.Size = new System.Drawing.Size(854, 544);
            this.ucTenant1.TabIndex = 13;
            // 
            // usAgencies1
            // 
            this.usAgencies1.Location = new System.Drawing.Point(242, 51);
            this.usAgencies1.Name = "usAgencies1";
            this.usAgencies1.Size = new System.Drawing.Size(854, 544);
            this.usAgencies1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 646);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnAgencies;
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button btnPropType;
        private ucLogIn ucLogIn1;
        private ucAdmins ucAdmins1;
        private ucAgent ucAgent1;
        private ucCities ucCities1;
        private ucProperties ucProperties1;
        private ucPropertyAgent ucPropertyAgent1;
        private ucPropertyType ucPropertyType1;
        private ucProvince ucProvince1;
        private ucRental ucRental1;
        private ucSignUp ucSignUp1;
        private ucSurburbs ucSurburbs1;
        private ucTenant ucTenant1;
        private usAgencies usAgencies1;
        private System.Windows.Forms.Button btnPropAgent;
        private System.Windows.Forms.Button btnSurbubs;
        private System.Windows.Forms.Button btnCities;
        private System.Windows.Forms.Button btnProvince;
    }
}

