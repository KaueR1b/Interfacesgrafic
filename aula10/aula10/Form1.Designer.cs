
namespace aula10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxaluno = new System.Windows.Forms.CheckBox();
            this.Selecionar = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnexibir = new System.Windows.Forms.Button();
            this.cbxprof = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.pnlprof = new System.Windows.Forms.Panel();
            this.txtgrad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlaluno = new System.Windows.Forms.Panel();
            this.txtturma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.pnlprof.SuspendLayout();
            this.pnlaluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxaluno
            // 
            this.cbxaluno.AutoSize = true;
            this.cbxaluno.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxaluno.Location = new System.Drawing.Point(215, 44);
            this.cbxaluno.Name = "cbxaluno";
            this.cbxaluno.Size = new System.Drawing.Size(82, 33);
            this.cbxaluno.TabIndex = 0;
            this.cbxaluno.Text = "Aluno";
            this.cbxaluno.UseVisualStyleBackColor = true;
            this.cbxaluno.CheckedChanged += new System.EventHandler(this.cbxaluno_CheckedChanged);
            // 
            // Selecionar
            // 
            this.Selecionar.AutoSize = true;
            this.Selecionar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Selecionar.Location = new System.Drawing.Point(32, 48);
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Size = new System.Drawing.Size(106, 29);
            this.Selecionar.TabIndex = 1;
            this.Selecionar.Text = "Selecionar";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcpf.Location = new System.Drawing.Point(161, 183);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(300, 35);
            this.txtcpf.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnome.Location = new System.Drawing.Point(161, 122);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(300, 35);
            this.txtnome.TabIndex = 3;
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnexibir.Location = new System.Drawing.Point(96, 400);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(75, 42);
            this.btnexibir.TabIndex = 4;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // cbxprof
            // 
            this.cbxprof.AutoSize = true;
            this.cbxprof.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxprof.Location = new System.Drawing.Point(545, 44);
            this.cbxprof.Name = "cbxprof";
            this.cbxprof.Size = new System.Drawing.Size(118, 33);
            this.cbxprof.TabIndex = 5;
            this.cbxprof.Text = "Professor";
            this.cbxprof.UseVisualStyleBackColor = true;
            this.cbxprof.CheckedChanged += new System.EventHandler(this.cbxprof_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtendereco.Location = new System.Drawing.Point(161, 248);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(300, 35);
            this.txtendereco.TabIndex = 10;
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txttel.Location = new System.Drawing.Point(161, 313);
            this.txttel.Mask = "00000-9999";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(300, 35);
            this.txttel.TabIndex = 11;
            // 
            // pnlprof
            // 
            this.pnlprof.Controls.Add(this.txtgrad);
            this.pnlprof.Controls.Add(this.label6);
            this.pnlprof.Controls.Add(this.txtaula);
            this.pnlprof.Controls.Add(this.label5);
            this.pnlprof.Location = new System.Drawing.Point(501, 112);
            this.pnlprof.Name = "pnlprof";
            this.pnlprof.Size = new System.Drawing.Size(368, 138);
            this.pnlprof.TabIndex = 12;
            // 
            // txtgrad
            // 
            this.txtgrad.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgrad.Location = new System.Drawing.Point(132, 86);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(165, 35);
            this.txtgrad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Graduação";
            // 
            // txtaula
            // 
            this.txtaula.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtaula.Location = new System.Drawing.Point(178, 26);
            this.txtaula.Name = "txtaula";
            this.txtaula.Size = new System.Drawing.Size(165, 35);
            this.txtaula.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero de aulas";
            // 
            // pnlaluno
            // 
            this.pnlaluno.Controls.Add(this.txtturma);
            this.pnlaluno.Controls.Add(this.label9);
            this.pnlaluno.Controls.Add(this.txtcurso);
            this.pnlaluno.Controls.Add(this.label8);
            this.pnlaluno.Controls.Add(this.txtra);
            this.pnlaluno.Controls.Add(this.label7);
            this.pnlaluno.Location = new System.Drawing.Point(506, 274);
            this.pnlaluno.Name = "pnlaluno";
            this.pnlaluno.Size = new System.Drawing.Size(362, 168);
            this.pnlaluno.TabIndex = 13;
            this.pnlaluno.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtturma
            // 
            this.txtturma.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtturma.Location = new System.Drawing.Point(138, 104);
            this.txtturma.Name = "txtturma";
            this.txtturma.Size = new System.Drawing.Size(165, 35);
            this.txtturma.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Turma";
            // 
            // txtcurso
            // 
            this.txtcurso.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcurso.Location = new System.Drawing.Point(138, 63);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(165, 35);
            this.txtcurso.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(16, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Curso";
            // 
            // txtra
            // 
            this.txtra.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtra.Location = new System.Drawing.Point(138, 22);
            this.txtra.Name = "txtra";
            this.txtra.Size = new System.Drawing.Size(165, 35);
            this.txtra.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "RA";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsalvar.Location = new System.Drawing.Point(340, 400);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(84, 42);
            this.btnsalvar.TabIndex = 14;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 485);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.pnlaluno);
            this.Controls.Add(this.pnlprof);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxprof);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.Selecionar);
            this.Controls.Add(this.cbxaluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlprof.ResumeLayout(false);
            this.pnlprof.PerformLayout();
            this.pnlaluno.ResumeLayout(false);
            this.pnlaluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxaluno;
        private System.Windows.Forms.Label Selecionar;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.CheckBox cbxprof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.Panel pnlprof;
        private System.Windows.Forms.TextBox txtgrad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlaluno;
        private System.Windows.Forms.TextBox txtturma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsalvar;
    }
}

