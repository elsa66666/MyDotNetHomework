namespace homework4_1
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.treePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.depthSlider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lengthSlider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.per1Slider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.th2Slider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.th1Slider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.per2Slider = new Guna.UI2.WinForms.Guna2TrackBar();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depthValueLabel = new System.Windows.Forms.Label();
            this.lengthValueLabel = new System.Windows.Forms.Label();
            this.per1ValueLabel = new System.Windows.Forms.Label();
            this.per2ValueLabel = new System.Windows.Forms.Label();
            this.th1ValueLabel = new System.Windows.Forms.Label();
            this.th2ValueLabel = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Navy;
            this.guna2Button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(577, 489);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(139, 44);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "drawButton";
            this.guna2Button1.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // treePanel
            // 
            this.treePanel.FillColor = System.Drawing.Color.Navy;
            this.treePanel.Location = new System.Drawing.Point(66, 62);
            this.treePanel.Name = "treePanel";
            this.treePanel.ShadowDecoration.Parent = this.treePanel;
            this.treePanel.Size = new System.Drawing.Size(344, 344);
            this.treePanel.TabIndex = 1;
            // 
            // depthSlider
            // 
            this.depthSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.depthSlider.HoverState.Parent = this.depthSlider;
            this.depthSlider.IndicateFocus = false;
            this.depthSlider.Location = new System.Drawing.Point(577, 62);
            this.depthSlider.Maximum = 10;
            this.depthSlider.Minimum = 6;
            this.depthSlider.Name = "depthSlider";
            this.depthSlider.Size = new System.Drawing.Size(139, 30);
            this.depthSlider.TabIndex = 2;
            this.depthSlider.ThumbColor = System.Drawing.Color.Navy;
            this.depthSlider.Value = 8;
            // 
            // lengthSlider
            // 
            this.lengthSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lengthSlider.HoverState.Parent = this.lengthSlider;
            this.lengthSlider.IndicateFocus = false;
            this.lengthSlider.Location = new System.Drawing.Point(577, 124);
            this.lengthSlider.Minimum = 50;
            this.lengthSlider.Name = "lengthSlider";
            this.lengthSlider.Size = new System.Drawing.Size(139, 30);
            this.lengthSlider.TabIndex = 3;
            this.lengthSlider.ThumbColor = System.Drawing.Color.Navy;
            this.lengthSlider.Value = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "depth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "per1:";
            // 
            // per1Slider
            // 
            this.per1Slider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.per1Slider.HoverState.Parent = this.per1Slider;
            this.per1Slider.IndicateFocus = false;
            this.per1Slider.Location = new System.Drawing.Point(577, 187);
            this.per1Slider.Name = "per1Slider";
            this.per1Slider.Size = new System.Drawing.Size(139, 30);
            this.per1Slider.TabIndex = 7;
            this.per1Slider.ThumbColor = System.Drawing.Color.Navy;
            this.per1Slider.ValueChanged += new System.EventHandler(this.per1Slider_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "th2:";
            // 
            // th2Slider
            // 
            this.th2Slider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.th2Slider.HoverState.Parent = this.th2Slider;
            this.th2Slider.IndicateFocus = false;
            this.th2Slider.Location = new System.Drawing.Point(577, 376);
            this.th2Slider.Name = "th2Slider";
            this.th2Slider.Size = new System.Drawing.Size(139, 30);
            this.th2Slider.TabIndex = 13;
            this.th2Slider.ThumbColor = System.Drawing.Color.Navy;
            this.th2Slider.ValueChanged += new System.EventHandler(this.th2Slider_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "th1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "per2:";
            // 
            // th1Slider
            // 
            this.th1Slider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.th1Slider.HoverState.Parent = this.th1Slider;
            this.th1Slider.IndicateFocus = false;
            this.th1Slider.Location = new System.Drawing.Point(577, 313);
            this.th1Slider.Name = "th1Slider";
            this.th1Slider.Size = new System.Drawing.Size(139, 30);
            this.th1Slider.TabIndex = 10;
            this.th1Slider.ThumbColor = System.Drawing.Color.Navy;
            this.th1Slider.ValueChanged += new System.EventHandler(this.th1Slider_ValueChanged);
            // 
            // per2Slider
            // 
            this.per2Slider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.per2Slider.HoverState.Parent = this.per2Slider;
            this.per2Slider.IndicateFocus = false;
            this.per2Slider.Location = new System.Drawing.Point(577, 251);
            this.per2Slider.Name = "per2Slider";
            this.per2Slider.Size = new System.Drawing.Size(139, 30);
            this.per2Slider.TabIndex = 9;
            this.per2Slider.ThumbColor = System.Drawing.Color.Navy;
            this.per2Slider.ValueChanged += new System.EventHandler(this.per2Slider_ValueChanged);
            // 
            // colorBox
            // 
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "White",
            "Yellow",
            "Green"});
            this.colorBox.Location = new System.Drawing.Point(149, 435);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(232, 38);
            this.colorBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color:";
            // 
            // depthValueLabel
            // 
            this.depthValueLabel.AutoSize = true;
            this.depthValueLabel.Location = new System.Drawing.Point(738, 62);
            this.depthValueLabel.Name = "depthValueLabel";
            this.depthValueLabel.Size = new System.Drawing.Size(28, 30);
            this.depthValueLabel.TabIndex = 17;
            this.depthValueLabel.Text = "8";
            // 
            // lengthValueLabel
            // 
            this.lengthValueLabel.AutoSize = true;
            this.lengthValueLabel.Location = new System.Drawing.Point(738, 124);
            this.lengthValueLabel.Name = "lengthValueLabel";
            this.lengthValueLabel.Size = new System.Drawing.Size(43, 30);
            this.lengthValueLabel.TabIndex = 18;
            this.lengthValueLabel.Text = "75";
            // 
            // per1ValueLabel
            // 
            this.per1ValueLabel.AutoSize = true;
            this.per1ValueLabel.Location = new System.Drawing.Point(738, 187);
            this.per1ValueLabel.Name = "per1ValueLabel";
            this.per1ValueLabel.Size = new System.Drawing.Size(65, 30);
            this.per1ValueLabel.TabIndex = 19;
            this.per1ValueLabel.Text = "0.75";
            // 
            // per2ValueLabel
            // 
            this.per2ValueLabel.AutoSize = true;
            this.per2ValueLabel.Location = new System.Drawing.Point(738, 251);
            this.per2ValueLabel.Name = "per2ValueLabel";
            this.per2ValueLabel.Size = new System.Drawing.Size(65, 30);
            this.per2ValueLabel.TabIndex = 20;
            this.per2ValueLabel.Text = "0.75";
            // 
            // th1ValueLabel
            // 
            this.th1ValueLabel.AutoSize = true;
            this.th1ValueLabel.Location = new System.Drawing.Point(738, 313);
            this.th1ValueLabel.Name = "th1ValueLabel";
            this.th1ValueLabel.Size = new System.Drawing.Size(58, 30);
            this.th1ValueLabel.TabIndex = 21;
            this.th1ValueLabel.Text = "45°";
            // 
            // th2ValueLabel
            // 
            this.th2ValueLabel.AutoSize = true;
            this.th2ValueLabel.Location = new System.Drawing.Point(738, 376);
            this.th2ValueLabel.Name = "th2ValueLabel";
            this.th2ValueLabel.Size = new System.Drawing.Size(58, 30);
            this.th2ValueLabel.TabIndex = 22;
            this.th2ValueLabel.Text = "45°";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::homework4_1.Properties.Resources.exit;
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.Location = new System.Drawing.Point(800, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(23, 23);
            this.guna2ImageButton1.TabIndex = 23;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 560);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.th2ValueLabel);
            this.Controls.Add(this.th1ValueLabel);
            this.Controls.Add(this.per2ValueLabel);
            this.Controls.Add(this.per1ValueLabel);
            this.Controls.Add(this.lengthValueLabel);
            this.Controls.Add(this.depthValueLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.th2Slider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.th1Slider);
            this.Controls.Add(this.per2Slider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.per1Slider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthSlider);
            this.Controls.Add(this.depthSlider);
            this.Controls.Add(this.treePanel);
            this.Controls.Add(this.guna2Button1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel treePanel;
        private Guna.UI2.WinForms.Guna2TrackBar depthSlider;
        private Guna.UI2.WinForms.Guna2TrackBar lengthSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TrackBar per1Slider;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TrackBar th2Slider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TrackBar th1Slider;
        private Guna.UI2.WinForms.Guna2TrackBar per2Slider;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label depthValueLabel;
        private System.Windows.Forms.Label lengthValueLabel;
        private System.Windows.Forms.Label per1ValueLabel;
        private System.Windows.Forms.Label per2ValueLabel;
        private System.Windows.Forms.Label th1ValueLabel;
        private System.Windows.Forms.Label th2ValueLabel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}

