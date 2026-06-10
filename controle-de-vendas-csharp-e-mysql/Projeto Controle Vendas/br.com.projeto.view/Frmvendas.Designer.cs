namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmvendas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.NumericUpDown();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.NumericUpDown();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 92);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE VENDAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(37, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnome.Location = new System.Drawing.Point(113, 89);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(266, 26);
            this.txtnome.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(57, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nome:";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcpf.Location = new System.Drawing.Point(113, 39);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(122, 26);
            this.txtcpf.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(69, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnremover);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(37, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 258);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(113, 82);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(266, 26);
            this.txtdescricao.TabIndex = 35;
            // 
            // txtpreco
            // 
            this.txtpreco.DecimalPlaces = 2;
            this.txtpreco.Location = new System.Drawing.Point(113, 125);
            this.txtpreco.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(92, 26);
            this.txtpreco.TabIndex = 34;
            this.txtpreco.ThousandsSeparator = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(113, 35);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(93, 26);
            this.txtcodigo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(23, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Preço (R$):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(49, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(242, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Qtd.:";
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(286, 125);
            this.txtqtd.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(93, 26);
            this.txtqtd.TabIndex = 32;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(51, 191);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(145, 40);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Adicionar Item";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(211, 191);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(145, 40);
            this.btnremover.TabIndex = 37;
            this.btnremover.Text = "Remover Item";
            this.btnremover.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(337, 422);
            this.dataGridView1.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(470, 539);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 75);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.DecimalPlaces = 2;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttotal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txttotal.InterceptArrowKeys = false;
            this.txttotal.Location = new System.Drawing.Point(103, 28);
            this.txttotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(208, 26);
            this.txttotal.TabIndex = 36;
            this.txttotal.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Total (R$):";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(651, 632);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(156, 60);
            this.btncancelar.TabIndex = 39;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnpagamento
            // 
            this.btnpagamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpagamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagamento.ForeColor = System.Drawing.Color.White;
            this.btnpagamento.Location = new System.Drawing.Point(470, 632);
            this.btnpagamento.Name = "btnpagamento";
            this.btnpagamento.Size = new System.Drawing.Size(156, 60);
            this.btnpagamento.TabIndex = 38;
            this.btnpagamento.Text = "Pagamento";
            this.btnpagamento.UseVisualStyleBackColor = false;
            // 
            // Frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 707);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnpagamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmvendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtqtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttotal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtqtd;
        private System.Windows.Forms.NumericUpDown txtpreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txttotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpagamento;
    }
}