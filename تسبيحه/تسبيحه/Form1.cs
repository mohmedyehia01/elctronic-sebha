namespace تسبيحه
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void sbhanAllah_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = i + 1;
            sbhanAllah.Text = i.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = i + 1;
           elhamd.Text = i.ToString();
        }
    }
}
