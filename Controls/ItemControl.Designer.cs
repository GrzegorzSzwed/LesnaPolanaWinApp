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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblShop = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlBasement = new System.Windows.Forms.Panel();
            this.tblBasement = new System.Windows.Forms.TableLayoutPanel();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.txtPrize = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tblBasementEdit = new System.Windows.Forms.TableLayoutPanel();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tblName = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tblItemView.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlBasement.SuspendLayout();
            this.tblBasement.SuspendLayout();
            this.tblBasementEdit.SuspendLayout();
            this.tblName.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblItemView
            // 
            this.tblItemView.BackColor = System.Drawing.Color.White;
            this.tblItemView.ColumnCount = 4;
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblItemView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblItemView.Controls.Add(this.lblName, 0, 0);
            this.tblItemView.Controls.Add(this.lblShop, 3, 0);
            this.tblItemView.Controls.Add(this.lblPrize, 2, 0);
            this.tblItemView.Controls.Add(this.lblUnit, 1, 0);
            this.tblItemView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblItemView.Location = new System.Drawing.Point(0, 0);
            this.tblItemView.Margin = new System.Windows.Forms.Padding(0);
            this.tblItemView.Name = "tblItemView";
            this.tblItemView.RowCount = 1;
            this.tblItemView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblItemView.Size = new System.Drawing.Size(500, 50);
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
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(500, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.tblItemView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Margin = new System.Windows.Forms.Padding(0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(500, 50);
            this.pnlView.TabIndex = 1;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.White;
            this.pnlEdit.Controls.Add(this.tblBasementEdit);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(500, 50);
            this.pnlEdit.TabIndex = 2;
            // 
            // pnlBasement
            // 
            this.pnlBasement.Controls.Add(this.pnlEdit);
            this.pnlBasement.Controls.Add(this.pnlView);
            this.pnlBasement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBasement.Location = new System.Drawing.Point(0, 0);
            this.pnlBasement.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBasement.Name = "pnlBasement";
            this.pnlBasement.Size = new System.Drawing.Size(500, 50);
            this.pnlBasement.TabIndex = 3;
            // 
            // tblBasement
            // 
            this.tblBasement.ColumnCount = 2;
            this.tblBasement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBasement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblBasement.Controls.Add(this.pnlBasement, 0, 0);
            this.tblBasement.Controls.Add(this.btnEdit, 1, 0);
            this.tblBasement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBasement.Location = new System.Drawing.Point(0, 0);
            this.tblBasement.Margin = new System.Windows.Forms.Padding(0);
            this.tblBasement.Name = "tblBasement";
            this.tblBasement.RowCount = 1;
            this.tblBasement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBasement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBasement.Size = new System.Drawing.Size(550, 50);
            this.tblBasement.TabIndex = 0;
            // 
            // cmbShop
            // 
            this.cmbShop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Items.AddRange(new object[] {
            "Biedronka",
            "Lidl",
            "Kaufland",
            "Makro",
            "Aldi"});
            this.cmbShop.Location = new System.Drawing.Point(253, 3);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(244, 33);
            this.cmbShop.TabIndex = 4;
            this.cmbShop.SelectedIndexChanged += new System.EventHandler(this.CmbShop_SelectedIndexChanged);
            // 
            // txtPrize
            // 
            this.txtPrize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrize.Location = new System.Drawing.Point(253, 3);
            this.txtPrize.Name = "txtPrize";
            this.txtPrize.Size = new System.Drawing.Size(244, 23);
            this.txtPrize.TabIndex = 5;
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
            this.cmbUnit.Location = new System.Drawing.Point(253, 3);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(244, 33);
            this.cmbUnit.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(3, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(497, 25);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tblBasementEdit
            // 
            this.tblBasementEdit.ColumnCount = 1;
            this.tblBasementEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBasementEdit.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tblBasementEdit.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tblBasementEdit.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tblBasementEdit.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblBasementEdit.Controls.Add(this.btnUpdate, 0, 5);
            this.tblBasementEdit.Controls.Add(this.tblName, 0, 0);
            this.tblBasementEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBasementEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tblBasementEdit.Location = new System.Drawing.Point(0, 0);
            this.tblBasementEdit.Name = "tblBasementEdit";
            this.tblBasementEdit.RowCount = 6;
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblBasementEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBasementEdit.Size = new System.Drawing.Size(500, 50);
            this.tblBasementEdit.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCategory.Location = new System.Drawing.Point(253, 3);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(235, 23);
            this.txtCategory.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(253, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 23);
            this.txtName.TabIndex = 6;
            // 
            // tblName
            // 
            this.tblName.ColumnCount = 2;
            this.tblName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblName.Controls.Add(this.txtName, 1, 0);
            this.tblName.Controls.Add(this.label1, 0, 0);
            this.tblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblName.Location = new System.Drawing.Point(0, 0);
            this.tblName.Margin = new System.Windows.Forms.Padding(0);
            this.tblName.Name = "tblName";
            this.tblName.RowCount = 1;
            this.tblName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblName.Size = new System.Drawing.Size(500, 3);
            this.tblName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 3);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nazwa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbUnit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 4);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 4);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jednostka";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbShop, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 7);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 4);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 4);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sklep";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPrize, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 11);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 4);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 4);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena w wybranych sklepie";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCategory, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 15);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(500, 4);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 4);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kategoria";
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblBasement);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(550, 50);
            this.tblItemView.ResumeLayout(false);
            this.tblItemView.PerformLayout();
            this.pnlView.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlBasement.ResumeLayout(false);
            this.tblBasement.ResumeLayout(false);
            this.tblBasementEdit.ResumeLayout(false);
            this.tblName.ResumeLayout(false);
            this.tblName.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.Panel pnlBasement;
        private System.Windows.Forms.TableLayoutPanel tblBasement;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.TextBox txtPrize;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tblBasementEdit;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}
