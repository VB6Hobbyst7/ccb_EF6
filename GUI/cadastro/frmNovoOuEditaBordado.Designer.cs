namespace ccb_ef6
{
    partial class frmNovoOuEditaBordado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoOuEditaBordado));
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtBastidor = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.CorNomeLabel = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtDisquete = new System.Windows.Forms.TextBox();
            this.LinhaIdLabel = new System.Windows.Forms.Label();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.gcImagem = new DevExpress.XtraEditors.GroupControl();
            this.peImagem = new DevExpress.XtraEditors.PictureEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcImagem)).BeginInit();
            this.gcImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImagem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.AcceptsTab = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(81, 58);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(424, 20);
            this.txtDescricao.TabIndex = 81;
            this.txtDescricao.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(510, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 23);
            this.btnBrowse.TabIndex = 93;
            this.btnBrowse.Text = "...";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Navy;
            this.txtId.Location = new System.Drawing.Point(81, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 29);
            this.txtId.TabIndex = 86;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(162, 107);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 92;
            this.Label4.Text = "Bastidor:";
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(320, 106);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(39, 13);
            this.Label8.TabIndex = 94;
            this.Label8.Text = "Grupo:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(13, 58);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(65, 19);
            this.Label10.TabIndex = 90;
            this.Label10.Text = "Descrição:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBastidor
            // 
            this.txtBastidor.Location = new System.Drawing.Point(218, 104);
            this.txtBastidor.Name = "txtBastidor";
            this.txtBastidor.Size = new System.Drawing.Size(68, 20);
            this.txtBastidor.TabIndex = 83;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivo.Location = new System.Drawing.Point(207, 19);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(298, 20);
            this.txtArquivo.TabIndex = 80;
            this.txtArquivo.Text = "teste.dst";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(13, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 16);
            this.Label1.TabIndex = 89;
            this.Label1.Text = "Caminho:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(23, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 13);
            this.Label3.TabIndex = 91;
            this.Label3.Text = "Disquete:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CorNomeLabel
            // 
            this.CorNomeLabel.AutoSize = true;
            this.CorNomeLabel.Location = new System.Drawing.Point(155, 23);
            this.CorNomeLabel.Name = "CorNomeLabel";
            this.CorNomeLabel.Size = new System.Drawing.Size(46, 13);
            this.CorNomeLabel.TabIndex = 87;
            this.CorNomeLabel.Text = "Arquivo:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(81, 82);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(425, 20);
            this.txtCaminho.TabIndex = 88;
            this.txtCaminho.TabStop = false;
            // 
            // txtDisquete
            // 
            this.txtDisquete.Location = new System.Drawing.Point(81, 104);
            this.txtDisquete.Name = "txtDisquete";
            this.txtDisquete.Size = new System.Drawing.Size(65, 20);
            this.txtDisquete.TabIndex = 82;
            // 
            // LinhaIdLabel
            // 
            this.LinhaIdLabel.Location = new System.Drawing.Point(23, 23);
            this.LinhaIdLabel.Name = "LinhaIdLabel";
            this.LinhaIdLabel.Size = new System.Drawing.Size(55, 13);
            this.LinhaIdLabel.TabIndex = 85;
            this.LinhaIdLabel.Text = "Código:";
            this.LinhaIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGrupo
            // 
            this.cbGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(369, 104);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(137, 21);
            this.cbGrupo.TabIndex = 84;
            // 
            // gcImagem
            // 
            this.gcImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcImagem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcImagem.Controls.Add(this.peImagem);
            this.gcImagem.Location = new System.Drawing.Point(539, 17);
            this.gcImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcImagem.Name = "gcImagem";
            this.gcImagem.ShowCaption = false;
            this.gcImagem.Size = new System.Drawing.Size(277, 252);
            this.gcImagem.TabIndex = 216;
            // 
            // peImagem
            // 
            this.peImagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.peImagem.EditValue = ((object)(resources.GetObject("peImagem.EditValue")));
            this.peImagem.Location = new System.Drawing.Point(28, 13);
            this.peImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.peImagem.Name = "peImagem";
            this.peImagem.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.peImagem.Properties.Appearance.Options.UseBackColor = true;
            this.peImagem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peImagem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peImagem.Properties.ZoomAccelerationFactor = 1D;
            this.peImagem.Size = new System.Drawing.Size(231, 219);
            this.peImagem.TabIndex = 213;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(696, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 46);
            this.btnExit.TabIndex = 218;
            this.btnExit.Text = "&Fechar";
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrUpdate.ImageOptions.Image")));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(559, 430);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(118, 46);
            this.btnAddOrUpdate.TabIndex = 217;
            this.btnAddOrUpdate.Text = "&Gravar";
            // 
            // frmNovoOuEditaBordado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 488);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.gcImagem);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtBastidor);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.CorNomeLabel);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.txtDisquete);
            this.Controls.Add(this.LinhaIdLabel);
            this.Controls.Add(this.cbGrupo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNovoOuEditaBordado";
            this.Text = "Novo Bordado";
            ((System.ComponentModel.ISupportInitialize)(this.gcImagem)).EndInit();
            this.gcImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peImagem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDescricao;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtBastidor;
        internal System.Windows.Forms.TextBox txtArquivo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label CorNomeLabel;
        internal System.Windows.Forms.TextBox txtCaminho;
        internal System.Windows.Forms.TextBox txtDisquete;
        internal System.Windows.Forms.Label LinhaIdLabel;
        internal System.Windows.Forms.ComboBox cbGrupo;
        internal DevExpress.XtraEditors.GroupControl gcImagem;
        internal DevExpress.XtraEditors.PictureEdit peImagem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnAddOrUpdate;
    }
}