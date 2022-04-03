
namespace View
{
    partial class SearchForm
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
            this.ExitSearchButton = new System.Windows.Forms.Button();
            this.SearchExerciseButton = new System.Windows.Forms.Button();
            this.CaloriesSpendTextBox = new System.Windows.Forms.TextBox();
            this.CaloriesSpendLabel = new System.Windows.Forms.Label();
            this.ExerciseNameComboBox = new System.Windows.Forms.ComboBox();
            this.ExerciseNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitSearchButton
            // 
            this.ExitSearchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitSearchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitSearchButton.Location = new System.Drawing.Point(174, 72);
            this.ExitSearchButton.Name = "ExitSearchButton";
            this.ExitSearchButton.Size = new System.Drawing.Size(129, 36);
            this.ExitSearchButton.TabIndex = 30;
            this.ExitSearchButton.Text = "Отмена";
            this.ExitSearchButton.UseVisualStyleBackColor = false;
            this.ExitSearchButton.Click += new System.EventHandler(this.ExitSearchButton_Click);
            // 
            // SearchExerciseButton
            // 
            this.SearchExerciseButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SearchExerciseButton.Location = new System.Drawing.Point(15, 72);
            this.SearchExerciseButton.Name = "SearchExerciseButton";
            this.SearchExerciseButton.Size = new System.Drawing.Size(128, 36);
            this.SearchExerciseButton.TabIndex = 29;
            this.SearchExerciseButton.Text = "Поиск";
            this.SearchExerciseButton.UseVisualStyleBackColor = false;
            this.SearchExerciseButton.Click += new System.EventHandler(this.SearchExerciseButton_Click);
            // 
            // CaloriesSpendTextBox
            // 
            this.CaloriesSpendTextBox.Location = new System.Drawing.Point(157, 38);
            this.CaloriesSpendTextBox.Name = "CaloriesSpendTextBox";
            this.CaloriesSpendTextBox.Size = new System.Drawing.Size(146, 20);
            this.CaloriesSpendTextBox.TabIndex = 28;
            // 
            // CaloriesSpendLabel
            // 
            this.CaloriesSpendLabel.AutoSize = true;
            this.CaloriesSpendLabel.Location = new System.Drawing.Point(12, 45);
            this.CaloriesSpendLabel.Name = "CaloriesSpendLabel";
            this.CaloriesSpendLabel.Size = new System.Drawing.Size(119, 13);
            this.CaloriesSpendLabel.TabIndex = 27;
            this.CaloriesSpendLabel.Text = "Затраченные калории";
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
            this.ExerciseNameComboBox.Location = new System.Drawing.Point(157, 11);
            this.ExerciseNameComboBox.Name = "ExerciseNameComboBox";
            this.ExerciseNameComboBox.Size = new System.Drawing.Size(146, 21);
            this.ExerciseNameComboBox.TabIndex = 26;
            // 
            // ExerciseNameLabel
            // 
            this.ExerciseNameLabel.AutoSize = true;
            this.ExerciseNameLabel.Location = new System.Drawing.Point(12, 18);
            this.ExerciseNameLabel.Name = "ExerciseNameLabel";
            this.ExerciseNameLabel.Size = new System.Drawing.Size(121, 13);
            this.ExerciseNameLabel.TabIndex = 25;
            this.ExerciseNameLabel.Text = "Название упражнения";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 116);
            this.Controls.Add(this.ExitSearchButton);
            this.Controls.Add(this.SearchExerciseButton);
            this.Controls.Add(this.CaloriesSpendTextBox);
            this.Controls.Add(this.CaloriesSpendLabel);
            this.Controls.Add(this.ExerciseNameComboBox);
            this.Controls.Add(this.ExerciseNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 155);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 155);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск информации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitSearchButton;
        private System.Windows.Forms.Button SearchExerciseButton;
        private System.Windows.Forms.TextBox CaloriesSpendTextBox;
        private System.Windows.Forms.Label CaloriesSpendLabel;
        private System.Windows.Forms.ComboBox ExerciseNameComboBox;
        private System.Windows.Forms.Label ExerciseNameLabel;
    }
}