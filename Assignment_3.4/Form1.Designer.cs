namespace Assignment_3._4;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        dataGridViewCoffees = new System.Windows.Forms.DataGridView();
        bindingSource = new System.Windows.Forms.BindingSource(components);
        buttonAdd = new System.Windows.Forms.Button();
        buttonDelete = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize) dataGridViewCoffees).BeginInit();
        ((System.ComponentModel.ISupportInitialize) bindingSource).BeginInit();
        SuspendLayout();
        // 
        // dataGridViewCoffees
        // 
        dataGridViewCoffees.Location = new System.Drawing.Point(10, 22);
        dataGridViewCoffees.Name = "dataGridViewCoffees";
        dataGridViewCoffees.Size = new System.Drawing.Size(778, 130);
        dataGridViewCoffees.TabIndex = 0;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new System.Drawing.Point(53, 218);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new System.Drawing.Size(163, 44);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += ButtonAdd_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new System.Drawing.Point(252, 218);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new System.Drawing.Size(163, 44);
        buttonDelete.TabIndex = 2;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += ButtonDelete_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(buttonDelete);
        Controls.Add(buttonAdd);
        Controls.Add(dataGridViewCoffees);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize) dataGridViewCoffees).EndInit();
        ((System.ComponentModel.ISupportInitialize) bindingSource).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonDelete;

    private System.Windows.Forms.Button buttonAdd;

    private System.Windows.Forms.BindingSource bindingSource;

    private System.Windows.Forms.DataGridView dataGridViewCoffees;

    #endregion
}