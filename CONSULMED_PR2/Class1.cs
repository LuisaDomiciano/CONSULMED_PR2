using System.IO;
using System.Windows.Forms;
using System;

public static class GerenciadorCodigo
{
    private static string arquivoCodigo = Path.Combine(Path.GetTempPath(), "codigo_recuperacao.txt");

    public static void SalvarCodigo(string email, string codigo)
    {
        try
        {
            File.WriteAllText(arquivoCodigo, $"{email}|{codigo}|{DateTime.Now}");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao salvar código: {ex.Message}");
        }
    }

    public static (string email, string codigo, DateTime data) LerCodigo()
    {
        try
        {
            if (File.Exists(arquivoCodigo))
            {
                string[] dados = File.ReadAllText(arquivoCodigo).Split('|');
                if (dados.Length == 3)
                {
                    return (dados[0], dados[1], DateTime.Parse(dados[2]));
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao ler código: {ex.Message}");
        }
        return (null, null, DateTime.MinValue);
    }
}