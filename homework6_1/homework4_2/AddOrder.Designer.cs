namespace homework4_2
{
    partial class AddOrder
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddOrderDtGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddOrderLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.AddOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LabelTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitPriceTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.amountNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.userNameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.finishButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddOrderDtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrderDtGridView
            // 
            this.AddOrderDtGridView.AllowDrop = true;
            this.AddOrderDtGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.AddOrderDtGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AddOrderDtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddOrderDtGridView.BackgroundColor = System.Drawing.Color.White;
            this.AddOrderDtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddOrderDtGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AddOrderDtGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddOrderDtGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AddOrderDtGridView.ColumnHeadersHeight = 35;
            this.AddOrderDtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Label,
            this.Amount,
            this.UnitPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AddOrderDtGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AddOrderDtGridView.EnableHeadersVisualStyles = false;
            this.AddOrderDtGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AddOrderDtGridView.Location = new System.Drawing.Point(35, 228);
            this.AddOrderDtGridView.Name = "AddOrderDtGridView";
            this.AddOrderDtGridView.ReadOnly = true;
            this.AddOrderDtGridView.RowHeadersVisible = false;
            this.AddOrderDtGridView.RowHeadersWidth = 70;
            this.AddOrderDtGridView.RowTemplate.Height = 60;
            this.AddOrderDtGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddOrderDtGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddOrderDtGridView.Size = new System.Drawing.Size(657, 172);
            this.AddOrderDtGridView.StandardTab = true;
            this.AddOrderDtGridView.TabIndex = 1;
            this.AddOrderDtGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.AddOrderDtGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AddOrderDtGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderDtGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AddOrderDtGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AddOrderDtGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AddOrderDtGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AddOrderDtGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AddOrderDtGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Indigo;
            this.AddOrderDtGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AddOrderDtGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderDtGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AddOrderDtGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AddOrderDtGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.AddOrderDtGridView.ThemeStyle.ReadOnly = true;
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.Height = 60;
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AddOrderDtGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ID
            // 
            this.ID.FillWeight = 90.90909F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Label
            // 
            this.Label.FillWeight = 103.0303F;
            this.Label.HeaderText = "Label";
            this.Label.MinimumWidth = 8;
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 103.0303F;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 103.0303F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 8;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // AddOrderLabel
            // 
            this.AddOrderLabel.AutoSize = true;
            this.AddOrderLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderLabel.ForeColor = System.Drawing.Color.Indigo;
            this.AddOrderLabel.Location = new System.Drawing.Point(30, 21);
            this.AddOrderLabel.Name = "AddOrderLabel";
            this.AddOrderLabel.Size = new System.Drawing.Size(164, 37);
            this.AddOrderLabel.TabIndex = 2;
            this.AddOrderLabel.Text = "Add Order";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Indigo;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(35, 55);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(657, 3);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.CheckedState.Parent = this.AddOrderButton;
            this.AddOrderButton.CustomImages.Parent = this.AddOrderButton;
            this.AddOrderButton.FillColor = System.Drawing.Color.Indigo;
            this.AddOrderButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.HoverState.Parent = this.AddOrderButton;
            this.AddOrderButton.Location = new System.Drawing.Point(604, 193);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.ShadowDecoration.Parent = this.AddOrderButton;
            this.AddOrderButton.Size = new System.Drawing.Size(88, 29);
            this.AddOrderButton.TabIndex = 4;
            this.AddOrderButton.Text = "ADD";
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Indigo;
            this.NameLabel.Location = new System.Drawing.Point(44, 86);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(140, 26);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name of item :";
            // 
            // LabelTextBox
            // 
            this.LabelTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LabelTextBox.DefaultText = "";
            this.LabelTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LabelTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LabelTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LabelTextBox.DisabledState.Parent = this.LabelTextBox;
            this.LabelTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LabelTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LabelTextBox.FocusedState.Parent = this.LabelTextBox;
            this.LabelTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LabelTextBox.HoverState.Parent = this.LabelTextBox;
            this.LabelTextBox.Location = new System.Drawing.Point(176, 88);
            this.LabelTextBox.Name = "LabelTextBox";
            this.LabelTextBox.PasswordChar = '\0';
            this.LabelTextBox.PlaceholderText = "";
            this.LabelTextBox.SelectedText = "";
            this.LabelTextBox.ShadowDecoration.Parent = this.LabelTextBox;
            this.LabelTextBox.Size = new System.Drawing.Size(182, 24);
            this.LabelTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(77, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(66, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unit Price :";
            // 
            // unitPriceTB
            // 
            this.unitPriceTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitPriceTB.DefaultText = "";
            this.unitPriceTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unitPriceTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unitPriceTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitPriceTB.DisabledState.Parent = this.unitPriceTB;
            this.unitPriceTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unitPriceTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitPriceTB.FocusedState.Parent = this.unitPriceTB;
            this.unitPriceTB.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unitPriceTB.HoverState.Parent = this.unitPriceTB;
            this.unitPriceTB.Location = new System.Drawing.Point(176, 172);
            this.unitPriceTB.Name = "unitPriceTB";
            this.unitPriceTB.PasswordChar = '\0';
            this.unitPriceTB.PlaceholderText = "";
            this.unitPriceTB.SelectedText = "";
            this.unitPriceTB.ShadowDecoration.Parent = this.unitPriceTB;
            this.unitPriceTB.Size = new System.Drawing.Size(182, 22);
            this.unitPriceTB.TabIndex = 10;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.amountNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountNumericUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountNumericUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountNumericUpDown.DisabledState.Parent = this.amountNumericUpDown;
            this.amountNumericUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.amountNumericUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.amountNumericUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountNumericUpDown.FocusedState.Parent = this.amountNumericUpDown;
            this.amountNumericUpDown.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.amountNumericUpDown.Location = new System.Drawing.Point(176, 129);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.ShadowDecoration.Parent = this.amountNumericUpDown;
            this.amountNumericUpDown.Size = new System.Drawing.Size(200, 24);
            this.amountNumericUpDown.TabIndex = 11;
            this.amountNumericUpDown.UpDownButtonFillColor = System.Drawing.Color.Lavender;
            // 
            // userNameTB
            // 
            this.userNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTB.DefaultText = "";
            this.userNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTB.DisabledState.Parent = this.userNameTB;
            this.userNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTB.FocusedState.Parent = this.userNameTB;
            this.userNameTB.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userNameTB.HoverState.Parent = this.userNameTB;
            this.userNameTB.Location = new System.Drawing.Point(510, 88);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.PasswordChar = '\0';
            this.userNameTB.PlaceholderText = "";
            this.userNameTB.SelectedText = "";
            this.userNameTB.ShadowDecoration.Parent = this.userNameTB;
            this.userNameTB.Size = new System.Drawing.Size(182, 24);
            this.userNameTB.TabIndex = 13;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Indigo;
            this.userName.Location = new System.Drawing.Point(414, 86);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(140, 26);
            this.userName.TabIndex = 12;
            this.userName.Text = "username:";
            // 
            // finishButton
            // 
            this.finishButton.CheckedState.Parent = this.finishButton;
            this.finishButton.CustomImages.Parent = this.finishButton;
            this.finishButton.FillColor = System.Drawing.Color.Indigo;
            this.finishButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.HoverState.Parent = this.finishButton;
            this.finishButton.Location = new System.Drawing.Point(604, 20);
            this.finishButton.Name = "finishButton";
            this.finishButton.ShadowDecoration.Parent = this.finishButton;
            this.finishButton.Size = new System.Drawing.Size(88, 29);
            this.finishButton.TabIndex = 14;
            this.finishButton.Text = "Finish";
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.unitPriceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.AddOrderLabel);
            this.Controls.Add(this.AddOrderDtGridView);
            this.Name = "AddOrder";
            this.Size = new System.Drawing.Size(758, 413);
            ((System.ComponentModel.ISupportInitialize)(this.AddOrderDtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView AddOrderDtGridView;
        private System.Windows.Forms.Label AddOrderLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button AddOrderButton;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2TextBox LabelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox unitPriceTB;
        private Guna.UI2.WinForms.Guna2NumericUpDown amountNumericUpDown;
        private Guna.UI2.WinForms.Guna2TextBox userNameTB;
        private System.Windows.Forms.Label userName;
        private Guna.UI2.WinForms.Guna2Button finishButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}
