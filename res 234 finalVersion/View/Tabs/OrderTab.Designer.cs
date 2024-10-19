namespace WindowsFormsApp1.View.Tabs
{
    partial class OrderTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTab));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CreatedBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.adressControl1 = new WindowsFormsApp1.View.Control.AdressControl();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.DeliveryTimeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DataPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Created,
            this.Price,
            this.Adress,
            this.OrderStatus,
            this.FullName});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(285, 313);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 110;
            // 
            // Created
            // 
            this.Created.HeaderText = "Created";
            this.Created.MinimumWidth = 6;
            this.Created.Name = "Created";
            this.Created.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Created.Width = 110;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Price.Width = 125;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Adress.Width = 125;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Order Status";
            this.OrderStatus.MinimumWidth = 6;
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderStatus.Width = 110;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Created:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status:";
            // 
            // CreatedBox
            // 
            this.CreatedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedBox.Location = new System.Drawing.Point(67, 58);
            this.CreatedBox.Name = "CreatedBox";
            this.CreatedBox.ReadOnly = true;
            this.CreatedBox.Size = new System.Drawing.Size(111, 22);
            this.CreatedBox.TabIndex = 6;
            // 
            // IdBox
            // 
            this.IdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdBox.Location = new System.Drawing.Point(61, 20);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(91, 22);
            this.IdBox.TabIndex = 7;
            // 
            // StatusBox
            // 
            this.StatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(61, 89);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(117, 24);
            this.StatusBox.TabIndex = 8;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // adressControl1
            // 
            this.adressControl1.address = ((WindowsFormsApp1.Model.Address)(resources.GetObject("adressControl1.address")));
            this.adressControl1.Location = new System.Drawing.Point(12, 147);
            this.adressControl1.Name = "adressControl1";
            this.adressControl1.Size = new System.Drawing.Size(437, 189);
            this.adressControl1.TabIndex = 9;
            // 
            // AmountBox
            // 
            this.AmountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountBox.Location = new System.Drawing.Point(17, 467);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(181, 22);
            this.AmountBox.TabIndex = 13;
            // 
            // ItemListBox
            // 
            this.ItemListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 16;
            this.ItemListBox.Location = new System.Drawing.Point(12, 342);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(273, 84);
            this.ItemListBox.TabIndex = 14;
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.Controls.Add(this.DeliveryTimeBox);
            this.DataPanel.Controls.Add(this.label8);
            this.DataPanel.Location = new System.Drawing.Point(244, 23);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(329, 124);
            this.DataPanel.TabIndex = 15;
            // 
            // DeliveryTimeBox
            // 
            this.DeliveryTimeBox.FormattingEnabled = true;
            this.DeliveryTimeBox.Location = new System.Drawing.Point(101, 39);
            this.DeliveryTimeBox.Name = "DeliveryTimeBox";
            this.DeliveryTimeBox.Size = new System.Drawing.Size(121, 24);
            this.DeliveryTimeBox.TabIndex = 28;
            this.DeliveryTimeBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "DeliveryTime:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 515);
            this.panel1.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 515);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 515);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataPanel);
            this.panel3.Controls.Add(this.ItemListBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.StatusBox);
            this.panel3.Controls.Add(this.adressControl1);
            this.panel3.Controls.Add(this.CreatedBox);
            this.panel3.Controls.Add(this.IdBox);
            this.panel3.Controls.Add(this.AmountBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(587, 515);
            this.panel3.TabIndex = 0;
            // 
            // OrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "OrderTab";
            this.Size = new System.Drawing.Size(1002, 515);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreatedBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.ComboBox StatusBox;
        private Control.AdressControl adressControl1;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private  new System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.ComboBox DeliveryTimeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
