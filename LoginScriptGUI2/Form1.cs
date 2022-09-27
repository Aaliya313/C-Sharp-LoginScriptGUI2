namespace LoginScriptGUI2
{
    public partial class LoginScriptGUI2 : Form
    {
        public LoginScriptGUI2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblSuccessfulLogin.Text = "Successful Login";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblSuccessfulLogin.Text = null;
            txtUserName.Text = null;
            txtPassword.Text = null;
        }
    }
}