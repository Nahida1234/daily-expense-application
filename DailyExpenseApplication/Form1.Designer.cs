namespace DailyExpenseApplication
{
    partial class dailyExpenseAppForm
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
            this.dailyExpenseEntryLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.categoryLeftComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.viewSummaryLabel = new System.Windows.Forms.Label();
            this.showLeftButton = new System.Windows.Forms.Button();
            this.totalexpenseTextBox = new System.Windows.Forms.TextBox();
            this.maximumexpenseTextBox = new System.Windows.Forms.TextBox();
            this.viewCategorywiseEnpenseLabel = new System.Windows.Forms.Label();
            this.categoryRightComboBox = new System.Windows.Forms.ComboBox();
            this.showRightButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dailyExpenseEntryLabel
            // 
            this.dailyExpenseEntryLabel.AutoSize = true;
            this.dailyExpenseEntryLabel.Location = new System.Drawing.Point(9, 21);
            this.dailyExpenseEntryLabel.Name = "dailyExpenseEntryLabel";
            this.dailyExpenseEntryLabel.Size = new System.Drawing.Size(101, 13);
            this.dailyExpenseEntryLabel.TabIndex = 0;
            this.dailyExpenseEntryLabel.Text = "Daily Expense Entry";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(124, 58);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(151, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // categoryLeftComboBox
            // 
            this.categoryLeftComboBox.FormattingEnabled = true;
            this.categoryLeftComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryLeftComboBox.Location = new System.Drawing.Point(124, 93);
            this.categoryLeftComboBox.Name = "categoryLeftComboBox";
            this.categoryLeftComboBox.Size = new System.Drawing.Size(151, 21);
            this.categoryLeftComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category";
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(124, 143);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(151, 42);
            this.particularTextBox.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(707, 181);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(193, 134);
            this.listBox2.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(200, 202);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // viewSummaryLabel
            // 
            this.viewSummaryLabel.AutoSize = true;
            this.viewSummaryLabel.Location = new System.Drawing.Point(12, 272);
            this.viewSummaryLabel.Name = "viewSummaryLabel";
            this.viewSummaryLabel.Size = new System.Drawing.Size(76, 13);
            this.viewSummaryLabel.TabIndex = 5;
            this.viewSummaryLabel.Text = "View Summary";
            // 
            // showLeftButton
            // 
            this.showLeftButton.Location = new System.Drawing.Point(200, 292);
            this.showLeftButton.Name = "showLeftButton";
            this.showLeftButton.Size = new System.Drawing.Size(75, 23);
            this.showLeftButton.TabIndex = 6;
            this.showLeftButton.Text = "Show";
            this.showLeftButton.UseVisualStyleBackColor = true;
            this.showLeftButton.Click += new System.EventHandler(this.showLeftButton_Click);
            // 
            // totalexpenseTextBox
            // 
            this.totalexpenseTextBox.Location = new System.Drawing.Point(124, 344);
            this.totalexpenseTextBox.Name = "totalexpenseTextBox";
            this.totalexpenseTextBox.Size = new System.Drawing.Size(151, 20);
            this.totalexpenseTextBox.TabIndex = 7;
            // 
            // maximumexpenseTextBox
            // 
            this.maximumexpenseTextBox.Location = new System.Drawing.Point(124, 380);
            this.maximumexpenseTextBox.Name = "maximumexpenseTextBox";
            this.maximumexpenseTextBox.Size = new System.Drawing.Size(151, 20);
            this.maximumexpenseTextBox.TabIndex = 8;
            // 
            // viewCategorywiseEnpenseLabel
            // 
            this.viewCategorywiseEnpenseLabel.AutoSize = true;
            this.viewCategorywiseEnpenseLabel.Location = new System.Drawing.Point(576, 43);
            this.viewCategorywiseEnpenseLabel.Name = "viewCategorywiseEnpenseLabel";
            this.viewCategorywiseEnpenseLabel.Size = new System.Drawing.Size(140, 13);
            this.viewCategorywiseEnpenseLabel.TabIndex = 9;
            this.viewCategorywiseEnpenseLabel.Text = "View Categorywise Expense";
            // 
            // categoryRightComboBox
            // 
            this.categoryRightComboBox.FormattingEnabled = true;
            this.categoryRightComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryRightComboBox.Location = new System.Drawing.Point(731, 79);
            this.categoryRightComboBox.Name = "categoryRightComboBox";
            this.categoryRightComboBox.Size = new System.Drawing.Size(169, 21);
            this.categoryRightComboBox.TabIndex = 10;
            // 
            // showRightButton
            // 
            this.showRightButton.Location = new System.Drawing.Point(815, 129);
            this.showRightButton.Name = "showRightButton";
            this.showRightButton.Size = new System.Drawing.Size(75, 23);
            this.showRightButton.TabIndex = 11;
            this.showRightButton.Text = "Show";
            this.showRightButton.UseVisualStyleBackColor = true;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(731, 360);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(169, 20);
            this.totalTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Particular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Maximum Expense";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Category";
            // 
            // dailyExpenseAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.showRightButton);
            this.Controls.Add(this.categoryRightComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.viewCategorywiseEnpenseLabel);
            this.Controls.Add(this.maximumexpenseTextBox);
            this.Controls.Add(this.totalexpenseTextBox);
            this.Controls.Add(this.showLeftButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.viewSummaryLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.particularTextBox);
            this.Controls.Add(this.categoryLeftComboBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dailyExpenseEntryLabel);
            this.Name = "dailyExpenseAppForm";
            this.Text = "Daily Expense Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dailyExpenseEntryLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox categoryLeftComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label viewSummaryLabel;
        private System.Windows.Forms.Button showLeftButton;
        private System.Windows.Forms.TextBox totalexpenseTextBox;
        private System.Windows.Forms.TextBox maximumexpenseTextBox;
        private System.Windows.Forms.Label viewCategorywiseEnpenseLabel;
        private System.Windows.Forms.ComboBox categoryRightComboBox;
        private System.Windows.Forms.Button showRightButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

