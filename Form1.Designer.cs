namespace PizzaOrder_in_C_
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
            this.label1 = new System.Windows.Forms.Label();
            this.gpSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gpCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinkCurst = new System.Windows.Forms.RadioButton();
            this.rbThinCurst = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chMashrooms = new System.Windows.Forms.CheckBox();
            this.chExtraChess = new System.Windows.Forms.CheckBox();
            this.gpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.gpSize.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 90F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1098, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // gpSize
            // 
            this.gpSize.Controls.Add(this.rbLarge);
            this.gpSize.Controls.Add(this.rbMedium);
            this.gpSize.Controls.Add(this.rbSmall);
            this.gpSize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSize.Location = new System.Drawing.Point(48, 151);
            this.gpSize.Name = "gpSize";
            this.gpSize.Size = new System.Drawing.Size(331, 222);
            this.gpSize.TabIndex = 1;
            this.gpSize.TabStop = false;
            this.gpSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(17, 163);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(75, 27);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "20";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(17, 105);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(95, 27);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "16";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(17, 47);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 27);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "12";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gpCrustType
            // 
            this.gpCrustType.Controls.Add(this.rbThinkCurst);
            this.gpCrustType.Controls.Add(this.rbThinCurst);
            this.gpCrustType.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gpCrustType.Location = new System.Drawing.Point(48, 462);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.Size = new System.Drawing.Size(333, 144);
            this.gpCrustType.TabIndex = 2;
            this.gpCrustType.TabStop = false;
            this.gpCrustType.Text = "Curst Type";
            // 
            // rbThinkCurst
            // 
            this.rbThinkCurst.AutoSize = true;
            this.rbThinkCurst.Location = new System.Drawing.Point(17, 94);
            this.rbThinkCurst.Name = "rbThinkCurst";
            this.rbThinkCurst.Size = new System.Drawing.Size(123, 27);
            this.rbThinkCurst.TabIndex = 5;
            this.rbThinkCurst.TabStop = true;
            this.rbThinkCurst.Tag = "6";
            this.rbThinkCurst.Text = "Think Curst";
            this.rbThinkCurst.UseVisualStyleBackColor = true;
            this.rbThinkCurst.CheckedChanged += new System.EventHandler(this.rbThinkCurst_CheckedChanged);
            // 
            // rbThinCurst
            // 
            this.rbThinCurst.AutoSize = true;
            this.rbThinCurst.Location = new System.Drawing.Point(17, 47);
            this.rbThinCurst.Name = "rbThinCurst";
            this.rbThinCurst.Size = new System.Drawing.Size(114, 27);
            this.rbThinCurst.TabIndex = 4;
            this.rbThinCurst.TabStop = true;
            this.rbThinCurst.Tag = "3";
            this.rbThinCurst.Text = "Thin Curst";
            this.rbThinCurst.UseVisualStyleBackColor = true;
            this.rbThinCurst.CheckedChanged += new System.EventHandler(this.rbThinCurst_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.chGreenPeppers);
            this.gpToppings.Controls.Add(this.chOlives);
            this.gpToppings.Controls.Add(this.chOnion);
            this.gpToppings.Controls.Add(this.chTomatoes);
            this.gpToppings.Controls.Add(this.chMashrooms);
            this.gpToppings.Controls.Add(this.chExtraChess);
            this.gpToppings.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gpToppings.Location = new System.Drawing.Point(450, 151);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(383, 222);
            this.gpToppings.TabIndex = 3;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chGreenPeppers
            // 
            this.chGreenPeppers.AutoSize = true;
            this.chGreenPeppers.Location = new System.Drawing.Point(221, 163);
            this.chGreenPeppers.Name = "chGreenPeppers";
            this.chGreenPeppers.Size = new System.Drawing.Size(131, 23);
            this.chGreenPeppers.TabIndex = 11;
            this.chGreenPeppers.Tag = "5";
            this.chGreenPeppers.Text = "Green Peppers";
            this.chGreenPeppers.UseVisualStyleBackColor = true;
            this.chGreenPeppers.CheckedChanged += new System.EventHandler(this.chGreenPeppers_CheckedChanged);
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Location = new System.Drawing.Point(221, 105);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(71, 23);
            this.chOlives.TabIndex = 9;
            this.chOlives.Tag = "2";
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            this.chOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Location = new System.Drawing.Point(221, 51);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(71, 23);
            this.chOnion.TabIndex = 7;
            this.chOnion.Tag = "2";
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            this.chOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Location = new System.Drawing.Point(39, 163);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(98, 23);
            this.chTomatoes.TabIndex = 10;
            this.chTomatoes.Tag = "2";
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            this.chTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chMashrooms
            // 
            this.chMashrooms.AutoSize = true;
            this.chMashrooms.Location = new System.Drawing.Point(37, 105);
            this.chMashrooms.Name = "chMashrooms";
            this.chMashrooms.Size = new System.Drawing.Size(109, 23);
            this.chMashrooms.TabIndex = 8;
            this.chMashrooms.Tag = "4";
            this.chMashrooms.Text = "Mashrooms";
            this.chMashrooms.UseVisualStyleBackColor = true;
            this.chMashrooms.CheckedChanged += new System.EventHandler(this.chMashrooms_CheckedChanged);
            // 
            // chExtraChess
            // 
            this.chExtraChess.AutoSize = true;
            this.chExtraChess.Location = new System.Drawing.Point(39, 47);
            this.chExtraChess.Name = "chExtraChess";
            this.chExtraChess.Size = new System.Drawing.Size(107, 23);
            this.chExtraChess.TabIndex = 6;
            this.chExtraChess.Tag = "6";
            this.chExtraChess.Text = "Extra chess";
            this.chExtraChess.UseVisualStyleBackColor = true;
            this.chExtraChess.CheckedChanged += new System.EventHandler(this.chExtraChess_CheckedChanged);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.Controls.Add(this.rbTakeOut);
            this.gpWhereToEat.Controls.Add(this.rbEatIn);
            this.gpWhereToEat.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gpWhereToEat.Location = new System.Drawing.Point(450, 413);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.Size = new System.Drawing.Size(383, 144);
            this.gpWhereToEat.TabIndex = 4;
            this.gpWhereToEat.TabStop = false;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(217, 60);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(104, 27);
            this.rbTakeOut.TabIndex = 13;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(11, 60);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(79, 27);
            this.rbEatIn.TabIndex = 12;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnOrderPizza.Location = new System.Drawing.Point(450, 582);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(157, 55);
            this.btnOrderPizza.TabIndex = 14;
            this.btnOrderPizza.Text = "Order";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnResetForm.Location = new System.Drawing.Point(671, 582);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(157, 55);
            this.btnResetForm.TabIndex = 15;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gpSummary
            // 
            this.gpSummary.Controls.Add(this.lblToppings);
            this.gpSummary.Controls.Add(this.lblTotalPrice);
            this.gpSummary.Controls.Add(this.label11);
            this.gpSummary.Controls.Add(this.lblCrustType);
            this.gpSummary.Controls.Add(this.label12);
            this.gpSummary.Controls.Add(this.lblWhereToEat);
            this.gpSummary.Controls.Add(this.label10);
            this.gpSummary.Controls.Add(this.label3);
            this.gpSummary.Controls.Add(this.lblSize);
            this.gpSummary.Controls.Add(this.label2);
            this.gpSummary.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gpSummary.Location = new System.Drawing.Point(881, 154);
            this.gpSummary.Name = "gpSummary";
            this.gpSummary.Size = new System.Drawing.Size(508, 544);
            this.gpSummary.TabIndex = 7;
            this.gpSummary.TabStop = false;
            this.gpSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 67.25F);
            this.lblTotalPrice.Location = new System.Drawing.Point(220, 402);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 109);
            this.lblTotalPrice.TabIndex = 14;
            this.lblTotalPrice.Tag = "0";
            this.lblTotalPrice.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Price : ";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(166, 253);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(96, 23);
            this.lblCrustType.TabIndex = 12;
            this.lblCrustType.Text = "Thin Curst";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 23);
            this.label12.TabIndex = 11;
            this.label12.Text = "Where to Eat :";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(173, 338);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(86, 23);
            this.lblWhereToEat.TabIndex = 10;
            this.lblWhereToEat.Text = "Take Out";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Curst Type : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toppings : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(142, 60);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(55, 23);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Small";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size : ";
            // 
            // lblToppings
            // 
            this.lblToppings.Location = new System.Drawing.Point(146, 160);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(342, 59);
            this.lblToppings.TabIndex = 15;
            this.lblToppings.Text = "No Toppings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 707);
            this.Controls.Add(this.gpSummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpWhereToEat);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpCrustType);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpSummary.ResumeLayout(false);
            this.gpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gpCrustType;
        private System.Windows.Forms.RadioButton rbThinkCurst;
        private System.Windows.Forms.RadioButton rbThinCurst;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chMashrooms;
        private System.Windows.Forms.CheckBox chExtraChess;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chGreenPeppers;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.GroupBox gpWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gpSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblToppings;
    }
}

