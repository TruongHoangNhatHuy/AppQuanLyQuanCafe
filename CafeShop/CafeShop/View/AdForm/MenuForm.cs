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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            reload?.Invoke();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            foodPanel.Visible = false;
            categoryFoodPanel.Visible = false;
            categoryCombobox.Items.AddRange(BLLMenu.Instance.GetDanhMucThucDon().ToArray());
            LoadData();
        }
        private void LoadData()
        {
            categoryFoodData.DataSource = BLLMenu.Instance.GetDanhMucThucDon();
            foodData.DataSource = BLLMenu.Instance.GetAllMon();
            //categoryCombobox.Items.AddRange(BLLMenu.Instance.GetDanhMucThucDon().ToArray());
        }
        private void categoryFoodData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(categoryFoodData.SelectedRows.Count == 1)
            {
                string MaHangMuc = categoryFoodData.SelectedRows[0].Cells["MaDanhMuc"].Value.ToString();
                foodData.DataSource = BLLMenu.Instance.GetMonByMaDanhMuc(MaHangMuc);
            }    
        }

        private void editCButton_Click(object sender, EventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
            {
                RefreshData();
                //foodPanel.Visible = false;
                categoryFoodPanel.Visible = true;
                categoryIDTextbox.Texts = categoryFoodData.SelectedRows[0].Cells["MaDanhMuc"].Value.ToString();
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
                    if(item.MaDanhMuc == food.MaDanhMuc)
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
            if(categoryFoodPanel.Visible)
            {
                DanhMucThucDon category = new DanhMucThucDon() 
                {
                    MaDanhMuc = categoryIDTextbox.Texts, 
                    TenDanhMuc = categoryNameTextbox.Texts 
                };
                BLLMenu.Instance.ExecuteCategory(category);
            }    
            else if(foodPanel.Visible)
            {
                Mon food = new Mon()
                {
                    MaMon = foodIDTextbox.Texts,
                    TenMon = foodNameTextbox.Texts,
                    DonGia = Convert.ToInt32(priceTextbox.Texts),
                    DonVi = unitTextbox.Texts,
                    MaDanhMuc = (categoryCombobox.SelectedItem as DanhMucThucDon).MaDanhMuc
                };
                BLLMenu.Instance.ExecuteFood(food);
            }
            LoadData();
            //categoryFoodPanel.Visible = false;
            //foodPanel.Visible = false;
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
    }
}
