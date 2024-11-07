namespace WindowsFormsApp1
{
    
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new WindowsFormsApp1.View.Tabs.ItemsTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customersTab1 = new WindowsFormsApp1.View.Tabs.CustomersTab();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new WindowsFormsApp1.View.Tabs.CartsTab();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.orderTab1 = new WindowsFormsApp1.View.Tabs.OrderTab();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.prioretyOrder1 = new WindowsFormsApp1.View.Tabs.PriorityOrderTab();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 893);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.itemsTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 864);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.BackColor = System.Drawing.SystemColors.Control;
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Items = null;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Margin = new System.Windows.Forms.Padding(4);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(978, 858);
            this.itemsTab1.TabIndex = 0;
            this.itemsTab1.Load += new System.EventHandler(this.itemsTab1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customersTab1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 864);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.BackColor = System.Drawing.SystemColors.Control;
            this.customersTab1.Customers = null;
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Margin = new System.Windows.Forms.Padding(4);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.newPer = null;
            this.customersTab1.Size = new System.Drawing.Size(978, 858);
            this.customersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cartsTab1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(984, 864);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.BackColor = System.Drawing.SystemColors.Control;
            this.cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab1.Location = new System.Drawing.Point(3, 3);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(978, 858);
            this.cartsTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.orderTab1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(984, 864);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Order";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // orderTab1
            // 
            this.orderTab1.BackColor = System.Drawing.SystemColors.Control;
            this.orderTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTab1.listcustomer = null;
            this.orderTab1.Location = new System.Drawing.Point(0, 0);
            this.orderTab1.Name = "orderTab1";
            this.orderTab1.Size = new System.Drawing.Size(984, 864);
            this.orderTab1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.prioretyOrder1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(984, 864);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Priority Order";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // prioretyOrder1
            // 
            this.prioretyOrder1.BackColor = System.Drawing.SystemColors.Control;
            this.prioretyOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.prioretyOrder1.listcustomer = ((System.Collections.Generic.List<WindowsFormsApp1.Model.Customer>)(resources.GetObject("prioretyOrder1.listcustomer")));
            this.prioretyOrder1.Location = new System.Drawing.Point(3, 3);
            this.prioretyOrder1.Name = "prioretyOrder1";
            this.prioretyOrder1.Size = new System.Drawing.Size(978, 858);
            this.prioretyOrder1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 893);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage tabPage3;
        private View.Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage tabPage4;
        private View.Tabs.OrderTab orderTab1;
        private System.Windows.Forms.TabPage tabPage5;
        public View.Tabs.PriorityOrderTab prioretyOrder1;
    }
}

