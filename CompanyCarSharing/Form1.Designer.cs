namespace CompanyCarSharing;

partial class TheGreenMile
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tabControl1 = new TabControl();
        tbCars = new TabPage();
        label7 = new Label();
        tbFilterCars = new TextBox();
        btnDeleteCar = new Button();
        lbCars = new ListBox();
        gpCars = new GroupBox();
        nmrMaintenanceInterval = new NumericUpDown();
        label6 = new Label();
        tbLicencePlate = new TextBox();
        label5 = new Label();
        nmrCurrentMilage = new NumericUpDown();
        label4 = new Label();
        nmrEndOfLife = new NumericUpDown();
        label3 = new Label();
        tbCarModel = new TextBox();
        label2 = new Label();
        tbCarBrand = new TextBox();
        label1 = new Label();
        btnAddCar = new Button();
        tbEmployees = new TabPage();
        btnDeleteEmployee = new Button();
        lbEmployees = new ListBox();
        gpEmployees = new GroupBox();
        btnNewEmployee = new Button();
        tbEmail = new TextBox();
        label11 = new Label();
        tbLastName = new TextBox();
        label10 = new Label();
        tbFirstName = new TextBox();
        label9 = new Label();
        nmrEmployeeNumber = new NumericUpDown();
        label8 = new Label();
        tbTrips = new TabPage();
        groupBox1 = new GroupBox();
        btnRegisterTrip = new Button();
        groupBox3 = new GroupBox();
        cbPrivate = new CheckBox();
        tbTripsTotalKilometersDriven = new TextBox();
        label20 = new Label();
        nmrTripsEndMilage = new NumericUpDown();
        label19 = new Label();
        tbTripsStartMilage = new TextBox();
        label18 = new Label();
        tbTripsCarNameAndModel = new TextBox();
        label17 = new Label();
        groupBox2 = new GroupBox();
        tbTripsFullName = new TextBox();
        tbTripsEmployeeNumber = new TextBox();
        label16 = new Label();
        tbTripsEmployeeEmail = new TextBox();
        label15 = new Label();
        label14 = new Label();
        tbSearchCars = new TextBox();
        tbSearchEmployees = new TextBox();
        label13 = new Label();
        lbTripsCars = new ListBox();
        label12 = new Label();
        lbTripsEmployees = new ListBox();
        tabControl1.SuspendLayout();
        tbCars.SuspendLayout();
        gpCars.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nmrMaintenanceInterval).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nmrCurrentMilage).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nmrEndOfLife).BeginInit();
        tbEmployees.SuspendLayout();
        gpEmployees.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nmrEmployeeNumber).BeginInit();
        tbTrips.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nmrTripsEndMilage).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tbCars);
        tabControl1.Controls.Add(tbEmployees);
        tabControl1.Controls.Add(tbTrips);
        tabControl1.Location = new Point(17, 13);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(771, 425);
        tabControl1.TabIndex = 0;
        // 
        // tbCars
        // 
        tbCars.Controls.Add(label7);
        tbCars.Controls.Add(tbFilterCars);
        tbCars.Controls.Add(btnDeleteCar);
        tbCars.Controls.Add(lbCars);
        tbCars.Controls.Add(gpCars);
        tbCars.Location = new Point(4, 24);
        tbCars.Name = "tbCars";
        tbCars.Padding = new Padding(3);
        tbCars.Size = new Size(763, 397);
        tbCars.TabIndex = 0;
        tbCars.Text = "Cars";
        tbCars.UseVisualStyleBackColor = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(31, 251);
        label7.Name = "label7";
        label7.Size = new Size(60, 15);
        label7.TabIndex = 5;
        label7.Text = "Filter cars:";
        // 
        // tbFilterCars
        // 
        tbFilterCars.Location = new Point(97, 248);
        tbFilterCars.Name = "tbFilterCars";
        tbFilterCars.Size = new Size(243, 23);
        tbFilterCars.TabIndex = 4;
        tbFilterCars.Tag = "Cars";
        tbFilterCars.KeyUp += FilterCars_Key_Up_Event;
        // 
        // btnDeleteCar
        // 
        btnDeleteCar.Location = new Point(31, 357);
        btnDeleteCar.Name = "btnDeleteCar";
        btnDeleteCar.Size = new Size(309, 23);
        btnDeleteCar.TabIndex = 3;
        btnDeleteCar.Text = "Delete selected car";
        btnDeleteCar.UseVisualStyleBackColor = true;
        btnDeleteCar.Click += btnDeleteCar_Click;
        // 
        // lbCars
        // 
        lbCars.FormattingEnabled = true;
        lbCars.ItemHeight = 15;
        lbCars.Location = new Point(371, 22);
        lbCars.Name = "lbCars";
        lbCars.Size = new Size(386, 364);
        lbCars.TabIndex = 2;
        // 
        // gpCars
        // 
        gpCars.Controls.Add(nmrMaintenanceInterval);
        gpCars.Controls.Add(label6);
        gpCars.Controls.Add(tbLicencePlate);
        gpCars.Controls.Add(label5);
        gpCars.Controls.Add(nmrCurrentMilage);
        gpCars.Controls.Add(label4);
        gpCars.Controls.Add(nmrEndOfLife);
        gpCars.Controls.Add(label3);
        gpCars.Controls.Add(tbCarModel);
        gpCars.Controls.Add(label2);
        gpCars.Controls.Add(tbCarBrand);
        gpCars.Controls.Add(label1);
        gpCars.Controls.Add(btnAddCar);
        gpCars.Location = new Point(11, 14);
        gpCars.Name = "gpCars";
        gpCars.Size = new Size(348, 221);
        gpCars.TabIndex = 1;
        gpCars.TabStop = false;
        gpCars.Text = "New car";
        // 
        // nmrMaintenanceInterval
        // 
        nmrMaintenanceInterval.Location = new Point(144, 153);
        nmrMaintenanceInterval.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nmrMaintenanceInterval.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
        nmrMaintenanceInterval.Name = "nmrMaintenanceInterval";
        nmrMaintenanceInterval.Size = new Size(182, 23);
        nmrMaintenanceInterval.TabIndex = 12;
        nmrMaintenanceInterval.Value = new decimal(new int[] { 5000, 0, 0, 0 });
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(17, 155);
        label6.Name = "label6";
        label6.Size = new Size(121, 15);
        label6.TabIndex = 11;
        label6.Text = "Maintenance interval:";
        // 
        // tbLicencePlate
        // 
        tbLicencePlate.ImeMode = ImeMode.On;
        tbLicencePlate.Location = new Point(105, 124);
        tbLicencePlate.MaxLength = 8;
        tbLicencePlate.Name = "tbLicencePlate";
        tbLicencePlate.Size = new Size(221, 23);
        tbLicencePlate.TabIndex = 10;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 127);
        label5.Name = "label5";
        label5.Size = new Size(79, 15);
        label5.TabIndex = 9;
        label5.Text = "Licence plate:";
        // 
        // nmrCurrentMilage
        // 
        nmrCurrentMilage.Location = new Point(128, 93);
        nmrCurrentMilage.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
        nmrCurrentMilage.Name = "nmrCurrentMilage";
        nmrCurrentMilage.Size = new Size(201, 23);
        nmrCurrentMilage.TabIndex = 8;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(20, 95);
        label4.Name = "label4";
        label4.Size = new Size(89, 15);
        label4.TabIndex = 7;
        label4.Text = "Current Milage:";
        // 
        // nmrEndOfLife
        // 
        nmrEndOfLife.Location = new Point(128, 64);
        nmrEndOfLife.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
        nmrEndOfLife.Name = "nmrEndOfLife";
        nmrEndOfLife.Size = new Size(201, 23);
        nmrEndOfLife.TabIndex = 6;
        nmrEndOfLife.Value = new decimal(new int[] { 200000, 0, 0, 0 });
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(20, 66);
        label3.Name = "label3";
        label3.Size = new Size(102, 15);
        label3.TabIndex = 5;
        label3.Text = "End of life milage:";
        // 
        // tbCarModel
        // 
        tbCarModel.Location = new Point(226, 27);
        tbCarModel.Name = "tbCarModel";
        tbCarModel.Size = new Size(100, 23);
        tbCarModel.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(176, 32);
        label2.Name = "label2";
        label2.Size = new Size(44, 15);
        label2.TabIndex = 3;
        label2.Text = "Model:";
        // 
        // tbCarBrand
        // 
        tbCarBrand.Location = new Point(67, 27);
        tbCarBrand.Name = "tbCarBrand";
        tbCarBrand.Size = new Size(100, 23);
        tbCarBrand.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 32);
        label1.Name = "label1";
        label1.Size = new Size(41, 15);
        label1.TabIndex = 1;
        label1.Text = "Brand:";
        // 
        // btnAddCar
        // 
        btnAddCar.Location = new Point(20, 182);
        btnAddCar.Name = "btnAddCar";
        btnAddCar.Size = new Size(309, 23);
        btnAddCar.TabIndex = 0;
        btnAddCar.Text = "Add car to carpool";
        btnAddCar.UseVisualStyleBackColor = true;
        btnAddCar.Click += btnAddCar_Click;
        // 
        // tbEmployees
        // 
        tbEmployees.Controls.Add(btnDeleteEmployee);
        tbEmployees.Controls.Add(lbEmployees);
        tbEmployees.Controls.Add(gpEmployees);
        tbEmployees.Location = new Point(4, 24);
        tbEmployees.Name = "tbEmployees";
        tbEmployees.Padding = new Padding(3);
        tbEmployees.Size = new Size(763, 397);
        tbEmployees.TabIndex = 1;
        tbEmployees.Text = "Employees";
        tbEmployees.UseVisualStyleBackColor = true;
        // 
        // btnDeleteEmployee
        // 
        btnDeleteEmployee.Location = new Point(33, 354);
        btnDeleteEmployee.Name = "btnDeleteEmployee";
        btnDeleteEmployee.Size = new Size(342, 23);
        btnDeleteEmployee.TabIndex = 2;
        btnDeleteEmployee.Text = "Delete selected employee";
        btnDeleteEmployee.UseVisualStyleBackColor = true;
        btnDeleteEmployee.Click += btnDeleteEmployee_Click;
        // 
        // lbEmployees
        // 
        lbEmployees.FormattingEnabled = true;
        lbEmployees.ItemHeight = 15;
        lbEmployees.Location = new Point(401, 13);
        lbEmployees.Name = "lbEmployees";
        lbEmployees.Size = new Size(356, 364);
        lbEmployees.TabIndex = 1;
        // 
        // gpEmployees
        // 
        gpEmployees.Controls.Add(btnNewEmployee);
        gpEmployees.Controls.Add(tbEmail);
        gpEmployees.Controls.Add(label11);
        gpEmployees.Controls.Add(tbLastName);
        gpEmployees.Controls.Add(label10);
        gpEmployees.Controls.Add(tbFirstName);
        gpEmployees.Controls.Add(label9);
        gpEmployees.Controls.Add(nmrEmployeeNumber);
        gpEmployees.Controls.Add(label8);
        gpEmployees.Location = new Point(17, 13);
        gpEmployees.Name = "gpEmployees";
        gpEmployees.Size = new Size(366, 195);
        gpEmployees.TabIndex = 0;
        gpEmployees.TabStop = false;
        gpEmployees.Text = "Register employee";
        // 
        // btnNewEmployee
        // 
        btnNewEmployee.Location = new Point(14, 154);
        btnNewEmployee.Name = "btnNewEmployee";
        btnNewEmployee.Size = new Size(344, 23);
        btnNewEmployee.TabIndex = 8;
        btnNewEmployee.Text = "Register new Employee";
        btnNewEmployee.UseVisualStyleBackColor = true;
        btnNewEmployee.Click += btnNewEmployee_Click;
        // 
        // tbEmail
        // 
        tbEmail.Location = new Point(85, 114);
        tbEmail.Name = "tbEmail";
        tbEmail.Size = new Size(273, 23);
        tbEmail.TabIndex = 7;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(16, 119);
        label11.Name = "label11";
        label11.Size = new Size(44, 15);
        label11.TabIndex = 6;
        label11.Text = "E-mail:";
        // 
        // tbLastName
        // 
        tbLastName.Location = new Point(85, 85);
        tbLastName.Name = "tbLastName";
        tbLastName.Size = new Size(273, 23);
        tbLastName.TabIndex = 5;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(14, 90);
        label10.Name = "label10";
        label10.Size = new Size(64, 15);
        label10.TabIndex = 4;
        label10.Text = "Last name:";
        // 
        // tbFirstName
        // 
        tbFirstName.Location = new Point(85, 56);
        tbFirstName.Name = "tbFirstName";
        tbFirstName.Size = new Size(273, 23);
        tbFirstName.TabIndex = 3;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(14, 61);
        label9.Name = "label9";
        label9.Size = new Size(65, 15);
        label9.TabIndex = 2;
        label9.Text = "First name:";
        // 
        // nmrEmployeeNumber
        // 
        nmrEmployeeNumber.Location = new Point(127, 27);
        nmrEmployeeNumber.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
        nmrEmployeeNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nmrEmployeeNumber.Name = "nmrEmployeeNumber";
        nmrEmployeeNumber.Size = new Size(231, 23);
        nmrEmployeeNumber.TabIndex = 1;
        nmrEmployeeNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(14, 29);
        label8.Name = "label8";
        label8.Size = new Size(107, 15);
        label8.TabIndex = 0;
        label8.Text = "Employee number:";
        // 
        // tbTrips
        // 
        tbTrips.Controls.Add(groupBox1);
        tbTrips.Controls.Add(tbSearchCars);
        tbTrips.Controls.Add(tbSearchEmployees);
        tbTrips.Controls.Add(label13);
        tbTrips.Controls.Add(lbTripsCars);
        tbTrips.Controls.Add(label12);
        tbTrips.Controls.Add(lbTripsEmployees);
        tbTrips.Location = new Point(4, 24);
        tbTrips.Name = "tbTrips";
        tbTrips.Size = new Size(763, 397);
        tbTrips.TabIndex = 2;
        tbTrips.Text = "Trips";
        tbTrips.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnRegisterTrip);
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Location = new Point(367, 33);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(381, 347);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "New trip";
        // 
        // btnRegisterTrip
        // 
        btnRegisterTrip.Location = new Point(6, 292);
        btnRegisterTrip.Name = "btnRegisterTrip";
        btnRegisterTrip.Size = new Size(369, 23);
        btnRegisterTrip.TabIndex = 4;
        btnRegisterTrip.Text = "Register new trip";
        btnRegisterTrip.UseVisualStyleBackColor = true;
        btnRegisterTrip.Click += btnRegisterTrip_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(cbPrivate);
        groupBox3.Controls.Add(tbTripsTotalKilometersDriven);
        groupBox3.Controls.Add(label20);
        groupBox3.Controls.Add(nmrTripsEndMilage);
        groupBox3.Controls.Add(label19);
        groupBox3.Controls.Add(tbTripsStartMilage);
        groupBox3.Controls.Add(label18);
        groupBox3.Controls.Add(tbTripsCarNameAndModel);
        groupBox3.Controls.Add(label17);
        groupBox3.Location = new Point(6, 151);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(369, 123);
        groupBox3.TabIndex = 3;
        groupBox3.TabStop = false;
        groupBox3.Text = "Car information";
        // 
        // cbPrivate
        // 
        cbPrivate.AutoSize = true;
        cbPrivate.Location = new Point(183, 86);
        cbPrivate.Name = "cbPrivate";
        cbPrivate.Size = new Size(83, 19);
        cbPrivate.TabIndex = 8;
        cbPrivate.Text = "Private trip";
        cbPrivate.UseVisualStyleBackColor = true;
        // 
        // tbTripsTotalKilometersDriven
        // 
        tbTripsTotalKilometersDriven.Enabled = false;
        tbTripsTotalKilometersDriven.Location = new Point(102, 82);
        tbTripsTotalKilometersDriven.Name = "tbTripsTotalKilometersDriven";
        tbTripsTotalKilometersDriven.Size = new Size(75, 23);
        tbTripsTotalKilometersDriven.TabIndex = 7;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(4, 85);
        label20.Name = "label20";
        label20.Size = new Size(102, 15);
        label20.TabIndex = 6;
        label20.Text = "Kilometers driven:";
        // 
        // nmrTripsEndMilage
        // 
        nmrTripsEndMilage.Enabled = false;
        nmrTripsEndMilage.Location = new Point(249, 53);
        nmrTripsEndMilage.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        nmrTripsEndMilage.Name = "nmrTripsEndMilage";
        nmrTripsEndMilage.Size = new Size(114, 23);
        nmrTripsEndMilage.TabIndex = 5;
        nmrTripsEndMilage.ValueChanged += nmrTripsEndMilage_ValueChanged;
        nmrTripsEndMilage.KeyUp += nmrTripsEndMilage_KeyUp;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(183, 56);
        label19.Name = "label19";
        label19.Size = new Size(69, 15);
        label19.TabIndex = 4;
        label19.Text = "End milage:";
        // 
        // tbTripsStartMilage
        // 
        tbTripsStartMilage.Enabled = false;
        tbTripsStartMilage.Location = new Point(83, 53);
        tbTripsStartMilage.Name = "tbTripsStartMilage";
        tbTripsStartMilage.Size = new Size(94, 23);
        tbTripsStartMilage.TabIndex = 3;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(4, 56);
        label18.Name = "label18";
        label18.Size = new Size(73, 15);
        label18.TabIndex = 2;
        label18.Text = "Start milage:";
        // 
        // tbTripsCarNameAndModel
        // 
        tbTripsCarNameAndModel.Enabled = false;
        tbTripsCarNameAndModel.Location = new Point(124, 16);
        tbTripsCarNameAndModel.Name = "tbTripsCarNameAndModel";
        tbTripsCarNameAndModel.Size = new Size(239, 23);
        tbTripsCarNameAndModel.TabIndex = 1;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(6, 19);
        label17.Name = "label17";
        label17.Size = new Size(121, 15);
        label17.TabIndex = 0;
        label17.Text = "Car name and model:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(tbTripsFullName);
        groupBox2.Controls.Add(tbTripsEmployeeNumber);
        groupBox2.Controls.Add(label16);
        groupBox2.Controls.Add(tbTripsEmployeeEmail);
        groupBox2.Controls.Add(label15);
        groupBox2.Controls.Add(label14);
        groupBox2.Location = new Point(6, 25);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(369, 120);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Employee information";
        // 
        // tbTripsFullName
        // 
        tbTripsFullName.Enabled = false;
        tbTripsFullName.Location = new Point(116, 52);
        tbTripsFullName.Name = "tbTripsFullName";
        tbTripsFullName.Size = new Size(247, 23);
        tbTripsFullName.TabIndex = 5;
        // 
        // tbTripsEmployeeNumber
        // 
        tbTripsEmployeeNumber.Enabled = false;
        tbTripsEmployeeNumber.Location = new Point(116, 21);
        tbTripsEmployeeNumber.Name = "tbTripsEmployeeNumber";
        tbTripsEmployeeNumber.Size = new Size(247, 23);
        tbTripsEmployeeNumber.TabIndex = 1;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(6, 55);
        label16.Name = "label16";
        label16.Size = new Size(62, 15);
        label16.TabIndex = 4;
        label16.Text = "Full name:";
        // 
        // tbTripsEmployeeEmail
        // 
        tbTripsEmployeeEmail.Enabled = false;
        tbTripsEmployeeEmail.Location = new Point(116, 84);
        tbTripsEmployeeEmail.Name = "tbTripsEmployeeEmail";
        tbTripsEmployeeEmail.Size = new Size(247, 23);
        tbTripsEmployeeEmail.TabIndex = 3;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(6, 87);
        label15.Name = "label15";
        label15.Size = new Size(39, 15);
        label15.TabIndex = 2;
        label15.Text = "Email:";
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(6, 24);
        label14.Name = "label14";
        label14.Size = new Size(107, 15);
        label14.TabIndex = 0;
        label14.Text = "Employee number:";
        // 
        // tbSearchCars
        // 
        tbSearchCars.Location = new Point(156, 287);
        tbSearchCars.Name = "tbSearchCars";
        tbSearchCars.Size = new Size(187, 23);
        tbSearchCars.TabIndex = 5;
        tbSearchCars.Tag = "Trips";
        tbSearchCars.KeyUp += FilterCars_Key_Up_Event;
        // 
        // tbSearchEmployees
        // 
        tbSearchEmployees.Location = new Point(156, 135);
        tbSearchEmployees.Name = "tbSearchEmployees";
        tbSearchEmployees.Size = new Size(187, 23);
        tbSearchEmployees.TabIndex = 4;
        tbSearchEmployees.KeyUp += tbSearchEmployees_KeyUp;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(18, 163);
        label13.Name = "label13";
        label13.Size = new Size(152, 15);
        label13.TabIndex = 3;
        label13.Text = "Select a car in the list below";
        // 
        // lbTripsCars
        // 
        lbTripsCars.FormattingEnabled = true;
        lbTripsCars.ItemHeight = 15;
        lbTripsCars.Location = new Point(15, 187);
        lbTripsCars.Name = "lbTripsCars";
        lbTripsCars.Size = new Size(328, 94);
        lbTripsCars.TabIndex = 2;
        lbTripsCars.SelectedIndexChanged += lbTripsCars_SelectedIndexChanged;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(18, 11);
        label12.Name = "label12";
        label12.Size = new Size(195, 15);
        label12.TabIndex = 1;
        label12.Text = "Select an employee in the list below";
        // 
        // lbTripsEmployees
        // 
        lbTripsEmployees.FormattingEnabled = true;
        lbTripsEmployees.ItemHeight = 15;
        lbTripsEmployees.Location = new Point(15, 35);
        lbTripsEmployees.Name = "lbTripsEmployees";
        lbTripsEmployees.Size = new Size(328, 94);
        lbTripsEmployees.TabIndex = 0;
        lbTripsEmployees.SelectedIndexChanged += lbTripsEmployees_SelectedIndexChanged;
        // 
        // TheGreenMile
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(tabControl1);
        Name = "TheGreenMile";
        Text = "TheGreenMile™";
        tabControl1.ResumeLayout(false);
        tbCars.ResumeLayout(false);
        tbCars.PerformLayout();
        gpCars.ResumeLayout(false);
        gpCars.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nmrMaintenanceInterval).EndInit();
        ((System.ComponentModel.ISupportInitialize)nmrCurrentMilage).EndInit();
        ((System.ComponentModel.ISupportInitialize)nmrEndOfLife).EndInit();
        tbEmployees.ResumeLayout(false);
        gpEmployees.ResumeLayout(false);
        gpEmployees.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nmrEmployeeNumber).EndInit();
        tbTrips.ResumeLayout(false);
        tbTrips.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nmrTripsEndMilage).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tbCars;
    private TabPage tbEmployees;
    private TabPage tbTrips;
    private GroupBox gpCars;
    private Button btnAddCar;
    private TextBox tbCarModel;
    private Label label2;
    private TextBox tbCarBrand;
    private Label label1;
    private NumericUpDown nmrEndOfLife;
    private Label label3;
    private NumericUpDown nmrCurrentMilage;
    private Label label4;
    private TextBox tbLicencePlate;
    private Label label5;
    private NumericUpDown nmrMaintenanceInterval;
    private Label label6;
    private ListBox lbCars;
    private Button btnDeleteCar;
    private Label label7;
    private TextBox tbFilterCars;
    private GroupBox gpEmployees;
    private Label label9;
    private NumericUpDown nmrEmployeeNumber;
    private Label label8;
    private TextBox tbLastName;
    private Label label10;
    private TextBox tbFirstName;
    private TextBox tbEmail;
    private Label label11;
    private ListBox lbEmployees;
    private Button btnNewEmployee;
    private Button btnDeleteEmployee;
    private TextBox tbSearchCars;
    private TextBox tbSearchEmployees;
    private Label label13;
    private ListBox lbTripsCars;
    private Label label12;
    private ListBox lbTripsEmployees;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private TextBox tbTripsFullName;
    private Label label16;
    private TextBox tbTripsEmployeeEmail;
    private Label label15;
    private TextBox tbTripsEmployeeNumber;
    private Label label14;
    private GroupBox groupBox3;
    private TextBox tbTripsCarNameAndModel;
    private Label label17;
    private TextBox tbTripsStartMilage;
    private Label label18;
    private NumericUpDown nmrTripsEndMilage;
    private Label label19;
    private TextBox tbTripsTotalKilometersDriven;
    private Label label20;
    private Button btnRegisterTrip;
    private CheckBox cbPrivate;
}