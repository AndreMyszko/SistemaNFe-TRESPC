namespace CalcVLSM_Final
{
    partial class ViewCalc
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
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.dgvHost = new System.Windows.Forms.DataGridView();
            this.btnAddIP = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.nudHost = new System.Windows.Forms.NumericUpDown();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "---Calculadora VLSM---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP:";
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(42, 53);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(100, 22);
            this.txtIP1.TabIndex = 2;
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(148, 53);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(100, 22);
            this.txtIP2.TabIndex = 3;
            // 
            // txtIP3
            // 
            this.txtIP3.Location = new System.Drawing.Point(254, 53);
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.Size = new System.Drawing.Size(100, 22);
            this.txtIP3.TabIndex = 4;
            // 
            // txtIP4
            // 
            this.txtIP4.Location = new System.Drawing.Point(360, 53);
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.Size = new System.Drawing.Size(100, 22);
            this.txtIP4.TabIndex = 5;
            // 
            // dgvHost
            // 
            this.dgvHost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHost.Location = new System.Drawing.Point(15, 89);
            this.dgvHost.Name = "dgvHost";
            this.dgvHost.RowHeadersWidth = 51;
            this.dgvHost.RowTemplate.Height = 24;
            this.dgvHost.Size = new System.Drawing.Size(445, 151);
            this.dgvHost.TabIndex = 6;
            // 
            // btnAddIP
            // 
            this.btnAddIP.Location = new System.Drawing.Point(466, 46);
            this.btnAddIP.Name = "btnAddIP";
            this.btnAddIP.Size = new System.Drawing.Size(97, 37);
            this.btnAddIP.TabIndex = 7;
            this.btnAddIP.Text = "Adicionar IP";
            this.btnAddIP.UseVisualStyleBackColor = true;
            this.btnAddIP.Click += new System.EventHandler(this.BtnAddIP_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(569, 46);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(97, 37);
            this.btnReiniciar.TabIndex = 8;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // nudHost
            // 
            this.nudHost.Location = new System.Drawing.Point(466, 89);
            this.nudHost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudHost.Name = "nudHost";
            this.nudHost.Size = new System.Drawing.Size(97, 22);
            this.nudHost.TabIndex = 9;
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(569, 89);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(97, 37);
            this.btnAddHost.TabIndex = 10;
            this.btnAddHost.Text = "Add HOST";
            this.btnAddHost.UseVisualStyleBackColor = true;
            this.btnAddHost.Click += new System.EventHandler(this.BtnAddHost_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(466, 203);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 37);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(12, 246);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(654, 511);
            this.rtbResultado.TabIndex = 12;
            this.rtbResultado.Text = "";
            // 
            // ViewCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 769);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAddHost);
            this.Controls.Add(this.nudHost);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAddIP);
            this.Controls.Add(this.dgvHost);
            this.Controls.Add(this.txtIP4);
            this.Controls.Add(this.txtIP3);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewCalc";
            this.Text = "Calculadora VLSM - 2019";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.DataGridView dgvHost;
        private System.Windows.Forms.Button btnAddIP;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.NumericUpDown nudHost;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}

