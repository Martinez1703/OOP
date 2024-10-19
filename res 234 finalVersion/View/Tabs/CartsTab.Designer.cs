namespace WindowsFormsApp1.View.Tabs
{
    partial class CartsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.AddToCart = new System.Windows.Forms.Button();
            this.CustomerBox = new System.Windows.Forms.ComboBox();
            this.CartBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListBox
            // 
            this.ItemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 16;
            this.ItemListBox.Location = new System.Drawing.Point(29, 0);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(315, 244);
            this.ItemListBox.TabIndex = 1;
            // 
            // AddToCart
            // 
            this.AddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToCart.Location = new System.Drawing.Point(3, 3);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(395, 60);
            this.AddToCart.TabIndex = 2;
            this.AddToCart.Text = "Add to Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // CustomerBox
            // 
            this.CustomerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerBox.FormattingEnabled = true;
            this.CustomerBox.Location = new System.Drawing.Point(43, 23);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(135, 24);
            this.CustomerBox.TabIndex = 4;
            this.CustomerBox.SelectedIndexChanged += new System.EventHandler(this.CustomerBox_SelectedIndexChanged);
            // 
            // CartBox
            // 
            this.CartBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartBox.FormattingEnabled = true;
            this.CartBox.ItemHeight = 16;
            this.CartBox.Location = new System.Drawing.Point(43, 79);
            this.CartBox.Name = "CartBox";
            this.CartBox.Size = new System.Drawing.Size(226, 132);
            this.CartBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cart:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextBox.Location = new System.Drawing.Point(15, 265);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(184, 22);
            this.AmountTextBox.TabIndex = 8;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrderButton.Location = new System.Drawing.Point(3, 3);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(202, 54);
            this.CreateOrderButton.TabIndex = 9;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(419, 3);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(142, 54);
            this.ClearCartButton.TabIndex = 10;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItem.Location = new System.Drawing.Point(211, 3);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(202, 54);
            this.RemoveItem.TabIndex = 11;
            this.RemoveItem.Text = "Remove Item";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 445);
            this.panel1.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(969, 445);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddToCart, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 379);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 66);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemListBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 445);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel2.Controls.Add(this.CreateOrderButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClearCartButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemoveItem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 385);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 60);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CustomerBox);
            this.panel3.Controls.Add(this.AmountTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.CartBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 382);
            this.panel3.TabIndex = 8;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(969, 445);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.ComboBox CustomerBox;
        private System.Windows.Forms.ListBox CartBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
    }
}
