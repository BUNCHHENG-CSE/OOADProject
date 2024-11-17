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
    }

    private void DoClickAddCategory(object? sender, EventArgs e)
    {
        new CategoryAddForm().Show();
    }
}
