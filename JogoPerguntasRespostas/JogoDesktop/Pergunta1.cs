using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public int id_jogador_banco;

        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void Bproxina_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection("Server=AME0556321W10-1\\SQLEXPRESS;Database=PER;Trusted_Connection=Yes"))
            {
                using (SqlCommand comando = new SqlCommand("insert into TBPerguntas(pergunta,resposta_C,id_jogador) values(@PER,@RES,@ID)", conexao))
                {
                    comando.Parameters.AddWithValue("PER", lbl.Text);
                    comando.Parameters.AddWithValue("RES", RB4.Text);
                    comando.Parameters.AddWithValue("ID", id_jogador_banco);
                    conexao.Open();
                    if (comando.ExecuteNonQuery() == 1)
                         if (RB4.Checked == true)
                        {
                            MessageBox.Show("Acertou", "Parabens");
                        }
                        else { MessageBox.Show("Errou", "Feio"); }

                    Pergunta2 P2 = new Pergunta2(id_jogador_banco);
                    P2.ShowDialog();
                    this.Close();
                }

                }
            }
        }
    }