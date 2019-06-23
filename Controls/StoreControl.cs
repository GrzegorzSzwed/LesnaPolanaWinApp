using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LesnaPolanaWinApp.Classess;

namespace LesnaPolanaWinApp.Controls
{
    public partial class StoreControl : UserControl
    {
        static StoreControl _obj;
        private List<Panel> pnls;
        private User user;
        private DBMigrator migrator;
        private Dictionary<string, double> shops;
        private string lastShop;
        public StoreControl(User user, DBMigrator migrator)
        {
            InitializeComponent();
            _obj = this;
            shops = new Dictionary<string, double>();
            pnls = new List<Panel>();
            pnls.Add(pnlAddItem);
            pnls.Add(pnlListItems);
            pnls[1].BringToFront();
            this.user = new User();
            this.user = user;
            this.migrator = migrator;
        }
        public DBMigrator MongoCRUD
        {
            get { return migrator; }
        }
        public FlowLayoutPanel ListItems
        {
            get { return flwListItems; }
            set { flwListItems = value; }
        }

        public static StoreControl Instance
        {
            get
            {
                return _obj;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && cmbUnit.Text != string.Empty)
            {
                string name = txtName.Text;
                string unit = cmbUnit.Text;
                double amount = Convert.ToDouble(txtAmount.Text);
                Item newItem = new Item(name, unit, amount, shops, user);
                migrator.InsertRecord<Item>("Items", newItem);
                ClearTxtboxes();
                MessageBox.Show("Dodano jednostkę");
            }
            else
                MessageBox.Show("Uzupełnij nazwe i jednostke");
        }

        private void CmbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            double currentPrize;
            double lastPrize;
            if (cmbShop.Text!=string.Empty)
            {
                string currentShop = cmbShop.Text;
                if (txtPrize.Text != string.Empty)
                {
                    double prize = Convert.ToDouble(txtPrize.Text);
                    //check if currentshop exists in dictionary and gets initiliazed value
                    if (shops.TryGetValue(currentShop, out currentPrize))
                        txtPrize.Text = currentPrize.ToString();
                    else
                        txtPrize.Text = string.Empty;

                    //check if lastshop exists with value in dictionary to not to get it into dictionary
                    if (shops.TryGetValue(lastShop, out lastPrize))
                    {
                        if (lastPrize != prize)
                            shops[lastShop] = prize;
                    }
                    else
                        shops.Add(lastShop, prize);

                    lastShop = cmbShop.Text.ToString();
                }
                else
                {
                    if (shops.TryGetValue(currentShop, out currentPrize))
                        txtPrize.Text = currentPrize.ToString();
                    else
                        txtPrize.Text = string.Empty;

                    lastShop = cmbShop.Text.ToString();
                }
            }
        }

        private void ClearTxtboxes()
        {
            txtName.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtPrize.Text = string.Empty;
            cmbShop.Text = string.Empty;
            cmbUnit.Text = string.Empty;
            shops.Clear();
        }

        private void BtnNewItem_Click(object sender, EventArgs e)
        {
            pnls[0].BringToFront();
        }

        private void BtnListItems_Click(object sender, EventArgs e)
        {
            pnls[1].BringToFront();
            List<Item> items = new List<Item>();
            items = migrator.LoadRecords<Item>("Items");
            ItemControl[] cntrls = new ItemControl[items.Count];
            int inc = 0;
            foreach (var item in items)
            {
                cntrls[inc] = new ItemControl();
                cntrls[inc] = ParseToControl(item,cntrls[inc]);
                cntrls[inc++].Width = flwListItems.Width - 30;
            }
            flwListItems.Controls.AddRange(cntrls);
        }

        private ItemControl ParseToControl(Item item, ItemControl itemControl)
        {
            itemControl.ItemName = item.Name;
            itemControl.Unit = item.Unit;
            if(item.Shops.Count!=0)
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
