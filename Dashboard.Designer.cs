namespace LesnaPolanaWinApp
{
    partial class DashboardForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.flwMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.tblDashboard.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.flwMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.BackColor = System.Drawing.Color.White;
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.pnlTop, 0, 0);
            this.tblDashboard.Controls.Add(this.flwMenu, 0, 1);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Size = new System.Drawing.Size(1000, 800);
            this.tblDashboard.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 50);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDoubleClick);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(956, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // flwMenu
            // 
            this.flwMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.flwMenu.Controls.Add(this.btnUsers);
            this.flwMenu.Controls.Add(this.btnServices);
            this.flwMenu.Controls.Add(this.btnMagazine);
            this.flwMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flwMenu.Location = new System.Drawing.Point(0, 50);
            this.flwMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flwMenu.Name = "flwMenu";
            this.flwMenu.Size = new System.Drawing.Size(1000, 50);
            this.flwMenu.TabIndex = 1;
            this.flwMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.FlwMenu_Paint);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(942, 2);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2, 2, 10, 10);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(48, 48);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnServices
            // 
            this.btnServices.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnServices.BackColor = System.Drawing.Color.Transparent;
            this.btnServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServices.BackgroundImage")));
            this.btnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Location = new System.Drawing.Point(882, 2);
            this.btnServices.Margin = new System.Windows.Forms.Padding(2, 2, 10, 10);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(48, 48);
            this.btnServices.TabIndex = 6;
            this.btnServices.UseVisualStyleBackColor = false;
            // 
            // btnMagazine
            // 
            this.btnMagazine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMagazine.BackColor = System.Drawing.Color.Transparent;
            this.btnMagazine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMagazine.BackgroundImage")));
            this.btnMagazine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMagazine.FlatAppearance.BorderSize = 0;
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazine.Location = new System.Drawing.Point(822, 2);
            this.btnMagazine.Margin = new System.Windows.Forms.Padding(2, 2, 10, 10);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(48, 48);
            this.btnMagazine.TabIndex = 8;
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.BtnMagazine_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.tblDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lesna Polana Windows Application";
            this.tblDashboard.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.flwMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel flwMenu;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnMagazine;
    }
}

