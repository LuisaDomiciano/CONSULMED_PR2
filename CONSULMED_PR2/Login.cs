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

            // 💡 String de conexão
            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027392PR2;User ID=aluno;Password=aluno;";

            // 🔍 Queries para cada tabela
            string queryPac = @"SELECT COUNT(*) FROM Pagina_LoginPac 
                    WHERE Usuario_LogPac = @Usuario AND Senha_LogPac = @Senha";

            string queryMed = @"SELECT COUNT(*) FROM Pagina_LoginMed 
                    WHERE Usuario_LogMed = @Usuario AND Senha_LogMed = @Senha";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmdPac = new SqlCommand(queryPac, conn))
                using (SqlCommand cmdMed = new SqlCommand(queryMed, conn))
                {
                    cmdPac.Parameters.AddWithValue("@Usuario", nomeLogin);
                    cmdPac.Parameters.AddWithValue("@Senha", senhaLogin);

                    cmdMed.Parameters.AddWithValue("@Usuario", nomeLogin);
                    cmdMed.Parameters.AddWithValue("@Senha", senhaLogin);

                    conn.Open();

                    int countPac = (int)cmdPac.ExecuteScalar();
                    int countMed = (int)cmdMed.ExecuteScalar();

                    if (countPac > 0)
                    {
                        MessageBox.Show("Login de paciente realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuPrincipalPaciente menuPac = new MenuPrincipalPaciente();
                        menuPac.Show();
                        this.Hide();
                    }
                    else if (countMed > 0)
                    {
                        MessageBox.Show("Login de médico realizado com sucesso!", "Bem-vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuPrincipalMedico menuMed = new MenuPrincipalMedico();
                        menuMed.Show();
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
            {

                // Fecha o form atual
                this.Hide();

                // Abre o form de redefinição de senha
                RedefinirSenha RedefinirSenha = new RedefinirSenha();
                RedefinirSenha.Show();

                // Exemplo: gerar e enviar código de recuperação
                string emailUsuario = TxtUsuarioLogin.Text.Trim();

                if (string.IsNullOrEmpty(emailUsuario))
                {
                    MessageBox.Show("Digite o nome de usuário ou e-mail antes de redefinir a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                    return;
                }

                string codigo = GerarCodigo();

                try
                {
                    EnviarCodigoRecuperacao(emailUsuario, codigo);
                    MessageBox.Show("Um código de recuperação foi enviado ao seu e-mail!", "Código enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar código: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }
            }
        }

        // 🔢 Gera um código de 6 dígitos
        private string GerarCodigo()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        // ✉️ Envia o código para o e-mail
        private void EnviarCodigoRecuperacao(string emailDestino, string codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("consultasmedicasconsulmed@gmail.com");
                mail.To.Add(emailDestino);
                mail.Subject = "Código de Recuperação de Senha - CONSULMED";
                mail.Body = $"Olá!\n\nSeu código de recuperação é: {codigo}\n\nAtenciosamente,\nEquipe CONSULMED";

                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("consultasmedicasconsulmed@gmail.com", "recu zsht nnhb shid");
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch
            {
                throw; // Deixa o erro subir para ser tratado no método chamador
            }
        }
    }
}
