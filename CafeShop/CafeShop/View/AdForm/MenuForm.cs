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
        private string MaDanhMuc = null;
        public MenuForm()
        {
            InitializeComponent();        
        }

        private void NewMenuForm_Load(object sender, EventArgs e)
        {
            categoryCombobox.Items.AddRange(BLLMenu.Instance.GetDanhMucThucDon().ToArray());
            selectionCombobox.SelectedIndex = 0;
            SetDataGridView();
            ResetAddUpdatePanel();
        }
        private void SetDataGridView()
        {
            SetCategoryDataGridView();
            SetFoodDataGridView();
        }
        private void SetCategoryDataGridView()
        {
            categoryFoodData.DataSource = BLLMenu.Instance.GetDanhMucThucDon();
        }
        private void SetFoodDataGridView(string searchText = "")
        {
            int selection = selectionCombobox.SelectedIndex;
            var list = BLLMenu.Instance.GetMonByMaDanhMuc(MaDanhMuc, searchText);
            if (selection == 0)
                foodData.DataSource = list;
            else if (selection == 1)
                foodData.DataSource = BLLMenu.Instance.GetVisibleMon(list);
            else if (selection == 2)
                foodData.DataSource = BLLMenu.Instance.GetHiddenMon(list);
        }

        
        private void categoryFoodData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
            {
                MaDanhMuc = categoryFoodData.SelectedRows[0].Cells[0].Value.ToString();
                //foodData.DataSource = BLLMenu.Instance.GetMonByMaDanhMuc(MaDanhMuc);
                SetFoodDataGridView();
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
            //foodData.DataSource = BLLMenu.Instance.GetAllMon();
            MaDanhMuc = null;
            SetFoodDataGridView();
            
        }

        private void selectionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFoodDataGridView();
        }
        private void editCButton_Click(object sender, EventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
            {
                ResetAddUpdatePanel();
                buttonPanel.Visible = true;
                //foodPanel.Visible = false;
                categoryFoodPanel.Visible = true;
                categoryIDTextbox.Texts = categoryFoodData.SelectedRows[0].Cells[0].Value.ToString();
                categoryNameTextbox.Texts = categoryFoodData.SelectedRows[0].Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void addCButton_Click(object sender, EventArgs e)
        {
            ResetAddUpdatePanel();
            buttonPanel.Visible = true;
            categoryIDTextbox.Texts = BLLMenu.Instance.NewCategoryKey();
            categoryFoodPanel.Visible = true;
        }

        private void editFButton_Click(object sender, EventArgs e)
        {
            if (foodData.SelectedRows.Count == 1)
            {
                ResetAddUpdatePanel();
                buttonPanel.Visible = true;
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
            ResetAddUpdatePanel();
            buttonPanel.Visible = true;
            foodIDTextbox.Texts = BLLMenu.Instance.NewFoodKey();
            foodPanel.Visible = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoryFoodPanel.Visible)
                {
                    if (categoryNameTextbox != null)
                    {
                        DanhMucThucDon category = new DanhMucThucDon()
                        {
                            MaDanhMuc = categoryIDTextbox.Texts,
                            TenDanhMuc = categoryNameTextbox.Texts,
                            Visible = true
                        };
                        BLLMenu.Instance.ExecuteCategory(category);
                        SetCategoryDataGridView();
                    }
                    else
                        throw new Exception("*Thiếu thông tin");
                }
                else if (foodPanel.Visible)
                {
                    if (foodIDTextbox.Texts != "" && foodNameTextbox.Texts != "" && unitTextbox.Texts != "" && categoryCombobox.SelectedItem != null)
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
                        if (food.DonGia <= 0)
                            throw new Exception("*Đơn giá phải lớn hơn 0");
                        BLLMenu.Instance.ExecuteFood(food);
                        SetFoodDataGridView();
                    }
                    else
                        throw new Exception("*Thiếu thông tin");

                }
                ResetAddUpdatePanel();
            }
            catch (FormatException ex)
            {
                exceptionLabel.Text = "*Đơn giá không đúng định dạng số";
            }
            catch (OverflowException ex)
            {
                exceptionLabel.Text = "*Đơn giá vượt ngoài giá trị\n cho phép";
            }
            catch (Exception ex)
            {
                exceptionLabel.Text = ex.Message;
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            ResetAddUpdatePanel();
        }

        public void ResetAddUpdatePanel()
        {
            //categoryCombobox.Items.Clear();
            categoryCombobox.SelectedItem = null;
            categoryIDTextbox.Texts = "";
            categoryNameTextbox.Texts = "";
            foodIDTextbox.Texts = "";
            foodNameTextbox.Texts = "";
            priceTextbox.Texts = "";
            unitTextbox.Texts = "";
            exceptionLabel.Text = "";
            foodPanel.Visible = false;
            categoryFoodPanel.Visible = false;
            buttonPanel.Visible = false;
        }

        private void deleteCButton_Click(object sender, EventArgs e)
        {
            if (categoryFoodData.SelectedRows.Count == 1)
                BLLMenu.Instance.ChangeCategoryState(categoryFoodData.SelectedRows[0].Cells[0].Value.ToString());
            SetCategoryDataGridView();
        }

        private void deleteFButton_Click(object sender, EventArgs e)
        {
            if (foodData.SelectedRows.Count == 1)
                BLLMenu.Instance.ChangeFoodState(foodData.SelectedRows[0].Cells["MaMon"].Value.ToString());
            SetFoodDataGridView();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            reload?.Invoke();
        }

        private void searchTextbox__TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Texts;
            SetFoodDataGridView(searchText);
        }
    }
}
