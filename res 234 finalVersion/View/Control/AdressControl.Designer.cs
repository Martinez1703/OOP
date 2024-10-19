namespace WindowsFormsApp1.View.Control
{
    partial class AdressControl
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
            this.components = new System.ComponentModel.Container();
            this.PostIndex = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ApartamentLabel = new System.Windows.Forms.Label();
            this.PostIndexBox = new System.Windows.Forms.TextBox();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CityBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BuildingBox = new System.Windows.Forms.TextBox();
            this.ApartamentBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // PostIndex
            // 
            this.PostIndex.AutoSize = true;
            this.PostIndex.Location = new System.Drawing.Point(3, 9);
            this.PostIndex.Name = "PostIndex";
            this.PostIndex.Size = new System.Drawing.Size(72, 16);
            this.PostIndex.TabIndex = 1;
            this.PostIndex.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(20, 40);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(55, 16);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(20, 79);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(45, 16);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(17, 123);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(58, 16);
            this.BuildingLabel.TabIndex = 4;
            this.BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(285, 40);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 16);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City:";
            // 
            // ApartamentLabel
            // 
            this.ApartamentLabel.AutoSize = true;
            this.ApartamentLabel.Location = new System.Drawing.Point(213, 123);
            this.ApartamentLabel.Name = "ApartamentLabel";
            this.ApartamentLabel.Size = new System.Drawing.Size(79, 16);
            this.ApartamentLabel.TabIndex = 6;
            this.ApartamentLabel.Text = "Apartament:";
            // 
            // PostIndexBox
            // 
            this.PostIndexBox.Location = new System.Drawing.Point(81, 6);
            this.PostIndexBox.Name = "PostIndexBox";
            this.PostIndexBox.Size = new System.Drawing.Size(105, 22);
            this.PostIndexBox.TabIndex = 7;
            this.PostIndexBox.TextChanged += new System.EventHandler(this.PostIndexBox_TextChanged);
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(81, 34);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(185, 22);
            this.CountryBox.TabIndex = 8;
            this.CountryBox.TextChanged += new System.EventHandler(this.CountryBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StreetBox
            // 
            this.StreetBox.Location = new System.Drawing.Point(81, 73);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(261, 22);
            this.StreetBox.TabIndex = 10;
            this.StreetBox.TextChanged += new System.EventHandler(this.StreetBox_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(323, 34);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(93, 22);
            this.CityBox.TabIndex = 11;
            this.CityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // BuildingBox
            // 
            this.BuildingBox.Location = new System.Drawing.Point(81, 117);
            this.BuildingBox.Name = "BuildingBox";
            this.BuildingBox.Size = new System.Drawing.Size(100, 22);
            this.BuildingBox.TabIndex = 13;
            this.BuildingBox.TextChanged += new System.EventHandler(this.BuildingBox_TextChanged);
            // 
            // ApartamentBox
            // 
            this.ApartamentBox.Location = new System.Drawing.Point(298, 120);
            this.ApartamentBox.Name = "ApartamentBox";
            this.ApartamentBox.Size = new System.Drawing.Size(100, 22);
            this.ApartamentBox.TabIndex = 14;
            this.ApartamentBox.TextChanged += new System.EventHandler(this.ApartamentBox_TextChanged);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // AdressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApartamentBox);
            this.Controls.Add(this.BuildingBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.PostIndexBox);
            this.Controls.Add(this.ApartamentLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.PostIndex);
            this.Name = "AdressControl";
            this.Size = new System.Drawing.Size(424, 162);
            this.Load += new System.EventHandler(this.AdressControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PostIndex;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ApartamentLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        public System.Windows.Forms.TextBox PostIndexBox;
        public System.Windows.Forms.TextBox CountryBox;
        public System.Windows.Forms.TextBox StreetBox;
        public System.Windows.Forms.TextBox CityBox;
        public System.Windows.Forms.TextBox BuildingBox;
        public System.Windows.Forms.TextBox ApartamentBox;
    }
}
