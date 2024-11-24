using OOADPRO.Models;
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

public partial class CategoryAddForm : Form
{
    int categoryCount = 0;
    int indexOfUpdateCategory;
    public CategoryAddForm()
    {
        InitializeComponent();
        btnClear.Click += DoClickClearFormInput;
        btnInsert.Click += DoClickInsertCategory;
        btnUpdate.Click += DoClickUpdateCategory;
    }

    private void DoClickUpdateCategory(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void DoClickInsertCategory(object? sender, EventArgs e)
    {
        if (txtCategoryName.Text == "" || txtCategoryName.Text.Trim().Length > 100)
        {
            MessageBox.Show("Staff Name is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }

        if (rtxtCategoryDescription.Text == "" || rtxtCategoryDescription.Text.Trim().Length > 1000)
        {
            MessageBox.Show("Staff Address is required or address too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
       

        Category newCategory = new Category()
        {
            CategoryName = txtCategoryName.Text.Trim(),
            CategoryDescription = rtxtCategoryDescription.Text.Trim(),      
        };
        try
        {
            var result = CategoryFunc.AddCategory(Program.Connection, newCategory);
            if (result == true)
            {
                MessageBox.Show($"Successfully inserted category with the id {txtCategoryID.Text}");

            }
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        clearFormInput();
    }

    private void DoClickClearFormInput(object? sender, EventArgs e)
    {
        clearFormInput();
    }
     private void CategoryAddForm_Load(object sender, EventArgs e)
    {
        try
        {
            var result =CategoryFunc.GetAllCategory(Program.Connection);
            if (result.LastOrDefault() != null) { categoryCount = result.LastOrDefault().CategoryID; }
            else { categoryCount = 0; }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving category", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        txtCategoryID.Text = (categoryCount + 1).ToString();
    }
    private void clearFormInput()
    {
        txtCategoryID.Text = (categoryCount + 1).ToString();
        txtCategoryName.Text = "";
        rtxtCategoryDescription.Text = "";
    }

   
}
