namespace QUANLYPHONGMAY
{
    partial class frmHeThong
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchĐăngKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngMáyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiPhòngToolStripMenuItem,
            this.lịchĐăngKýToolStripMenuItem,
            this.phòngMáyToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // loạiPhòngToolStripMenuItem
            // 
            this.loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            this.loạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.loạiPhòngToolStripMenuItem.Text = "Loại Phòng";
            // 
            // lịchĐăngKýToolStripMenuItem
            // 
            this.lịchĐăngKýToolStripMenuItem.Name = "lịchĐăngKýToolStripMenuItem";
            this.lịchĐăngKýToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.lịchĐăngKýToolStripMenuItem.Text = "Lịch Đăng Ký";
            this.lịchĐăngKýToolStripMenuItem.Click += new System.EventHandler(this.lịchĐăngKýToolStripMenuItem_Click);
            // 
            // phòngMáyToolStripMenuItem
            // 
            this.phòngMáyToolStripMenuItem.Name = "phòngMáyToolStripMenuItem";
            this.phòngMáyToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.phòngMáyToolStripMenuItem.Text = "Phòng Máy";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo- Thống kê";
            this.báoCáoThốngKêToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThốngKêToolStripMenuItem_Click);
            // 
            // frmHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 543);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHeThong";
            this.Text = "frmHeThong";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchĐăngKýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngMáyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
    }
}