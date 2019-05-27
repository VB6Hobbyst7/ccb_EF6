namespace ccb_ef6
{
    partial class frmListaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaCliente));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextToFind = new System.Windows.Forms.TextBox();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.dgRegistros = new DevExpress.XtraGrid.GridControl();
            this.gvRegistros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistros)).BeginInit();
            this.gbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca: ";
            // 
            // txtTextToFind
            // 
            this.txtTextToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToFind.Location = new System.Drawing.Point(65, 22);
            this.txtTextToFind.Name = "txtTextToFind";
            this.txtTextToFind.Size = new System.Drawing.Size(550, 23);
            this.txtTextToFind.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTextToFind, "Criterios de busqueda: Nombres, Apellidos, Correo o Teléfonos");
            this.txtTextToFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTextToFind_KeyUp);
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
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(693, 506);
            this.gbList.TabIndex = 0;
            this.gbList.TabStop = false;
            this.gbList.Text = "Lista de clientes";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(620, 18);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 26);
            this.btnFind.TabIndex = 54;
            this.btnFind.Text = "Buscar";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgRegistros
            // 
            this.dgRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.dgRegistros.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgRegistros.Location = new System.Drawing.Point(0, 50);
            this.dgRegistros.MainView = this.gvRegistros;
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.Size = new System.Drawing.Size(693, 457);
            this.dgRegistros.TabIndex = 53;
            this.dgRegistros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRegistros});
            // 
            // gvRegistros
            // 
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
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnExit);
            this.gbAcciones.Controls.Add(this.btnEdit);
            this.gbAcciones.Controls.Add(this.btnNew);
            this.gbAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(699, 0);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(110, 506);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Ações";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(12, 459);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 37);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Fechar";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(12, 76);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 37);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(12, 24);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 37);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "Novo";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(824, 543);
            this.Name = "frmListaCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmListaCliente_Load);
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegistros)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TextBox txtTextToFind;
        protected System.Windows.Forms.GroupBox gbList;
        protected System.Windows.Forms.GroupBox gbAcciones;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevExpress.XtraGrid.GridControl dgRegistros;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRegistros;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnFind;
    }
}