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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbThinkCurst = new System.Windows.Forms.RadioButton();
            this.rbThinCurst = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chExtraChess = new System.Windows.Forms.CheckBox();
            this.chMashrooms = new System.Windows.Forms.CheckBox();
            this.chTomatoes = new System.Windows.Forms.CheckBox();
            this.chOnion = new System.Windows.Forms.CheckBox();
            this.chOlives = new System.Windows.Forms.CheckBox();
            this.chGreenPeppers = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gpTakeOut = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(17, 105);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(95, 27);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(17, 47);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(73, 27);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbThinkCurst);
            this.groupBox1.Controls.Add(this.rbThinCurst);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(48, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curst Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbThinkCurst
            // 
            this.rbThinkCurst.AutoSize = true;
            this.rbThinkCurst.Location = new System.Drawing.Point(17, 94);
            this.rbThinkCurst.Name = "rbThinkCurst";
            this.rbThinkCurst.Size = new System.Drawing.Size(123, 27);
            this.rbThinkCurst.TabIndex = 1;
            this.rbThinkCurst.TabStop = true;
            this.rbThinkCurst.Text = "Think Curst";
            this.rbThinkCurst.UseVisualStyleBackColor = true;
            // 
            // rbThinCurst
            // 
            this.rbThinCurst.AutoSize = true;
            this.rbThinCurst.Location = new System.Drawing.Point(17, 47);
            this.rbThinCurst.Name = "rbThinCurst";
            this.rbThinCurst.Size = new System.Drawing.Size(114, 27);
            this.rbThinCurst.TabIndex = 0;
            this.rbThinCurst.TabStop = true;
            this.rbThinCurst.Text = "Thin Curst";
            this.rbThinCurst.UseVisualStyleBackColor = true;
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
            this.gpToppings.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chExtraChess
            // 
            this.chExtraChess.AutoSize = true;
            this.chExtraChess.Location = new System.Drawing.Point(39, 47);
            this.chExtraChess.Name = "chExtraChess";
            this.chExtraChess.Size = new System.Drawing.Size(107, 23);
            this.chExtraChess.TabIndex = 6;
            this.chExtraChess.Text = "Extra chess";
            this.chExtraChess.UseVisualStyleBackColor = true;
            // 
            // chMashrooms
            // 
            this.chMashrooms.AutoSize = true;
            this.chMashrooms.Location = new System.Drawing.Point(37, 105);
            this.chMashrooms.Name = "chMashrooms";
            this.chMashrooms.Size = new System.Drawing.Size(109, 23);
            this.chMashrooms.TabIndex = 7;
            this.chMashrooms.Text = "Mashrooms";
            this.chMashrooms.UseVisualStyleBackColor = true;
            // 
            // chTomatoes
            // 
            this.chTomatoes.AutoSize = true;
            this.chTomatoes.Location = new System.Drawing.Point(39, 163);
            this.chTomatoes.Name = "chTomatoes";
            this.chTomatoes.Size = new System.Drawing.Size(98, 23);
            this.chTomatoes.TabIndex = 8;
            this.chTomatoes.Text = "Tomatoes";
            this.chTomatoes.UseVisualStyleBackColor = true;
            // 
            // chOnion
            // 
            this.chOnion.AutoSize = true;
            this.chOnion.Location = new System.Drawing.Point(221, 51);
            this.chOnion.Name = "chOnion";
            this.chOnion.Size = new System.Drawing.Size(71, 23);
            this.chOnion.TabIndex = 9;
            this.chOnion.Text = "Onion";
            this.chOnion.UseVisualStyleBackColor = true;
            // 
            // chOlives
            // 
            this.chOlives.AutoSize = true;
            this.chOlives.Location = new System.Drawing.Point(221, 105);
            this.chOlives.Name = "chOlives";
            this.chOlives.Size = new System.Drawing.Size(71, 23);
            this.chOlives.TabIndex = 10;
            this.chOlives.Text = "Olives";
            this.chOlives.UseVisualStyleBackColor = true;
            // 
            // chGreenPeppers
            // 
            this.chGreenPeppers.AutoSize = true;
            this.chGreenPeppers.Location = new System.Drawing.Point(221, 163);
            this.chGreenPeppers.Name = "chGreenPeppers";
            this.chGreenPeppers.Size = new System.Drawing.Size(131, 23);
            this.chGreenPeppers.TabIndex = 11;
            this.chGreenPeppers.Text = "Green Peppers";
            this.chGreenPeppers.UseVisualStyleBackColor = true;
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.gpTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gbWhereToEat.Location = new System.Drawing.Point(450, 413);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(383, 144);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(11, 60);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(79, 27);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            // 
            // gpTakeOut
            // 
            this.gpTakeOut.AutoSize = true;
            this.gpTakeOut.Location = new System.Drawing.Point(217, 60);
            this.gpTakeOut.Name = "gpTakeOut";
            this.gpTakeOut.Size = new System.Drawing.Size(104, 27);
            this.gpTakeOut.TabIndex = 1;
            this.gpTakeOut.TabStop = true;
            this.gpTakeOut.Text = "Take Out";
            this.gpTakeOut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 707);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpSize.ResumeLayout(false);
            this.gpSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbThinkCurst;
        private System.Windows.Forms.RadioButton rbThinCurst;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chTomatoes;
        private System.Windows.Forms.CheckBox chMashrooms;
        private System.Windows.Forms.CheckBox chExtraChess;
        private System.Windows.Forms.CheckBox chOnion;
        private System.Windows.Forms.CheckBox chGreenPeppers;
        private System.Windows.Forms.CheckBox chOlives;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton gpTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

