namespace GuiDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_ClickMe_Click(object sender, EventArgs e)
        {
            label_ShortText.Text = "Clicked";
            richTextBox_ParagraphText.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button_ClickMe.Size = new System.Drawing.Size(175, (int)(numericUpDown1.Value));
        }
    }
}
