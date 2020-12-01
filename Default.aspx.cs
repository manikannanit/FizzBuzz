using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FizzBuzz
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string Numbers = txtNumbers.Text;
            if (string.IsNullOrWhiteSpace(Numbers)) //validate the input control
            {
                lblError.Text = "The input is empty";
            }
            else
            {
                FizzBuzz(Numbers);
            }
        }
        private void FizzBuzz(string FizzInput)
        {
            try
            {
                var Num = FizzInput.Split(',');

                foreach (var i in Num)
                    if (int.TryParse(i, out int n))
                    {
                        if (int.Parse(i) % 3 == 0 && int.Parse(i) % 5 == 0)
                        {
                            txtResult1.Items.Add("FizzBuzz");
                        }
                        else if (int.Parse(i) % 3 == 0)
                        {
                            txtResult1.Items.Add("Fizz");

                        }
                        else if (int.Parse(i) % 5 == 0)
                        {
                            txtResult1.Items.Add("Buzz");
                        }
                        else
                        {
                            txtResult1.Items.Add("Divided " + i + " By 3");
                            txtResult1.Items.Add("Divided " + i + " By 5");
                        }
                    }
                    else
                        txtResult1.Items.Add("Invalid item");
            }
            catch (Exception e)
            {
                lblError.Text = e.Message;
            }

        }
    }
}