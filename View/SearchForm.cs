using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс поиска информации о физическом упражнении.
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Делегат поиска физического упражнения.
        /// </summary>
        private readonly SearchDelegate _searchDelegate = null;

        /// <summary>
        /// Конструктор класса SearchForm.
        /// </summary>
        /// <param name="searchDelegate">Делегат поиска
        /// физического упражнения.</param>
        public SearchForm(SearchDelegate searchDelegate)
        {
            InitializeComponent();
            _searchDelegate = searchDelegate;
            CaloriesSpendTextBox.KeyPress += View.Validate.ValidateTextBox;
            ExerciseNameComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие при нажатии на кнопку найти.
        /// </summary>
        private void SearchExerciseButton_Click(object sender, EventArgs e)
        {
            Hide();
            PhysicalExercise physicalExercise = new PhysicalExercise
            {
                ExerciseName = ExerciseNameComboBox.SelectedItem.ToString()
            };
            if (!string.IsNullOrWhiteSpace(CaloriesSpendTextBox.Text))
                physicalExercise.CaloriesSpend =
                    Convert.ToDouble(CaloriesSpendTextBox.Text);
            else
                physicalExercise.CaloriesSpend = null;
            _searchDelegate(physicalExercise);
        }

        /// <summary>
        /// Событие при нажатии на кнопку отмена.
        /// </summary>
        private void ExitSearchButton_Click(object sender, EventArgs e)
        {
            Hide();
            PhysicalExercise physicalExercise = new PhysicalExercise
            {
                ExerciseName = "",
                CaloriesSpend = null
            };
            _searchDelegate(physicalExercise);
        }
    }
}