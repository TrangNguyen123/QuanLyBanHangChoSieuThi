namespace QUANLY_BHST.VIEW
{
    partial class FromHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromHelp));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Hướng Dẫn Cài Đặt");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Hướng Dẫn Sử Dụng");
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TVHelp = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.btnThoat});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 365);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(798, 25);
            this.bindingNavigator2.TabIndex = 73;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 22);
            this.btnThoat.Text = "Trang Chủ";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(270, 1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(516, 348);
            this.webBrowser1.TabIndex = 72;
            // 
            // TVHelp
            // 
            this.TVHelp.Location = new System.Drawing.Point(12, 1);
            this.TVHelp.Name = "TVHelp";
            treeNode1.Name = "NodeHDCD";
            treeNode1.Text = "Hướng Dẫn Cài Đặt";
            treeNode2.Name = "NodeHDSD";
            treeNode2.Text = "Hướng Dẫn Sử Dụng";
            this.TVHelp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.TVHelp.Size = new System.Drawing.Size(239, 349);
            this.TVHelp.TabIndex = 74;
            this.TVHelp.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVHelp_AfterSelect);
            this.TVHelp.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TVHelp_NodeMouseClick);
            // 
            // FromHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 390);
            this.Controls.Add(this.TVHelp);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.webBrowser1);
            this.Name = "FromHelp";
            this.Text = "FromHelp";
            this.Load += new System.EventHandler(this.FromHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView TVHelp;
    }
}