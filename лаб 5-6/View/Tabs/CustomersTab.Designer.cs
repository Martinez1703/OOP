namespace WindowsFormsApp1.View.Tabs
{
    partial class CustomersTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersTab));
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.adressControl1 = new WindowsFormsApp1.View.Control.AdressControl();
            this.IsPriority = new System.Windows.Forms.CheckBox();
            this.DiscountlistBox = new System.Windows.Forms.ListBox();
            this.DaddButton = new System.Windows.Forms.Button();
            this.DremoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 16;
            this.CustomerListBox.Location = new System.Drawing.Point(5, 4);
            this.CustomerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(388, 628);
            this.CustomerListBox.TabIndex = 1;
            this.CustomerListBox.SelectedIndexChanged += new System.EventHandler(this.CustomerListBox_SelectedIndexChanged);
            this.CustomerListBox.DoubleClick += new System.EventHandler(this.CustomerListBox_DoubleClick);
            this.CustomerListBox.MouseEnter += new System.EventHandler(this.CustomerListBox_MouseEnter);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(5, 650);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(145, 59);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveButton.Location = new System.Drawing.Point(167, 650);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(123, 59);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(428, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(417, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "FullName:";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(526, 27);
            this.IdBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(132, 22);
            this.IdBox.TabIndex = 12;
            this.IdBox.MouseEnter += new System.EventHandler(this.IdBox_MouseEnter);
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(526, 78);
            this.FullNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(389, 22);
            this.FullNameBox.TabIndex = 13;
            this.FullNameBox.TextChanged += new System.EventHandler(this.FullnameBox_TextChanged);
            this.FullNameBox.MouseEnter += new System.EventHandler(this.FullNameBox_MouseEnter);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(297, 650);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(96, 59);
            this.EditButton.TabIndex = 16;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseEnter += new System.EventHandler(this.EditButton_MouseEnter);
            // 
            // adressControl1
            // 
            this.adressControl1.address = ((WindowsFormsApp1.Model.Address)(resources.GetObject("adressControl1.address")));
            this.adressControl1.Location = new System.Drawing.Point(419, 155);
            this.adressControl1.Name = "adressControl1";
            this.adressControl1.Size = new System.Drawing.Size(535, 189);
            this.adressControl1.TabIndex = 17;
            // 
            // IsPriority
            // 
            this.IsPriority.AutoSize = true;
            this.IsPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsPriority.Location = new System.Drawing.Point(526, 116);
            this.IsPriority.Name = "IsPriority";
            this.IsPriority.Size = new System.Drawing.Size(110, 33);
            this.IsPriority.TabIndex = 18;
            this.IsPriority.Text = "Priority";
            this.IsPriority.UseVisualStyleBackColor = true;
            // 
            // DiscountlistBox
            // 
            this.DiscountlistBox.FormattingEnabled = true;
            this.DiscountlistBox.ItemHeight = 16;
            this.DiscountlistBox.Location = new System.Drawing.Point(419, 356);
            this.DiscountlistBox.Name = "DiscountlistBox";
            this.DiscountlistBox.Size = new System.Drawing.Size(355, 276);
            this.DiscountlistBox.TabIndex = 20;
            // 
            // DaddButton
            // 
            this.DaddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DaddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DaddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaddButton.Location = new System.Drawing.Point(781, 497);
            this.DaddButton.Margin = new System.Windows.Forms.Padding(4);
            this.DaddButton.Name = "DaddButton";
            this.DaddButton.Size = new System.Drawing.Size(190, 59);
            this.DaddButton.TabIndex = 21;
            this.DaddButton.Text = "Add";
            this.DaddButton.UseVisualStyleBackColor = true;
            this.DaddButton.Click += new System.EventHandler(this.DaddButton_Click);
            // 
            // DremoveButton
            // 
            this.DremoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.DremoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DremoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DremoveButton.Location = new System.Drawing.Point(781, 573);
            this.DremoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.DremoveButton.Name = "DremoveButton";
            this.DremoveButton.Size = new System.Drawing.Size(190, 59);
            this.DremoveButton.TabIndex = 22;
            this.DremoveButton.Text = "Remove";
            this.DremoveButton.UseVisualStyleBackColor = true;
            this.DremoveButton.Click += new System.EventHandler(this.DremoveButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.DremoveButton);
            this.Controls.Add(this.DaddButton);
            this.Controls.Add(this.DiscountlistBox);
            this.Controls.Add(this.IsPriority);
            this.Controls.Add(this.adressControl1);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomerListBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(1002, 865);
            this.Load += new System.EventHandler(this.CustomersTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.Button EditButton;
        public Control.AdressControl adressControl1;
        public System.Windows.Forms.ListBox CustomerListBox;
        public System.Windows.Forms.CheckBox IsPriority;
        private System.Windows.Forms.ListBox DiscountlistBox;
        private System.Windows.Forms.Button DaddButton;
        private System.Windows.Forms.Button DremoveButton;
    }
}
