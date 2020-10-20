namespace homework4_2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainToolsPanel = new System.Windows.Forms.Panel();
            this.SearchStrip = new System.Windows.Forms.Panel();
            this.SearchButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DeleteOrderStrip = new System.Windows.Forms.Panel();
            this.AddOrderStrip = new System.Windows.Forms.Panel();
            this.DeleteOrderButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddOrderButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.HomeBtStrip = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.HomeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.appIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mainScreenPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TitlePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Title = new System.Windows.Forms.Label();
            this.ExitButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mainToolsPanel.SuspendLayout();
            this.HomeBtStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolsPanel
            // 
            this.mainToolsPanel.BackColor = System.Drawing.Color.White;
            this.mainToolsPanel.Controls.Add(this.HomeBtStrip);
            this.mainToolsPanel.Controls.Add(this.SearchStrip);
            this.mainToolsPanel.Controls.Add(this.SearchButton);
            this.mainToolsPanel.Controls.Add(this.DeleteOrderStrip);
            this.mainToolsPanel.Controls.Add(this.AddOrderStrip);
            this.mainToolsPanel.Controls.Add(this.DeleteOrderButton);
            this.mainToolsPanel.Controls.Add(this.AddOrderButton);
            this.mainToolsPanel.Controls.Add(this.HomeButton);
            this.mainToolsPanel.Controls.Add(this.appIcon);
            this.mainToolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.mainToolsPanel.Name = "mainToolsPanel";
            this.mainToolsPanel.Size = new System.Drawing.Size(68, 467);
            this.mainToolsPanel.TabIndex = 0;
            // 
            // SearchStrip
            // 
            this.SearchStrip.BackColor = System.Drawing.Color.Indigo;
            this.SearchStrip.Location = new System.Drawing.Point(6, 194);
            this.SearchStrip.Name = "SearchStrip";
            this.SearchStrip.Size = new System.Drawing.Size(5, 40);
            this.SearchStrip.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SearchButton.CheckedState.Parent = this.SearchButton;
            this.SearchButton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchButton.HoverState.Parent = this.SearchButton;
            this.SearchButton.Image = global::homework4_2.Properties.Resources.放大镜;
            this.SearchButton.ImageRotate = 0F;
            this.SearchButton.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchButton.Location = new System.Drawing.Point(24, 194);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchButton.PressedState.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(41, 42);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteOrderStrip
            // 
            this.DeleteOrderStrip.BackColor = System.Drawing.Color.Indigo;
            this.DeleteOrderStrip.Location = new System.Drawing.Point(6, 371);
            this.DeleteOrderStrip.Name = "DeleteOrderStrip";
            this.DeleteOrderStrip.Size = new System.Drawing.Size(5, 40);
            this.DeleteOrderStrip.TabIndex = 6;
            // 
            // AddOrderStrip
            // 
            this.AddOrderStrip.BackColor = System.Drawing.Color.Indigo;
            this.AddOrderStrip.Location = new System.Drawing.Point(6, 284);
            this.AddOrderStrip.Name = "AddOrderStrip";
            this.AddOrderStrip.Size = new System.Drawing.Size(5, 40);
            this.AddOrderStrip.TabIndex = 5;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.DeleteOrderButton.CheckedState.Parent = this.DeleteOrderButton;
            this.DeleteOrderButton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteOrderButton.HoverState.Parent = this.DeleteOrderButton;
            this.DeleteOrderButton.Image = global::homework4_2.Properties.Resources.minus;
            this.DeleteOrderButton.ImageRotate = 0F;
            this.DeleteOrderButton.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteOrderButton.Location = new System.Drawing.Point(25, 369);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteOrderButton.PressedState.Parent = this.DeleteOrderButton;
            this.DeleteOrderButton.Size = new System.Drawing.Size(41, 50);
            this.DeleteOrderButton.TabIndex = 6;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddOrderButton.CheckedState.Parent = this.AddOrderButton;
            this.AddOrderButton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.AddOrderButton.HoverState.Parent = this.AddOrderButton;
            this.AddOrderButton.Image = global::homework4_2.Properties.Resources.add;
            this.AddOrderButton.ImageRotate = 0F;
            this.AddOrderButton.ImageSize = new System.Drawing.Size(25, 25);
            this.AddOrderButton.Location = new System.Drawing.Point(24, 283);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.AddOrderButton.PressedState.Parent = this.AddOrderButton;
            this.AddOrderButton.Size = new System.Drawing.Size(41, 42);
            this.AddOrderButton.TabIndex = 5;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // HomeBtStrip
            // 
            this.HomeBtStrip.BackColor = System.Drawing.Color.Indigo;
            this.HomeBtStrip.Controls.Add(this.guna2ImageButton1);
            this.HomeBtStrip.Location = new System.Drawing.Point(6, 110);
            this.HomeBtStrip.Name = "HomeBtStrip";
            this.HomeBtStrip.Size = new System.Drawing.Size(5, 40);
            this.HomeBtStrip.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::homework4_2.Properties.Resources.home;
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.Location = new System.Drawing.Point(17, 82);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(41, 42);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // HomeButton
            // 
            this.HomeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeButton.CheckedState.Parent = this.HomeButton;
            this.HomeButton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.HomeButton.HoverState.Parent = this.HomeButton;
            this.HomeButton.Image = global::homework4_2.Properties.Resources.home;
            this.HomeButton.ImageRotate = 0F;
            this.HomeButton.ImageSize = new System.Drawing.Size(25, 25);
            this.HomeButton.Location = new System.Drawing.Point(24, 108);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.HomeButton.PressedState.Parent = this.HomeButton;
            this.HomeButton.Size = new System.Drawing.Size(41, 42);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // appIcon
            // 
            this.appIcon.BackColor = System.Drawing.Color.Transparent;
            this.appIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.appIcon.Image = global::homework4_2.Properties.Resources.marketCart;
            this.appIcon.Location = new System.Drawing.Point(0, 0);
            this.appIcon.Name = "appIcon";
            this.appIcon.ShadowDecoration.Parent = this.appIcon;
            this.appIcon.Size = new System.Drawing.Size(68, 54);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIcon.TabIndex = 0;
            this.appIcon.TabStop = false;
            // 
            // mainScreenPanel
            // 
            this.mainScreenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainScreenPanel.Location = new System.Drawing.Point(68, 54);
            this.mainScreenPanel.Name = "mainScreenPanel";
            this.mainScreenPanel.ShadowDecoration.Parent = this.mainScreenPanel;
            this.mainScreenPanel.Size = new System.Drawing.Size(761, 413);
            this.mainScreenPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.White;
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.Controls.Add(this.ExitButton);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(68, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.ShadowDecoration.Parent = this.TitlePanel;
            this.TitlePanel.Size = new System.Drawing.Size(761, 54);
            this.TitlePanel.TabIndex = 6;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Indigo;
            this.Title.Location = new System.Drawing.Point(23, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 37);
            this.Title.TabIndex = 8;
            this.Title.Text = "Order Manager";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.ImageSize = new System.Drawing.Size(28, 28);
            this.ExitButton.Location = new System.Drawing.Point(706, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitButton.PressedState.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(41, 36);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.UseTransparentBackground = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(829, 467);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.mainScreenPanel);
            this.Controls.Add(this.mainToolsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainToolsPanel.ResumeLayout(false);
            this.HomeBtStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainToolsPanel;
        private Guna.UI2.WinForms.Guna2Panel mainScreenPanel;
        private Guna.UI2.WinForms.Guna2Panel TitlePanel;
        private Guna.UI2.WinForms.Guna2PictureBox appIcon;
        private Guna.UI2.WinForms.Guna2ImageButton ExitButton;
        private Guna.UI2.WinForms.Guna2ImageButton HomeButton;
        private Guna.UI2.WinForms.Guna2ImageButton AddOrderButton;
        private System.Windows.Forms.Panel HomeBtStrip;
        private Guna.UI2.WinForms.Guna2ImageButton DeleteOrderButton;
        private System.Windows.Forms.Panel DeleteOrderStrip;
        private System.Windows.Forms.Panel AddOrderStrip;
        private System.Windows.Forms.Panel SearchStrip;
        private Guna.UI2.WinForms.Guna2ImageButton SearchButton;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label Title;
    }
}

