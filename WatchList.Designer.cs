namespace WatchList
{
    partial class WatchList
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
            this.WatchListLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvWL = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WatchListLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WatchListLogo
            // 
            this.WatchListLogo.BackColor = System.Drawing.Color.MediumPurple;
            this.WatchListLogo.Image = global::WatchList.Properties.Resources.watchlist_icon;
            this.WatchListLogo.Location = new System.Drawing.Point(26, 26);
            this.WatchListLogo.Name = "WatchListLogo";
            this.WatchListLogo.Size = new System.Drawing.Size(251, 218);
            this.WatchListLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WatchListLogo.TabIndex = 0;
            this.WatchListLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(283, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(481, 116);
            this.button1.TabIndex = 1;
            this.button1.Text = "WatchList";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 4;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 11.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(819, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Curiousity Centre";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumPurple;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 11.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1247, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(374, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "Shrine of Patience";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumPurple;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 4;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic", 11.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(1670, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hall of Fame";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvWL
            // 
            this.dgvWL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvWL.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvWL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWL.GridColor = System.Drawing.Color.MediumPurple;
            this.dgvWL.Location = new System.Drawing.Point(505, 416);
            this.dgvWL.Name = "dgvWL";
            this.dgvWL.RowHeadersWidth = 102;
            this.dgvWL.RowTemplate.Height = 49;
            this.dgvWL.Size = new System.Drawing.Size(1433, 674);
            this.dgvWL.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PowderBlue;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(115, 546);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 58);
            this.button5.TabIndex = 6;
            this.button5.Text = "Add New Title";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PowderBlue;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button6.FlatAppearance.BorderSize = 5;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(115, 690);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(235, 58);
            this.button6.TabIndex = 7;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.WatchListLogo);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1979, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button8.FlatAppearance.BorderSize = 5;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(115, 826);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 58);
            this.button8.TabIndex = 10;
            this.button8.Text = "Show All";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(859, 310);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1030, 47);
            this.searchBox.TabIndex = 11;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(731, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search";
            // 
            // WatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1982, 1149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgvWL);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "WatchList";
            this.Text = "WatchList";
            this.Load += new System.EventHandler(this.WatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WatchListLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox WatchListLogo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgvWL;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private Button button8;
        private TextBox searchBox;
        private Label label1;
    }
}