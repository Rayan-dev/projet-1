namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                UserAccount fr = new UserAccount();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue!!!!!");
            }
        }
    }
}