namespace WindowsFormsApp1.View.Tabs
{
    partial class PriorityOrderTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriorityOrderTab));
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.CreatedBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderItemListBox = new System.Windows.Forms.ListBox();
            this.adressControl1 = new WindowsFormsApp1.View.Control.AdressControl();
            this.label8 = new System.Windows.Forms.Label();
            this.DeliveryTimeBox = new System.Windows.Forms.ComboBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(81, 94);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 24);
            this.StatusBox.TabIndex = 14;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // IdBox
            // 
            this.IdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IdBox.Location = new System.Drawing.Point(81, 23);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(277, 22);
            this.IdBox.TabIndex = 13;
            // 
            // CreatedBox
            // 
            this.CreatedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreatedBox.Location = new System.Drawing.Point(81, 55);
            this.CreatedBox.Name = "CreatedBox";
            this.CreatedBox.ReadOnly = true;
            this.CreatedBox.Size = new System.Drawing.Size(275, 22);
            this.CreatedBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Created:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id:";
            // 
            // OrderItemListBox
            // 
            this.OrderItemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderItemListBox.FormattingEnabled = true;
            this.OrderItemListBox.ItemHeight = 16;
            this.OrderItemListBox.Location = new System.Drawing.Point(18, 339);
            this.OrderItemListBox.Name = "OrderItemListBox";
            this.OrderItemListBox.Size = new System.Drawing.Size(447, 132);
            this.OrderItemListBox.TabIndex = 16;
            // 
            // adressControl1
            // 
            this.adressControl1.address = ((WindowsFormsApp1.Model.Address)(resources.GetObject("adressControl1.address")));
            this.adressControl1.Location = new System.Drawing.Point(7, 124);
            this.adressControl1.Name = "adressControl1";
            this.adressControl1.Size = new System.Drawing.Size(535, 189);
            this.adressControl1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "DeliveryTime:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DeliveryTimeBox
            // 
            this.DeliveryTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryTimeBox.FormattingEnabled = true;
            this.DeliveryTimeBox.Location = new System.Drawing.Point(504, 20);
            this.DeliveryTimeBox.Name = "DeliveryTimeBox";
            this.DeliveryTimeBox.Size = new System.Drawing.Size(87, 24);
            this.DeliveryTimeBox.TabIndex = 25;
            this.DeliveryTimeBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeBox_SelectedIndexChanged);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextBox.Location = new System.Drawing.Point(44, 500);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(150, 22);
            this.AmountTextBox.TabIndex = 19;
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(478, 591);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(113, 68);
            this.ClearCartButton.TabIndex = 21;
            this.ClearCartButton.Text = "Clear Order";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(272, 591);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(138, 68);
            this.RemoveItemButton.TabIndex = 22;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemButton.Location = new System.Drawing.Point(18, 591);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(194, 68);
            this.AddItemButton.TabIndex = 20;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderItemListBox);
            this.panel1.Controls.Add(this.StatusBox);
            this.panel1.Controls.Add(this.ClearCartButton);
            this.panel1.Controls.Add(this.AddItemButton);
            this.panel1.Controls.Add(this.DeliveryTimeBox);
            this.panel1.Controls.Add(this.IdBox);
            this.panel1.Controls.Add(this.RemoveItemButton);
            this.panel1.Controls.Add(this.CreatedBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AmountTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 673);
            this.panel1.TabIndex = 26;

            // 
            // PriorityOrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.adressControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "PriorityOrderTab";
            this.Size = new System.Drawing.Size(649, 673);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox CreatedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox OrderItemListBox;
        private Control.AdressControl adressControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DeliveryTimeBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Panel panel1;
    }
}
