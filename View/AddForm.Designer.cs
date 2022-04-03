
namespace View
{
    partial class AddForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.RandomValueButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SwimmingEnumComboBox = new System.Windows.Forms.ComboBox();
            this.item2TextBox = new System.Windows.Forms.TextBox();
            this.item1TextBox = new System.Windows.Forms.TextBox();
            this.exersice2Label = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.ExerciseNameComboBox = new System.Windows.Forms.ComboBox();
            this.ExerciseTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(272, 90);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 36);
            this.ExitButton.TabIndex = 31;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RandomValueButton
            // 
            this.RandomValueButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RandomValueButton.Location = new System.Drawing.Point(101, 90);
            this.RandomValueButton.Name = "RandomValueButton";
            this.RandomValueButton.Size = new System.Drawing.Size(165, 36);
            this.RandomValueButton.TabIndex = 30;
            this.RandomValueButton.Text = "Случайное значение";
            this.RandomValueButton.UseVisualStyleBackColor = false;
            this.RandomValueButton.Click += new System.EventHandler(this.RandomValueButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.Location = new System.Drawing.Point(15, 90);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 36);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "OK";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SwimmingEnumComboBox
            // 
            this.SwimmingEnumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SwimmingEnumComboBox.FormattingEnabled = true;
            this.SwimmingEnumComboBox.ItemHeight = 13;
            this.SwimmingEnumComboBox.Items.AddRange(new object[] {
            "Брасс",
            "Баттерфляй",
            "Кроль"});
            this.SwimmingEnumComboBox.Location = new System.Drawing.Point(148, 38);
            this.SwimmingEnumComboBox.Name = "SwimmingEnumComboBox";
            this.SwimmingEnumComboBox.Size = new System.Drawing.Size(204, 21);
            this.SwimmingEnumComboBox.TabIndex = 28;
            // 
            // item2TextBox
            // 
            this.item2TextBox.Location = new System.Drawing.Point(148, 64);
            this.item2TextBox.Name = "item2TextBox";
            this.item2TextBox.Size = new System.Drawing.Size(204, 20);
            this.item2TextBox.TabIndex = 27;
            // 
            // item1TextBox
            // 
            this.item1TextBox.Location = new System.Drawing.Point(148, 38);
            this.item1TextBox.Name = "item1TextBox";
            this.item1TextBox.Size = new System.Drawing.Size(204, 20);
            this.item1TextBox.TabIndex = 26;
            // 
            // exersice2Label
            // 
            this.exersice2Label.AutoSize = true;
            this.exersice2Label.Location = new System.Drawing.Point(12, 67);
            this.exersice2Label.Name = "exersice2Label";
            this.exersice2Label.Size = new System.Drawing.Size(58, 13);
            this.exersice2Label.TabIndex = 24;
            this.exersice2Label.Text = "item2Label";
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Location = new System.Drawing.Point(12, 41);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(58, 13);
            this.item1Label.TabIndex = 25;
            this.item1Label.Text = "item1Label";
            // 
            // ExerciseNameComboBox
            // 
            this.ExerciseNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExerciseNameComboBox.FormattingEnabled = true;
            this.ExerciseNameComboBox.ItemHeight = 13;
            this.ExerciseNameComboBox.Items.AddRange(new object[] {
            "Бег",
            "Плавание",
            "Жим штанги"});
            this.ExerciseNameComboBox.Location = new System.Drawing.Point(148, 6);
            this.ExerciseNameComboBox.Name = "ExerciseNameComboBox";
            this.ExerciseNameComboBox.Size = new System.Drawing.Size(204, 21);
            this.ExerciseNameComboBox.TabIndex = 23;
            this.ExerciseNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ExerciseNameComboBox_SelectedIndexChanged);
            // 
            // ExerciseTypeLabel
            // 
            this.ExerciseTypeLabel.AutoSize = true;
            this.ExerciseTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.ExerciseTypeLabel.Name = "ExerciseTypeLabel";
            this.ExerciseTypeLabel.Size = new System.Drawing.Size(121, 13);
            this.ExerciseTypeLabel.TabIndex = 22;
            this.ExerciseTypeLabel.Text = "Название упражнения";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 138);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RandomValueButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SwimmingEnumComboBox);
            this.Controls.Add(this.item2TextBox);
            this.Controls.Add(this.item1TextBox);
            this.Controls.Add(this.exersice2Label);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.ExerciseNameComboBox);
            this.Controls.Add(this.ExerciseTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 177);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 177);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление информации";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RandomValueButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox SwimmingEnumComboBox;
        private System.Windows.Forms.TextBox item2TextBox;
        private System.Windows.Forms.TextBox item1TextBox;
        private System.Windows.Forms.Label exersice2Label;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.ComboBox ExerciseNameComboBox;
        private System.Windows.Forms.Label ExerciseTypeLabel;
    }
}