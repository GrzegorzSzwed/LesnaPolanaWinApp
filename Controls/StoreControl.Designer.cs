namespace LesnaPolanaWinApp.Controls
{
    partial class StoreControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreControl));
            this.tblMagazine = new System.Windows.Forms.TableLayoutPanel();
            this.flwMagazineMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnListItems = new System.Windows.Forms.Button();
            this.pnlBasement = new System.Windows.Forms.Panel();
            this.pnlListItems = new System.Windows.Forms.Panel();
            this.tblListDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flwListItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.tblNewItemBasemeent = new System.Windows.Forms.TableLayoutPanel();
            this.tblNewItem = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.tblMagazine.SuspendLayout();
            this.flwMagazineMenu.SuspendLayout();
            this.pnlBasement.SuspendLayout();
            this.pnlListItems.SuspendLayout();
            this.tblListDashboard.SuspendLayout();
            this.pnlAddItem.SuspendLayout();
            this.tblNewItemBasemeent.SuspendLayout();
            this.tblNewItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMagazine
            // 
            this.tblMagazine.BackColor = System.Drawing.Color.White;
            this.tblMagazine.ColumnCount = 2;
            this.tblMagazine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblMagazine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMagazine.Controls.Add(this.flwMagazineMenu, 0, 0);
            this.tblMagazine.Controls.Add(this.pnlBasement, 1, 0);
            this.tblMagazine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMagazine.Location = new System.Drawing.Point(0, 0);
            this.tblMagazine.Margin = new System.Windows.Forms.Padding(0);
            this.tblMagazine.Name = "tblMagazine";
            this.tblMagazine.RowCount = 1;
            this.tblMagazine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMagazine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMagazine.Size = new System.Drawing.Size(834, 552);
            this.tblMagazine.TabIndex = 0;
            // 
            // flwMagazineMenu
            // 
            this.flwMagazineMenu.BackColor = System.Drawing.Color.Teal;
            this.flwMagazineMenu.Controls.Add(this.btnNewItem);
            this.flwMagazineMenu.Controls.Add(this.btnListItems);
            this.flwMagazineMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwMagazineMenu.Location = new System.Drawing.Point(0, 0);
            this.flwMagazineMenu.Margin = new System.Windows.Forms.Padding(0);
            this.flwMagazineMenu.Name = "flwMagazineMenu";
            this.flwMagazineMenu.Size = new System.Drawing.Size(100, 552);
            this.flwMagazineMenu.TabIndex = 0;
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.Teal;
            this.btnNewItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewItem.BackgroundImage")));
            this.btnNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNewItem.FlatAppearance.BorderSize = 0;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Location = new System.Drawing.Point(25, 10);
            this.btnNewItem.Margin = new System.Windows.Forms.Padding(25, 10, 0, 0);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(50, 50);
            this.btnNewItem.TabIndex = 0;
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.BtnNewItem_Click);
            // 
            // btnListItems
            // 
            this.btnListItems.BackColor = System.Drawing.Color.Teal;
            this.btnListItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListItems.BackgroundImage")));
            this.btnListItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListItems.FlatAppearance.BorderSize = 0;
            this.btnListItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListItems.Location = new System.Drawing.Point(25, 70);
            this.btnListItems.Margin = new System.Windows.Forms.Padding(25, 10, 0, 0);
            this.btnListItems.Name = "btnListItems";
            this.btnListItems.Size = new System.Drawing.Size(50, 50);
            this.btnListItems.TabIndex = 1;
            this.btnListItems.UseVisualStyleBackColor = false;
            this.btnListItems.Click += new System.EventHandler(this.BtnListItems_Click);
            // 
            // pnlBasement
            // 
            this.pnlBasement.Controls.Add(this.pnlAddItem);
            this.pnlBasement.Controls.Add(this.pnlListItems);
            this.pnlBasement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBasement.Location = new System.Drawing.Point(100, 0);
            this.pnlBasement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBasement.Name = "pnlBasement";
            this.pnlBasement.Size = new System.Drawing.Size(734, 552);
            this.pnlBasement.TabIndex = 1;
            // 
            // pnlListItems
            // 
            this.pnlListItems.Controls.Add(this.tblListDashboard);
            this.pnlListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListItems.Location = new System.Drawing.Point(0, 0);
            this.pnlListItems.Name = "pnlListItems";
            this.pnlListItems.Size = new System.Drawing.Size(734, 552);
            this.pnlListItems.TabIndex = 1;
            // 
            // tblListDashboard
            // 
            this.tblListDashboard.ColumnCount = 1;
            this.tblListDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblListDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblListDashboard.Controls.Add(this.flwListItems, 0, 1);
            this.tblListDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblListDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblListDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tblListDashboard.Name = "tblListDashboard";
            this.tblListDashboard.RowCount = 2;
            this.tblListDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblListDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblListDashboard.Size = new System.Drawing.Size(734, 552);
            this.tblListDashboard.TabIndex = 0;
            // 
            // flwListItems
            // 
            this.flwListItems.AutoScroll = true;
            this.flwListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwListItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwListItems.Location = new System.Drawing.Point(0, 53);
            this.flwListItems.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flwListItems.Name = "flwListItems";
            this.flwListItems.Size = new System.Drawing.Size(734, 496);
            this.flwListItems.TabIndex = 0;
            this.flwListItems.WrapContents = false;
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.Controls.Add(this.tblNewItemBasemeent);
            this.pnlAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddItem.Location = new System.Drawing.Point(0, 0);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(734, 552);
            this.pnlAddItem.TabIndex = 0;
            // 
            // tblNewItemBasemeent
            // 
            this.tblNewItemBasemeent.ColumnCount = 1;
            this.tblNewItemBasemeent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNewItemBasemeent.Controls.Add(this.tblNewItem, 0, 0);
            this.tblNewItemBasemeent.Controls.Add(this.btnAdd, 0, 1);
            this.tblNewItemBasemeent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNewItemBasemeent.Location = new System.Drawing.Point(0, 0);
            this.tblNewItemBasemeent.Margin = new System.Windows.Forms.Padding(0);
            this.tblNewItemBasemeent.Name = "tblNewItemBasemeent";
            this.tblNewItemBasemeent.RowCount = 2;
            this.tblNewItemBasemeent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNewItemBasemeent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblNewItemBasemeent.Size = new System.Drawing.Size(734, 552);
            this.tblNewItemBasemeent.TabIndex = 1;
            // 
            // tblNewItem
            // 
            this.tblNewItem.ColumnCount = 2;
            this.tblNewItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNewItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNewItem.Controls.Add(this.txtAmount, 1, 2);
            this.tblNewItem.Controls.Add(this.txtName, 1, 0);
            this.tblNewItem.Controls.Add(this.lblName, 0, 0);
            this.tblNewItem.Controls.Add(this.lblUnit, 0, 1);
            this.tblNewItem.Controls.Add(this.lblAmount, 0, 2);
            this.tblNewItem.Controls.Add(this.cmbShop, 0, 3);
            this.tblNewItem.Controls.Add(this.txtPrize, 1, 3);
            this.tblNewItem.Controls.Add(this.cmbUnit, 1, 1);
            this.tblNewItem.Controls.Add(this.label1, 0, 4);
            this.tblNewItem.Controls.Add(this.txtCategory, 1, 4);
            this.tblNewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNewItem.Location = new System.Drawing.Point(0, 0);
            this.tblNewItem.Margin = new System.Windows.Forms.Padding(0);
            this.tblNewItem.Name = "tblNewItem";
            this.tblNewItem.RowCount = 6;
            this.tblNewItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblNewItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblNewItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblNewItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblNewItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblNewItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblNewItem.Size = new System.Drawing.Size(734, 512);
            this.tblNewItem.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAmount.Location = new System.Drawing.Point(370, 113);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(294, 23);
            this.txtAmount.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(370, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 23);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(292, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nazwa";
            // 
            // lblUnit
            // 
            this.lblUnit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnit.Location = new System.Drawing.Point(261, 62);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(103, 25);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Jednostka";
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAmount.Location = new System.Drawing.Point(312, 112);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 25);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Ilość";
            // 
            // cmbShop
            // 
            this.cmbShop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Items.AddRange(new object[] {
            "Biedronka",
            "Lidl",
            "Kaufland",
            "Makro",
            "Aldi"});
            this.cmbShop.Location = new System.Drawing.Point(160, 158);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(204, 33);
            this.cmbShop.TabIndex = 3;
            this.cmbShop.SelectedIndexChanged += new System.EventHandler(this.CmbShop_SelectedIndexChanged);
            // 
            // txtPrize
            // 
            this.txtPrize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrize.Location = new System.Drawing.Point(370, 163);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(294, 23);
            this.txtPrize.TabIndex = 4;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "kg",
            "g",
            "L",
            "sztuk"});
            this.cmbUnit.Location = new System.Drawing.Point(370, 58);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(294, 33);
            this.cmbUnit.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 512);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(734, 40);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(268, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kategoria";
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCategory.Location = new System.Drawing.Point(370, 213);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(294, 23);
            this.txtCategory.TabIndex = 10;
            // 
            // StoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblMagazine);
            this.Name = "StoreControl";
            this.Size = new System.Drawing.Size(834, 552);
            this.tblMagazine.ResumeLayout(false);
            this.flwMagazineMenu.ResumeLayout(false);
            this.pnlBasement.ResumeLayout(false);
            this.pnlListItems.ResumeLayout(false);
            this.tblListDashboard.ResumeLayout(false);
            this.pnlAddItem.ResumeLayout(false);
            this.tblNewItemBasemeent.ResumeLayout(false);
            this.tblNewItem.ResumeLayout(false);
            this.tblNewItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMagazine;
        private System.Windows.Forms.FlowLayoutPanel flwMagazineMenu;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnListItems;
        private System.Windows.Forms.Panel pnlBasement;
        private System.Windows.Forms.Panel pnlListItems;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.TableLayoutPanel tblNewItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrize;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TableLayoutPanel tblNewItemBasemeent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tblListDashboard;
        private System.Windows.Forms.FlowLayoutPanel flwListItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
    }
}
