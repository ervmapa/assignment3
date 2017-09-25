namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.grpFuel = new System.Windows.Forms.GroupBox();
            this.btnFuelCalc = new System.Windows.Forms.Button();
            this.txtFuelPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrevKm = new System.Windows.Forms.TextBox();
            this.txtCurrentKm = new System.Windows.Forms.TextBox();
            this.lblFuelPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrevKm = new System.Windows.Forms.Label();
            this.lblCurrentKm = new System.Windows.Forms.Label();
            this.grpFuelResults = new System.Windows.Forms.GroupBox();
            this.lblFuelResCostKm = new System.Windows.Forms.Label();
            this.lblFuelResMil = new System.Windows.Forms.Label();
            this.lblFuelResLitMile = new System.Windows.Forms.Label();
            this.lblFuelResLitKm = new System.Windows.Forms.Label();
            this.lblFuelResKmLit = new System.Windows.Forms.Label();
            this.lblFuelResults_5 = new System.Windows.Forms.Label();
            this.lblFuelResults_4 = new System.Windows.Forms.Label();
            this.lblFuelResults_3 = new System.Windows.Forms.Label();
            this.lblFuelResults_2 = new System.Windows.Forms.Label();
            this.lblFuelResults_1 = new System.Windows.Forms.Label();
            this.grpBmi = new System.Windows.Forms.GroupBox();
            this.radUs = new System.Windows.Forms.RadioButton();
            this.radMetric = new System.Windows.Forms.RadioButton();
            this.btnBmiCalc = new System.Windows.Forms.Button();
            this.txtBmiWeight = new System.Windows.Forms.TextBox();
            this.txtBmiHeight = new System.Windows.Forms.TextBox();
            this.txtBmiName = new System.Windows.Forms.TextBox();
            this.lblBmiWeight = new System.Windows.Forms.Label();
            this.lblBmiHeight = new System.Windows.Forms.Label();
            this.lnlBmiName = new System.Windows.Forms.Label();
            this.grpBmiResults = new System.Windows.Forms.GroupBox();
            this.lblBmiResCat = new System.Windows.Forms.Label();
            this.lblBmiResBmi = new System.Windows.Forms.Label();
            this.lblBmiRange = new System.Windows.Forms.Label();
            this.lblBmiResults_2 = new System.Windows.Forms.Label();
            this.lblBmiResults_1 = new System.Windows.Forms.Label();
            this.grpBmr = new System.Windows.Forms.GroupBox();
            this.lblBmrSelect = new System.Windows.Forms.Label();
            this.btnBrmUnselect = new System.Windows.Forms.Button();
            this.btnBmrCalc = new System.Windows.Forms.Button();
            this.lboxBmr = new System.Windows.Forms.ListBox();
            this.grpActivity = new System.Windows.Forms.GroupBox();
            this.radALight = new System.Windows.Forms.RadioButton();
            this.radAModerate = new System.Windows.Forms.RadioButton();
            this.radAVery = new System.Windows.Forms.RadioButton();
            this.radAExtra = new System.Windows.Forms.RadioButton();
            this.radASedentary = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.grpFuel.SuspendLayout();
            this.grpFuelResults.SuspendLayout();
            this.grpBmi.SuspendLayout();
            this.grpBmiResults.SuspendLayout();
            this.grpBmr.SuspendLayout();
            this.grpActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFuel
            // 
            this.grpFuel.Controls.Add(this.btnFuelCalc);
            this.grpFuel.Controls.Add(this.txtFuelPrice);
            this.grpFuel.Controls.Add(this.txtAmount);
            this.grpFuel.Controls.Add(this.txtPrevKm);
            this.grpFuel.Controls.Add(this.txtCurrentKm);
            this.grpFuel.Controls.Add(this.lblFuelPrice);
            this.grpFuel.Controls.Add(this.lblAmount);
            this.grpFuel.Controls.Add(this.lblPrevKm);
            this.grpFuel.Controls.Add(this.lblCurrentKm);
            this.grpFuel.Controls.Add(this.grpFuelResults);
            this.grpFuel.Location = new System.Drawing.Point(12, 12);
            this.grpFuel.Name = "grpFuel";
            this.grpFuel.Size = new System.Drawing.Size(263, 315);
            this.grpFuel.TabIndex = 0;
            this.grpFuel.TabStop = false;
            this.grpFuel.Text = "Fuel";
            // 
            // btnFuelCalc
            // 
            this.btnFuelCalc.Location = new System.Drawing.Point(10, 119);
            this.btnFuelCalc.Name = "btnFuelCalc";
            this.btnFuelCalc.Size = new System.Drawing.Size(75, 23);
            this.btnFuelCalc.TabIndex = 9;
            this.btnFuelCalc.Text = "Calculate";
            this.btnFuelCalc.UseVisualStyleBackColor = true;
            this.btnFuelCalc.Click += new System.EventHandler(this.BtnFuelCalc_Click);
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(157, 96);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.Size = new System.Drawing.Size(100, 20);
            this.txtFuelPrice.TabIndex = 8;
            this.txtFuelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(203, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(54, 20);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrevKm
            // 
            this.txtPrevKm.Location = new System.Drawing.Point(177, 44);
            this.txtPrevKm.Name = "txtPrevKm";
            this.txtPrevKm.Size = new System.Drawing.Size(80, 20);
            this.txtPrevKm.TabIndex = 6;
            this.txtPrevKm.Text = "0";
            this.txtPrevKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentKm
            // 
            this.txtCurrentKm.Location = new System.Drawing.Point(177, 17);
            this.txtCurrentKm.Name = "txtCurrentKm";
            this.txtCurrentKm.Size = new System.Drawing.Size(80, 20);
            this.txtCurrentKm.TabIndex = 5;
            this.txtCurrentKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.AutoSize = true;
            this.lblFuelPrice.Location = new System.Drawing.Point(8, 94);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(68, 13);
            this.lblFuelPrice.TabIndex = 4;
            this.lblFuelPrice.Text = "Price per liter";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(8, 71);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(177, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Current amount of fuel tanked (liters)";
            // 
            // lblPrevKm
            // 
            this.lblPrevKm.AutoSize = true;
            this.lblPrevKm.Location = new System.Drawing.Point(8, 42);
            this.lblPrevKm.Name = "lblPrevKm";
            this.lblPrevKm.Size = new System.Drawing.Size(156, 13);
            this.lblPrevKm.TabIndex = 2;
            this.lblPrevKm.Text = "Previous odometer reading (km)";
            // 
            // lblCurrentKm
            // 
            this.lblCurrentKm.AutoSize = true;
            this.lblCurrentKm.Location = new System.Drawing.Point(8, 18);
            this.lblCurrentKm.Name = "lblCurrentKm";
            this.lblCurrentKm.Size = new System.Drawing.Size(149, 13);
            this.lblCurrentKm.TabIndex = 1;
            this.lblCurrentKm.Text = "Current odometer reading (km)";
            // 
            // grpFuelResults
            // 
            this.grpFuelResults.Controls.Add(this.lblFuelResCostKm);
            this.grpFuelResults.Controls.Add(this.lblFuelResMil);
            this.grpFuelResults.Controls.Add(this.lblFuelResLitMile);
            this.grpFuelResults.Controls.Add(this.lblFuelResLitKm);
            this.grpFuelResults.Controls.Add(this.lblFuelResKmLit);
            this.grpFuelResults.Controls.Add(this.lblFuelResults_5);
            this.grpFuelResults.Controls.Add(this.lblFuelResults_4);
            this.grpFuelResults.Controls.Add(this.lblFuelResults_3);
            this.grpFuelResults.Controls.Add(this.lblFuelResults_2);
            this.grpFuelResults.Controls.Add(this.lblFuelResults_1);
            this.grpFuelResults.Location = new System.Drawing.Point(10, 148);
            this.grpFuelResults.Name = "grpFuelResults";
            this.grpFuelResults.Size = new System.Drawing.Size(247, 157);
            this.grpFuelResults.TabIndex = 0;
            this.grpFuelResults.TabStop = false;
            this.grpFuelResults.Text = "Results";
            // 
            // lblFuelResCostKm
            // 
            this.lblFuelResCostKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResCostKm.Location = new System.Drawing.Point(190, 122);
            this.lblFuelResCostKm.Name = "lblFuelResCostKm";
            this.lblFuelResCostKm.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResCostKm.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResCostKm.TabIndex = 14;
            // 
            // lblFuelResMil
            // 
            this.lblFuelResMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResMil.Location = new System.Drawing.Point(190, 98);
            this.lblFuelResMil.Name = "lblFuelResMil";
            this.lblFuelResMil.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResMil.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResMil.TabIndex = 13;
            // 
            // lblFuelResLitMile
            // 
            this.lblFuelResLitMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResLitMile.Location = new System.Drawing.Point(190, 73);
            this.lblFuelResLitMile.Name = "lblFuelResLitMile";
            this.lblFuelResLitMile.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResLitMile.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResLitMile.TabIndex = 12;
            // 
            // lblFuelResLitKm
            // 
            this.lblFuelResLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResLitKm.Location = new System.Drawing.Point(190, 49);
            this.lblFuelResLitKm.Name = "lblFuelResLitKm";
            this.lblFuelResLitKm.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResLitKm.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResLitKm.TabIndex = 11;
            // 
            // lblFuelResKmLit
            // 
            this.lblFuelResKmLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResKmLit.Location = new System.Drawing.Point(190, 26);
            this.lblFuelResKmLit.Name = "lblFuelResKmLit";
            this.lblFuelResKmLit.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResKmLit.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResKmLit.TabIndex = 10;
            // 
            // lblFuelResults_5
            // 
            this.lblFuelResults_5.AutoSize = true;
            this.lblFuelResults_5.Location = new System.Drawing.Point(6, 124);
            this.lblFuelResults_5.Name = "lblFuelResults_5";
            this.lblFuelResults_5.Size = new System.Drawing.Size(91, 13);
            this.lblFuelResults_5.TabIndex = 9;
            this.lblFuelResults_5.Text = "Cost per kilometer";
            // 
            // lblFuelResults_4
            // 
            this.lblFuelResults_4.AutoSize = true;
            this.lblFuelResults_4.Location = new System.Drawing.Point(6, 100);
            this.lblFuelResults_4.Name = "lblFuelResults_4";
            this.lblFuelResults_4.Size = new System.Drawing.Size(164, 13);
            this.lblFuelResults_4.TabIndex = 8;
            this.lblFuelResults_4.Text = "Fuel consumption (lit/swedish mil)";
            // 
            // lblFuelResults_3
            // 
            this.lblFuelResults_3.AutoSize = true;
            this.lblFuelResults_3.Location = new System.Drawing.Point(6, 74);
            this.lblFuelResults_3.Name = "lblFuelResults_3";
            this.lblFuelResults_3.Size = new System.Drawing.Size(160, 13);
            this.lblFuelResults_3.TabIndex = 7;
            this.lblFuelResults_3.Text = "Fuel consumption (lit/metric mile)";
            // 
            // lblFuelResults_2
            // 
            this.lblFuelResults_2.AutoSize = true;
            this.lblFuelResults_2.Location = new System.Drawing.Point(6, 49);
            this.lblFuelResults_2.Name = "lblFuelResults_2";
            this.lblFuelResults_2.Size = new System.Drawing.Size(125, 13);
            this.lblFuelResults_2.TabIndex = 6;
            this.lblFuelResults_2.Text = "Fuel consumption (lit/km)";
            // 
            // lblFuelResults_1
            // 
            this.lblFuelResults_1.AutoSize = true;
            this.lblFuelResults_1.Location = new System.Drawing.Point(6, 26);
            this.lblFuelResults_1.Name = "lblFuelResults_1";
            this.lblFuelResults_1.Size = new System.Drawing.Size(125, 13);
            this.lblFuelResults_1.TabIndex = 5;
            this.lblFuelResults_1.Text = "Fuel consumption (km/lit)";
            // 
            // grpBmi
            // 
            this.grpBmi.Controls.Add(this.radUs);
            this.grpBmi.Controls.Add(this.radMetric);
            this.grpBmi.Controls.Add(this.btnBmiCalc);
            this.grpBmi.Controls.Add(this.txtBmiWeight);
            this.grpBmi.Controls.Add(this.txtBmiHeight);
            this.grpBmi.Controls.Add(this.txtBmiName);
            this.grpBmi.Controls.Add(this.lblBmiWeight);
            this.grpBmi.Controls.Add(this.lblBmiHeight);
            this.grpBmi.Controls.Add(this.lnlBmiName);
            this.grpBmi.Controls.Add(this.grpBmiResults);
            this.grpBmi.Location = new System.Drawing.Point(281, 12);
            this.grpBmi.Name = "grpBmi";
            this.grpBmi.Size = new System.Drawing.Size(316, 315);
            this.grpBmi.TabIndex = 1;
            this.grpBmi.TabStop = false;
            this.grpBmi.Text = "BMI";
            // 
            // radUs
            // 
            this.radUs.AutoSize = true;
            this.radUs.Location = new System.Drawing.Point(212, 68);
            this.radUs.Name = "radUs";
            this.radUs.Size = new System.Drawing.Size(83, 17);
            this.radUs.TabIndex = 9;
            this.radUs.Text = "US (lb, inch)";
            this.radUs.UseVisualStyleBackColor = true;
            this.radUs.CheckedChanged += new System.EventHandler(this.RadUs_CheckedChanged);
            // 
            // radMetric
            // 
            this.radMetric.AutoSize = true;
            this.radMetric.Checked = true;
            this.radMetric.Location = new System.Drawing.Point(212, 45);
            this.radMetric.Name = "radMetric";
            this.radMetric.Size = new System.Drawing.Size(95, 17);
            this.radMetric.TabIndex = 8;
            this.radMetric.TabStop = true;
            this.radMetric.Text = "Metric (kg, cm)";
            this.radMetric.UseVisualStyleBackColor = true;
            this.radMetric.CheckedChanged += new System.EventHandler(this.RadMetric_CheckedChanged);
            // 
            // btnBmiCalc
            // 
            this.btnBmiCalc.Location = new System.Drawing.Point(10, 119);
            this.btnBmiCalc.Name = "btnBmiCalc";
            this.btnBmiCalc.Size = new System.Drawing.Size(75, 23);
            this.btnBmiCalc.TabIndex = 10;
            this.btnBmiCalc.Text = "Calculate";
            this.btnBmiCalc.UseVisualStyleBackColor = true;
            this.btnBmiCalc.Click += new System.EventHandler(this.BtnBmiCalc_Click);
            // 
            // txtBmiWeight
            // 
            this.txtBmiWeight.Location = new System.Drawing.Point(106, 70);
            this.txtBmiWeight.Name = "txtBmiWeight";
            this.txtBmiWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBmiWeight.TabIndex = 7;
            this.txtBmiWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBmiHeight
            // 
            this.txtBmiHeight.Location = new System.Drawing.Point(106, 44);
            this.txtBmiHeight.Name = "txtBmiHeight";
            this.txtBmiHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBmiHeight.TabIndex = 6;
            this.txtBmiHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBmiName
            // 
            this.txtBmiName.Location = new System.Drawing.Point(106, 19);
            this.txtBmiName.Name = "txtBmiName";
            this.txtBmiName.Size = new System.Drawing.Size(202, 20);
            this.txtBmiName.TabIndex = 5;
            // 
            // lblBmiWeight
            // 
            this.lblBmiWeight.AutoSize = true;
            this.lblBmiWeight.Location = new System.Drawing.Point(10, 73);
            this.lblBmiWeight.Name = "lblBmiWeight";
            this.lblBmiWeight.Size = new System.Drawing.Size(62, 13);
            this.lblBmiWeight.TabIndex = 3;
            this.lblBmiWeight.Text = "Weight (kg)";
            // 
            // lblBmiHeight
            // 
            this.lblBmiHeight.AutoSize = true;
            this.lblBmiHeight.Location = new System.Drawing.Point(7, 44);
            this.lblBmiHeight.Name = "lblBmiHeight";
            this.lblBmiHeight.Size = new System.Drawing.Size(61, 13);
            this.lblBmiHeight.TabIndex = 2;
            this.lblBmiHeight.Text = "Height (cm)";
            // 
            // lnlBmiName
            // 
            this.lnlBmiName.AutoSize = true;
            this.lnlBmiName.Location = new System.Drawing.Point(7, 20);
            this.lnlBmiName.Name = "lnlBmiName";
            this.lnlBmiName.Size = new System.Drawing.Size(58, 13);
            this.lnlBmiName.TabIndex = 1;
            this.lnlBmiName.Text = "Your name";
            // 
            // grpBmiResults
            // 
            this.grpBmiResults.Controls.Add(this.lblBmiResCat);
            this.grpBmiResults.Controls.Add(this.lblBmiResBmi);
            this.grpBmiResults.Controls.Add(this.lblBmiRange);
            this.grpBmiResults.Controls.Add(this.lblBmiResults_2);
            this.grpBmiResults.Controls.Add(this.lblBmiResults_1);
            this.grpBmiResults.Location = new System.Drawing.Point(10, 148);
            this.grpBmiResults.Name = "grpBmiResults";
            this.grpBmiResults.Size = new System.Drawing.Size(295, 157);
            this.grpBmiResults.TabIndex = 0;
            this.grpBmiResults.TabStop = false;
            this.grpBmiResults.Text = "Results";
            // 
            // lblBmiResCat
            // 
            this.lblBmiResCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResCat.Location = new System.Drawing.Point(96, 49);
            this.lblBmiResCat.Name = "lblBmiResCat";
            this.lblBmiResCat.Padding = new System.Windows.Forms.Padding(2);
            this.lblBmiResCat.Size = new System.Drawing.Size(100, 19);
            this.lblBmiResCat.TabIndex = 11;
            this.lblBmiResCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBmiResBmi
            // 
            this.lblBmiResBmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResBmi.Location = new System.Drawing.Point(96, 23);
            this.lblBmiResBmi.Name = "lblBmiResBmi";
            this.lblBmiResBmi.Padding = new System.Windows.Forms.Padding(2);
            this.lblBmiResBmi.Size = new System.Drawing.Size(100, 19);
            this.lblBmiResBmi.TabIndex = 10;
            this.lblBmiResBmi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBmiRange
            // 
            this.lblBmiRange.Location = new System.Drawing.Point(11, 74);
            this.lblBmiRange.Name = "lblBmiRange";
            this.lblBmiRange.Size = new System.Drawing.Size(276, 53);
            this.lblBmiRange.TabIndex = 9;
            // 
            // lblBmiResults_2
            // 
            this.lblBmiResults_2.AutoSize = true;
            this.lblBmiResults_2.Location = new System.Drawing.Point(8, 49);
            this.lblBmiResults_2.Name = "lblBmiResults_2";
            this.lblBmiResults_2.Size = new System.Drawing.Size(85, 13);
            this.lblBmiResults_2.TabIndex = 6;
            this.lblBmiResults_2.Text = "Weight category";
            // 
            // lblBmiResults_1
            // 
            this.lblBmiResults_1.AutoSize = true;
            this.lblBmiResults_1.Location = new System.Drawing.Point(8, 27);
            this.lblBmiResults_1.Name = "lblBmiResults_1";
            this.lblBmiResults_1.Size = new System.Drawing.Size(51, 13);
            this.lblBmiResults_1.TabIndex = 5;
            this.lblBmiResults_1.Text = "Your BMI";
            // 
            // grpBmr
            // 
            this.grpBmr.Controls.Add(this.lblBmrSelect);
            this.grpBmr.Controls.Add(this.btnBrmUnselect);
            this.grpBmr.Controls.Add(this.btnBmrCalc);
            this.grpBmr.Controls.Add(this.lboxBmr);
            this.grpBmr.Controls.Add(this.grpActivity);
            this.grpBmr.Controls.Add(this.txtAge);
            this.grpBmr.Controls.Add(this.lblAge);
            this.grpBmr.Controls.Add(this.radMale);
            this.grpBmr.Controls.Add(this.radFemale);
            this.grpBmr.Location = new System.Drawing.Point(12, 333);
            this.grpBmr.Name = "grpBmr";
            this.grpBmr.Size = new System.Drawing.Size(585, 239);
            this.grpBmr.TabIndex = 2;
            this.grpBmr.TabStop = false;
            this.grpBmr.Text = "BMR";
            // 
            // lblBmrSelect
            // 
            this.lblBmrSelect.AutoSize = true;
            this.lblBmrSelect.Location = new System.Drawing.Point(279, 215);
            this.lblBmrSelect.Name = "lblBmrSelect";
            this.lblBmrSelect.Size = new System.Drawing.Size(62, 13);
            this.lblBmrSelect.TabIndex = 14;
            this.lblBmrSelect.Text = "selected: -1";
            // 
            // btnBrmUnselect
            // 
            this.btnBrmUnselect.Location = new System.Drawing.Point(499, 210);
            this.btnBrmUnselect.Name = "btnBrmUnselect";
            this.btnBrmUnselect.Size = new System.Drawing.Size(75, 23);
            this.btnBrmUnselect.TabIndex = 13;
            this.btnBrmUnselect.Text = "Unselect";
            this.btnBrmUnselect.UseVisualStyleBackColor = true;
            this.btnBrmUnselect.Click += new System.EventHandler(this.BtnBrmUnselect_Click);
            // 
            // btnBmrCalc
            // 
            this.btnBmrCalc.Location = new System.Drawing.Point(11, 209);
            this.btnBmrCalc.Name = "btnBmrCalc";
            this.btnBmrCalc.Size = new System.Drawing.Size(75, 23);
            this.btnBmrCalc.TabIndex = 12;
            this.btnBmrCalc.Text = "Calculate";
            this.btnBmrCalc.UseVisualStyleBackColor = true;
            this.btnBmrCalc.Click += new System.EventHandler(this.btnBmrCalc_Click);
            // 
            // lboxBmr
            // 
            this.lboxBmr.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxBmr.FormattingEnabled = true;
            this.lboxBmr.ItemHeight = 12;
            this.lboxBmr.Location = new System.Drawing.Point(269, 67);
            this.lboxBmr.Name = "lboxBmr";
            this.lboxBmr.Size = new System.Drawing.Size(305, 136);
            this.lboxBmr.TabIndex = 11;
            this.lboxBmr.SelectedIndexChanged += new System.EventHandler(this.LboxBmr_SelectedIndexChanged);
            // 
            // grpActivity
            // 
            this.grpActivity.Controls.Add(this.radALight);
            this.grpActivity.Controls.Add(this.radAModerate);
            this.grpActivity.Controls.Add(this.radAVery);
            this.grpActivity.Controls.Add(this.radAExtra);
            this.grpActivity.Controls.Add(this.radASedentary);
            this.grpActivity.Location = new System.Drawing.Point(10, 69);
            this.grpActivity.Name = "grpActivity";
            this.grpActivity.Size = new System.Drawing.Size(244, 134);
            this.grpActivity.TabIndex = 10;
            this.grpActivity.TabStop = false;
            this.grpActivity.Text = "Activity level per week";
            // 
            // radALight
            // 
            this.radALight.AutoSize = true;
            this.radALight.Location = new System.Drawing.Point(7, 42);
            this.radALight.Name = "radALight";
            this.radALight.Size = new System.Drawing.Size(138, 17);
            this.radALight.TabIndex = 5;
            this.radALight.Text = "Lightly active (1-3 times)";
            this.radALight.UseVisualStyleBackColor = true;
            this.radALight.CheckedChanged += new System.EventHandler(this.RadALight_CheckedChanged);
            // 
            // radAModerate
            // 
            this.radAModerate.AutoSize = true;
            this.radAModerate.Location = new System.Drawing.Point(7, 65);
            this.radAModerate.Name = "radAModerate";
            this.radAModerate.Size = new System.Drawing.Size(166, 17);
            this.radAModerate.TabIndex = 4;
            this.radAModerate.Text = "Moderately active (3 - 5 times)";
            this.radAModerate.UseVisualStyleBackColor = true;
            this.radAModerate.CheckedChanged += new System.EventHandler(this.RadAModerate_CheckedChanged);
            // 
            // radAVery
            // 
            this.radAVery.AutoSize = true;
            this.radAVery.Location = new System.Drawing.Point(7, 88);
            this.radAVery.Name = "radAVery";
            this.radAVery.Size = new System.Drawing.Size(124, 17);
            this.radAVery.TabIndex = 3;
            this.radAVery.Text = "Very active (6-7 time)";
            this.radAVery.UseVisualStyleBackColor = true;
            this.radAVery.CheckedChanged += new System.EventHandler(this.RadAVery_CheckedChanged);
            // 
            // radAExtra
            // 
            this.radAExtra.AutoSize = true;
            this.radAExtra.Location = new System.Drawing.Point(7, 111);
            this.radAExtra.Name = "radAExtra";
            this.radAExtra.Size = new System.Drawing.Size(184, 17);
            this.radAExtra.TabIndex = 2;
            this.radAExtra.Text = "Extra active, hard excersise or job";
            this.radAExtra.UseVisualStyleBackColor = true;
            this.radAExtra.CheckedChanged += new System.EventHandler(this.RadAExtra_CheckedChanged);
            // 
            // radASedentary
            // 
            this.radASedentary.AutoSize = true;
            this.radASedentary.Checked = true;
            this.radASedentary.Location = new System.Drawing.Point(7, 19);
            this.radASedentary.Name = "radASedentary";
            this.radASedentary.Size = new System.Drawing.Size(175, 17);
            this.radASedentary.TabIndex = 1;
            this.radASedentary.TabStop = true;
            this.radASedentary.Text = "Sedentary (little or no excersice)";
            this.radASedentary.UseVisualStyleBackColor = true;
            this.radASedentary.CheckedChanged += new System.EventHandler(this.RadASedentary_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(62, 43);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(68, 20);
            this.txtAge.TabIndex = 9;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 46);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(82, 20);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 1;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            this.radMale.CheckedChanged += new System.EventHandler(this.RadMale_CheckedChanged);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Checked = true;
            this.radFemale.Location = new System.Drawing.Point(17, 20);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 0;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            this.radFemale.CheckedChanged += new System.EventHandler(this.RadFemale_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 576);
            this.Controls.Add(this.grpBmi);
            this.Controls.Add(this.grpFuel);
            this.Controls.Add(this.grpBmr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Universal calculator";
            this.grpFuel.ResumeLayout(false);
            this.grpFuel.PerformLayout();
            this.grpFuelResults.ResumeLayout(false);
            this.grpFuelResults.PerformLayout();
            this.grpBmi.ResumeLayout(false);
            this.grpBmi.PerformLayout();
            this.grpBmiResults.ResumeLayout(false);
            this.grpBmiResults.PerformLayout();
            this.grpBmr.ResumeLayout(false);
            this.grpBmr.PerformLayout();
            this.grpActivity.ResumeLayout(false);
            this.grpActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFuel;
        private System.Windows.Forms.Button btnFuelCalc;
        private System.Windows.Forms.TextBox txtFuelPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrevKm;
        private System.Windows.Forms.TextBox txtCurrentKm;
        private System.Windows.Forms.Label lblFuelPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPrevKm;
        private System.Windows.Forms.Label lblCurrentKm;
        private System.Windows.Forms.GroupBox grpFuelResults;
        private System.Windows.Forms.Label lblFuelResCostKm;
        private System.Windows.Forms.Label lblFuelResMil;
        private System.Windows.Forms.Label lblFuelResLitMile;
        private System.Windows.Forms.Label lblFuelResLitKm;
        private System.Windows.Forms.Label lblFuelResKmLit;
        private System.Windows.Forms.Label lblFuelResults_5;
        private System.Windows.Forms.Label lblFuelResults_4;
        private System.Windows.Forms.Label lblFuelResults_3;
        private System.Windows.Forms.Label lblFuelResults_2;
        private System.Windows.Forms.Label lblFuelResults_1;
        private System.Windows.Forms.GroupBox grpBmi;
        private System.Windows.Forms.RadioButton radUs;
        private System.Windows.Forms.RadioButton radMetric;
        private System.Windows.Forms.Button btnBmiCalc;
        private System.Windows.Forms.TextBox txtBmiWeight;
        private System.Windows.Forms.TextBox txtBmiHeight;
        private System.Windows.Forms.TextBox txtBmiName;
        private System.Windows.Forms.Label lblBmiWeight;
        private System.Windows.Forms.Label lblBmiHeight;
        private System.Windows.Forms.Label lnlBmiName;
        private System.Windows.Forms.GroupBox grpBmiResults;
        private System.Windows.Forms.Label lblBmiResCat;
        private System.Windows.Forms.Label lblBmiResBmi;
        private System.Windows.Forms.Label lblBmiRange;
        private System.Windows.Forms.Label lblBmiResults_2;
        private System.Windows.Forms.Label lblBmiResults_1;
        private System.Windows.Forms.GroupBox grpBmr;
        private System.Windows.Forms.GroupBox grpActivity;
        private System.Windows.Forms.RadioButton radALight;
        private System.Windows.Forms.RadioButton radAModerate;
        private System.Windows.Forms.RadioButton radAVery;
        private System.Windows.Forms.RadioButton radAExtra;
        private System.Windows.Forms.RadioButton radASedentary;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Button btnBmrCalc;
        private System.Windows.Forms.ListBox lboxBmr;
        private System.Windows.Forms.Button btnBrmUnselect;
        private System.Windows.Forms.Label lblBmrSelect;
    }
}

