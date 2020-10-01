namespace Aula3009
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnSair = new FontAwesome.Sharp.IconButton();
            this.ibtnOrders = new FontAwesome.Sharp.IconButton();
            this.ibtnFerramentas = new FontAwesome.Sharp.IconButton();
            this.ibtnMarketing = new FontAwesome.Sharp.IconButton();
            this.ibtnClientes = new FontAwesome.Sharp.IconButton();
            this.ibtnProdutos = new FontAwesome.Sharp.IconButton();
            this.ibtnDashboard = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.ibtnSair);
            this.pnlMenu.Controls.Add(this.ibtnOrders);
            this.pnlMenu.Controls.Add(this.ibtnFerramentas);
            this.pnlMenu.Controls.Add(this.ibtnMarketing);
            this.pnlMenu.Controls.Add(this.ibtnClientes);
            this.pnlMenu.Controls.Add(this.ibtnProdutos);
            this.pnlMenu.Controls.Add(this.ibtnDashboard);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(168, 611);
            this.pnlMenu.TabIndex = 0;
            // 
            // ibtnSair
            // 
            this.ibtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnSair.FlatAppearance.BorderSize = 0;
            this.ibtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSair.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnSair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnSair.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnSair.IconSize = 40;
            this.ibtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSair.Location = new System.Drawing.Point(0, 504);
            this.ibtnSair.Name = "ibtnSair";
            this.ibtnSair.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnSair.Rotation = 0D;
            this.ibtnSair.Size = new System.Drawing.Size(168, 50);
            this.ibtnSair.TabIndex = 5;
            this.ibtnSair.Text = "Sair";
            this.ibtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSair.UseVisualStyleBackColor = false;
            // 
            // ibtnOrders
            // 
            this.ibtnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnOrders.FlatAppearance.BorderSize = 0;
            this.ibtnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ibtnOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnOrders.IconSize = 40;
            this.ibtnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrders.Location = new System.Drawing.Point(0, 229);
            this.ibtnOrders.Name = "ibtnOrders";
            this.ibtnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnOrders.Rotation = 0D;
            this.ibtnOrders.Size = new System.Drawing.Size(168, 50);
            this.ibtnOrders.TabIndex = 5;
            this.ibtnOrders.Text = "Orders";
            this.ibtnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnOrders.UseVisualStyleBackColor = false;
            // 
            // ibtnFerramentas
            // 
            this.ibtnFerramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnFerramentas.FlatAppearance.BorderSize = 0;
            this.ibtnFerramentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnFerramentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnFerramentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnFerramentas.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibtnFerramentas.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnFerramentas.IconSize = 40;
            this.ibtnFerramentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFerramentas.Location = new System.Drawing.Point(0, 448);
            this.ibtnFerramentas.Name = "ibtnFerramentas";
            this.ibtnFerramentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnFerramentas.Rotation = 0D;
            this.ibtnFerramentas.Size = new System.Drawing.Size(168, 50);
            this.ibtnFerramentas.TabIndex = 4;
            this.ibtnFerramentas.Text = "Ferramentas";
            this.ibtnFerramentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnFerramentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnFerramentas.UseVisualStyleBackColor = false;
            // 
            // ibtnMarketing
            // 
            this.ibtnMarketing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnMarketing.FlatAppearance.BorderSize = 0;
            this.ibtnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMarketing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMarketing.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.ibtnMarketing.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnMarketing.IconSize = 40;
            this.ibtnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMarketing.Location = new System.Drawing.Point(0, 392);
            this.ibtnMarketing.Name = "ibtnMarketing";
            this.ibtnMarketing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnMarketing.Rotation = 0D;
            this.ibtnMarketing.Size = new System.Drawing.Size(168, 50);
            this.ibtnMarketing.TabIndex = 3;
            this.ibtnMarketing.Text = "Marketing";
            this.ibtnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMarketing.UseVisualStyleBackColor = false;
            // 
            // ibtnClientes
            // 
            this.ibtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnClientes.FlatAppearance.BorderSize = 0;
            this.ibtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ibtnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnClientes.IconSize = 40;
            this.ibtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClientes.Location = new System.Drawing.Point(0, 336);
            this.ibtnClientes.Name = "ibtnClientes";
            this.ibtnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnClientes.Rotation = 0D;
            this.ibtnClientes.Size = new System.Drawing.Size(168, 50);
            this.ibtnClientes.TabIndex = 2;
            this.ibtnClientes.Text = "Clientes";
            this.ibtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnClientes.UseVisualStyleBackColor = false;
            // 
            // ibtnProdutos
            // 
            this.ibtnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnProdutos.FlatAppearance.BorderSize = 0;
            this.ibtnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProdutos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnProdutos.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnProdutos.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.ibtnProdutos.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnProdutos.IconSize = 40;
            this.ibtnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProdutos.Location = new System.Drawing.Point(0, 285);
            this.ibtnProdutos.Name = "ibtnProdutos";
            this.ibtnProdutos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnProdutos.Rotation = 0D;
            this.ibtnProdutos.Size = new System.Drawing.Size(168, 50);
            this.ibtnProdutos.TabIndex = 1;
            this.ibtnProdutos.Text = "Produtos";
            this.ibtnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnProdutos.UseVisualStyleBackColor = false;
            // 
            // ibtnDashboard
            // 
            this.ibtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ibtnDashboard.FlatAppearance.BorderSize = 0;
            this.ibtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ibtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ibtnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.ibtnDashboard.IconSize = 40;
            this.ibtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDashboard.Location = new System.Drawing.Point(0, 173);
            this.ibtnDashboard.Name = "ibtnDashboard";
            this.ibtnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ibtnDashboard.Rotation = 0D;
            this.ibtnDashboard.Size = new System.Drawing.Size(168, 50);
            this.ibtnDashboard.TabIndex = 0;
            this.ibtnDashboard.Text = "Dashboard";
            this.ibtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(168, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(735, 611);
            this.pnlContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 105);
            this.panel1.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 611);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Principal";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton ibtnOrders;
        private FontAwesome.Sharp.IconButton ibtnFerramentas;
        private FontAwesome.Sharp.IconButton ibtnMarketing;
        private FontAwesome.Sharp.IconButton ibtnClientes;
        private FontAwesome.Sharp.IconButton ibtnProdutos;
        private FontAwesome.Sharp.IconButton ibtnSair;
        private System.Windows.Forms.Panel panel1;
    }
}

