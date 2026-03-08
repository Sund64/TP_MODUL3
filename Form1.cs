namespace TP_MODUL3_103022400075
{
    public partial class Form1 : Form
    {
        // accumulator holds the running total for additions
        private double accumulator = 0;
        // indicates whether the next number button press should start a new entry
        private bool newEntry = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var digit = btn.Text;

                // Treat the default text as empty
                if (newEntry || textBox1.Text == "Label Output")
                {
                    textBox1.Text = digit;
                    newEntry = false;
                }
                else
                {
                    textBox1.Text += digit;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // kept for compatibility if designer still references it
            NumberButton_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // '+' pressed: add current displayed number to accumulator and prepare for next number
        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                accumulator += value;
            }
            else
            {
                // If parsing fails, assume 0
            }

            // Prepare for next number entry
            newEntry = true;
            // Optional: clear display to indicate ready for next number
            textBox1.Text = string.Empty;
        }

        // '=' pressed: add current displayed number to accumulator, show result, reset accumulator
        private void button14_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                accumulator += value;
            }

            textBox1.Text = accumulator.ToString();

            // Reset for a fresh calculation sequence
            accumulator = 0;
            newEntry = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }
    }
}
