namespace eKino.WinUI
{
    partial class frmProjectionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProjections = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbAuditorium = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.labelHint2 = new System.Windows.Forms.Label();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditorium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfProjection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjections
            // 
            this.dgvProjections.AllowUserToAddRows = false;
            this.dgvProjections.AllowUserToDeleteRows = false;
            this.dgvProjections.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjections.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movie,
            this.Auditorium,
            this.DateOfProjection,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjections.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjections.Location = new System.Drawing.Point(10, 84);
            this.dgvProjections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProjections.MultiSelect = false;
            this.dgvProjections.Name = "dgvProjections";
            this.dgvProjections.ReadOnly = true;
            this.dgvProjections.RowHeadersWidth = 51;
            this.dgvProjections.RowTemplate.Height = 40;
            this.dgvProjections.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjections.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjections.Size = new System.Drawing.Size(709, 236);
            this.dgvProjections.TabIndex = 0;
            this.dgvProjections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjections_CellContentClick);
            this.dgvProjections.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjections_CellDoubleClick);
            this.dgvProjections.Enter += new System.EventHandler(this.dgvProjections_Enter);
            this.dgvProjections.Leave += new System.EventHandler(this.dgvProjections_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(637, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movie";
            // 
            // btnPage
            // 
            this.btnPage.Location = new System.Drawing.Point(323, 328);
            this.btnPage.Name = "btnPage";
            this.btnPage.Size = new System.Drawing.Size(75, 23);
            this.btnPage.TabIndex = 7;
            this.btnPage.Text = "Page 1";
            this.btnPage.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(404, 328);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(283, 329);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(34, 23);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(10, 328);
            this.btnCreateNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(82, 22);
            this.btnCreateNew.TabIndex = 5;
            this.btnCreateNew.Text = "Create new";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Auditorium";
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(18, 33);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(246, 23);
            this.cmbMovie.TabIndex = 3;
            this.cmbMovie.SelectedIndexChanged += new System.EventHandler(this.cmbDirector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date of projection";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbAuditorium
            // 
            this.cmbAuditorium.FormattingEnabled = true;
            this.cmbAuditorium.Location = new System.Drawing.Point(270, 32);
            this.cmbAuditorium.Name = "cmbAuditorium";
            this.cmbAuditorium.Size = new System.Drawing.Size(246, 23);
            this.cmbAuditorium.TabIndex = 17;
            this.cmbAuditorium.SelectedIndexChanged += new System.EventHandler(this.cmbAuditorium_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(519, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(112, 23);
            this.dtpDate.TabIndex = 18;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // labelHint2
            // 
            this.labelHint2.AutoSize = true;
            this.labelHint2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHint2.Location = new System.Drawing.Point(21, 61);
            this.labelHint2.Name = "labelHint2";
            this.labelHint2.Size = new System.Drawing.Size(222, 15);
            this.labelHint2.TabIndex = 7;
            this.labelHint2.Text = "Hint: Double-click a row to begin editing";
            this.labelHint2.Visible = false;
            // 
            // Movie
            // 
            this.Movie.DataPropertyName = "Movie";
            this.Movie.HeaderText = "Movie";
            this.Movie.MinimumWidth = 6;
            this.Movie.Name = "Movie";
            this.Movie.ReadOnly = true;
            this.Movie.Width = 300;
            // 
            // Auditorium
            // 
            this.Auditorium.DataPropertyName = "Auditorium";
            this.Auditorium.HeaderText = "Auditorium";
            this.Auditorium.Name = "Auditorium";
            this.Auditorium.ReadOnly = true;
            // 
            // DateOfProjection
            // 
            this.DateOfProjection.DataPropertyName = "DateOfProjection";
            this.DateOfProjection.HeaderText = "Date of projection";
            this.DateOfProjection.Name = "DateOfProjection";
            this.DateOfProjection.ReadOnly = true;
            this.DateOfProjection.Width = 135;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // frmProjectionList
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 358);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbAuditorium);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPage);
            this.Controls.Add(this.labelHint2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProjections);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProjectionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projection List";
            this.Load += new System.EventHandler(this.frmProjection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProjections;
        private Button btnSearch;
        private Label label1;
        private Button btnPage;
        private Button btnNext;
        private Button btnPrev;
        private Button btnCreateNew;
        private Label label2;
        private ComboBox cmbMovie;
        private Label label3;
        private ErrorProvider errorProvider1;
        private ComboBox cmbAuditorium;
        private DateTimePicker dtpDate;
        private Label labelHint2;
        private DataGridViewTextBoxColumn Movie;
        private DataGridViewTextBoxColumn Auditorium;
        private DataGridViewTextBoxColumn DateOfProjection;
        private DataGridViewButtonColumn Delete;
    }
}