namespace Clinic_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                if (string.IsNullOrEmpty(txtPassword.Text)) txtpassworderror.Visible = true; 
                if (string.IsNullOrEmpty(txtUsername.Text)) txtusererror.Visible = true;
                return;
            }

        }
    }
}