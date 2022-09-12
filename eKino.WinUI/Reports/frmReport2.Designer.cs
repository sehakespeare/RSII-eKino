using Microsoft.Reporting.WinForms;

namespace eKino.WinUI.Reports
{
    partial class frmReport2
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
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eKino.WinUI.Reports.Report2.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(26, 20);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 400);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReport2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 457);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReport2";
            this.Text = "Revenue per month";
            this.Load += new System.EventHandler(this.frmReport2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ReportViewer reportViewer1;
    }
}