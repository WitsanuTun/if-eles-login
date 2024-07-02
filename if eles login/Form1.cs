namespace if_eles_login
{
    public partial class Form1 : Form
    {

        string username = "montree";
        string password =   "1234";
        string logusername;
        string logPassword;

        public Form1()
        {

            InitializeComponent();
        }

        private void cview_CheckedChanged(object sender, EventArgs e)
        {
            if (cview.Checked)
            {
                tpwd.UseSystemPasswordChar = false;
            }
            else
            {
                tpwd.UseSystemPasswordChar = true;
            }
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            logusername=tuser.Text;
            logPassword=tpwd.Text;
            if ((username == logusername) && (password == logPassword)) 
            {
                FormUser fuser = new FormUser();
                fuser.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ชื่อและรหัสผ่านไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tuser.Text = string.Empty; //ข้อความในช่องจะหายไป
                tpwd.Text = string.Empty;   
                tuser.Select();
            }

        }
    }
}