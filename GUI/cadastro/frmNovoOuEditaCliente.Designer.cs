namespace ccb_ef6
{
    partial class frmNovoOuEditaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoOuEditaCliente));
            this.lblNomeRazaoSocial = new System.Windows.Forms.Label();
            this.txtNomeRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogradoro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.rgPfPj = new DevExpress.XtraEditors.RadioGroup();
            this.chkAtivo = new DevExpress.XtraEditors.CheckEdit();
            this.chkCreditoNegado = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgPfPj.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAtivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCreditoNegado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeRazaoSocial
            // 
            this.lblNomeRazaoSocial.AutoSize = true;
            this.lblNomeRazaoSocial.Location = new System.Drawing.Point(294, 4);
            this.lblNomeRazaoSocial.Name = "lblNomeRazaoSocial";
            this.lblNomeRazaoSocial.Size = new System.Drawing.Size(52, 13);
            this.lblNomeRazaoSocial.TabIndex = 0;
            this.lblNomeRazaoSocial.Text = "Nome: *";
            // 
            // txtNomeRazaoSocial
            // 
            this.txtNomeRazaoSocial.Location = new System.Drawing.Point(294, 20);
            this.txtNomeRazaoSocial.Name = "txtNomeRazaoSocial";
            this.txtNomeRazaoSocial.Size = new System.Drawing.Size(302, 20);
            this.txtNomeRazaoSocial.TabIndex = 3;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(94, 20);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(185, 20);
            this.txtCpfCnpj.TabIndex = 13;
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(91, 4);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCpfCnpj.TabIndex = 1;
            this.lblCpfCnpj.Text = "CPF:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(417, 67);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(90, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(248, 169);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(54, 20);
            this.txtUf.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "UF:";
            // 
            // txtLogradoro
            // 
            this.txtLogradoro.Location = new System.Drawing.Point(12, 67);
            this.txtLogradoro.Name = "txtLogradoro";
            this.txtLogradoro.Size = new System.Drawing.Size(399, 20);
            this.txtLogradoro.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Logadoro:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(12, 169);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(225, 20);
            this.txtCidade.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Cidade: *";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(518, 67);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(215, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Complemento:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrUpdate.ImageOptions.Image")));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(478, 314);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(118, 46);
            this.btnAddOrUpdate.TabIndex = 24;
            this.btnAddOrUpdate.Text = "&Gravar";
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(615, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 46);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "&Fechar";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rgPfPj
            // 
            this.rgPfPj.EditValue = true;
            this.rgPfPj.Location = new System.Drawing.Point(9, 12);
            this.rgPfPj.Name = "rgPfPj";
            this.rgPfPj.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgPfPj.Properties.Appearance.Options.UseBackColor = true;
            this.rgPfPj.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgPfPj.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "PF"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "PJ")});
            this.rgPfPj.Size = new System.Drawing.Size(79, 28);
            this.rgPfPj.TabIndex = 27;
            this.rgPfPj.SelectedIndexChanged += new System.EventHandler(this.rgPfPj_SelectedIndexChanged);
            // 
            // chkAtivo
            // 
            this.chkAtivo.Location = new System.Drawing.Point(615, 1);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Properties.Caption = "Ativo";
            this.chkAtivo.Size = new System.Drawing.Size(52, 19);
            this.chkAtivo.TabIndex = 28;
            // 
            // chkCreditoNegado
            // 
            this.chkCreditoNegado.Location = new System.Drawing.Point(615, 26);
            this.chkCreditoNegado.Name = "chkCreditoNegado";
            this.chkCreditoNegado.Properties.Caption = "Crédito Negado";
            this.chkCreditoNegado.Size = new System.Drawing.Size(113, 19);
            this.chkCreditoNegado.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 115);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(399, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(417, 115);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(138, 20);
            this.txtCEP.TabIndex = 8;
            // 
            // frmNovoOuEditaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(750, 380);
            this.Controls.Add(this.chkCreditoNegado);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.rgPfPj);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLogradoro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.txtNomeRazaoSocial);
            this.Controls.Add(this.lblNomeRazaoSocial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 419);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(766, 419);
            this.Name = "frmNovoOuEditaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo  Cliente";
            this.Load += new System.EventHandler(this.frmNovoOuEditaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgPfPj.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAtivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCreditoNegado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeRazaoSocial;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogradoro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnAddOrUpdate;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.RadioGroup rgPfPj;
        private DevExpress.XtraEditors.CheckEdit chkCreditoNegado;
        private DevExpress.XtraEditors.CheckEdit chkAtivo;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label2;
    }
}