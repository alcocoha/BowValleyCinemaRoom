namespace BowValleyCinemaRoom
{
    partial class AddMovie
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
            this.btnRegisterMovie = new System.Windows.Forms.Button();
            this.textCopiesInStore = new System.Windows.Forms.TextBox();
            this.labelTotalCopies = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterMovie
            // 
            this.btnRegisterMovie.Location = new System.Drawing.Point(155, 363);
            this.btnRegisterMovie.Name = "btnRegisterMovie";
            this.btnRegisterMovie.Size = new System.Drawing.Size(142, 23);
            this.btnRegisterMovie.TabIndex = 61;
            this.btnRegisterMovie.Text = "Add Movie";
            this.btnRegisterMovie.UseVisualStyleBackColor = true;
            this.btnRegisterMovie.Click += new System.EventHandler(this.btnRegisterMovie_Click);
            // 
            // textCopiesInStore
            // 
            this.textCopiesInStore.Location = new System.Drawing.Point(126, 274);
            this.textCopiesInStore.Name = "textCopiesInStore";
            this.textCopiesInStore.Size = new System.Drawing.Size(171, 23);
            this.textCopiesInStore.TabIndex = 60;
            // 
            // labelTotalCopies
            // 
            this.labelTotalCopies.AutoSize = true;
            this.labelTotalCopies.Location = new System.Drawing.Point(16, 277);
            this.labelTotalCopies.Name = "labelTotalCopies";
            this.labelTotalCopies.Size = new System.Drawing.Size(86, 15);
            this.labelTotalCopies.TabIndex = 59;
            this.labelTotalCopies.Text = "Copies in Store";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(126, 233);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(171, 23);
            this.textYear.TabIndex = 58;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(73, 236);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 15);
            this.labelYear.TabIndex = 57;
            this.labelYear.Text = "Year";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(47, 193);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 15);
            this.labelCategory.TabIndex = 55;
            this.labelCategory.Text = "Category";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(126, 66);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(171, 105);
            this.textDescription.TabIndex = 51;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(35, 69);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 50;
            this.labelDescription.Text = "Description";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(126, 23);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(171, 23);
            this.textTitle.TabIndex = 49;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(67, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(29, 15);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "Title";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Action",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Thriller",
            "Western"});
            this.comboBoxCategory.Location = new System.Drawing.Point(126, 190);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(171, 23);
            this.comboBoxCategory.TabIndex = 62;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(126, 317);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(171, 23);
            this.textPrice.TabIndex = 64;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(63, 320);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 63;
            this.labelPrice.Text = "Price";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 422);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnRegisterMovie);
            this.Controls.Add(this.textCopiesInStore);
            this.Controls.Add(this.labelTotalCopies);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegisterMovie;
        private TextBox textCopiesInStore;
        private Label labelTotalCopies;
        private TextBox textYear;
        private Label labelYear;
        private Label labelCategory;
        private TextBox textDescription;
        private Label labelDescription;
        private TextBox textTitle;
        private Label labelTitle;
        private ComboBox comboBoxCategory;
        private TextBox textPrice;
        private Label labelPrice;
    }
}