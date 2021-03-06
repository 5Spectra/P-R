﻿using System;
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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                MessageBox.Show("Você deve informar seu nome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {

                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;
                using (SqlConnection conexao = new SqlConnection("Server=AME0524167W10-1\\SQLEXPRESS;Database=PER;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into Jogador(nome) OUTPUT INSERTED.ID values(@NOME)", conexao))
                    {
                        comando.Parameters.AddWithValue("NOME", txtNome.Text);
                        conexao.Open();

                        int id_jogador = (int)comando.ExecuteScalar();
                        // if(comando.ExecuteNonQuery() == 1)
                        if (id_jogador > 0)
                        {

                            MessageBox.Show("Olá " + txtNome.Text.ToUpper() + " Seu id é: " + id_jogador + ". Você está pronto para continuar!!!", "PLAYYYY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            /* System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                             player.SoundLocation = "C:\\Users\\andre.sacilotto\\Downloads\\som.wav";
                             player.Play();*/


                            Pergunta1 P1 = new Pergunta1(id_jogador); Pergunta2 P2 = new Pergunta2(id_jogador);
                            Pergunta3 P3 = new Pergunta3(id_jogador); Pergunta4 P4 = new Pergunta4(id_jogador);

                            P1.ShowDialog(); P2.ShowDialog(); P3.ShowDialog(); P4.ShowDialog();

                            comando.CommandText = "select COUNT(pergunta) from TBPerguntas where id_jogador = @Nun";

                            comando.Parameters.AddWithValue("Nun", id_jogador);
                            SqlDataReader acertos = comando.ExecuteReader();
                            acertos.Read();
                            MessageBox.Show("Sua pontuação é: " + acertos.GetInt32(0));
                            acertos.Close();

                        }
                        else
                        {
                            MessageBox.Show("DEU RUIMMMM!!!! Algo aconteceu durante o insert");
                        }


                        }
                    }
                    //fim do código para inserir o jogador na tabela
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Saair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
