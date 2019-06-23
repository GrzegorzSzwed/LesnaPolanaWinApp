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

namespace LesnaPolanaWinApp.Controls
{
    public partial class ItemControl : UserControl
    {
        private bool _editable;
        private string _itemName;
        private string _unit;
        private double _prize;
        private string _shop;
        private Color _backgroundColor;
        private List<Panel> pnls;
        public ItemControl()
        {
            InitializeComponent();
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
                    pnls[1].BringToFront();
                else
                    pnls[0].BringToFront();
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

        #endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int index = StoreControl.Instance.ListItems.Controls.IndexOf(this) + 1;
            StoreControl.Instance.ListItems.Controls.Clear();
            List<Item> items = new List<Item>();
            items = StoreControl.Instance.MongoCRUD.LoadRecords<Item>("Items");
            var item = items[index];
            Item editItem = item;
            items.Insert(index, editItem);

            ItemControl[] cntrls = new ItemControl[items.Count];
            int inc = 0;
            foreach (var cntrl in items)
            {
                cntrls[inc] = new ItemControl();
                cntrls[inc] = ParseToControl(cntrl, cntrls[inc]);
                cntrls[inc++].Width = StoreControl.Instance.ListItems.Width - 30;
            }
            cntrls[index].Edit = true;
            StoreControl.Instance.ListItems.Controls.AddRange(cntrls);
        }

        private ItemControl ParseToControl(Item item, ItemControl itemControl)
        {
            itemControl.ItemName = item.Name;
            itemControl.Unit = item.Unit;
            if (item.Shops.Count != 0)
            {
                double prize = item.Shops.Values.Min();
                foreach (var shop in item.Shops)
                    if (shop.Value == prize)
                        itemControl.Shop = shop.Key;
                itemControl.Prize = prize;
            }

            return itemControl;
        }
    }
}
