namespace Calculator
{
    public partial class Calculator : Form
    {
        public decimal Result { get; set; }
        public decimal Value { get; set; }
        private Operation SelectOperation { get; set; }
        private enum Operation
        {
            Sum,
            Substation,
            Multiplication,
            Division
        }
        public Calculator()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox.Text = "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox.Text = "9";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            SelectOperation = Operation.Sum;
            Value = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            label.Text = "+";
        }

        private void substation_Click(object sender, EventArgs e)
        {
            SelectOperation = Operation.Substation;
            Value = Convert.ToDecimal(textBox.Text);
            textBox.Text = ""; 
            label.Text = "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            SelectOperation = Operation.Multiplication;
            Value = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            label.Text = "x";
        }

        private void division_Click(object sender, EventArgs e)
        {
            SelectOperation = Operation.Division;
            Value = Convert.ToDecimal(textBox.Text);
            textBox.Text = "";
            label.Text = "/";
        }

        private void total_Click(object sender, EventArgs e)
        {
            switch (SelectOperation)
            {
                case Operation.Sum:
                    Result = Value + Convert.ToDecimal(textBox.Text);
                    break;
                case Operation.Substation:
                    Result = Value - Convert.ToDecimal(textBox.Text);
                    break;
                case Operation.Multiplication:
                    Result = Value * Convert.ToDecimal(textBox.Text);
                    break;
                case Operation.Division:
                    Result = Value / Convert.ToDecimal(textBox.Text);
                    break;
            }
            textBox.Text = Convert.ToString(Result);
            label.Text = "=";
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains(","))
                textBox.Text += ",";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            label.Text = "";
        }
    }
}