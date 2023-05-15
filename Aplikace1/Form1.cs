using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SMTPhodnota.Text))
            {
                MessageBox.Show("Hodnota SMPT musí být vyplněna!");
                return;
            }
            if (string.IsNullOrEmpty(MailOd.Text))
            {
                MessageBox.Show("Odesílatel musí být vyplněn!");
                return;
            }
            if (string.IsNullOrEmpty(MailKomu.Text))
            {
                MessageBox.Show("Příjemce musí být vyplněn!");
                return;
            }
            if (string.IsNullOrEmpty(TextZpravy.Text))
            {
                MessageBox.Show("Zpráva musí být vyplněna!");
                return;
            }

            int test = 0;
            if (!Int32.TryParse(Portnapis.Text, out test))
            {
                MessageBox.Show("Port musí číslo!");
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(SMTPhodnota.Text);

                mail.From = new MailAddress(MailOd.Text);
                mail.To.Add(MailKomu.Text);
                mail.Subject = "Test";
                mail.Body = TextZpravy.Text;

                int port = Int32.Parse(Portnapis.Text);
                SmtpServer.Port = port;

                //SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email byl odeslán");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Portnapis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}