using Microsoft.Reporting.WinForms;

namespace eKino.WinUI.Reports
{
    partial class frmReport1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieNameTitle = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eKino.WinUI.Reports.Report1.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(26, 41);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie title:";
            // 
            // txtMovieNameTitle
            // 
            this.txtMovieNameTitle.Location = new System.Drawing.Point(101, 11);
            this.txtMovieNameTitle.Name = "txtMovieNameTitle";
            this.txtMovieNameTitle.Size = new System.Drawing.Size(218, 23);
            this.txtMovieNameTitle.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(872, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date range:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(409, 10);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 23);
            this.dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(629, 10);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 23);
            this.dtpTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // frmReport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtMovieNameTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport1";
            this.Text = "Ticket sales per movie";
            this.Load += new System.EventHandler(this.frmReport1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReportViewer reportViewer1;
        private Label label1;
        private TextBox txtMovieNameTitle;
        private Button btnFilter;
        private Label label2;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label3;
    }
}