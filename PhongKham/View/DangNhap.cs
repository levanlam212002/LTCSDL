using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using PhongKham.Bus;
using PhongKham.View;

namespace BTL
{
    public partial class DangNhap : Form
    {
        Bus_Doctor d;
        public DangNhap()
        {
            InitializeComponent();
            d = new Bus_Doctor();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
            byte[] has = new MD5CryptoServiceProvider().ComputeHash(temp);
            string pass = has.ToString();
            //string pass = txtPassword.Text;
            int quyen = cbbQuyen.SelectedIndex;
            if (username != "" && pass != "")
            {
                if (guna2CheckBox1.Checked)
                {
                    PhongKham.Properties.Settings.Default.username = txtUserName.Text;
                    PhongKham.Properties.Settings.Default.password = txtPassword.Text;
                    PhongKham.Properties.Settings.Default.quyen = cbbQuyen.SelectedIndex;
                    PhongKham.Properties.Settings.Default.Save();
                }
                else
                {
                    PhongKham.Properties.Settings.Default.Reset();
                }
                if (d.KiemTraDangNhap(username, pass, quyen))
                {
                    if(quyen == 0)
                    {
                        this.Hide();
                        DangKy dk = new DangKy();
                        dk.ShowDialog();
                    }else
                    if(quyen == 1)
                    {
                        this.Hide();
                        BacSi bs = new BacSi();
                        bs.id = d.LayIDDoctor(username).ToString();
                        bs.ShowDialog();
                    }else
                     if(quyen == 2)
                    {
                        this.Hide();
                        Admin ad = new Admin();
                        ad.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn quyền để đăng nhập");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đủ tên đăng nhập và mật khẩu");
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbbQuyen.Items.Add("Y tá");
            cbbQuyen.Items.Add("Bác sĩ");
            cbbQuyen.Items.Add("Admin");
            txtUserName.Text = PhongKham.Properties.Settings.Default.username;
            txtPassword.Text = PhongKham.Properties.Settings.Default.password;
            cbbQuyen.SelectedIndex = PhongKham.Properties.Settings.Default.quyen;
            if (PhongKham.Properties.Settings.Default.username != "")
            {
                guna2CheckBox1.Checked = true;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        { 
                DialogResult h = MessageBox.Show
                    ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                    Application.Exit();
        }

        private static readonly string _from = "levanlam212002@gmail.com"; 
        private static readonly string _pass = "ppagbjxmcamomyxz";

        public string Send(string sendto, string subject, string content)
        { 
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        public string RandomPassword(int number)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var password = string.Empty;
            var random = new Random();
            for (var i = 0; i < number; i++)
            {
                var x = random.Next(1, chars.Length);
                if (!password.Contains(chars.GetValue(x).ToString()))
                {
                    password += chars.GetValue(x);
                }
                else
                {
                    i--;
                }
            }

            return password;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                string a = RandomPassword(10);
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(a);
                byte[] has = new MD5CryptoServiceProvider().ComputeHash(temp);
                string pass = has.ToString();
                d.SuaMatKhau(txtUserName.Text,pass);
                Send(txtPassword.Text, "Phòng mạch Lâm Hoàng Mỹ", "Mật khẩu mới của bạn là: " + a);
                MessageBox.Show("Mật khẩu mới đã được gửi vào mail của bạn!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '.')
            {
                pictureBox1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                txtPassword.PasswordChar = '.';
            }
        }
       
    }
}
