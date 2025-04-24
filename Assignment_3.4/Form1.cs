using System.ComponentModel;

namespace Assignment_3._4;

public partial class Form1 : Form
{
    private BindingList<Coffee> coffeeList = new BindingList<Coffee>();

    public Form1()
    {
        InitializeComponent();
        InitializeCoffeeList();
        SetupDataGridView();
        BindDataToGrid();
    }
    private void InitializeCoffeeList()
    {
        coffeeList.Add(new Coffee("Espresso", 3.50, "Small", true, "Arabica", "Dark", true));
        coffeeList.Add(new Coffee("Cappuccino", 4.25, "Medium", true, "Arabica", "Medium", true));
        coffeeList.Add(new Coffee("Iced Coffee", 3.75, "Large", false, "Robusta", "Medium", true));
    }
    
    private void SetupDataGridView()
    {
        dataGridViewCoffees.AutoGenerateColumns = true;
        dataGridViewCoffees.AllowUserToAddRows = false;
        dataGridViewCoffees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewCoffees.MultiSelect = false;
            
        buttonAdd.Click += ButtonAdd_Click;
        buttonDelete.Click += ButtonDelete_Click;
    }

    
    private void BindDataToGrid()
    {
        bindingSource.DataSource = coffeeList;
        dataGridViewCoffees.DataSource = bindingSource;
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        
    }
}