
namespace prova
{
    partial class telaonibus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnexibir = new System.Windows.Forms.Button();
            this.lblplaca = new System.Windows.Forms.TextBox();
            this.btnreaj = new System.Windows.Forms.Button();
            this.lblano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblassento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnexibir.Location = new System.Drawing.Point(204, 381);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(143, 54);
            this.btnexibir.TabIndex = 1;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // lblplaca
            // 
            this.lblplaca.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblplaca.Location = new System.Drawing.Point(226, 44);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(280, 43);
            this.lblplaca.TabIndex = 2;
            // 
            // btnreaj
            // 
            this.btnreaj.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnreaj.Location = new System.Drawing.Point(461, 381);
            this.btnreaj.Name = "btnreaj";
            this.btnreaj.Size = new System.Drawing.Size(143, 54);
            this.btnreaj.TabIndex = 3;
            this.btnreaj.Text = "Reajuste";
            this.btnreaj.UseVisualStyleBackColor = true;
            this.btnreaj.Click += new System.EventHandler(this.btnreaj_Click);
            // 
            // lblano
            // 
            this.lblano.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblano.Location = new System.Drawing.Point(226, 105);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(280, 43);
            this.lblano.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ano";
            // 
            // lblassento
            // 
            this.lblassento.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblassento.Location = new System.Drawing.Point(226, 167);
            this.lblassento.Name = "lblassento";
            this.lblassento.Size = new System.Drawing.Size(280, 43);
            this.lblassento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assento";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpreco.Location = new System.Drawing.Point(226, 226);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(280, 43);
            this.txtpreco.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // telaonibus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 476);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblassento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnreaj);
            this.Controls.Add(this.lblplaca);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.label1);
            this.Name = "telaonibus";
            this.Text = "telaonibus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.TextBox lblplaca;
        private System.Windows.Forms.Button btnreaj;
        private System.Windows.Forms.TextBox lblano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblassento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label4;
    }
}