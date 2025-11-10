using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONSULMED_PR2
{
    public partial class TxtLoginLog : Form


    {
        public TxtLoginLog()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLblNotAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }




        public partial class Login : Form
        {
            // Ajuste a string de conexão para o seu servidor/banco

            public Login()
            {

            }




            private void PictureBox1_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click_1(object sender, EventArgs e)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnterLogin_Click(object sender, EventArgs e)
        {

            // Capturar os valores digitados nas TextBox
            string nomeLogin = TxtUsuarioLogin.Text.Trim();
            string senhaLogin = TxtPasswordLogin.Text;

            // Validação simples
            if (string.IsNullOrEmpty(nomeLogin) || string.IsNullOrEmpty(senhaLogin))
            {
                MessageBox.Show("Por favor, preencha o login e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔍 Verificar se o login existe no banco
            string query = @"SELECT COUNT(*) FROM PaginaLog 
                     WHERE Nome_PagLog = @Nome_PagLog AND Senha_PagLog = @Senha_PagLog";

            // 💡 Colocando a conexão direto aqui
            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome_PagLog", nomeLogin);
                    cmd.Parameters.AddWithValue("@Senha_PagLog", senhaLogin);

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MenuPrincipalPaciente menuPaciente = new MenuPrincipalPaciente();
                        menuPaciente.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nome de login ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string emailUsuario = TxtUsuarioLogin.Text.Trim();

            if (string.IsNullOrEmpty(emailUsuario))
            {
                MessageBox.Show("Digite seu e-mail antes de continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = new Random().Next(100000, 999999).ToString();

            try
            {
                EnviarCodigoPorEmail(emailUsuario, codigo);
                MessageBox.Show("Um código de verificação foi enviado para seu e-mail.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: abrir um novo formulário para redefinir a senha
                // FrmRedefinirSenha frm = new FrmRedefinirSenha(emailUsuario, codigo);
                // frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 MÉTODO AUXILIAR DE ENVIO DE E-MAIL
        private void EnviarCodigoPorEmail(string destinatario, string codigo)
        {
            string remetente = "seuemail@gmail.com";
            string senha = "sua-senha-de-app"; // senha de aplicativo do Gmail

            // Criação da mensagem (escopo visível até o final do método)
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(remetente);
            mensagem.To.Add(destinatario);
            mensagem.Subject = "Recuperação de senha - CONSULMED";
            mensagem.Body = $"Olá! Seu código para redefinir a senha é: {codigo}";
            mensagem.IsBodyHtml = false;

            // Configuração do servidor SMTP
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(remetente, senha);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mensagem); // ← aqui o objeto "mensagem" existe
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("Erro SMTP ao enviar o e-mail: " + smtpEx.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




