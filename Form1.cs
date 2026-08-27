using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder_in_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float GetSelectedSizePrice()
        {

            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return  Convert.ToSingle(rbLarge.Tag);

        }

        float GetSelectedCrutPrice()
        {
            if (rbThinCurst.Checked)

                return Convert.ToSingle(rbThinCurst.Tag);

            else
                return Convert.ToSingle(rbThinkCurst.Tag);

        }

        float CalculateToppingsPrice()
        {

            float ToppingsTotalPrice = 0;

            if (chExtraChess.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chExtraChess.Tag);

            if (chOnion.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chExtraChess.Tag);

            if (chMashrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chMashrooms.Tag);
            }

            if (chOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chOlives.Tag);
            }

            if (chTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chTomatoes.Tag);
            }

            if (chGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chGreenPeppers.Tag);
            }



            return ToppingsTotalPrice;


        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }

        void UpdateTotalPrice()
        {

            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }

        void UpdateToppings()
        {

            UpdateTotalPrice();

            string sToppings = "";

            if (chExtraChess.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chMashrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            lblToppings.Text = sToppings;

        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCurst.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }

            if (rbThinkCurst.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out.";
                return;
            }

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCurst_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCurst_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();   
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to place this order?", "Order Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Your order has been placed successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gpSize.Enabled = false;
                gpToppings.Enabled = false;
                gpCrustType.Enabled = false;
                gpWhereToEat.Enabled = false;
            }

        }

        private void ResetForm()
        {

            gpSize.Enabled = true;
            gpToppings.Enabled = true;
            gpCrustType.Enabled = true;
            gpWhereToEat.Enabled = true;

            btnOrderPizza.Enabled = true;

            chExtraChess.Checked = false;
            chOnion.Checked = false;
            chMashrooms.Checked = false;
            chOlives.Checked = false;
            chTomatoes.Checked = false;
            chGreenPeppers.Checked = false;


            rbThinCurst.Checked = true;

            rbEatIn.Checked = true;

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            UpdateOrderSummary();
        }


    }


}
