namespace Trabalho2Bim
{
    partial class form_login
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
            this.txt_logLogin = new System.Windows.Forms.TextBox();
            this.txt_logSenha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cadSenha = new System.Windows.Forms.TextBox();
            this.txt_cadLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_logLogin
            // 
            this.txt_logLogin.Location = new System.Drawing.Point(42, 103);
            this.txt_logLogin.Name = "txt_logLogin";
            this.txt_logLogin.Size = new System.Drawing.Size(293, 22);
            this.txt_logLogin.TabIndex = 0;
            // 
            // txt_logSenha
            // 
            this.txt_logSenha.Location = new System.Drawing.Point(42, 152);
            this.txt_logSenha.Name = "txt_logSenha";
            this.txt_logSenha.PasswordChar = '♦';
            this.txt_logSenha.Size = new System.Drawing.Size(293, 22);
            this.txt_logSenha.TabIndex = 1;
            // 
            // txt_login
            // 
            this.txt_login.AutoSize = true;
            this.txt_login.Location = new System.Drawing.Point(42, 74);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(42, 17);
            this.txt_login.TabIndex = 2;
            this.txt_login.Text = "login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira seu login e senha para acessar o sistema:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(45, 211);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(113, 35);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ou cadastre-se como um novo usuário:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(45, 458);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(113, 35);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "login:";
            // 
            // txt_cadSenha
            // 
            this.txt_cadSenha.Location = new System.Drawing.Point(42, 405);
            this.txt_cadSenha.Name = "txt_cadSenha";
            this.txt_cadSenha.PasswordChar = '♦';
            this.txt_cadSenha.Size = new System.Drawing.Size(293, 22);
            this.txt_cadSenha.TabIndex = 13;
            // 
            // txt_cadLogin
            // 
            this.txt_cadLogin.Location = new System.Drawing.Point(42, 356);
            this.txt_cadLogin.Name = "txt_cadLogin";
            this.txt_cadLogin.Size = new System.Drawing.Size(293, 22);
            this.txt_cadLogin.TabIndex = 12;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cadSenha);
            this.Controls.Add(this.txt_cadLogin);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_logSenha);
            this.Controls.Add(this.txt_logLogin);
            this.Name = "form_login";
            this.Text = "Sistema Nota Fiscal - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_logLogin;
        private System.Windows.Forms.TextBox txt_logSenha;
        private System.Windows.Forms.Label txt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cadSenha;
        private System.Windows.Forms.TextBox txt_cadLogin;
    }
}

