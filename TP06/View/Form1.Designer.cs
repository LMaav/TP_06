namespace TP06
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
            this.btn_Filtro = new System.Windows.Forms.Button();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Maiuscula = new System.Windows.Forms.Button();
            this.btn_Agrupar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Filtro
            // 
            this.btn_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filtro.Location = new System.Drawing.Point(53, 166);
            this.btn_Filtro.Name = "btn_Filtro";
            this.btn_Filtro.Size = new System.Drawing.Size(143, 42);
            this.btn_Filtro.TabIndex = 0;
            this.btn_Filtro.Text = "Filtrar";
            this.btn_Filtro.UseVisualStyleBackColor = true;
            this.btn_Filtro.Click += new System.EventHandler(this.btn_Filtro_Click);
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtro.Location = new System.Drawing.Point(287, 95);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(39, 17);
            this.lbl_Filtro.TabIndex = 1;
            this.lbl_Filtro.Text = "Filtro";
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Filtro.Location = new System.Drawing.Point(215, 115);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(175, 23);
            this.txt_Filtro.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(584, 186);
            this.listBox1.TabIndex = 3;
            // 
            // btn_Maiuscula
            // 
            this.btn_Maiuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maiuscula.Location = new System.Drawing.Point(231, 166);
            this.btn_Maiuscula.Name = "btn_Maiuscula";
            this.btn_Maiuscula.Size = new System.Drawing.Size(143, 42);
            this.btn_Maiuscula.TabIndex = 0;
            this.btn_Maiuscula.Text = "Maiúsculas";
            this.btn_Maiuscula.UseVisualStyleBackColor = true;
            this.btn_Maiuscula.Click += new System.EventHandler(this.btn_Maiuscula_Click);
            // 
            // btn_Agrupar
            // 
            this.btn_Agrupar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agrupar.Location = new System.Drawing.Point(408, 166);
            this.btn_Agrupar.Name = "btn_Agrupar";
            this.btn_Agrupar.Size = new System.Drawing.Size(143, 42);
            this.btn_Agrupar.TabIndex = 0;
            this.btn_Agrupar.Text = "Agrupar";
            this.btn_Agrupar.UseVisualStyleBackColor = true;
            this.btn_Agrupar.Click += new System.EventHandler(this.btn_Agrupar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 443);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.btn_Agrupar);
            this.Controls.Add(this.btn_Maiuscula);
            this.Controls.Add(this.btn_Filtro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Maiuscula;
        private System.Windows.Forms.Button btn_Agrupar;
    }
}

