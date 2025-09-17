namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.cNTTICKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tICKLENGTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.sTEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.rangeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.x1ToolStripMenuItem,
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // sinToolStripMenuItem
            // 
            this.sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            this.sinToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.sinToolStripMenuItem.Text = "Sin";
            this.sinToolStripMenuItem.Click += new System.EventHandler(this.sinToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.cosToolStripMenuItem.Text = "Cos";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // x1ToolStripMenuItem
            // 
            this.x1ToolStripMenuItem.Name = "x1ToolStripMenuItem";
            this.x1ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x1ToolStripMenuItem.Text = "x";
            this.x1ToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // x2ToolStripMenuItem
            // 
            this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            this.x2ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x2ToolStripMenuItem.Text = "x^2";
            this.x2ToolStripMenuItem.Click += new System.EventHandler(this.x2ToolStripMenuItem_Click);
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.x3ToolStripMenuItem.Text = "x^3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // rangeToolStripMenuItem
            // 
            this.rangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2,
            this.cNTTICKSToolStripMenuItem,
            this.tICKLENGTHToolStripMenuItem,
            this.sTEPToolStripMenuItem});
            this.rangeToolStripMenuItem.Name = "rangeToolStripMenuItem";
            this.rangeToolStripMenuItem.Size = new System.Drawing.Size(103, 26);
            this.rangeToolStripMenuItem.Text = "AxisSettings";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(224, 26);
            this.toolStripTextBox2.Text = "ABS_RANGE";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox3.Text = "3.14";
            this.toolStripTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox3_KeyDown);
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // cNTTICKSToolStripMenuItem
            // 
            this.cNTTICKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.cNTTICKSToolStripMenuItem.Name = "cNTTICKSToolStripMenuItem";
            this.cNTTICKSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cNTTICKSToolStripMenuItem.Text = "CNT_TICKS";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "4";
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // tICKLENGTHToolStripMenuItem
            // 
            this.tICKLENGTHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox4});
            this.tICKLENGTHToolStripMenuItem.Name = "tICKLENGTHToolStripMenuItem";
            this.tICKLENGTHToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tICKLENGTHToolStripMenuItem.Text = "TICK_LENGTH";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox4.Text = "10";
            this.toolStripTextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox4_KeyDown_1);
            this.toolStripTextBox4.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // sTEPToolStripMenuItem
            // 
            this.sTEPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox5});
            this.sTEPToolStripMenuItem.Name = "sTEPToolStripMenuItem";
            this.sTEPToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sTEPToolStripMenuItem.Text = "STEP";
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox5.Text = "0.002";
            this.toolStripTextBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox5_KeyDown);
            this.toolStripTextBox5.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem cNTTICKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem tICKLENGTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripMenuItem sTEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
    }
}