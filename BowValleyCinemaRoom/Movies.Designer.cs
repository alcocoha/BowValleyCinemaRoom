namespace BowValleyCinemaRoom
{
    partial class Movies
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
            this.dgMovies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textMovie = new System.Windows.Forms.TextBox();
            this.btnSearchAMovie = new System.Windows.Forms.Button();
            this.listMovies = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listPrices = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTotalMovies = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMovies
            // 
            this.dgMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovies.Location = new System.Drawing.Point(12, 116);
            this.dgMovies.Name = "dgMovies";
            this.dgMovies.RowTemplate.Height = 25;
            this.dgMovies.Size = new System.Drawing.Size(460, 304);
            this.dgMovies.TabIndex = 0;
            this.dgMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovies_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your favorite movie";
            // 
            // textMovie
            // 
            this.textMovie.Location = new System.Drawing.Point(12, 72);
            this.textMovie.Name = "textMovie";
            this.textMovie.Size = new System.Drawing.Size(208, 23);
            this.textMovie.TabIndex = 2;
            // 
            // btnSearchAMovie
            // 
            this.btnSearchAMovie.Location = new System.Drawing.Point(229, 72);
            this.btnSearchAMovie.Name = "btnSearchAMovie";
            this.btnSearchAMovie.Size = new System.Drawing.Size(115, 23);
            this.btnSearchAMovie.TabIndex = 3;
            this.btnSearchAMovie.Text = "Search a movie";
            this.btnSearchAMovie.UseVisualStyleBackColor = true;
            this.btnSearchAMovie.Click += new System.EventHandler(this.btnSearchAMovie_Click);
            // 
            // listMovies
            // 
            this.listMovies.FormattingEnabled = true;
            this.listMovies.ItemHeight = 15;
            this.listMovies.Location = new System.Drawing.Point(489, 116);
            this.listMovies.Name = "listMovies";
            this.listMovies.Size = new System.Drawing.Size(176, 169);
            this.listMovies.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movies Selected";
            // 
            // listPrices
            // 
            this.listPrices.FormattingEnabled = true;
            this.listPrices.ItemHeight = 15;
            this.listPrices.Location = new System.Drawing.Point(671, 116);
            this.listPrices.Name = "listPrices";
            this.listPrices.Size = new System.Drawing.Size(66, 169);
            this.listPrices.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotalMovies
            // 
            this.labelTotalMovies.AutoSize = true;
            this.labelTotalMovies.Location = new System.Drawing.Point(489, 297);
            this.labelTotalMovies.Name = "labelTotalMovies";
            this.labelTotalMovies.Size = new System.Drawing.Size(127, 15);
            this.labelTotalMovies.TabIndex = 8;
            this.labelTotalMovies.Text = "Total movies to rent : 0";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(687, 297);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalPrice.Size = new System.Drawing.Size(44, 15);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "0.0 cad";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRent.Location = new System.Drawing.Point(489, 370);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(248, 50);
            this.btnRent.TabIndex = 10;
            this.btnRent.Text = "Rent Movies";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(662, 332);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset list";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button3_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 477);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelTotalMovies);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listPrices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listMovies);
            this.Controls.Add(this.btnSearchAMovie);
            this.Controls.Add(this.textMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMovies);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgMovies;
        private Label label1;
        private TextBox textMovie;
        private Button btnSearchAMovie;
        private ListBox listMovies;
        private Label label2;
        private ListBox listPrices;
        private Button button1;
        private Label labelTotalMovies;
        private Label labelTotalPrice;
        private Button btnRent;
        private Button btnReset;
    }
}