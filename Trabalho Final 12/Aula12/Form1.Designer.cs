
namespace Aula12
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlIndeterminado = new System.Windows.Forms.Panel();
            this.btnIndeterminado = new System.Windows.Forms.Button();
            this.txtVaula = new System.Windows.Forms.TextBox();
            this.txtNaula = new System.Windows.Forms.TextBox();
            this.pnlTemporario = new System.Windows.Forms.Panel();
            this.btnTemporario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbxTemporario = new System.Windows.Forms.CheckBox();
            this.cbxIndeterminado = new System.Windows.Forms.CheckBox();
            this.pnlOutro = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOutro = new System.Windows.Forms.Button();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.pnlDiretoria = new System.Windows.Forms.Panel();
            this.txtDiretoria = new System.Windows.Forms.TextBox();
            this.btnDiretoria = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxOutro = new System.Windows.Forms.CheckBox();
            this.cbxDiretoria = new System.Windows.Forms.CheckBox();
            this.pnlIndeterminado.SuspendLayout();
            this.pnlTemporario.SuspendLayout();
            this.pnlOutro.SuspendLayout();
            this.pnlDiretoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(78, 8);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 27);
            this.txtNome.TabIndex = 3;
            // 
            // mskCpf
            // 
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(78, 58);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(141, 26);
            this.mskCpf.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(78, 103);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(141, 27);
            this.txtSalario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DOCENTE ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Indeterminado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero  de Aulas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Valor da Aula:";
            // 
            // pnlIndeterminado
            // 
            this.pnlIndeterminado.Controls.Add(this.btnIndeterminado);
            this.pnlIndeterminado.Controls.Add(this.txtVaula);
            this.pnlIndeterminado.Controls.Add(this.txtNaula);
            this.pnlIndeterminado.Controls.Add(this.label4);
            this.pnlIndeterminado.Controls.Add(this.label7);
            this.pnlIndeterminado.Controls.Add(this.label5);
            this.pnlIndeterminado.Controls.Add(this.label6);
            this.pnlIndeterminado.Location = new System.Drawing.Point(11, 294);
            this.pnlIndeterminado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlIndeterminado.Name = "pnlIndeterminado";
            this.pnlIndeterminado.Size = new System.Drawing.Size(383, 162);
            this.pnlIndeterminado.TabIndex = 10;
            // 
            // btnIndeterminado
            // 
            this.btnIndeterminado.Location = new System.Drawing.Point(239, 16);
            this.btnIndeterminado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIndeterminado.Name = "btnIndeterminado";
            this.btnIndeterminado.Size = new System.Drawing.Size(114, 34);
            this.btnIndeterminado.TabIndex = 16;
            this.btnIndeterminado.Text = "CALCULAR ";
            this.btnIndeterminado.UseVisualStyleBackColor = true;
            this.btnIndeterminado.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVaula
            // 
            this.txtVaula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaula.Location = new System.Drawing.Point(159, 82);
            this.txtVaula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVaula.Multiline = true;
            this.txtVaula.Name = "txtVaula";
            this.txtVaula.Size = new System.Drawing.Size(91, 27);
            this.txtVaula.TabIndex = 13;
            // 
            // txtNaula
            // 
            this.txtNaula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaula.Location = new System.Drawing.Point(159, 53);
            this.txtNaula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaula.Multiline = true;
            this.txtNaula.Name = "txtNaula";
            this.txtNaula.Size = new System.Drawing.Size(58, 27);
            this.txtNaula.TabIndex = 12;
            // 
            // pnlTemporario
            // 
            this.pnlTemporario.Controls.Add(this.btnTemporario);
            this.pnlTemporario.Controls.Add(this.textBox1);
            this.pnlTemporario.Controls.Add(this.textBox2);
            this.pnlTemporario.Controls.Add(this.label11);
            this.pnlTemporario.Controls.Add(this.label12);
            this.pnlTemporario.Controls.Add(this.label13);
            this.pnlTemporario.Controls.Add(this.label14);
            this.pnlTemporario.Location = new System.Drawing.Point(13, 292);
            this.pnlTemporario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTemporario.Name = "pnlTemporario";
            this.pnlTemporario.Size = new System.Drawing.Size(392, 162);
            this.pnlTemporario.TabIndex = 17;
            this.pnlTemporario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnTemporario
            // 
            this.btnTemporario.Location = new System.Drawing.Point(265, 15);
            this.btnTemporario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemporario.Name = "btnTemporario";
            this.btnTemporario.Size = new System.Drawing.Size(114, 34);
            this.btnTemporario.TabIndex = 16;
            this.btnTemporario.Text = "CALCULAR ";
            this.btnTemporario.UseVisualStyleBackColor = true;
            this.btnTemporario.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(159, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 27);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(159, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 27);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "DOCENTE ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Valor da Aula:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(116, 21);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Temporario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 58);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Numero  de Aulas:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(238, 100);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 34);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "IMPRIME";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbxTemporario
            // 
            this.cbxTemporario.AutoSize = true;
            this.cbxTemporario.Location = new System.Drawing.Point(15, 254);
            this.cbxTemporario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTemporario.Name = "cbxTemporario";
            this.cbxTemporario.Size = new System.Drawing.Size(98, 17);
            this.cbxTemporario.TabIndex = 16;
            this.cbxTemporario.Text = "TEMPORARIO";
            this.cbxTemporario.UseVisualStyleBackColor = true;
            this.cbxTemporario.CheckedChanged += new System.EventHandler(this.cbxTemporario_CheckedChanged);
            // 
            // cbxIndeterminado
            // 
            this.cbxIndeterminado.AutoSize = true;
            this.cbxIndeterminado.Location = new System.Drawing.Point(117, 254);
            this.cbxIndeterminado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxIndeterminado.Name = "cbxIndeterminado";
            this.cbxIndeterminado.Size = new System.Drawing.Size(117, 17);
            this.cbxIndeterminado.TabIndex = 17;
            this.cbxIndeterminado.Text = "INDETERMINADO";
            this.cbxIndeterminado.UseVisualStyleBackColor = true;
            this.cbxIndeterminado.CheckedChanged += new System.EventHandler(this.cbxIndeterminado_CheckedChanged);
            // 
            // pnlOutro
            // 
            this.pnlOutro.Controls.Add(this.txtOutro);
            this.pnlOutro.Controls.Add(this.btnOutro);
            this.pnlOutro.Controls.Add(this.pnlDiretoria);
            this.pnlOutro.Controls.Add(this.label10);
            this.pnlOutro.Controls.Add(this.label9);
            this.pnlOutro.Controls.Add(this.label8);
            this.pnlOutro.Location = new System.Drawing.Point(422, 291);
            this.pnlOutro.Name = "pnlOutro";
            this.pnlOutro.Size = new System.Drawing.Size(376, 164);
            this.pnlOutro.TabIndex = 18;
            this.pnlOutro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOutro_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "ADMINISTRATIVO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Lucro de Participação: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Outro:";
            // 
            // btnOutro
            // 
            this.btnOutro.Location = new System.Drawing.Point(249, 117);
            this.btnOutro.Margin = new System.Windows.Forms.Padding(2);
            this.btnOutro.Name = "btnOutro";
            this.btnOutro.Size = new System.Drawing.Size(114, 34);
            this.btnOutro.TabIndex = 19;
            this.btnOutro.Text = "CALCULAR ";
            this.btnOutro.UseVisualStyleBackColor = true;
            this.btnOutro.Click += new System.EventHandler(this.btnOutro_Click);
            // 
            // txtOutro
            // 
            this.txtOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutro.Location = new System.Drawing.Point(181, 52);
            this.txtOutro.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutro.Multiline = true;
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(58, 27);
            this.txtOutro.TabIndex = 19;
            // 
            // pnlDiretoria
            // 
            this.pnlDiretoria.Controls.Add(this.txtDiretoria);
            this.pnlDiretoria.Controls.Add(this.btnDiretoria);
            this.pnlDiretoria.Controls.Add(this.label15);
            this.pnlDiretoria.Controls.Add(this.label16);
            this.pnlDiretoria.Controls.Add(this.label17);
            this.pnlDiretoria.Location = new System.Drawing.Point(0, 1);
            this.pnlDiretoria.Name = "pnlDiretoria";
            this.pnlDiretoria.Size = new System.Drawing.Size(376, 164);
            this.pnlDiretoria.TabIndex = 19;
            this.pnlDiretoria.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDiretoria_Paint);
            // 
            // txtDiretoria
            // 
            this.txtDiretoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiretoria.Location = new System.Drawing.Point(181, 52);
            this.txtDiretoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiretoria.Multiline = true;
            this.txtDiretoria.Name = "txtDiretoria";
            this.txtDiretoria.Size = new System.Drawing.Size(58, 27);
            this.txtDiretoria.TabIndex = 19;
            // 
            // btnDiretoria
            // 
            this.btnDiretoria.Location = new System.Drawing.Point(249, 117);
            this.btnDiretoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiretoria.Name = "btnDiretoria";
            this.btnDiretoria.Size = new System.Drawing.Size(114, 34);
            this.btnDiretoria.TabIndex = 19;
            this.btnDiretoria.Text = "CALCULAR ";
            this.btnDiretoria.UseVisualStyleBackColor = true;
            this.btnDiretoria.Click += new System.EventHandler(this.btnDiretoria_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(177, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Diretoria:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Lucro de Participação: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "ADMINISTRATIVO";
            // 
            // cbxOutro
            // 
            this.cbxOutro.AutoSize = true;
            this.cbxOutro.Location = new System.Drawing.Point(537, 254);
            this.cbxOutro.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOutro.Name = "cbxOutro";
            this.cbxOutro.Size = new System.Drawing.Size(65, 17);
            this.cbxOutro.TabIndex = 21;
            this.cbxOutro.Text = "OUTRO";
            this.cbxOutro.UseVisualStyleBackColor = true;
            this.cbxOutro.CheckedChanged += new System.EventHandler(this.cbxOutro_CheckedChanged);
            // 
            // cbxDiretoria
            // 
            this.cbxDiretoria.AutoSize = true;
            this.cbxDiretoria.Location = new System.Drawing.Point(435, 254);
            this.cbxDiretoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDiretoria.Name = "cbxDiretoria";
            this.cbxDiretoria.Size = new System.Drawing.Size(85, 17);
            this.cbxDiretoria.TabIndex = 20;
            this.cbxDiretoria.Text = "DIRETORIA";
            this.cbxDiretoria.UseVisualStyleBackColor = true;
            this.cbxDiretoria.CheckedChanged += new System.EventHandler(this.cbxDiretoria_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 467);
            this.Controls.Add(this.cbxOutro);
            this.Controls.Add(this.cbxDiretoria);
            this.Controls.Add(this.pnlOutro);
            this.Controls.Add(this.pnlTemporario);
            this.Controls.Add(this.cbxIndeterminado);
            this.Controls.Add(this.cbxTemporario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pnlIndeterminado);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlIndeterminado.ResumeLayout(false);
            this.pnlIndeterminado.PerformLayout();
            this.pnlTemporario.ResumeLayout(false);
            this.pnlTemporario.PerformLayout();
            this.pnlOutro.ResumeLayout(false);
            this.pnlOutro.PerformLayout();
            this.pnlDiretoria.ResumeLayout(false);
            this.pnlDiretoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlIndeterminado;
        private System.Windows.Forms.TextBox txtVaula;
        private System.Windows.Forms.TextBox txtNaula;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnIndeterminado;
        private System.Windows.Forms.Panel pnlTemporario;
        private System.Windows.Forms.Button btnTemporario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbxTemporario;
        private System.Windows.Forms.CheckBox cbxIndeterminado;
        private System.Windows.Forms.Panel pnlOutro;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.Button btnOutro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlDiretoria;
        private System.Windows.Forms.TextBox txtDiretoria;
        private System.Windows.Forms.Button btnDiretoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbxOutro;
        private System.Windows.Forms.CheckBox cbxDiretoria;
    }
}

