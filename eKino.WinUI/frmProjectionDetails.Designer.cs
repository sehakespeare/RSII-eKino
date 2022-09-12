namespace eKino.WinUI
{
    partial class frmProjectionDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAuditorium = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.numTicketPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 181);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numTicketPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAuditorium);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMovie);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(382, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic information";
            // 
            // cmbAuditorium
            // 
            this.cmbAuditorium.FormattingEnabled = true;
            this.cmbAuditorium.Location = new System.Drawing.Point(129, 54);
            this.cmbAuditorium.Name = "cmbAuditorium";
            this.cmbAuditorium.Size = new System.Drawing.Size(239, 23);
            this.cmbAuditorium.TabIndex = 2;
            this.cmbAuditorium.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAuditorium_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Auditorium:";
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(129, 25);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(239, 23);
            this.cmbMovie.TabIndex = 1;
            this.cmbMovie.Validating += new System.ComponentModel.CancelEventHandler(this.cmbMovie_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Movie:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(129, 83);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.ShowUpDown = true;
            this.dtpDate.Size = new System.Drawing.Size(239, 23);
            this.dtpDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of projection:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ticket price:";
            // 
            // numericUpDown1
            // 
            this.numTicketPrice.DecimalPlaces = 2;
            this.numTicketPrice.Location = new System.Drawing.Point(129, 113);
            this.numTicketPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTicketPrice.Name = "numericUpDown1";
            this.numTicketPrice.Size = new System.Drawing.Size(75, 23);
            this.numTicketPrice.TabIndex = 12;
            // 
            // frmProjectionDetails
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProjectionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projection Details";
            this.Load += new System.EventHandler(this.frmProjectionDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSave;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog1;
        private Label label5;
        private DateTimePicker dtpDate;
        private Label label3;
        private ComboBox cmbMovie;
        private ComboBox cmbAuditorium;
        private Label label1;
        private NumericUpDown numTicketPrice;
        private Label label2;
    }
}