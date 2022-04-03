#define Debug
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    ///  Класс добавления информации о физическом упражнении.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Коллекция c информацией о физических упражнениях.
        /// </summary>
        private readonly List<PhysicalExercise> _physicalExercise;

        /// <summary>
        /// Делегат обновления информации в таблице.
        /// </summary>
        private readonly UpdatePhysicalExercise
            _updatePhysicalExercise;

        /// <summary>
        /// Конструктор класса AddForm.
        /// </summary>
        /// <param name="physicalExercise">Коллекция с информацией
        /// о физическом упражнени.</param>
        /// <param name="updatePhysicalExercise">Делегат обновления
        /// информации.</param>
        public AddForm(List<PhysicalExercise> physicalExercise,
            UpdatePhysicalExercise updatePhysicalExercise)
        {
            InitializeComponent();
            _physicalExercise = physicalExercise;
            _updatePhysicalExercise = updatePhysicalExercise;
            ExerciseNameComboBox.SelectedIndex = 0;
#if Release
            this.RandomValueButton.Visible = false;
#elif Debug
            this.RandomValueButton.Visible = true;
#endif
        }

        /// <summary>
        /// Событие при загрузке формы.
        /// </summary>
        private void AddForm_Load(object sender, EventArgs e)
        {
            item1TextBox.KeyPress += View.Validate.ValidateTextBox;
            item2TextBox.KeyPress += View.Validate.ValidateTextBox;
        }

        /// <summary>
        /// Событие при выборе упражнения.
        /// </summary>
        private void ExerciseNameComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            item1TextBox.Text = string.Empty;
            item2TextBox.Text = string.Empty;

            switch (ExerciseNameComboBox.SelectedIndex)
            {
                case 0:
                    item1Label.Text = "Интенсивность";
                    exersice2Label.Text = "Дистанция";

                    item1TextBox.Visible = true;
                    item2TextBox.Visible = true;
                    SwimmingEnumComboBox.Visible = false;
                    break;
                case 1:
                    item1Label.Text = "Стиль плавания";
                    exersice2Label.Text = "Дистанция";
                    SwimmingEnumComboBox.SelectedIndex = 0;

                    item1TextBox.Visible = false;
                    item2TextBox.Visible = true;
                    SwimmingEnumComboBox.Visible = true;
                    break;
                case 2:
                    item1Label.Text = "Вес штанги";
                    exersice2Label.Text = "Количество повторений";

                    item1TextBox.Visible = true;
                    item2TextBox.Visible = true;
                    SwimmingEnumComboBox.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку OK
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string errorText = string.Empty;
            try
            {
                switch (ExerciseNameComboBox.SelectedIndex)
                {
                    case 0:
                        if (item1TextBox.Text == string.Empty)
                        {
                            errorText += "Необходимо ввести " +
                                "интенсивность бега.\n";
                        }
                        if (item2TextBox.Text == string.Empty)
                        {
                            errorText += "Необходимо " +
                                "ввести дистанцию.\n";
                        }
                        if (errorText == string.Empty)
                        {
                            ExercisePhysicalBase runExercise =
                                new Run(Convert
                                .ToDouble(item1TextBox.Text),
                                Convert.ToDouble(item2TextBox
                                .Text));
                            AddExercise(runExercise);
                        }
                        break;
                    case 1:
                        if (item2TextBox.Text == string.Empty)
                        {
                            errorText += "Необходимо" +
                                " ввести дистанцию.\n";
                        }
                        if (errorText == string.Empty)
                        {
                            SwimmingEnum swimmingStyle =
                                (SwimmingEnum)SwimmingEnumComboBox
                                .SelectedIndex;
                            ExercisePhysicalBase swimmingExercise =
                                new Swimming(swimmingStyle,
                                Convert.ToDouble(item2TextBox
                                .Text));
                            AddExercise(swimmingExercise);
                        }
                        break;
                    case 2:
                        if (item1TextBox.Text == string.Empty)
                        {
                            errorText += "Необходимо ввести " +
                                "вес штанги.\n";
                        }
                        if (item2TextBox.Text == string.Empty)
                        {
                            errorText += "Необходимо ввести " +
                                "количество повторений.\n";
                        }
                        if (errorText == string.Empty)
                        {
                            ExercisePhysicalBase 
                                barbellBrenchExercise = new 
                                BarbellBrench(Convert
                                .ToDouble(item1TextBox.Text),
                                Convert.ToDouble(item2TextBox
                                .Text));
                            AddExercise(barbellBrenchExercise);
                        }
                        break;
                }
                if (errorText != string.Empty)
                {
                    MessageBox.Show(errorText, "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                    Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод добавления информации об упражнении.
        /// </summary>
        /// <param name="exercisePhysical">Объект с информацией
        /// об упражнении.</param>
        private void AddExercise(ExercisePhysicalBase
            exercisePhysical)
        {
            _physicalExercise.Add(new PhysicalExercise
            {
                ExerciseName = ExerciseNameComboBox.Text,
                CaloriesSpend = (double?)decimal.Round(
                    Convert.ToDecimal(exercisePhysical
                    .NumberCaloriesSpend), 3,
                    MidpointRounding.ToEven)
            });
        }

        /// <summary>
        /// Событие при нажатии на кнопку случайное значение.
        /// </summary>
        private void RandomValueButton_Click(object sender,
            EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0,
                ExerciseNameComboBox.Items.Count);
            ExerciseNameComboBox.SelectedIndex = randomNumber;
            Thread.Sleep(7);
            switch (ExerciseNameComboBox.SelectedIndex)
            {
                case 0:
                    item1TextBox.Text = random
                        .Next(ExercisePhysicalBase
                        .minValue + 1, Run.maxIntensity)
                        .ToString();
                    item2TextBox.Text = random
                        .Next(ExercisePhysicalBase
                        .minValue + 1, Run.maxDistance)
                        .ToString();
                    break;
                case 1:
                    SwimmingEnumComboBox.SelectedIndex = random
                        .Next(0, SwimmingEnumComboBox.Items.Count);
                    item2TextBox.Text = random
                        .Next(ExercisePhysicalBase
                        .minValue + 1,
                        Swimming.maxDistance).ToString();
                    break;
                case 2:
                    item1TextBox.Text = random
                        .Next(ExercisePhysicalBase
                        .minValue + 1,
                        BarbellBrench.maxWeigth).ToString();
                    item2TextBox.Text = random
                        .Next(ExercisePhysicalBase
                        .minValue + 1,
                        BarbellBrench.maxNumber).ToString();
                    break;
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку отмена.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (_physicalExercise.Count > 0)
                _updatePhysicalExercise();
        }
    }
}