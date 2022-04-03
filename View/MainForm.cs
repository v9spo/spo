using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace View
{
    /// <summary>
    /// Делегат обновления информации в PhysicalExerciseDataGridView.
    /// </summary>
    public delegate void UpdatePhysicalExercise();

    /// <summary>
    /// Делегат поиска информации.
    /// </summary>
    /// <param name="physicalExercise">Информация о
    /// физическом упражнении.</param>
    public delegate void SearchDelegate(PhysicalExercise physicalExercise);

    /// <summary>
    /// Класс для описания действий над физическими упражнениями.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Конструктор класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Коллекция объектов для описания физических упражнений.
        /// </summary>
        private readonly List<PhysicalExercise> _physicalExercise =
            new List<PhysicalExercise>();

        /// <summary>
        /// Делегат обновления информации.
        /// </summary>
        private UpdatePhysicalExercise _updatePhysicalExercise = null;

        /// <summary>
        /// Объект для описания удаляемого упражнения. 
        /// </summary>
        private readonly PhysicalExercise _deletePhysicalExercise =
            new PhysicalExercise();

        /// <summary>
        /// Поле для описания пути к файлу. 
        /// </summary>
        private string _fileSaveLoad;

        /// <summary>
        /// Событие при загрузке формы MainForm.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _updatePhysicalExercise = UpdatePhysicalExerciseDataGridView;
        }

        /// <summary>
        /// Метод обновления информации 
        /// в  PhysicalExerciseDataGridView.
        /// </summary>
        internal void UpdatePhysicalExerciseDataGridView()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.SuspendBinding();
            bindingSource.DataSource = _physicalExercise;
            bindingSource.ResumeBinding();

            PhysicalExerciseDataGridView.DataSource = bindingSource;

            PhysicalExerciseDataGridView.Columns[0].HeaderText =
                "Название упражнения";
            PhysicalExerciseDataGridView.Columns[1].HeaderText =
                "Затраченные калории";

            PhysicalExerciseDataGridView.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            PhysicalExerciseDataGridView.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            PhysicalExerciseDataGridView.ClearSelection();
        }

        /// <summary>
        /// Событие вызова формы добавления
        /// информации о физическом упражнении.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(_physicalExercise,
                _updatePhysicalExercise);
            addForm.ShowDialog();
            UpdatePhysicalExerciseDataGridView();
            addForm.Dispose();
        }

        /// <summary>
        /// Событие при нажатии на кнопку удалить.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PhysicalExerciseDataGridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow physicalExersice in
                             this.PhysicalExerciseDataGridView.SelectedRows)
                {
                    _deletePhysicalExercise.ExerciseName =
                        PhysicalExerciseDataGridView[0,
                        physicalExersice.Index]
                        .Value.ToString();
                    _deletePhysicalExercise.CaloriesSpend =
                        Convert.ToDouble(PhysicalExerciseDataGridView[1,
                        physicalExersice.Index].Value);
                }

                foreach (var physicalExersice in _physicalExercise)
                {
                    if ((physicalExersice.ExerciseName ==
                        _deletePhysicalExercise.ExerciseName)
                        && (physicalExersice.CaloriesSpend ==
                        _deletePhysicalExercise.CaloriesSpend))
                    {
                        _physicalExercise.Remove(physicalExersice);
                        break;
                    }
                }
                UpdatePhysicalExerciseDataGridView();
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку загрузить.
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (_fileSaveLoad != null)
            {
                openDialog.InitialDirectory = _fileSaveLoad;
            }
            else
            {
                openDialog.InitialDirectory = Application.StartupPath;
            }
            openDialog.Filter = "Exercise *.exr|*.exr";
            openDialog.FilterIndex = 1;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                _fileSaveLoad = openDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream(
                    openDialog.FileName, FileMode.OpenOrCreate))
                {
                    try
                    {
                        List<PhysicalExercise> openlList =
                            (List<PhysicalExercise>)binaryFormatter
                            .Deserialize(fileStream);
                        if (_physicalExercise.Count > 0)
                        {
                            _physicalExercise.Clear();
                        }
                        foreach (var item in openlList)
                        {
                            _physicalExercise.Add(item);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось загрузить файл. Возможно он повреждён. \n");
                    }
                }
                UpdatePhysicalExerciseDataGridView();
            }
            openDialog.Dispose();
        }

        /// <summary>
        /// Событие при нажатии на кнопку сохранить.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            if (_fileSaveLoad != null)
            {
                saveDialog.InitialDirectory = _fileSaveLoad;
            }
            else
            {
                saveDialog.InitialDirectory = Application.StartupPath;
            }
            saveDialog.Filter = "Exercise *.exr|*.exr";
            saveDialog.FilterIndex = 1;

            List<PhysicalExercise> saveList = new List<PhysicalExercise>();
            foreach (var exercise in _physicalExercise)
            {
                saveList.Add(exercise);
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                _fileSaveLoad = saveDialog.FileName;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream(
                    saveDialog.FileName, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(fileStream, saveList);
                }
            }
            saveDialog.Dispose();
        }

        /// <summary>
        /// Событие при нажатии на кнопку найти.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm =
                new SearchForm(new SearchDelegate(SearchPhysicalExercise));
            searchForm.ShowDialog();
            searchForm.Dispose();
        }

        /// <summary>
        /// Метод поиска информации о физическом упражнении.
        /// </summary>
        /// <param name="physicalExercise">Объект хранящий
        /// параметры физического упражнения.</param>
        private void SearchPhysicalExercise(PhysicalExercise
            physicalExercise)
        {
            PhysicalExerciseDataGridView.ClearSelection();
            for (int i = 0; i < PhysicalExerciseDataGridView
                .RowCount; i++)
            {
                PhysicalExerciseDataGridView.Rows[i].DefaultCellStyle
                    .BackColor = Color.White;
            }

            if (physicalExercise.CaloriesSpend != null)
            {
                for (int i = 0; i < PhysicalExerciseDataGridView
                    .RowCount; i++)
                {
                    if ((PhysicalExerciseDataGridView.Rows[i].Cells[0]
                        .Value.ToString()) == physicalExercise.ExerciseName
                        .ToString() && ((double)PhysicalExerciseDataGridView
                        .Rows[i].Cells[1].Value ==
                        physicalExercise.CaloriesSpend))
                    {
                        PhysicalExerciseDataGridView.Rows[i]
                            .DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    }
                    else
                    {
                        PhysicalExerciseDataGridView.Rows[i]
                            .DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            else
            {
                for (int i = 0; i < PhysicalExerciseDataGridView
                    .RowCount; i++)
                {

                    if ((PhysicalExerciseDataGridView.Rows[i].Cells[0]
                        .Value.ToString()) == physicalExercise.ExerciseName
                        .ToString())
                    {
                        PhysicalExerciseDataGridView.Rows[i]
                            .DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    }
                    else
                    {
                        PhysicalExerciseDataGridView.Rows[i]
                            .DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Событие при нажатии на кнопку выход.
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}