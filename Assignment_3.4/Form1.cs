using System.ComponentModel;

namespace Assignment_3._4;

public partial class Form1 : Form
{
    private BindingList<Coffee> coffeeList = new BindingList<Coffee>();

    public Form1()
    {
        InitializeComponent();
        ExampleCoffeeList();
        SetupDataGridView();
        BindDataToGrid();
    }
    private void ExampleCoffeeList()
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
    }
    
    private void BindDataToGrid()
    {
        bindingSource.DataSource = coffeeList;
        dataGridViewCoffees.DataSource = bindingSource;
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        using (var form = new Form())
        {
            form.Text = "Add Coffee";
            form.Size = new Size(350, 320);
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            
            var lblName = new Label { Text = "Name:", Left = 20, Top = 20 };
            var txtName = new TextBox { Left = 120, Top = 20, Width = 200 };
            
            var lblPrice = new Label { Text = "Price:", Left = 20, Top = 50 };
            var txtPrice = new TextBox { Left = 120, Top = 50, Width = 200 };
            
            var lblSize = new Label { Text = "Size:", Left = 20, Top = 80 };
            var cboSize = new ComboBox { Left = 120, Top = 80, Width = 200 };
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cboSize.SelectedIndex = 1;  // Default to Medium
            
            var chkIsHot = new CheckBox { Text = "Is Hot", Left = 120, Top = 110, Width = 200 };
            chkIsHot.Checked = true;
            
            var lblBeanType = new Label { Text = "Bean Type:", Left = 20, Top = 140 };
            var txtBeanType = new TextBox { Left = 120, Top = 140, Width = 200 };
            txtBeanType.Text = "Arabica";
            
            var lblRoastLevel = new Label { Text = "Roast Level:", Left = 20, Top = 170 };
            var cboRoastLevel = new ComboBox { Left = 120, Top = 170, Width = 200 };
            cboRoastLevel.Items.AddRange(new object[] { "Light", "Medium", "Dark" });
            cboRoastLevel.SelectedIndex = 1;  // Default to Medium
            
            var chkHasCaffeine = new CheckBox { Text = "Has Caffeine", Left = 120, Top = 200, Width = 200 };
            chkHasCaffeine.Checked = true;
            
            var btnSave = new Button { Text = "Save", Left = 120, Top = 240, Width = 80 };
            var btnCancel = new Button { Text = "Cancel", Left = 220, Top = 240, Width = 80 };
            
            form.Controls.AddRange(new Control[] { 
                lblName, txtName, lblPrice, txtPrice, lblSize, cboSize, 
                chkIsHot, lblBeanType, txtBeanType, lblRoastLevel, cboRoastLevel,
                chkHasCaffeine, btnSave, btnCancel 
            });
            
            btnSave.Click += (s, ev) => {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
                {
                    MessageBox.Show("Please enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(txtBeanType.Text))
                {
                    MessageBox.Show("Please enter a bean type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Create and add the new coffee
                var coffee = new Coffee(
                    txtName.Text,
                    price,
                    cboSize.Text,
                    chkIsHot.Checked,
                    txtBeanType.Text,
                    cboRoastLevel.Text,
                    chkHasCaffeine.Checked
                );
                
                coffeeList.Add(coffee);
                form.DialogResult = DialogResult.OK;
                form.Close();
            };
            
            btnCancel.Click += (s, ev) => {
                form.DialogResult = DialogResult.Cancel;
                form.Close();
            };
            
            form.ShowDialog();
        }
    }


    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridViewCoffees.SelectedRows.Count > 0)
        {
            int index = dataGridViewCoffees.SelectedRows[0].Index;
            
            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this coffee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            
            if (result == DialogResult.Yes)
            {
                coffeeList.RemoveAt(index);
            }
        }
        else
        {
            MessageBox.Show(
                "Please select a coffee to delete",
                "No Selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

}