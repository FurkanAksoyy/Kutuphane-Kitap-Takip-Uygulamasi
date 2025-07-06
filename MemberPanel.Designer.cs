namespace Kütüphane_Kitap_Takip_Uygulaması
{
    partial class MemberPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DataGridView dgvMyReservations;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.dgvMyReservations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 22);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 26);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(20, 60);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(600, 250);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(530, 320);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(90, 30);
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // dgvMyReservations
            // 
            this.dgvMyReservations.AllowUserToAddRows = false;
            this.dgvMyReservations.AllowUserToDeleteRows = false;
            this.dgvMyReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyReservations.Location = new System.Drawing.Point(20, 370);
            this.dgvMyReservations.Name = "dgvMyReservations";
            this.dgvMyReservations.ReadOnly = true;
            this.dgvMyReservations.Size = new System.Drawing.Size(600, 200);
            this.dgvMyReservations.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvMyReservations_RowPrePaint);
            // 
            // MemberPanel
            // 
            this.ClientSize = new System.Drawing.Size(650, 600);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dgvMyReservations);
            this.Name = "MemberPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Panel";
            this.Load += new System.EventHandler(this.MemberPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
