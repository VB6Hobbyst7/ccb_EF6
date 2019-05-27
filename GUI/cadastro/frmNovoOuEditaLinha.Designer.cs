namespace ccb_ef6
{
    partial class frmNovoOuEditaLinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoOuEditaLinha));
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ceCor = new DevExpress.XtraEditors.ColorEdit();
            this.txtEstoque1 = new DevExpress.XtraEditors.TextEdit();
            this.txtEstoque2 = new DevExpress.XtraEditors.TextEdit();
            this.txtMinimo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(380, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 46);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "&Fechar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Mínimo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrUpdate.ImageOptions.Image")));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(223, 226);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(135, 46);
            this.btnAddOrUpdate.TabIndex = 48;
            this.btnAddOrUpdate.Text = "&Gravar";
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(17, 175);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(244, 22);
            this.txtTipo.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tipo: ";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(17, 82);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(244, 22);
            this.txtMaterial.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Material:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Estoque 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Estoqque 1: ";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(17, 130);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(244, 22);
            this.txtFabricante.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fabricante";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(116, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 22);
            this.txtNome.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 22);
            this.txtCodigo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Código";
            // 
            // ceCor
            // 
            this.ceCor.EditValue = System.Drawing.Color.Empty;
            this.ceCor.Location = new System.Drawing.Point(353, 36);
            this.ceCor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ceCor.Name = "ceCor";
            this.ceCor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceCor.Size = new System.Drawing.Size(160, 22);
            this.ceCor.TabIndex = 50;
            // 
            // txtEstoque1
            // 
            this.txtEstoque1.EditValue = "0";
            this.txtEstoque1.EnterMoveNextControl = true;
            this.txtEstoque1.Location = new System.Drawing.Point(405, 93);
            this.txtEstoque1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoque1.Name = "txtEstoque1";
            this.txtEstoque1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEstoque1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEstoque1.Properties.Mask.EditMask = "n2";
            this.txtEstoque1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEstoque1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEstoque1.Size = new System.Drawing.Size(87, 22);
            this.txtEstoque1.TabIndex = 102;
            this.txtEstoque1.TabStop = false;
            // 
            // txtEstoque2
            // 
            this.txtEstoque2.EditValue = "0";
            this.txtEstoque2.EnterMoveNextControl = true;
            this.txtEstoque2.Location = new System.Drawing.Point(405, 129);
            this.txtEstoque2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEstoque2.Name = "txtEstoque2";
            this.txtEstoque2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEstoque2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEstoque2.Properties.Mask.EditMask = "n2";
            this.txtEstoque2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEstoque2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEstoque2.Size = new System.Drawing.Size(87, 22);
            this.txtEstoque2.TabIndex = 102;
            this.txtEstoque2.TabStop = false;
            // 
            // txtMinimo
            // 
            this.txtMinimo.EditValue = "0";
            this.txtMinimo.EnterMoveNextControl = true;
            this.txtMinimo.Location = new System.Drawing.Point(405, 171);
            this.txtMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMinimo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMinimo.Properties.Mask.EditMask = "n2";
            this.txtMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMinimo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMinimo.Size = new System.Drawing.Size(87, 22);
            this.txtMinimo.TabIndex = 102;
            this.txtMinimo.TabStop = false;
            // 
            // frmNovoOuEditaLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 292);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtEstoque2);
            this.Controls.Add(this.txtEstoque1);
            this.Controls.Add(this.ceCor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovoOuEditaLinha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Linha";
            this.Load += new System.EventHandler(this.frmNovoOuEditaLinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinimo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.SimpleButton btnAddOrUpdate;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ColorEdit ceCor;
        internal DevExpress.XtraEditors.TextEdit txtMinimo;
        internal DevExpress.XtraEditors.TextEdit txtEstoque2;
        internal DevExpress.XtraEditors.TextEdit txtEstoque1;
    }
}