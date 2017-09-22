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
            this.grpFuel.SuspendLayout();
            this.grpFuelResults.SuspendLayout();
            this.grpBmi.SuspendLayout();
            this.grpBmiResults.SuspendLayout();
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
            this.grpFuel.Size = new System.Drawing.Size(263, 331);
            this.grpFuel.TabIndex = 0;
            this.grpFuel.TabStop = false;
            this.grpFuel.Text = "Fuel";
            // 
            // btnFuelCalc
            // 
            this.btnFuelCalc.Location = new System.Drawing.Point(10, 130);
            this.btnFuelCalc.Name = "btnFuelCalc";
            this.btnFuelCalc.Size = new System.Drawing.Size(75, 23);
            this.btnFuelCalc.TabIndex = 9;
            this.btnFuelCalc.Text = "Calculate";
            this.btnFuelCalc.UseVisualStyleBackColor = true;
            this.btnFuelCalc.Click += new System.EventHandler(this.btnFuelCalc_Click);
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
            this.grpFuelResults.Location = new System.Drawing.Point(10, 168);
            this.grpFuelResults.Name = "grpFuelResults";
            this.grpFuelResults.Size = new System.Drawing.Size(247, 157);
            this.grpFuelResults.TabIndex = 0;
            this.grpFuelResults.TabStop = false;
            this.grpFuelResults.Text = "Results";
            // 
            // lblFuelResCostKm
            // 
            this.lblFuelResCostKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResCostKm.Location = new System.Drawing.Point(190, 134);
            this.lblFuelResCostKm.Name = "lblFuelResCostKm";
            this.lblFuelResCostKm.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResCostKm.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResCostKm.TabIndex = 14;
            // 
            // lblFuelResMil
            // 
            this.lblFuelResMil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResMil.Location = new System.Drawing.Point(190, 107);
            this.lblFuelResMil.Name = "lblFuelResMil";
            this.lblFuelResMil.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResMil.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResMil.TabIndex = 13;
            // 
            // lblFuelResLitMile
            // 
            this.lblFuelResLitMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResLitMile.Location = new System.Drawing.Point(190, 79);
            this.lblFuelResLitMile.Name = "lblFuelResLitMile";
            this.lblFuelResLitMile.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResLitMile.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResLitMile.TabIndex = 12;
            // 
            // lblFuelResLitKm
            // 
            this.lblFuelResLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResLitKm.Location = new System.Drawing.Point(190, 52);
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
            this.lblFuelResults_5.Location = new System.Drawing.Point(6, 136);
            this.lblFuelResults_5.Name = "lblFuelResults_5";
            this.lblFuelResults_5.Size = new System.Drawing.Size(91, 13);
            this.lblFuelResults_5.TabIndex = 9;
            this.lblFuelResults_5.Text = "Cost per kilometer";
            // 
            // lblFuelResults_4
            // 
            this.lblFuelResults_4.AutoSize = true;
            this.lblFuelResults_4.Location = new System.Drawing.Point(6, 109);
            this.lblFuelResults_4.Name = "lblFuelResults_4";
            this.lblFuelResults_4.Size = new System.Drawing.Size(164, 13);
            this.lblFuelResults_4.TabIndex = 8;
            this.lblFuelResults_4.Text = "Fuel consumption (lit/swedish mil)";
            // 
            // lblFuelResults_3
            // 
            this.lblFuelResults_3.AutoSize = true;
            this.lblFuelResults_3.Location = new System.Drawing.Point(6, 80);
            this.lblFuelResults_3.Name = "lblFuelResults_3";
            this.lblFuelResults_3.Size = new System.Drawing.Size(160, 13);
            this.lblFuelResults_3.TabIndex = 7;
            this.lblFuelResults_3.Text = "Fuel consumption (lit/metric mile)";
            // 
            // lblFuelResults_2
            // 
            this.lblFuelResults_2.AutoSize = true;
            this.lblFuelResults_2.Location = new System.Drawing.Point(6, 52);
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
            this.grpBmi.Size = new System.Drawing.Size(316, 331);
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
            this.radUs.CheckedChanged += new System.EventHandler(this.radUs_CheckedChanged);
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
            this.radMetric.CheckedChanged += new System.EventHandler(this.radMetric_CheckedChanged);
            // 
            // btnBmiCalc
            // 
            this.btnBmiCalc.Location = new System.Drawing.Point(10, 130);
            this.btnBmiCalc.Name = "btnBmiCalc";
            this.btnBmiCalc.Size = new System.Drawing.Size(75, 23);
            this.btnBmiCalc.TabIndex = 10;
            this.btnBmiCalc.Text = "Calculate";
            this.btnBmiCalc.UseVisualStyleBackColor = true;
            this.btnBmiCalc.Click += new System.EventHandler(this.btnBmiCalc_Click);
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
            this.grpBmiResults.Location = new System.Drawing.Point(13, 168);
            this.grpBmiResults.Name = "grpBmiResults";
            this.grpBmiResults.Size = new System.Drawing.Size(295, 157);
            this.grpBmiResults.TabIndex = 0;
            this.grpBmiResults.TabStop = false;
            this.grpBmiResults.Text = "Results";
            // 
            // lblBmiResCat
            // 
            this.lblBmiResCat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResCat.Location = new System.Drawing.Point(96, 58);
            this.lblBmiResCat.Name = "lblBmiResCat";
            this.lblBmiResCat.Padding = new System.Windows.Forms.Padding(2);
            this.lblBmiResCat.Size = new System.Drawing.Size(100, 19);
            this.lblBmiResCat.TabIndex = 11;
            this.lblBmiResCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBmiResBmi
            // 
            this.lblBmiResBmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBmiResBmi.Location = new System.Drawing.Point(96, 26);
            this.lblBmiResBmi.Name = "lblBmiResBmi";
            this.lblBmiResBmi.Padding = new System.Windows.Forms.Padding(2);
            this.lblBmiResBmi.Size = new System.Drawing.Size(100, 19);
            this.lblBmiResBmi.TabIndex = 10;
            this.lblBmiResBmi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBmiRange
            // 
            this.lblBmiRange.Location = new System.Drawing.Point(6, 96);
            this.lblBmiRange.Name = "lblBmiRange";
            this.lblBmiRange.Size = new System.Drawing.Size(276, 53);
            this.lblBmiRange.TabIndex = 9;
            // 
            // lblBmiResults_2
            // 
            this.lblBmiResults_2.AutoSize = true;
            this.lblBmiResults_2.Location = new System.Drawing.Point(6, 58);
            this.lblBmiResults_2.Name = "lblBmiResults_2";
            this.lblBmiResults_2.Size = new System.Drawing.Size(85, 13);
            this.lblBmiResults_2.TabIndex = 6;
            this.lblBmiResults_2.Text = "Weight category";
            // 
            // lblBmiResults_1
            // 
            this.lblBmiResults_1.AutoSize = true;
            this.lblBmiResults_1.Location = new System.Drawing.Point(6, 28);
            this.lblBmiResults_1.Name = "lblBmiResults_1";
            this.lblBmiResults_1.Size = new System.Drawing.Size(51, 13);
            this.lblBmiResults_1.TabIndex = 5;
            this.lblBmiResults_1.Text = "Your BMI";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 367);
            this.Controls.Add(this.grpBmi);
            this.Controls.Add(this.grpFuel);
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
    }
}

