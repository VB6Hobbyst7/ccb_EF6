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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextToFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.gbxTransactions = new System.Windows.Forms.GroupBox();
            this.btnAdjustment = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbAcciones.SuspendLayout();
            this.gbxTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca: ";
            // 
            // txtTextToFind
            // 
            this.txtTextToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToFind.Location = new System.Drawing.Point(82, 38);
            this.txtTextToFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTextToFind.Name = "txtTextToFind";
            this.txtTextToFind.Size = new System.Drawing.Size(555, 26);
            this.txtTextToFind.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtTextToFind, "Criterios de busqueda: Nombres, Apellidos, Correo o Teléfonos");
            this.txtTextToFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTextToFind_KeyUp);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.Peru;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(645, 21);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(192, 59);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Visible = false;
            // 
            // gbList
            // 
            this.gbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbList.Controls.Add(this.dgvClientes);
            this.gbList.Controls.Add(this.btnFind);
            this.gbList.Controls.Add(this.txtTextToFind);
            this.gbList.Controls.Add(this.label1);
            this.gbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbList.Location = new System.Drawing.Point(0, 0);
            this.gbList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbList.Name = "gbList";
            this.gbList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbList.Size = new System.Drawing.Size(845, 623);
            this.gbList.TabIndex = 0;
            this.gbList.TabStop = false;
            this.gbList.Text = "Lista de clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Contato_Nome,
            this.Telefone1,
            this.Telefone2,
            this.Email});
            this.dgvClientes.Location = new System.Drawing.Point(20, 87);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 10;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(817, 528);
            this.dgvClientes.TabIndex = 17;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            this.dgvClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvClientes_KeyPress);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 46;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 86;
            // 
            // Contato_Nome
            // 
            this.Contato_Nome.DataPropertyName = "Contato_Nome";
            this.Contato_Nome.HeaderText = "Contato_nome";
            this.Contato_Nome.Name = "Contato_Nome";
            this.Contato_Nome.ReadOnly = true;
            this.Contato_Nome.Width = 158;
            // 
            // Telefone1
            // 
            this.Telefone1.DataPropertyName = "Telefone1";
            this.Telefone1.HeaderText = "Telefone";
            this.Telefone1.Name = "Telefone1";
            this.Telefone1.ReadOnly = true;
            this.Telefone1.Width = 110;
            // 
            // Telefone2
            // 
            this.Telefone2.DataPropertyName = "Telefone2";
            this.Telefone2.HeaderText = "Celular";
            this.Telefone2.Name = "Telefone2";
            this.Telefone2.ReadOnly = true;
            this.Telefone2.Width = 98;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 85;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnViewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAccount.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAccount.Location = new System.Drawing.Point(16, 159);
            this.btnViewAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(192, 59);
            this.btnViewAccount.TabIndex = 12;
            this.btnViewAccount.Text = "Ver Conta";
            this.btnViewAccount.UseVisualStyleBackColor = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Orange;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(16, 28);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(192, 59);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "&Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(16, 94);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(192, 59);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "&Editar ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(16, 556);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 59);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.gbxTransactions);
            this.gbAcciones.Controls.Add(this.btnClose);
            this.gbAcciones.Controls.Add(this.btnEdit);
            this.gbAcciones.Controls.Add(this.btnNew);
            this.gbAcciones.Controls.Add(this.btnViewAccount);
            this.gbAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbAcciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAcciones.Location = new System.Drawing.Point(855, 0);
            this.gbAcciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAcciones.Size = new System.Drawing.Size(224, 623);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // gbxTransactions
            // 
            this.gbxTransactions.Controls.Add(this.btnAdjustment);
            this.gbxTransactions.Controls.Add(this.btnWithdrawal);
            this.gbxTransactions.Controls.Add(this.btnExpense);
            this.gbxTransactions.Controls.Add(this.btnPurchase);
            this.gbxTransactions.Location = new System.Drawing.Point(8, 229);
            this.gbxTransactions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTransactions.Name = "gbxTransactions";
            this.gbxTransactions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxTransactions.Size = new System.Drawing.Size(208, 315);
            this.gbxTransactions.TabIndex = 17;
            this.gbxTransactions.TabStop = false;
            this.gbxTransactions.Text = "Transacciones";
            // 
            // btnAdjustment
            // 
            this.btnAdjustment.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjustment.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjustment.Location = new System.Drawing.Point(8, 238);
            this.btnAdjustment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdjustment.Name = "btnAdjustment";
            this.btnAdjustment.Size = new System.Drawing.Size(192, 59);
            this.btnAdjustment.TabIndex = 19;
            this.btnAdjustment.Text = "Ajuste";
            this.btnAdjustment.UseVisualStyleBackColor = false;
            this.btnAdjustment.Visible = false;
            this.btnAdjustment.Click += new System.EventHandler(this.btnAdjustment_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.BackColor = System.Drawing.Color.Tomato;
            this.btnWithdrawal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawal.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrawal.Location = new System.Drawing.Point(8, 171);
            this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(192, 59);
            this.btnWithdrawal.TabIndex = 18;
            this.btnWithdrawal.Text = "Retiro";
            this.btnWithdrawal.UseVisualStyleBackColor = false;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.Location = new System.Drawing.Point(8, 105);
            this.btnExpense.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(192, 59);
            this.btnExpense.TabIndex = 17;
            this.btnExpense.Text = "Gasto";
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(8, 38);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(192, 59);
            this.btnPurchase.TabIndex = 16;
            this.btnPurchase.Text = "Compra";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // frmListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1079, 623);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1094, 660);
            this.Name = "frmListaCliente";
            this.Text = "Lista de clientes";
            this.Load += new System.EventHandler(this.frmListaCliente_Load);
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            this.gbxTransactions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TextBox txtTextToFind;
        protected System.Windows.Forms.Button btnFind;
        protected System.Windows.Forms.GroupBox gbList;
        protected System.Windows.Forms.Button btnViewAccount;
        protected System.Windows.Forms.Button btnNew;
        protected System.Windows.Forms.Button btnEdit;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.GroupBox gbAcciones;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbxTransactions;
        protected System.Windows.Forms.Button btnWithdrawal;
        protected System.Windows.Forms.Button btnExpense;
        protected System.Windows.Forms.Button btnPurchase;
        protected System.Windows.Forms.Button btnAdjustment;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}