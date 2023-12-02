namespace adminUI
{
    partial class EditEmployee
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
            this.rolesDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeNotRolesdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Action1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotRolesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesDataGridView
            // 
            this.rolesDataGridView.AllowUserToAddRows = false;
            this.rolesDataGridView.AllowUserToDeleteRows = false;
            this.rolesDataGridView.AutoGenerateColumns = false;
            this.rolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn1,
            this.Action1});
            this.rolesDataGridView.DataSource = this.roleBindingSource;
            this.rolesDataGridView.Location = new System.Drawing.Point(40, 32);
            this.rolesDataGridView.Name = "rolesDataGridView";
            this.rolesDataGridView.ReadOnly = true;
            this.rolesDataGridView.RowHeadersWidth = 51;
            this.rolesDataGridView.RowTemplate.Height = 24;
            this.rolesDataGridView.Size = new System.Drawing.Size(406, 253);
            this.rolesDataGridView.TabIndex = 0;
            this.rolesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesDataGridView_CellContentClick);
            // 
            // employeeNotRolesdataGridView
            // 
            this.employeeNotRolesdataGridView.AllowUserToAddRows = false;
            this.employeeNotRolesdataGridView.AllowUserToDeleteRows = false;
            this.employeeNotRolesdataGridView.AutoGenerateColumns = false;
            this.employeeNotRolesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeNotRolesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.Action});
            this.employeeNotRolesdataGridView.DataSource = this.roleBindingSource;
            this.employeeNotRolesdataGridView.Location = new System.Drawing.Point(532, 32);
            this.employeeNotRolesdataGridView.Name = "employeeNotRolesdataGridView";
            this.employeeNotRolesdataGridView.ReadOnly = true;
            this.employeeNotRolesdataGridView.RowHeadersWidth = 51;
            this.employeeNotRolesdataGridView.RowTemplate.Height = 24;
            this.employeeNotRolesdataGridView.Size = new System.Drawing.Size(406, 253);
            this.employeeNotRolesdataGridView.TabIndex = 1;
            this.employeeNotRolesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeNotRolesdataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Roles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Not Roles";
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Description";
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Assign";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 125;
            // 
            // Action1
            // 
            this.Action1.DataPropertyName = "Description";
            this.Action1.HeaderText = "Action";
            this.Action1.MinimumWidth = 6;
            this.Action1.Name = "Action1";
            this.Action1.ReadOnly = true;
            this.Action1.Text = "Unassign role";
            this.Action1.UseColumnTextForButtonValue = true;
            this.Action1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(adminUI.Role);
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeNotRolesdataGridView);
            this.Controls.Add(this.rolesDataGridView);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNotRolesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rolesDataGridView;
        private System.Windows.Forms.DataGridView employeeNotRolesdataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Action1;
    }
}