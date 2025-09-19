namespace AppDesktop_FORMNETCORE_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDatos = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnAge = new DataGridViewTextBoxColumn();
            btnGetAll = new Button();
            btnGetById = new Button();
            txtID = new TextBox();
            label1 = new Label();
            btnPost = new Button();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnName, ColumnAge });
            dgvDatos.Location = new Point(12, 12);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(342, 150);
            dgvDatos.TabIndex = 0;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnAge
            // 
            ColumnAge.HeaderText = "Age";
            ColumnAge.Name = "ColumnAge";
            ColumnAge.ReadOnly = true;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(360, 12);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(75, 35);
            btnGetAll.TabIndex = 1;
            btnGetAll.Text = "GetAll";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnGetById
            // 
            btnGetById.Location = new Point(360, 53);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(75, 35);
            btnGetById.TabIndex = 2;
            btnGetById.Text = "GetById";
            btnGetById.UseVisualStyleBackColor = true;
            btnGetById.Click += btnGetById_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(36, 184);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 187);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // btnPost
            // 
            btnPost.Location = new Point(360, 94);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(75, 35);
            btnPost.TabIndex = 5;
            btnPost.Text = "Post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 171);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(223, 168);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 200);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(223, 197);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(360, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(360, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 231);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(btnPost);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnGetById);
            Controls.Add(btnGetAll);
            Controls.Add(dgvDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAge;
        private Button btnGetAll;
        private Button btnGetById;
        private TextBox txtID;
        private Label label1;
        private Button btnPost;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtAge;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
