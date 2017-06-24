namespace ContactList
{
	partial class frmMain
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblInfoTitle = new System.Windows.Forms.Label();
			this.lblInfoFullName = new System.Windows.Forms.Label();
			this.lblInfoEmail = new System.Windows.Forms.Label();
			this.lblInfoPhone = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtBirth = new System.Windows.Forms.DateTimePicker();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.dtg = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
			this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dtg, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.67377F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.32623F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 562);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(878, 200);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.85649F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.14351F));
			this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.lblInfoTitle, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblInfoFullName, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lblInfoEmail, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.lblInfoPhone, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.txtEmail, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.txtPhone, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.txtBirth, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.txtFullName, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.btnNew, 0, 5);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 6;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 200);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
			this.btnAdd.Enabled = false;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.Location = new System.Drawing.Point(761, 168);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(114, 29);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblInfoTitle
			// 
			this.lblInfoTitle.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.lblInfoTitle, 2);
			this.lblInfoTitle.Font = new System.Drawing.Font("Segoe UI Light", 18.25F);
			this.lblInfoTitle.ForeColor = System.Drawing.Color.White;
			this.lblInfoTitle.Location = new System.Drawing.Point(3, 0);
			this.lblInfoTitle.Name = "lblInfoTitle";
			this.lblInfoTitle.Size = new System.Drawing.Size(219, 33);
			this.lblInfoTitle.TabIndex = 1;
			this.lblInfoTitle.Text = "Contact List Sample";
			// 
			// lblInfoFullName
			// 
			this.lblInfoFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblInfoFullName.AutoSize = true;
			this.lblInfoFullName.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoFullName.ForeColor = System.Drawing.Color.White;
			this.lblInfoFullName.Location = new System.Drawing.Point(3, 40);
			this.lblInfoFullName.Name = "lblInfoFullName";
			this.lblInfoFullName.Size = new System.Drawing.Size(70, 19);
			this.lblInfoFullName.TabIndex = 2;
			this.lblInfoFullName.Text = "Full Name";
			// 
			// lblInfoEmail
			// 
			this.lblInfoEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblInfoEmail.AutoSize = true;
			this.lblInfoEmail.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoEmail.ForeColor = System.Drawing.Color.White;
			this.lblInfoEmail.Location = new System.Drawing.Point(3, 73);
			this.lblInfoEmail.Name = "lblInfoEmail";
			this.lblInfoEmail.Size = new System.Drawing.Size(41, 19);
			this.lblInfoEmail.TabIndex = 2;
			this.lblInfoEmail.Text = "Email";
			// 
			// lblInfoPhone
			// 
			this.lblInfoPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblInfoPhone.AutoSize = true;
			this.lblInfoPhone.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfoPhone.ForeColor = System.Drawing.Color.White;
			this.lblInfoPhone.Location = new System.Drawing.Point(3, 106);
			this.lblInfoPhone.Name = "lblInfoPhone";
			this.lblInfoPhone.Size = new System.Drawing.Size(48, 19);
			this.lblInfoPhone.TabIndex = 2;
			this.lblInfoPhone.Text = "Phone";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(3, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "Birthday";
			// 
			// txtEmail
			// 
			this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtEmail.Location = new System.Drawing.Point(150, 71);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.ReadOnly = true;
			this.txtEmail.Size = new System.Drawing.Size(725, 22);
			this.txtEmail.TabIndex = 1;
			// 
			// txtPhone
			// 
			this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPhone.Location = new System.Drawing.Point(150, 104);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(725, 22);
			this.txtPhone.TabIndex = 2;
			// 
			// txtBirth
			// 
			this.txtBirth.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtBirth.Enabled = false;
			this.txtBirth.Location = new System.Drawing.Point(150, 137);
			this.txtBirth.Name = "txtBirth";
			this.txtBirth.Size = new System.Drawing.Size(224, 22);
			this.txtBirth.TabIndex = 4;
			// 
			// txtFullName
			// 
			this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFullName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtFullName.Location = new System.Drawing.Point(150, 38);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.ReadOnly = true;
			this.txtFullName.Size = new System.Drawing.Size(725, 22);
			this.txtFullName.TabIndex = 0;
			// 
			// btnNew
			// 
			this.btnNew.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNew.FlatAppearance.BorderSize = 0;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.Location = new System.Drawing.Point(3, 168);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(141, 29);
			this.btnNew.TabIndex = 5;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// dtg
			// 
			this.dtg.AllowUserToAddRows = false;
			this.dtg.AllowUserToDeleteRows = false;
			this.dtg.AllowUserToResizeColumns = false;
			this.dtg.AllowUserToResizeRows = false;
			this.dtg.BackgroundColor = System.Drawing.Color.White;
			this.dtg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dtg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dtg.ColumnHeadersHeight = 30;
			this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colMail,
            this.colPhone,
            this.colBirth,
            this.colAction,
            this.colEdit});
			this.tableLayoutPanel1.SetColumnSpan(this.dtg, 2);
			this.dtg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dtg.EnableHeadersVisualStyles = false;
			this.dtg.Location = new System.Drawing.Point(3, 209);
			this.dtg.Name = "dtg";
			this.dtg.ReadOnly = true;
			this.dtg.RowHeadersVisible = false;
			this.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg.Size = new System.Drawing.Size(878, 350);
			this.dtg.TabIndex = 1;
			// 
			// colId
			// 
			this.colId.HeaderText = "ID";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			this.colId.Visible = false;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.HeaderText = "FULL NAME";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colMail
			// 
			this.colMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colMail.HeaderText = "EMAIL";
			this.colMail.Name = "colMail";
			this.colMail.ReadOnly = true;
			// 
			// colPhone
			// 
			this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colPhone.HeaderText = "PHONE";
			this.colPhone.Name = "colPhone";
			this.colPhone.ReadOnly = true;
			this.colPhone.Width = 67;
			// 
			// colBirth
			// 
			this.colBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colBirth.HeaderText = "BIRTHDAY";
			this.colBirth.Name = "colBirth";
			this.colBirth.ReadOnly = true;
			this.colBirth.Width = 80;
			// 
			// colAction
			// 
			this.colAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colAction.HeaderText = "ACTION";
			this.colAction.Name = "colAction";
			this.colAction.ReadOnly = true;
			this.colAction.Width = 50;
			// 
			// colEdit
			// 
			this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colEdit.HeaderText = "ACTION";
			this.colEdit.Name = "colEdit";
			this.colEdit.ReadOnly = true;
			this.colEdit.Width = 50;
			// 
			// frmMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contact List | FescDEV";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.DataGridView dtg;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblInfoTitle;
		private System.Windows.Forms.Label lblInfoFullName;
		private System.Windows.Forms.Label lblInfoEmail;
		private System.Windows.Forms.Label lblInfoPhone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.DateTimePicker txtBirth;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBirth;
		private System.Windows.Forms.DataGridViewButtonColumn colAction;
		private System.Windows.Forms.DataGridViewButtonColumn colEdit;
	}
}

