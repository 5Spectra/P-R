namespace JogoDesktop
{
    partial class Pergunta1
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
            this.lbl = new System.Windows.Forms.Label();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.Bproxima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(77, 55);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(211, 26);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Qual o melhor TOP?";
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(80, 124);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(47, 17);
            this.RB1.TabIndex = 1;
            this.RB1.TabStop = true;
            this.RB1.Text = "Irelia";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(80, 158);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(55, 17);
            this.RB2.TabIndex = 2;
            this.RB2.TabStop = true;
            this.RB2.Text = "Darius";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(80, 192);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(47, 17);
            this.RB3.TabIndex = 3;
            this.RB3.TabStop = true;
            this.RB3.Text = "WW";
            this.RB3.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Location = new System.Drawing.Point(80, 228);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(55, 17);
            this.RB4.TabIndex = 4;
            this.RB4.TabStop = true;
            this.RB4.Text = "Todos";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // Bproxima
            // 
            this.Bproxima.Location = new System.Drawing.Point(149, 271);
            this.Bproxima.Name = "Bproxima";
            this.Bproxima.Size = new System.Drawing.Size(143, 45);
            this.Bproxima.TabIndex = 5;
            this.Bproxima.Text = "Próxima pergunta";
            this.Bproxima.UseVisualStyleBackColor = true;
            this.Bproxima.Click += new System.EventHandler(this.Bproxina_Click);
            // 
            // Pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.Bproxima);
            this.Controls.Add(this.RB4);
            this.Controls.Add(this.RB3);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.lbl);
            this.Name = "Pergunta1";
            this.Text = "Pergunta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.Button Bproxima;
    }
}