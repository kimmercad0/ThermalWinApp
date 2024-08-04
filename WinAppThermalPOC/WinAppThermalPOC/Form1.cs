namespace WinAppThermalPOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetField();
        }

        private void CelciusTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CelciusTxt.Text) && CelciusTxt.Focused)
            {
                int celVal;
                if (int.TryParse((CelciusTxt.Text), out celVal))
                {

                    if (celVal < -30 || celVal > 200)
                    {
                        MessageBox.Show("Temperature must be between -30 and 200 degrees Celsius");
                        ResetField();
                    }
                    else
                    {
                        CelciusTrackBar.Value = celVal;
                        farenheitTxt.Text = ComputeFarenheit(celVal).ToString();
                        TempScrollColorChange(celVal);
                    }
                }
            }
        }

        private void farenheitTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(farenheitTxt.Text) && farenheitTxt.Focused)
            {
                int farenheitVal;
                if (int.TryParse((farenheitTxt.Text), out farenheitVal))
                {
                    int celciusVal = ComputeCelcius(farenheitVal);
                    if (celciusVal < -30 || celciusVal > 200)
                    {
                        MessageBox.Show("Temperature must be between -30 and 200 degrees Celsius");
                        ResetField();
                    }
                    else
                    {
                        CelciusTxt.Text = celciusVal.ToString();
                        CelciusTrackBar.Value = celciusVal;
                        TempScrollColorChange(celciusVal);
                    }
                }
            }
        }

        private void CelciusTrackBar_Scroll(object sender, EventArgs e)
        {
            if (CelciusTrackBar.Focused)
            {
                int celVal = CelciusTrackBar.Value;
                CelciusTxt.Text = celVal.ToString();
                farenheitTxt.Text = ComputeFarenheit(celVal).ToString();
                TempScrollColorChange(celVal);
            }
        }

        private void CelciusTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || CelciusTxt.SelectionStart != 0 || CelciusTxt.Text.Contains("-")))
            {
                e.Handled = true; // Discard non-numeric input
            }
        }

        private void farenheitTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || farenheitTxt.SelectionStart != 0 || farenheitTxt.Text.Contains("-")))
            {
                e.Handled = true; // Discard non-numeric input
            }
        }

        private int ComputeCelcius(int farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }

        private int ComputeFarenheit(int celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        private void TempScrollColorChange(int currentTemp)
        {
            if (currentTemp < 0)
            {
                CelciusTrackBar.BackColor = Color.DarkBlue;
            }
            else if (currentTemp >= 0 && currentTemp <= 10)
            {
                CelciusTrackBar.BackColor = Color.LightBlue;
            }
            else if (currentTemp > 10 && currentTemp <= 20)
            {
                CelciusTrackBar.BackColor = Color.Green;
            }
            else if (currentTemp > 20 && currentTemp <= 30)
            {
                CelciusTrackBar.BackColor = Color.Yellow;
            }
            else if (currentTemp > 30 && currentTemp <= 40)
            {
                CelciusTrackBar.BackColor = Color.Orange;
            }
            else if (currentTemp > 40)
            {
                CelciusTrackBar.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void ResetField()
        {
            CelciusTxt.Text = "0";
            farenheitTxt.Text = "0";
            CelciusTrackBar.Value = 0;
            CelciusTrackBar.BackColor = Color.DarkBlue;
        }
    }
}
