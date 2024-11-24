using OOADPRO.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADPRO.Forms.AdminDisplayForm;

public partial class CategoryForm : Form
{
    public CategoryForm()
    {
        InitializeComponent();
        btnAddCategory.Click += DoClickAddCategory;
        btnClickDelete.Click += DoClickDeleteCategory;
        btnClickUpdate.Click += DoClickUpdateCategory;
    }

    private void DoClickUpdateCategory(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void DoClickDeleteCategory(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void DoClickAddCategory(object? sender, EventArgs e)
    {
        new CategoryAddForm().Show();
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
        LoadingDataCategory();
    }
    private void LoadingDataCategory()
    {
        try
        {
            var result = CategoryFunc.GetAllCategory(Program.Connection);
            
            dgvCategory.Rows.Clear();
            foreach (var category in result)
            {
                dgvCategory.Rows.Add(category.CategoryID, category.CategoryName, category.CategoryDescription);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
