namespace BowValleyCinemaRoom
{
    partial class RegistersList
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
            this.dgRegisters = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.radioFirstName = new System.Windows.Forms.RadioButton();
            this.radioLastName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegisters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRegisters
            // 
            this.dgRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegisters.Location = new System.Drawing.Point(12, 78);
            this.dgRegisters.Name = "dgRegisters";
            this.dgRegisters.RowTemplate.Height = 25;
            this.dgRegisters.Size = new System.Drawing.Size(776, 360);
            this.dgRegisters.TabIndex = 0;
            this.dgRegisters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRegisters_CellContentClick);
            this.dgRegisters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRegisters_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // textFilter
            // 
            this.textFilter.Location = new System.Drawing.Point(12, 43);
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(209, 23);
            this.textFilter.TabIndex = 2;
            this.textFilter.TextChanged += new System.EventHandler(this.filter);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(239, 43);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 4;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(632, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search by: ";
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Location = new System.Drawing.Point(92, 17);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(35, 19);
            this.radioId.TabIndex = 8;
            this.radioId.TabStop = true;
            this.radioId.Text = "Id";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // radioFirstName
            // 
            this.radioFirstName.AutoSize = true;
            this.radioFirstName.Location = new System.Drawing.Point(145, 17);
            this.radioFirstName.Name = "radioFirstName";
            this.radioFirstName.Size = new System.Drawing.Size(79, 19);
            this.radioFirstName.TabIndex = 9;
            this.radioFirstName.TabStop = true;
            this.radioFirstName.Text = "FirstName";
            this.radioFirstName.UseVisualStyleBackColor = true;
            // 
            // radioLastName
            // 
            this.radioLastName.AutoSize = true;
            this.radioLastName.Location = new System.Drawing.Point(239, 18);
            this.radioLastName.Name = "radioLastName";
            this.radioLastName.Size = new System.Drawing.Size(78, 19);
            this.radioLastName.TabIndex = 10;
            this.radioLastName.TabStop = true;
            this.radioLastName.Text = "LastName";
            this.radioLastName.UseVisualStyleBackColor = true;
            // 
            // RegistersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioLastName);
            this.Controls.Add(this.radioFirstName);
            this.Controls.Add(this.radioId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRegisters);
            this.Name = "RegistersList";
            this.Text = "Registers List";
            this.Load += new System.EventHandler(this.RegistersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegisters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgRegisters;
        private Label label1;
        private TextBox textFilter;
        private Button btnClean;
        private Button btnEdit;
        private Button btnDelete;
        private Label label2;
        private RadioButton radioId;
        private RadioButton radioFirstName;
        private RadioButton radioLastName;
    }
}