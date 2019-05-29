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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoOuEditaBordado));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.dgLinhas_Utilizadas = new DevExpress.XtraGrid.GridControl();
            this.gvLinhas_Utilizadas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPontos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetragem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcImagem)).BeginInit();
            this.gcImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImagem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLinhas_Utilizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinhas_Utilizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.AcceptsReturn = true;
            this.txtDescricao.AcceptsTab = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(108, 71);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(564, 22);
            this.txtDescricao.TabIndex = 81;
            this.txtDescricao.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(680, 21);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 28);
            this.btnBrowse.TabIndex = 93;
            this.btnBrowse.Text = "...";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Navy;
            this.txtId.Location = new System.Drawing.Point(108, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(85, 34);
            this.txtId.TabIndex = 86;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(216, 132);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 17);
            this.Label4.TabIndex = 92;
            this.Label4.Text = "Bastidor:";
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(427, 130);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(52, 17);
            this.Label8.TabIndex = 94;
            this.Label8.Text = "Grupo:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(17, 71);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(87, 23);
            this.Label10.TabIndex = 90;
            this.Label10.Text = "Descrição:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBastidor
            // 
            this.txtBastidor.Location = new System.Drawing.Point(291, 128);
            this.txtBastidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBastidor.Name = "txtBastidor";
            this.txtBastidor.Size = new System.Drawing.Size(89, 22);
            this.txtBastidor.TabIndex = 83;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArquivo.Location = new System.Drawing.Point(276, 23);
            this.txtArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(396, 22);
            this.txtArquivo.TabIndex = 80;
            this.txtArquivo.Text = "teste.dst";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(17, 103);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 20);
            this.Label1.TabIndex = 89;
            this.Label1.Text = "Caminho:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(31, 129);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 16);
            this.Label3.TabIndex = 91;
            this.Label3.Text = "Disquete:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CorNomeLabel
            // 
            this.CorNomeLabel.AutoSize = true;
            this.CorNomeLabel.Location = new System.Drawing.Point(207, 28);
            this.CorNomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CorNomeLabel.Name = "CorNomeLabel";
            this.CorNomeLabel.Size = new System.Drawing.Size(60, 17);
            this.CorNomeLabel.TabIndex = 87;
            this.CorNomeLabel.Text = "Arquivo:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(108, 101);
            this.txtCaminho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(565, 22);
            this.txtCaminho.TabIndex = 88;
            this.txtCaminho.TabStop = false;
            // 
            // txtDisquete
            // 
            this.txtDisquete.Location = new System.Drawing.Point(108, 128);
            this.txtDisquete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDisquete.Name = "txtDisquete";
            this.txtDisquete.Size = new System.Drawing.Size(85, 22);
            this.txtDisquete.TabIndex = 82;
            // 
            // LinhaIdLabel
            // 
            this.LinhaIdLabel.Location = new System.Drawing.Point(31, 28);
            this.LinhaIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinhaIdLabel.Name = "LinhaIdLabel";
            this.LinhaIdLabel.Size = new System.Drawing.Size(73, 16);
            this.LinhaIdLabel.TabIndex = 85;
            this.LinhaIdLabel.Text = "Código:";
            this.LinhaIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGrupo
            // 
            this.cbGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(492, 128);
            this.cbGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(181, 24);
            this.cbGrupo.TabIndex = 84;
            // 
            // gcImagem
            // 
            this.gcImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gcImagem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gcImagem.Controls.Add(this.peImagem);
            this.gcImagem.Location = new System.Drawing.Point(719, 21);
            this.gcImagem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gcImagem.Name = "gcImagem";
            this.gcImagem.ShowCaption = false;
            this.gcImagem.Size = new System.Drawing.Size(369, 310);
            this.gcImagem.TabIndex = 216;
            // 
            // peImagem
            // 
            this.peImagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.peImagem.EditValue = ((object)(resources.GetObject("peImagem.EditValue")));
            this.peImagem.Location = new System.Drawing.Point(37, 16);
            this.peImagem.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.peImagem.Name = "peImagem";
            this.peImagem.Properties.Appearance.BackColor = System.Drawing.Color.Silver;
            this.peImagem.Properties.Appearance.Options.UseBackColor = true;
            this.peImagem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peImagem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peImagem.Properties.ZoomAccelerationFactor = 1D;
            this.peImagem.Size = new System.Drawing.Size(308, 270);
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
            this.btnExit.Location = new System.Drawing.Point(928, 529);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 57);
            this.btnExit.TabIndex = 218;
            this.btnExit.Text = "&Fechar";
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrUpdate.ImageOptions.Image")));
            this.btnAddOrUpdate.Location = new System.Drawing.Point(745, 529);
            this.btnAddOrUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(157, 57);
            this.btnAddOrUpdate.TabIndex = 217;
            this.btnAddOrUpdate.Text = "&Gravar";
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // dgLinhas_Utilizadas
            // 
            this.dgLinhas_Utilizadas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.dgLinhas_Utilizadas.Location = new System.Drawing.Point(108, 169);
            this.dgLinhas_Utilizadas.MainView = this.gvLinhas_Utilizadas;
            this.dgLinhas_Utilizadas.Margin = new System.Windows.Forms.Padding(2);
            this.dgLinhas_Utilizadas.Name = "dgLinhas_Utilizadas";
            this.dgLinhas_Utilizadas.Size = new System.Drawing.Size(402, 232);
            this.dgLinhas_Utilizadas.TabIndex = 219;
            this.dgLinhas_Utilizadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLinhas_Utilizadas});
            // 
            // gvLinhas_Utilizadas
            // 
            this.gvLinhas_Utilizadas.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvLinhas_Utilizadas.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.EvenRow.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.gvLinhas_Utilizadas.Appearance.FocusedRow.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvLinhas_Utilizadas.Appearance.GroupFooter.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 7F);
            this.gvLinhas_Utilizadas.Appearance.OddRow.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvLinhas_Utilizadas.Appearance.Row.Options.UseFont = true;
            this.gvLinhas_Utilizadas.Appearance.Row.Options.UseTextOptions = true;
            this.gvLinhas_Utilizadas.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvLinhas_Utilizadas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeq,
            this.codigo,
            this.cor,
            this.colNome,
            this.colPontos,
            this.colMetragem});
            this.gvLinhas_Utilizadas.FixedLineWidth = 1;
            this.gvLinhas_Utilizadas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvLinhas_Utilizadas.FooterPanelHeight = 10;
            gridFormatRule1.Column = this.colMetragem;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "Sim";
            formatConditionRuleValue1.PredefinedName = "Red Fill, Red Text";
            formatConditionRuleValue1.Value1 = "Sim";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gvLinhas_Utilizadas.FormatRules.Add(gridFormatRule1);
            this.gvLinhas_Utilizadas.GridControl = this.dgLinhas_Utilizadas;
            this.gvLinhas_Utilizadas.GroupFormat = "{0}: [#imagem]{1} {2}";
            this.gvLinhas_Utilizadas.Name = "gvLinhas_Utilizadas";
            this.gvLinhas_Utilizadas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvLinhas_Utilizadas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvLinhas_Utilizadas.OptionsBehavior.AllowIncrementalSearch = true;
            this.gvLinhas_Utilizadas.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvLinhas_Utilizadas.OptionsBehavior.AutoPopulateColumns = false;
            this.gvLinhas_Utilizadas.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvLinhas_Utilizadas.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvLinhas_Utilizadas.OptionsCustomization.AllowColumnMoving = false;
            this.gvLinhas_Utilizadas.OptionsCustomization.AllowColumnResizing = false;
            this.gvLinhas_Utilizadas.OptionsCustomization.AllowFilter = false;
            this.gvLinhas_Utilizadas.OptionsCustomization.AllowGroup = false;
            this.gvLinhas_Utilizadas.OptionsCustomization.AllowSort = false;
            this.gvLinhas_Utilizadas.OptionsDetail.EnableMasterViewMode = false;
            this.gvLinhas_Utilizadas.OptionsDetail.SmartDetailHeight = true;
            this.gvLinhas_Utilizadas.OptionsMenu.EnableColumnMenu = false;
            this.gvLinhas_Utilizadas.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvLinhas_Utilizadas.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvLinhas_Utilizadas.OptionsSelection.MultiSelect = true;
            this.gvLinhas_Utilizadas.OptionsSelection.UseIndicatorForSelection = false;
            this.gvLinhas_Utilizadas.OptionsView.ColumnAutoWidth = false;
            this.gvLinhas_Utilizadas.OptionsView.ShowGroupPanel = false;
            this.gvLinhas_Utilizadas.RowHeight = 18;
            this.gvLinhas_Utilizadas.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
            this.gvLinhas_Utilizadas.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colSeq
            // 
            this.colSeq.AppearanceCell.Options.UseTextOptions = true;
            this.colSeq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeq.AppearanceHeader.Options.UseTextOptions = true;
            this.colSeq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeq.Caption = "seq";
            this.colSeq.FieldName = "seq";
            this.colSeq.Name = "colSeq";
            this.colSeq.OptionsColumn.AllowEdit = false;
            this.colSeq.Visible = true;
            this.colSeq.VisibleIndex = 0;
            this.colSeq.Width = 40;
            // 
            // codigo
            // 
            this.codigo.AppearanceCell.Options.UseTextOptions = true;
            this.codigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.codigo.AppearanceHeader.Options.UseTextOptions = true;
            this.codigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.codigo.Caption = "codigo";
            this.codigo.FieldName = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.Visible = true;
            this.codigo.VisibleIndex = 1;
            this.codigo.Width = 53;
            // 
            // cor
            // 
            this.cor.Caption = "cor";
            this.cor.FieldName = "cor";
            this.cor.Name = "cor";
            this.cor.OptionsColumn.AllowEdit = false;
            this.cor.Visible = true;
            this.cor.VisibleIndex = 2;
            this.cor.Width = 42;
            // 
            // colNome
            // 
            this.colNome.Caption = "nome";
            this.colNome.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNome.FieldName = "nome";
            this.colNome.Name = "colNome";
            this.colNome.OptionsColumn.AllowEdit = false;
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 3;
            this.colNome.Width = 98;
            // 
            // colPontos
            // 
            this.colPontos.AppearanceCell.Options.UseTextOptions = true;
            this.colPontos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPontos.AppearanceHeader.Options.UseTextOptions = true;
            this.colPontos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPontos.Caption = "pontos";
            this.colPontos.FieldName = "pontos";
            this.colPontos.Name = "colPontos";
            this.colPontos.OptionsColumn.AllowEdit = false;
            this.colPontos.Visible = true;
            this.colPontos.VisibleIndex = 4;
            this.colPontos.Width = 60;
            // 
            // colMetragem
            // 
            this.colMetragem.AppearanceCell.Options.UseTextOptions = true;
            this.colMetragem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMetragem.AppearanceHeader.Options.UseTextOptions = true;
            this.colMetragem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colMetragem.Caption = "metragem";
            this.colMetragem.FieldName = "metragem";
            this.colMetragem.Name = "colMetragem";
            this.colMetragem.OptionsColumn.AllowEdit = false;
            this.colMetragem.Visible = true;
            this.colMetragem.VisibleIndex = 5;
            this.colMetragem.Width = 67;
            // 
            // frmNovoOuEditaBordado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 601);
            this.Controls.Add(this.dgLinhas_Utilizadas);
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmNovoOuEditaBordado";
            this.Text = "Novo Bordado";
            ((System.ComponentModel.ISupportInitialize)(this.gcImagem)).EndInit();
            this.gcImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peImagem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLinhas_Utilizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinhas_Utilizadas)).EndInit();
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
        internal DevExpress.XtraGrid.GridControl dgLinhas_Utilizadas;
        internal DevExpress.XtraGrid.Views.Grid.GridView gvLinhas_Utilizadas;
        internal DevExpress.XtraGrid.Columns.GridColumn colSeq;
        internal DevExpress.XtraGrid.Columns.GridColumn codigo;
        internal DevExpress.XtraGrid.Columns.GridColumn cor;
        internal DevExpress.XtraGrid.Columns.GridColumn colNome;
        internal DevExpress.XtraGrid.Columns.GridColumn colPontos;
        internal DevExpress.XtraGrid.Columns.GridColumn colMetragem;
    }
}