namespace Kütüphane_Kitap_Takip_Uygulaması
{
    partial class AdminPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblTotalReservations;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.DataGridView dgvBooksAdmin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblTotalCopies;
        private System.Windows.Forms.TextBox txtTotalCopies;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridView dgvReservationsAdmin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // sayaçlar
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.lblTotalReservations = new System.Windows.Forms.Label();
            // tabControl
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.tabReservations = new System.Windows.Forms.TabPage();
            // Books tab
            this.dgvBooksAdmin = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblTotalCopies = new System.Windows.Forms.Label();
            this.txtTotalCopies = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            // Members tab
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            // Reservations tab
            this.dgvReservationsAdmin = new System.Windows.Forms.DataGridView();

            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Location = new System.Drawing.Point(10, 10);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(100, 23);
            this.lblTotalBooks.Text = "Books: 0";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Location = new System.Drawing.Point(130, 10);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(120, 23);
            this.lblTotalMembers.Text = "Members: 0";
            // 
            // lblTotalReservations
            // 
            this.lblTotalReservations.AutoSize = true;
            this.lblTotalReservations.Location = new System.Drawing.Point(270, 10);
            this.lblTotalReservations.Name = "lblTotalReservations";
            this.lblTotalReservations.Size = new System.Drawing.Size(140, 23);
            this.lblTotalReservations.Text = "Reservations: 0";

            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabBooks);
            this.tabControlAdmin.Controls.Add(this.tabMembers);
            this.tabControlAdmin.Controls.Add(this.tabReservations);
            this.tabControlAdmin.Location = new System.Drawing.Point(10, 40);
            this.tabControlAdmin.Size = new System.Drawing.Size(880, 580);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dgvBooksAdmin);
            this.tabBooks.Controls.Add(this.lblTitle);
            this.tabBooks.Controls.Add(this.txtTitle);
            this.tabBooks.Controls.Add(this.lblAuthor);
            this.tabBooks.Controls.Add(this.txtAuthor);
            this.tabBooks.Controls.Add(this.lblISBN);
            this.tabBooks.Controls.Add(this.txtISBN);
            this.tabBooks.Controls.Add(this.lblTotalCopies);
            this.tabBooks.Controls.Add(this.txtTotalCopies);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Controls.Add(this.btnUpdateBook);
            this.tabBooks.Controls.Add(this.btnDeleteBook);
            this.tabBooks.Text = "Books";
            // 
            // dgvBooksAdmin
            // 
            this.dgvBooksAdmin.Location = new System.Drawing.Point(10, 10);
            this.dgvBooksAdmin.Size = new System.Drawing.Size(600, 450);
            this.dgvBooksAdmin.ReadOnly = true;
            this.dgvBooksAdmin.MultiSelect = false;
            this.dgvBooksAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooksAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksAdmin.SelectionChanged += new System.EventHandler(this.dgvBooksAdmin_SelectionChanged);
            // 
            // lblTitle / txtTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(630, 20);
            this.lblTitle.Text = "Title:";
            this.txtTitle.Location = new System.Drawing.Point(630, 40);
            this.txtTitle.Size = new System.Drawing.Size(220, 22);
            // 
            // lblAuthor / txtAuthor
            this.lblAuthor.Location = new System.Drawing.Point(630, 80);
            this.lblAuthor.Text = "Author:";
            this.txtAuthor.Location = new System.Drawing.Point(630, 100);
            this.txtAuthor.Size = new System.Drawing.Size(220, 22);
            // 
            // lblISBN / txtISBN
            this.lblISBN.Location = new System.Drawing.Point(630, 140);
            this.lblISBN.Text = "ISBN:";
            this.txtISBN.Location = new System.Drawing.Point(630, 160);
            this.txtISBN.Size = new System.Drawing.Size(220, 22);
            // 
            // lblTotalCopies / txtTotalCopies
            this.lblTotalCopies.Location = new System.Drawing.Point(630, 200);
            this.lblTotalCopies.Text = "Total Copies:";
            this.txtTotalCopies.Location = new System.Drawing.Point(630, 220);
            this.txtTotalCopies.Size = new System.Drawing.Size(220, 22);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(630, 260);
            this.btnAddBook.Size = new System.Drawing.Size(100, 30);
            this.btnAddBook.Text = "Add";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(750, 260);
            this.btnUpdateBook.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(630, 300);
            this.btnDeleteBook.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);

            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.dgvMembers);
            this.tabMembers.Text = "Members";
            this.dgvMembers.Location = new System.Drawing.Point(10, 10);
            this.dgvMembers.Size = new System.Drawing.Size(840, 500);
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.dgvReservationsAdmin);
            this.tabReservations.Text = "Reservations";
            this.dgvReservationsAdmin.Location = new System.Drawing.Point(10, 10);
            this.dgvReservationsAdmin.Size = new System.Drawing.Size(840, 500);
            this.dgvReservationsAdmin.ReadOnly = true;
            this.dgvReservationsAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // AdminPanel
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblTotalBooks);
            this.Controls.Add(this.lblTotalMembers);
            this.Controls.Add(this.lblTotalReservations);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationsAdmin)).EndInit();
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            this.tabMembers.ResumeLayout(false);
            this.tabReservations.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
