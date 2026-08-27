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



        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(rbSmall.Tag.ToString());

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
                lblTotalPrice.Tag = TotalPrice - Value;

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(rbMedium.Tag.ToString());

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
                lblTotalPrice.Tag = TotalPrice - Value;

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(rbLarge.Tag.ToString());

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
                lblTotalPrice.Tag = TotalPrice - Value;

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void rbThinCurst_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(rbThinCurst.Tag.ToString());

            if (rbThinCurst.Checked)
            {
                lblCrustType.Text = "Thin Curst";
                lblTotalPrice.Tag = TotalPrice + Value;

            }
            else
                lblTotalPrice.Tag = TotalPrice - Value;

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();

        }

        private void rbThinkCurst_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(rbThinkCurst.Tag.ToString());

            if (rbThinkCurst.Checked)
            {
                lblCrustType.Text = "Thick Curst";
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
                lblTotalPrice.Tag = TotalPrice - Value;

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void chExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(chExtraChess.Tag.ToString());

            if (chExtraChess.Checked)
            {
                lblExtraChess.Visible = true;
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
            {
                lblExtraChess.Visible = false;
                lblTotalPrice.Tag = TotalPrice - Value;
            }

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(chOnion.Tag.ToString());

            if (chOnion.Checked)
            {
                lblOnion.Visible = true;
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
            {
                lblOnion.Visible = false;
                lblTotalPrice.Tag = TotalPrice - Value;
            }

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void chMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(chMashrooms.Tag.ToString());

            if (chMashrooms.Checked)
            {
                lblMashrooms.Visible = true;
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
            {
                lblMashrooms.Visible = false;
                lblTotalPrice.Tag = TotalPrice - Value;
            }

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(chOlives.Tag.ToString());

            if (chOlives.Checked)
            {
                lblOlives.Visible = true;
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
            {
                lblOlives.Visible = false;
                lblTotalPrice.Tag = TotalPrice - Value;
            }

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(chTomatoes.Tag.ToString());

            if (chTomatoes.Checked)
            {
                lblTomatoes.Visible = true;
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
            {
                lblTomatoes.Visible = false;
                lblTotalPrice.Tag = TotalPrice - Value;
            }

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void chGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(lblTotalPrice.Tag);
            int Value = int.Parse(chGreenPeppers.Tag.ToString());

            if (chGreenPeppers.Checked)
            {
                lblGreenPeppers.Visible = true;
                lblTotalPrice.Tag = TotalPrice + Value;
            }
            else
            {
                lblGreenPeppers.Visible = false;
                lblTotalPrice.Tag = TotalPrice - Value;
            }

            lblTotalPrice.Text = lblTotalPrice.Tag.ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
            }
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
            }
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to place this order?", "Order Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Your order has been placed successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetOrder();
            }

        }

        private void ResetOrder()
        {
            rbSmall.Checked = true;
            rbThinCurst.Checked = true;
            rbEatIn.Checked = true;

            chExtraChess.Checked = false;
            chOnion.Checked = false;
            chMashrooms.Checked = false;
            chOlives.Checked = false;
            chTomatoes.Checked = false;
            chGreenPeppers.Checked = false;

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetOrder();
        }

        
    }


}
