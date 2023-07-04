using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexao conn = new Conexao();
        string sql = null;

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            sql = "delete from tb_Produto where cli_codigo ='" + txtCodigo.Text + "'";
            if(conn.ComandoSql(sql))
            {
                MessageBox.Show("Excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel excluir!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "          ")
            {
                sql = "insert into tb_Produto('" + txtCodigo.Text + "', '" +
                    txtDescricao.Text + "', '" + txtPreco.Text + "', '" + txtEstoque.Text + "', '" +
                    txtValidadeP.Text + "')";
                if (!conn.ComandoSql(sql))
                {
                    MessageBox.Show("Não foi possivel cadastrar!");
                }
                else
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                limpar();
            }
            else
            {
                sql = "Update tb_Produto set cli_codigo='" + txtCodigo.Text + "' and cli_descricao = '" + txtDescricao.Text + "' and cli_preco = '" +
                txtPreco.Text + "'and cli_estoque = '" + txtEstoque.Text + "' and cli_validade = '" +
                txtValidadeP.Text + "'";
                if (conn.ComandoSql(sql))
                {
                    MessageBox.Show("Atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar!");
                }
                limpar();
            }
        }
        private void limpar()
        {
            txtCodigo.Text = null;
            txtDescricao.Text = null;
            txtPreco.Text = null;
            txtEstoque.Text = null;
            txtValidadeP.Text = null;
        }
             
             //----------> CODIGO COMENTADO ABAIXO, ESTÁ ASSIM PORQUE TEVE MUITOS ERROS, ACHO QUE NÃO 
             //É POSSIVEL USAR DUAS TABELAS NO MESMO FORMS, POREM SIGO TESTANDO...
            
            //    if (txtCnpj.Text == "         ")
            //    {
            //        sql = "insert into tb_Fornecedor('" + txtCnpj.Text + "', '" +
            //            txtRazao.Text + "', '" + txtEndereco.Text + "', '" + txtFantasia.Text + "', '" +
            //            txtTelefone.Text + "', '"+ txtEmail.Text + "', '" +
            //            txtInscricao.Text + "' )";
            //    }
            //    if (conn.ComandoSql(sql))
            //    {
            //        MessageBox.Show("Cadastrado com sucesso!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Não foi possivel cadastrar!");
            //    }
            //    limpar();


            //    else
            //    {
            //        sql = "Update tb_Fornecedor set cli_cnpj='" + txtCnpj.Text + "' and cli_razao = '" + txtRazao.Text + "' and cli_endereco = '" +
            //        txtEndereco.Text + "'and cli_fantasia = '" + txtFantasia.Text + "' and cli_telefone = '" +
            //        txtTelefone.Text + "' and cli_email = '" + txtEmail.Text + "' and cli_inscricao = '" + txtInscricao.Text + "'";
            //        if (conn.ComandoSql(sql))
            //        {
            //            MessageBox.Show("Atualizado com sucesso!");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Não foi possivel atualizar!");
            //        }

            //    }
            //    private void limpar()
            //    {
            //        txtCnpj.Text = null;
            //        txtRazao.Text = null;
            //        txtEndereco.Text = null;
            //        txtFantasia.Text = null;
            //        txtTelefone.Text = null;
            //        txtEmail.Text = null;
            //        txtInscricao.Text = null;
            //    }
            //}

            private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == 13)
                {
                    sql = "select * from tb_Produto where cli_codigo'" + txtCodigo.Text + "'";
                    DataTable dt = new DataTable();
                    dt = conn.Busca(sql);
                    txtCodigo.Text = dt.Rows[0]["cli_codigo"].ToString();
                    txtDescricao.Text = dt.Rows[0]["cli_descricao"].ToString();
                    txtPreco.Text = dt.Rows[0]["cli_preco"].ToString();
                    txtEstoque.Text = dt.Rows[0]["cli_estoque"].ToString();
                    txtValidadeP.Text = dt.Rows[0]["cli_validade"].ToString();
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

