using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.BLL;
using CafeShop.DTO;

namespace CafeShop.View.AdForm
{
    public partial class MenuForm : Form
    {
        public delegate void Reload();
        public Reload reload;
        public MenuForm()
        {
            InitializeComponent();        
        }

        private void NewMenuForm_Load(object sender, EventArgs e)
        {
            foodPanel.Visible = false;
            categoryFoodPanel.Visible = false;
            categoryCombobox.Items.AddRange(BLLMenu.Instance.GetDanhMucThucDon().ToArray());
            selectionCombobox.SelectedIndex = 0;
            LoadData();
        }
        private void LoadData()
        {
            categoryFoodData.DataSource = BLLMenu.Instance.GetDanhMucThucDon();
            //foodData.DataSource = BLLMenu.Instance.GetAllMon();
            //categoryCombobox.Items.AddRange(BLLMenu.Instance.GetDanhMucThucDon().ToArray());
        }
        private string MaDanhMuc = null;
        private void categoryFoodData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
            {
                MaDanhMuc = categoryFoodData.SelectedRows[0].Cells[0].Value.ToString();
                foodData.DataSource = BLLMenu.Instance.GetMonByMaDanhMuc(MaDanhMuc);
                if (Convert.ToBoolean(categoryFoodData.SelectedRows[0].Cells[2].Value))
                    deleteCButton.Text = "Ẩn";
                else
                    deleteCButton.Text = "Hiện";
            }
        }
        private void foodData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (foodData.SelectedRows.Count == 1)
            {
                if (Convert.ToBoolean(foodData.SelectedRows[0].Cells["Visible"].Value))
                    deleteFButton.Text = "Ẩn";
                else
                    deleteFButton.Text = "Hiện";
            }
        }
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            foodData.DataSource = BLLMenu.Instance.GetAllMon();
            MaDanhMuc = null;
        }

        private void selectionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = selectionCombobox.SelectedIndex;
            var list = BLLMenu.Instance.GetMonByMaDanhMuc(MaDanhMuc);

            if (selection == 0)
                foodData.DataSource = list;
            else if (selection == 1)
                foodData.DataSource = BLLMenu.Instance.GetVisibleMon(list);

            else if (selection == 2)
                foodData.DataSource = BLLMenu.Instance.GetHiddenMon(list);
        }

        private void editCButton_Click(object sender, EventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
            {
                RefreshData();
                //foodPanel.Visible = false;
                categoryFoodPanel.Visible = true;
                categoryIDTextbox.Texts = categoryFoodData.SelectedRows[0].Cells[0].Value.ToString();
                categoryNameTextbox.Texts = categoryFoodData.SelectedRows[0].Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void addCButton_Click(object sender, EventArgs e)
        {
            RefreshData();
            categoryIDTextbox.Texts = BLLMenu.Instance.NewCategoryKey();
            //foodPanel.Visible = false;
            categoryFoodPanel.Visible = true;
        }

        private void editFButton_Click(object sender, EventArgs e)
        {
            if (foodData.SelectedRows.Count == 1)
            {
                RefreshData();
                foodPanel.Visible = true;
                foodIDTextbox.Texts = foodData.SelectedRows[0].Cells["MaMon"].Value.ToString();
                foodNameTextbox.Texts = foodData.SelectedRows[0].Cells["TenMon"].Value.ToString();
                unitTextbox.Texts = foodData.SelectedRows[0].Cells["DonVi"].Value.ToString();
                priceTextbox.Texts = foodData.SelectedRows[0].Cells["DonGia"].Value.ToString();
                var food = BLLMenu.Instance.GetMonByMaMon(foodData.SelectedRows[0].Cells["MaMon"].Value.ToString());
                foreach (DanhMucThucDon item in categoryCombobox.Items)
                {
                    if (item.MaDanhMuc == food.MaDanhMuc)
                    {
                        categoryCombobox.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void addFButton_Click(object sender, EventArgs e)
        {
            RefreshData();
            foodIDTextbox.Texts = BLLMenu.Instance.NewFoodKey();
            //categoryFoodPanel.Visible = false;
            foodPanel.Visible = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (categoryFoodPanel.Visible)
            {
                DanhMucThucDon category = new DanhMucThucDon()
                {
                    MaDanhMuc = categoryIDTextbox.Texts,
                    TenDanhMuc = categoryNameTextbox.Texts,
                    Visible = true
                };
                BLLMenu.Instance.ExecuteCategory(category);
            }
            else if (foodPanel.Visible)
            {
                Mon food = new Mon()
                {
                    MaMon = foodIDTextbox.Texts,
                    TenMon = foodNameTextbox.Texts,
                    DonGia = Convert.ToInt32(priceTextbox.Texts),
                    DonVi = unitTextbox.Texts,
                    MaDanhMuc = (categoryCombobox.SelectedItem as DanhMucThucDon).MaDanhMuc,
                    Visible = true
                };
                BLLMenu.Instance.ExecuteFood(food);
            }
            LoadData();
            RefreshData();
        }
        public void RefreshData()
        {
            //categoryCombobox.Items.Clear();
            categoryCombobox.SelectedItem = null;
            categoryIDTextbox.Texts = "";
            categoryNameTextbox.Texts = "";
            foodIDTextbox.Texts = "";
            foodNameTextbox.Texts = "";
            priceTextbox.Texts = "";
            unitTextbox.Texts = "";
            foodPanel.Visible = false;
            categoryFoodPanel.Visible = false;
        }

        private void deleteCButton_Click(object sender, EventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
                BLLMenu.Instance.ChangeCategoryState(categoryFoodData.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void deleteFButton_Click(object sender, EventArgs e)
        {
            if (foodData.SelectedRows.Count == 1)
                BLLMenu.Instance.ChangeFoodState(foodData.SelectedRows[0].Cells["MaMon"].Value.ToString());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }
    }
}
