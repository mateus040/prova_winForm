﻿namespace _211069_211090
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Brown;
            this.panelCabecalho.Controls.Add(this.btn_restaurar);
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnMinimizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 74);
            this.panelCabecalho.TabIndex = 0;
            this.panelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseDown);
            this.panelCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseMove);
            this.panelCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCabecalho_MouseUp);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_restaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_restaurar.FlatAppearance.BorderSize = 0;
            this.btn_restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.Location = new System.Drawing.Point(609, 14);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(50, 50);
            this.btn_restaurar.TabIndex = 4;
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema Supermercado";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(670, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 50);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(549, 17);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(726, 7);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(60, 60);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightCoral;
            this.panelMenu.Controls.Add(this.btnFornecedor);
            this.panelMenu.Controls.Add(this.btnFuncionario);
            this.panelMenu.Controls.Add(this.btnVendas);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 74);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 449);
            this.panelMenu.TabIndex = 1;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.LightCoral;
            this.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.Location = new System.Drawing.Point(0, 286);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(210, 50);
            this.btnFornecedor.TabIndex = 3;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.LightCoral;
            this.btnFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.Black;
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(0, 193);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(230, 70);
            this.btnFuncionario.TabIndex = 2;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.LightCoral;
            this.btnVendas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.Black;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 119);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(184, 45);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.LightCoral;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 35);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(184, 45);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.SeaShell;
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(180, 74);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(620, 449);
            this.panelConteudo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btn_restaurar;
        public System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

