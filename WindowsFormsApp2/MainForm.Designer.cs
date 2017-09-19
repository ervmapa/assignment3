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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFuelPrice = new System.Windows.Forms.Label();
            this.lblCurAmount = new System.Windows.Forms.Label();
            this.lblPrevOdo = new System.Windows.Forms.Label();
            this.lblCurrentOdo = new System.Windows.Forms.Label();
            this.grpFuelResults = new System.Windows.Forms.GroupBox();
            this.lblFuelResCostKm = new System.Windows.Forms.Label();
            this.lblFuelResKmSmil = new System.Windows.Forms.Label();
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblBmiWeight = new System.Windows.Forms.Label();
            this.lblBmiHeight = new System.Windows.Forms.Label();
            this.lblBmiName = new System.Windows.Forms.Label();
            this.grpBmiResults = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblBmiResults = new System.Windows.Forms.Label();
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
            this.grpFuel.Controls.Add(this.textBox3);
            this.grpFuel.Controls.Add(this.textBox2);
            this.grpFuel.Controls.Add(this.textBox1);
            this.grpFuel.Controls.Add(this.lblFuelPrice);
            this.grpFuel.Controls.Add(this.lblCurAmount);
            this.grpFuel.Controls.Add(this.lblPrevOdo);
            this.grpFuel.Controls.Add(this.lblCurrentOdo);
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
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(157, 96);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.Size = new System.Drawing.Size(100, 20);
            this.txtFuelPrice.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 5;
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
            // lblCurAmount
            // 
            this.lblCurAmount.AutoSize = true;
            this.lblCurAmount.Location = new System.Drawing.Point(8, 71);
            this.lblCurAmount.Name = "lblCurAmount";
            this.lblCurAmount.Size = new System.Drawing.Size(165, 13);
            this.lblCurAmount.TabIndex = 3;
            this.lblCurAmount.Text = "Current amount of fuel tank (liters)";
            // 
            // lblPrevOdo
            // 
            this.lblPrevOdo.AutoSize = true;
            this.lblPrevOdo.Location = new System.Drawing.Point(8, 42);
            this.lblPrevOdo.Name = "lblPrevOdo";
            this.lblPrevOdo.Size = new System.Drawing.Size(156, 13);
            this.lblPrevOdo.TabIndex = 2;
            this.lblPrevOdo.Text = "Previous odometer reading (km)";
            // 
            // lblCurrentOdo
            // 
            this.lblCurrentOdo.AutoSize = true;
            this.lblCurrentOdo.Location = new System.Drawing.Point(8, 18);
            this.lblCurrentOdo.Name = "lblCurrentOdo";
            this.lblCurrentOdo.Size = new System.Drawing.Size(149, 13);
            this.lblCurrentOdo.TabIndex = 1;
            this.lblCurrentOdo.Text = "Current odometer reading (km)";
            // 
            // grpFuelResults
            // 
            this.grpFuelResults.Controls.Add(this.lblFuelResCostKm);
            this.grpFuelResults.Controls.Add(this.lblFuelResKmSmil);
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
            this.lblFuelResCostKm.AutoSize = true;
            this.lblFuelResCostKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResCostKm.Location = new System.Drawing.Point(190, 134);
            this.lblFuelResCostKm.Name = "lblFuelResCostKm";
            this.lblFuelResCostKm.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResCostKm.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResCostKm.TabIndex = 14;
            this.lblFuelResCostKm.Text = "label10";
            // 
            // lblFuelResKmSmil
            // 
            this.lblFuelResKmSmil.AutoSize = true;
            this.lblFuelResKmSmil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResKmSmil.Location = new System.Drawing.Point(190, 107);
            this.lblFuelResKmSmil.Name = "lblFuelResKmSmil";
            this.lblFuelResKmSmil.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResKmSmil.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResKmSmil.TabIndex = 13;
            this.lblFuelResKmSmil.Text = "label11";
            // 
            // lblFuelResLitMile
            // 
            this.lblFuelResLitMile.AutoSize = true;
            this.lblFuelResLitMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResLitMile.Location = new System.Drawing.Point(190, 79);
            this.lblFuelResLitMile.Name = "lblFuelResLitMile";
            this.lblFuelResLitMile.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResLitMile.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResLitMile.TabIndex = 12;
            this.lblFuelResLitMile.Text = "label12";
            // 
            // lblFuelResLitKm
            // 
            this.lblFuelResLitKm.AutoSize = true;
            this.lblFuelResLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResLitKm.Location = new System.Drawing.Point(190, 52);
            this.lblFuelResLitKm.Name = "lblFuelResLitKm";
            this.lblFuelResLitKm.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResLitKm.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResLitKm.TabIndex = 11;
            this.lblFuelResLitKm.Text = "label13";
            // 
            // lblFuelResKmLit
            // 
            this.lblFuelResKmLit.AutoSize = true;
            this.lblFuelResKmLit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFuelResKmLit.Location = new System.Drawing.Point(190, 26);
            this.lblFuelResKmLit.Name = "lblFuelResKmLit";
            this.lblFuelResKmLit.Padding = new System.Windows.Forms.Padding(2);
            this.lblFuelResKmLit.Size = new System.Drawing.Size(47, 19);
            this.lblFuelResKmLit.TabIndex = 10;
            this.lblFuelResKmLit.Text = "label14";
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
            this.lblFuelResults_3.Location = new System.Drawing.Point(6, 79);
            this.lblFuelResults_3.Name = "lblFuelResults_3";
            this.lblFuelResults_3.Size = new System.Drawing.Size(163, 13);
            this.lblFuelResults_3.TabIndex = 7;
            this.lblFuelResults_3.Text = " Fuel consumption (lit/metric mile)";
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
            this.grpBmi.Controls.Add(this.textBox6);
            this.grpBmi.Controls.Add(this.textBox7);
            this.grpBmi.Controls.Add(this.textBox8);
            this.grpBmi.Controls.Add(this.lblBmiWeight);
            this.grpBmi.Controls.Add(this.lblBmiHeight);
            this.grpBmi.Controls.Add(this.lblBmiName);
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
            this.radUs.TabStop = true;
            this.radUs.Text = "US (lb, inch)";
            this.radUs.UseVisualStyleBackColor = true;
            // 
            // radMetric
            // 
            this.radMetric.AutoSize = true;
            this.radMetric.Location = new System.Drawing.Point(212, 45);
            this.radMetric.Name = "radMetric";
            this.radMetric.Size = new System.Drawing.Size(95, 17);
            this.radMetric.TabIndex = 8;
            this.radMetric.TabStop = true;
            this.radMetric.Text = "Metric (kg, cm)";
            this.radMetric.UseVisualStyleBackColor = true;
            // 
            // btnBmiCalc
            // 
            this.btnBmiCalc.Location = new System.Drawing.Point(10, 130);
            this.btnBmiCalc.Name = "btnBmiCalc";
            this.btnBmiCalc.Size = new System.Drawing.Size(75, 23);
            this.btnBmiCalc.TabIndex = 10;
            this.btnBmiCalc.Text = "button2";
            this.btnBmiCalc.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(106, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(106, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(106, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(202, 20);
            this.textBox8.TabIndex = 5;
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
            // lblBmiName
            // 
            this.lblBmiName.AutoSize = true;
            this.lblBmiName.Location = new System.Drawing.Point(7, 20);
            this.lblBmiName.Name = "lblBmiName";
            this.lblBmiName.Size = new System.Drawing.Size(58, 13);
            this.lblBmiName.TabIndex = 1;
            this.lblBmiName.Text = "Your name";
            // 
            // grpBmiResults
            // 
            this.grpBmiResults.Controls.Add(this.label22);
            this.grpBmiResults.Controls.Add(this.label23);
            this.grpBmiResults.Controls.Add(this.lblBmiResults);
            this.grpBmiResults.Controls.Add(this.lblBmiResults_2);
            this.grpBmiResults.Controls.Add(this.lblBmiResults_1);
            this.grpBmiResults.Location = new System.Drawing.Point(10, 168);
            this.grpBmiResults.Name = "grpBmiResults";
            this.grpBmiResults.Size = new System.Drawing.Size(298, 157);
            this.grpBmiResults.TabIndex = 0;
            this.grpBmiResults.TabStop = false;
            this.grpBmiResults.Text = "Results";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(96, 58);
            this.label22.Name = "label22";
            this.label22.Padding = new System.Windows.Forms.Padding(2);
            this.label22.Size = new System.Drawing.Size(47, 19);
            this.label22.TabIndex = 11;
            this.label22.Text = "label22";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(96, 26);
            this.label23.Name = "label23";
            this.label23.Padding = new System.Windows.Forms.Padding(2);
            this.label23.Size = new System.Drawing.Size(47, 19);
            this.label23.TabIndex = 10;
            this.label23.Text = "label23";
            // 
            // lblBmiResults
            // 
            this.lblBmiResults.AutoSize = true;
            this.lblBmiResults.Location = new System.Drawing.Point(6, 85);
            this.lblBmiResults.Name = "lblBmiResults";
            this.lblBmiResults.Size = new System.Drawing.Size(41, 13);
            this.lblBmiResults.TabIndex = 9;
            this.lblBmiResults.Text = "label24";
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFuelPrice;
        private System.Windows.Forms.Label lblCurAmount;
        private System.Windows.Forms.Label lblPrevOdo;
        private System.Windows.Forms.Label lblCurrentOdo;
        private System.Windows.Forms.GroupBox grpFuelResults;
        private System.Windows.Forms.Label lblFuelResCostKm;
        private System.Windows.Forms.Label lblFuelResKmSmil;
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblBmiWeight;
        private System.Windows.Forms.Label lblBmiHeight;
        private System.Windows.Forms.Label lblBmiName;
        private System.Windows.Forms.GroupBox grpBmiResults;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblBmiResults;
        private System.Windows.Forms.Label lblBmiResults_2;
        private System.Windows.Forms.Label lblBmiResults_1;
    }
}

