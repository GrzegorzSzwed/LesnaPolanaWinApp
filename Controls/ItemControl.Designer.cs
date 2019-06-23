namespace LesnaPolanaWinApp.Controls
{
    partial class ItemControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemControl));
            this.tblItemView = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.tblItemView.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblItemView
            // 
            this.tblItemView.BackColor = System.Drawing.Color.White;
            this.tblItemView.ColumnCount = 5;
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblItemView.Controls.Add(this.lblName, 0, 0);
            this.tblItemView.Controls.Add(this.btnEdit, 4, 0);
            this.tblItemView.Controls.Add(this.lblShop, 3, 0);
            this.tblItemView.Controls.Add(this.lblPrize, 2, 0);
            this.tblItemView.Controls.Add(this.lblUnit, 1, 0);
            this.tblItemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblItemView.Location = new System.Drawing.Point(0, 0);
            this.tblItemView.Margin = new System.Windows.Forms.Padding(0);
            this.tblItemView.Name = "tblItemView";
            this.tblItemView.RowCount = 1;
            this.tblItemView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblItemView.Size = new System.Drawing.Size(550, 50);
            this.tblItemView.TabIndex = 0;
            this.tblItemView.MouseEnter += new System.EventHandler(this.TblItemView_MouseEnter);
            this.tblItemView.MouseLeave += new System.EventHandler(this.TblItemView_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(64, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa";
            // 
            // lblPrize
            // 
            this.lblPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrize.Location = new System.Drawing.Point(280, 12);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(60, 25);
            this.lblPrize.TabIndex = 1;
            this.lblPrize.Text = "Cena";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(500, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnit.Location = new System.Drawing.Point(207, 12);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(46, 25);
            this.lblUnit.TabIndex = 4;
            this.lblUnit.Text = "Unit";
            // 
            // lblShop
            // 
            this.lblShop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShop.AutoSize = true;
            this.lblShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShop.Location = new System.Drawing.Point(399, 12);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(62, 25);
            this.lblShop.TabIndex = 5;
            this.lblShop.Text = "Sklep";
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.tblItemView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(550, 50);
            this.pnlView.TabIndex = 1;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(550, 50);
            this.pnlEdit.TabIndex = 2;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlView);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(550, 50);
            this.tblItemView.ResumeLayout(false);
            this.tblItemView.PerformLayout();
            this.pnlView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblItemView;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlEdit;
    }
}
