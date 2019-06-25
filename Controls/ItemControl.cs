using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LesnaPolanaWinApp.Controls;
using LesnaPolanaWinApp.Classess;
using MongoDB;
using MongoDB.Driver;

namespace LesnaPolanaWinApp.Controls
{
    public partial class ItemControl : UserControl
    {
        private bool _editable;
        private string _itemName;
        private string _unit;
        private string _category;
        private double _prize;
        private string _shop;
        private Color _backgroundColor;
        private List<Panel> pnls;
        private Item item;
        private string lastShop;
        public ItemControl(Item item)
        {
            InitializeComponent();
            this.item = item;
            this.ItemName = item.Name;
            this.Unit = item.Unit;
            this.Category = item.Category;
            if (item.Shops.Count != 0)
            {
                double prize = item.Shops.Values.Min();
                foreach (var shop in item.Shops)
                    if (shop.Value == prize)
                        this.Shop = shop.Key;

                this.Prize = prize;
            }
            _editable = false;
            pnls = new List<Panel>();
            pnls.Add(pnlView);
            pnls.Add(pnlEdit);
            pnls[0].BringToFront();
        }
        #region Attributes
        public bool Edit
        {
            get { return _editable; }
            set
            {
                _editable = value;
                if (_editable)
                {
                    pnls[1].BringToFront();
                    btnEdit.BackColor = Color.Silver;
                    txtName.Text = item.Name;
                    this.Height = 250;
                }
                else
                {
                    pnls[0].BringToFront();
                    btnEdit.BackColor = Color.Teal;
                    this.Height = 50;
                }

            }
        }
        public string Category
        {
            get { return _category; }
            set
            {
                if(value!=null)
                {
                    _category = value;
                    txtCategory.Text = value.ToString();
                }
                else
                {
                    _category = string.Empty;
                    txtCategory.Text = string.Empty;
                }
            }
        }
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; tblItemView.BackColor = value; }
        }
        public double Prize
        {
            get { return _prize; }
            set { _prize = value; lblPrize.Text = value.ToString(); }
        }
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; lblUnit.Text = value; }
        }
        public string Shop
        {
            get { return _shop; }
            set { _shop = value; lblShop.Text = value; }
        }
        public string  ItemName
        {
            get { return _itemName; }
            set { _itemName = value; lblName.Text = value; }
        }
        #endregion
        #region Events
        private void TblItemView_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.LightGray;
        }
        private void TblItemView_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.White;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.Edit ^= true;
        }
        private void QuickSort(double[] A, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(A, p, r);
                QuickSort(A, p, q);
                QuickSort(A, q+1, r);
            }
        }
        private int Partition(double[] A, int p, int r)
        {
            double x = A[p];
            int i = p - 1;
            int j = r + 1;

            while(true)
            {
                do
                {
                    j--;
                } while (A[j] <= x);
                do
                {
                    i++;
                } while (A[i] >= x);
                if (i < j)
                {
                    double memory = A[i];
                    A[i] = A[j];
                    A[j] = memory;
                }
                else
                    return j;
            }
        }
        #endregion

        private void CmbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            double currentPrize;
            double lastPrize;
            if (cmbShop.Text != string.Empty)
            {
                string currentShop = cmbShop.Text;
                if (txtPrize.Text != string.Empty)
                {
                    double prize = Convert.ToDouble(txtPrize.Text);
                    //check if currentshop exists in dictionary and gets initiliazed value
                    if (item.Shops.TryGetValue(currentShop, out currentPrize))
                        txtPrize.Text = currentPrize.ToString();
                    else
                        txtPrize.Text = string.Empty;

                    //check if lastshop exists with value in dictionary to not to get it into dictionary
                    if (item.Shops.TryGetValue(lastShop, out lastPrize))
                    {
                        if (lastPrize != prize)
                            item.Shops[lastShop] = prize;
                    }
                    else
                        item.Shops.Add(lastShop, prize);

                    lastShop = cmbShop.Text.ToString();
                }
                else
                {
                    if (item.Shops.TryGetValue(currentShop, out currentPrize))
                        txtPrize.Text = currentPrize.ToString();
                    else
                        txtPrize.Text = string.Empty;

                    lastShop = cmbShop.Text.ToString();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            item.Name = txtName.Text.ToString();
            item.Category = txtCategory.Text.ToString();
            if (cmbUnit.Text != string.Empty)
                item.Unit = cmbUnit.Text.ToString();

            try
            {
                StoreControl.Instance.MongoCRUD.UpdateRecord<Item>("Items", item.id, item);
                this.ItemName = item.Name;
                this.Unit = item.Unit;
                if (item.Shops.Count != 0)
                {
                    double prize = item.Shops.Values.Min();
                    foreach (var shop in item.Shops)
                        if (shop.Value == prize)
                            this.Shop = shop.Key;

                    this.Prize = prize;
                }
            }
            catch(MongoException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
