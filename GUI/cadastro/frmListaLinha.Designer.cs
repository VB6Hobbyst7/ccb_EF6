namespace ccb_ef6
{
    partial class frmListaLinha
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Repository.RepositoryItemColorEdit repositoryItemColorEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorEdit();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaLinha));
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gvRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estoque1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Minimo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTextToFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Estoque_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemColorEdit1)).BeginInit();
            this.gbList.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRegistros
            // 
            this.dgRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRegistros.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(0, 61);
            this.dgRegistros.MainView = this.gvRegistros;
            this.dgRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(924, 562);
            this.dgRegistros.TabIndex = 53;
            this.dgRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRegistros});
            // 
            // gvRegistros
            // 
            this.gvRegistros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.Nome,
            this.Cor,
            this.Estoque1,
            this.Estoque_2,
            this.Minimo,
            this.Pedido});
            this.gvRegistros.DetailHeight = 100;
            this.gvRegistros.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvRegistros.GridControl = this.dgRegistros;
            this.gvRegistros.Name = "gvRegistros";
            this.gvRegistros.OptionsBehavior.Editable = false;
            this.gvRegistros.OptionsBehavior.SmartVertScrollBar = false;
            this.gvRegistros.OptionsCustomization.AllowColumnMoving = false;
            this.gvRegistros.OptionsCustomization.AllowColumnResizing = false;
            this.gvRegistros.OptionsCustomization.AllowFilter = false;
            this.gvRegistros.OptionsCustomization.AllowGroup = false;
            this.gvRegistros.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvRegistros.OptionsCustomization.AllowSort = false;
            this.gvRegistros.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gvRegistros.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gvRegistros.OptionsFilter.AllowFilterEditor = false;
            this.gvRegistros.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gvRegistros.OptionsFilter.AllowMRUFilterList = false;
            this.gvRegistros.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gvRegistros.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gvRegistros.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvRegistros.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvRegistros.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvRegistros.OptionsView.AllowHtmlDrawGroups = false;
            this.gvRegistros.OptionsView.ShowFooter = true;
            this.gvRegistros.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gvRegistros.OptionsView.ShowGroupPanel = false;
            this.gvRegistros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvRegistros_KeyUp);
            this.gvRegistros.DoubleClick += new System.EventHandler(this.gvRegistros_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 54;
            // 
            // Nome
            // 
            this.Nome.Caption = "Cor";
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 1;
            this.Nome.Width = 234;
            // 
            // Cor
            // 
            this.Cor.Caption = "Cor";
            repositoryItemColorEdit1.AutoHeight = false;
            repositoryItemColorEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemColorEdit1.Name = "repositoryItemColorEdit1";
            this.Cor.ColumnEdit = repositoryItemColorEdit1;
            this.Cor.FieldName = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.Visible = true;
            this.Cor.VisibleIndex = 2;
            this.Cor.Width = 97;
            // 
            // Estoque1
            // 
            this.Estoque1.AppearanceHeader.Options.UseTextOptions = true;
            this.Estoque1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Estoque1.Caption = "Estoque1";
            this.Estoque1.FieldName = "Estoque_1";
            this.Estoque1.Name = "Estoque1";
            this.Estoque1.Visible = true;
            this.Estoque1.VisibleIndex = 3;
            this.Estoque1.Width = 94;
            // 
            // Minimo
            // 
            this.Minimo.AppearanceHeader.Options.UseTextOptions = true;
            this.Minimo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Minimo.Caption = "Mínimo";
            this.Minimo.FieldName = "Minimo";
            this.Minimo.Name = "Minimo";
            this.Minimo.Visible = true;
            this.Minimo.VisibleIndex = 5;
            this.Minimo.Width = 74;
            // 
            // txtTextToFind
            // 
            this.txtTextToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToFind.Location = new System.Drawing.Point(87, 27);
            this.txtTextToFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtTextToFind.Name = "txtTextToFind";
            this.txtTextToFind.Size = new System.Drawing.Size(732, 26);
            this.txtTextToFind.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTextToFind, "Criterios de busqueda: Nombres, Apellidos, Correo o Teléfonos");
            this.txtTextToFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTextToFind_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca: ";
            // 
            // gbList
            // 
            this.gbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbList.Controls.Add(this.btnFind);
            this.gbList.Controls.Add(this.dgRegistros);
            this.gbList.Controls.Add(this.txtTextToFind);
            this.gbList.Controls.Add(this.label1);
            this.gbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.Location = new System.Drawing.Point(0, 0);
            this.gbList.Margin = new System.Windows.Forms.Padding(4);
            this.gbList.Name = "gbList";
            this.gbList.Padding = new System.Windows.Forms.Padding(4);
            this.gbList.Size = new System.Drawing.Size(924, 623);
            this.gbList.TabIndex = 2;
            this.gbList.TabStop = false;
            this.gbList.Text = "Lista de linhas";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(826, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 32);
            this.btnFind.TabIndex = 54;
            this.btnFind.Text = "Buscar";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnExit);
            this.gbAcciones.Controls.Add(this.btnEdit);
            this.gbAcciones.Controls.Add(this.btnNew);
            this.gbAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(932, 0);
            this.gbAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.gbAcciones.Size = new System.Drawing.Size(147, 623);
            this.gbAcciones.TabIndex = 3;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Ações";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(16, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 46);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Fechar";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(16, 94);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 46);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(16, 30);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 46);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Novo";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Estoque_2
            // 
            this.Estoque_2.AppearanceHeader.Options.UseTextOptions = true;
            this.Estoque_2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Estoque_2.Caption = "Estoque2";
            this.Estoque_2.FieldName = "Estoque_2";
            this.Estoque_2.Name = "Estoque_2";
            this.Estoque_2.Visible = true;
            this.Estoque_2.VisibleIndex = 4;
            this.Estoque_2.Width = 86;
            // 
            // Pedido
            // 
            this.Pedido.AppearanceHeader.Options.UseTextOptions = true;
            this.Pedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Pedido.Caption = "Pedido";
            this.Pedido.FieldName = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.Visible = true;
            this.Pedido.VisibleIndex = 6;
            this.Pedido.Width = 265;
            // 
            // frmListaLinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 623);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbAcciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaLinha";
            this.Text = "Linhas";
            this.Load += new System.EventHandler(this.frmListaLinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemColorEdit1)).EndInit();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRegistros;
        protected System.Windows.Forms.TextBox txtTextToFind;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox gbList;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        protected System.Windows.Forms.GroupBox gbAcciones;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Cor;
        private DevExpress.XtraGrid.Columns.GridColumn Estoque1;
        private DevExpress.XtraGrid.Columns.GridColumn Minimo;
        private DevExpress.XtraGrid.Columns.GridColumn Estoque_2;
        private DevExpress.XtraGrid.Columns.GridColumn Pedido;
    }
}