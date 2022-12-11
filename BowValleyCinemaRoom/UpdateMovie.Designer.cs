namespace BowValleyCinemaRoom
{
    partial class UpdateMovie
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
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.textCopiesInStore = new System.Windows.Forms.TextBox();
            this.labelTotalCopies = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(110, 313);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(171, 23);
            this.textPrice.TabIndex = 77;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(47, 316);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 76;
            this.labelPrice.Text = "Price";
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
            this.comboBoxCategory.Location = new System.Drawing.Point(110, 186);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(171, 23);
            this.comboBoxCategory.TabIndex = 75;
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(139, 359);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(142, 23);
            this.btnUpdateMovie.TabIndex = 74;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // textCopiesInStore
            // 
            this.textCopiesInStore.Location = new System.Drawing.Point(110, 270);
            this.textCopiesInStore.Name = "textCopiesInStore";
            this.textCopiesInStore.Size = new System.Drawing.Size(171, 23);
            this.textCopiesInStore.TabIndex = 73;
            // 
            // labelTotalCopies
            // 
            this.labelTotalCopies.AutoSize = true;
            this.labelTotalCopies.Location = new System.Drawing.Point(0, 273);
            this.labelTotalCopies.Name = "labelTotalCopies";
            this.labelTotalCopies.Size = new System.Drawing.Size(86, 15);
            this.labelTotalCopies.TabIndex = 72;
            this.labelTotalCopies.Text = "Copies in Store";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(110, 229);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(171, 23);
            this.textYear.TabIndex = 71;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(57, 232);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 15);
            this.labelYear.TabIndex = 70;
            this.labelYear.Text = "Year";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(31, 189);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 15);
            this.labelCategory.TabIndex = 69;
            this.labelCategory.Text = "Category";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(110, 62);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(171, 105);
            this.textDescription.TabIndex = 68;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(19, 65);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 67;
            this.labelDescription.Text = "Description";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(110, 19);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(171, 23);
            this.textTitle.TabIndex = 66;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(51, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(29, 15);
            this.labelTitle.TabIndex = 65;
            this.labelTitle.Text = "Title";
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 420);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.textCopiesInStore);
            this.Controls.Add(this.labelTotalCopies);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTitle);
            this.Name = "UpdateMovie";
            this.Text = "UpdateMovie";
            this.Load += new System.EventHandler(this.UpdateMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textPrice;
        private Label labelPrice;
        private ComboBox comboBoxCategory;
        private Button btnUpdateMovie;
        private TextBox textCopiesInStore;
        private Label labelTotalCopies;
        private TextBox textYear;
        private Label labelYear;
        private Label labelCategory;
        private TextBox textDescription;
        private Label labelDescription;
        private TextBox textTitle;
        private Label labelTitle;
    }
}