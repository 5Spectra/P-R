using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class Pergunta4 : Form
    {
        public int id_jogador_banco;
        public Pergunta4(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void Bproxima_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0524167W10-1\\SQLEXPRESS;Database=PER;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into TBPerguntas(pergunta,resposta_C,id_jogador) values(@PER,@RES,@ID)", conexao))
                {
                    comando.Parameters.AddWithValue("PER", lbl.Text);
                    comando.Parameters.AddWithValue("RES", RB4.Text);
                    comando.Parameters.AddWithValue("ID", id_jogador_banco);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                    if (RB4.Checked == true) { MessageBox.Show("Acertou", " AEEEEEEEEEE"); }
                    else { MessageBox.Show("Errou"); }

                    this.Close();
                }
            }
        }


    }
}
