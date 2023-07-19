namespace Your_salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ми й не сумнівалися, що ви так думаєте");
        }

        private void buttonNO_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(0, ClientSize.Width - buttonNO.Width);
            int y = rand.Next(0, ClientSize.Height - buttonNO.Height);
            buttonNO.Location = new Point(x, y);
        }
    }
}