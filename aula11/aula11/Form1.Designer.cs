
namespace aula11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnltelas = new System.Windows.Forms.Panel();
            this.Eletro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Eletro);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 454);
            this.panel1.TabIndex = 0;
            // 
            // pnltelas
            // 
            this.pnltelas.Location = new System.Drawing.Point(151, 9);
            this.pnltelas.Name = "pnltelas";
            this.pnltelas.Size = new System.Drawing.Size(748, 454);
            this.pnltelas.TabIndex = 1;
            // 
            // Eletro
            // 
            this.Eletro.Location = new System.Drawing.Point(5, 29);
            this.Eletro.Name = "Eletro";
            this.Eletro.Size = new System.Drawing.Size(112, 58);
            this.Eletro.TabIndex = 0;
            this.Eletro.Text = "Eletro";
            this.Eletro.UseVisualStyleBackColor = true;
            this.Eletro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 475);
            this.Controls.Add(this.pnltelas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Eletro;
        private System.Windows.Forms.Panel pnltelas;
    }
}

