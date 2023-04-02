namespace Product_Stock
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.category = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.labal1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamePd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryPd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "เพิ่มรายการ";
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Location = new System.Drawing.Point(109, 107);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(203, 28);
            this.id.TabIndex = 1;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(109, 141);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(203, 28);
            this.name.TabIndex = 2;
            // 
            // category
            // 
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.category.Location = new System.Drawing.Point(109, 175);
            this.category.Multiline = true;
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(203, 28);
            this.category.TabIndex = 3;
            // 
            // price
            // 
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Location = new System.Drawing.Point(109, 209);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(203, 28);
            this.price.TabIndex = 4;
            // 
            // quantity
            // 
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantity.Location = new System.Drawing.Point(109, 243);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(203, 28);
            this.quantity.TabIndex = 5;
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(24, 119);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(32, 20);
            this.labal1.TabIndex = 6;
            this.labal1.Text = "รหัส";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ชื่อรายการ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "หมวดหมู่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ราคา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "จำนวน";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "เพิ่มรายการ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "ลบรายการ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1061, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduct,
            this.NamePd,
            this.CategoryPd,
            this.PricePd,
            this.QuantityPd});
            this.dataGridView1.Location = new System.Drawing.Point(377, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(681, 450);
            this.dataGridView1.TabIndex = 14;
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "รหัส";
            this.IdProduct.MinimumWidth = 6;
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Width = 125;
            // 
            // NamePd
            // 
            this.NamePd.HeaderText = "ชื่อรายการ";
            this.NamePd.MinimumWidth = 6;
            this.NamePd.Name = "NamePd";
            this.NamePd.Width = 125;
            // 
            // CategoryPd
            // 
            this.CategoryPd.HeaderText = "หมวดหมู่";
            this.CategoryPd.MinimumWidth = 6;
            this.CategoryPd.Name = "CategoryPd";
            this.CategoryPd.Width = 125;
            // 
            // PricePd
            // 
            this.PricePd.HeaderText = "ราคา";
            this.PricePd.MinimumWidth = 6;
            this.PricePd.Name = "PricePd";
            this.PricePd.Width = 125;
            // 
            // QuantityPd
            // 
            this.QuantityPd.HeaderText = "จำนวน";
            this.QuantityPd.MinimumWidth = 6;
            this.QuantityPd.Name = "QuantityPd";
            this.QuantityPd.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.category);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Product Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox id;
        private TextBox name;
        private TextBox category;
        private TextBox price;
        private TextBox quantity;
        private Label labal1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdProduct;
        private DataGridViewTextBoxColumn NamePd;
        private DataGridViewTextBoxColumn CategoryPd;
        private DataGridViewTextBoxColumn PricePd;
        private DataGridViewTextBoxColumn QuantityPd;
    }
}