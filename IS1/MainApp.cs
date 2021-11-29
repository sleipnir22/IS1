using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS1
{
    public partial class MainApp : Form
    {
        private ListModel _models;
        private int _price;
        private (int, int) _batteryRange;
        private CPUtype _cpu = CPUtype.NoMatter;
        private int _ram;
        private int _drive;
        private int _camera;

        //Инициализация формы
        //Здесь читаем .JSON файл и преобразуем его в список соответствующих объектов
        public MainApp()
        {
            InitializeComponent();
            var path = "модели.json";
            var json = File.ReadAllText(path);
            _models = JsonConvert.DeserializeObject<ListModel>(json);
            batteryBox.SelectedIndex = 0;
            ramBox.SelectedIndex = 0;
            diagonalBox.SelectedIndex = 0;
            cpuBox.SelectedIndex = 0;
            driveBox.SelectedIndex = 0;
            _camera = Convert.ToInt32(cameraTextBox.Text);
        }
        //Имеет ли значение какой-то параметр
        private bool doesMatter(string text)
        {
            return text != "Не имеет значения";
        }

        #region Обработка событий нажатия кнопок
        private void button1_Click(object sender, EventArgs e)
        {
            var models = new List<Model>(_models.models);
            
            models.RemoveAll(r => _cpu < r.cpu || r.ram < _ram || _price < r.price
                || r.drive < _drive || r.camera < _camera || r.battery < _batteryRange.Item1);

            if (models.Count == 0)
            {
                MessageBox.Show("Не удалось подобрать смартфон с подходящей конфигурацией");
            }
            else
            {
                ModelsResult newform = new ModelsResult();
                newform.Show();
                newform.ShowResults(models);
            }
        }

        private void batteryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            var text = obj.SelectedItem.ToString();
            if (doesMatter(text))
            {
                var numbers = text.Split('-');
                _batteryRange = (Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
            }
            else
            {
                _batteryRange.Item1 = 0;
                _batteryRange.Item2 = 0;
            }
        }

        private void ramBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            var text = obj.SelectedItem.ToString();
            if (doesMatter(text)) { _ram = Convert.ToInt32(text); }
            else _ram = 0;
        }

        private void diagonalBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void driveBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            var text = obj.SelectedItem.ToString();
            if (doesMatter(text))
                _drive = Convert.ToInt32(text);
            else
                _drive = 0;
        }

        private void cpuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = sender as ComboBox;
            var text = obj.SelectedItem.ToString();
            if (doesMatter(text))
            {
                switch (text)
                {

                    case "A+":
                        _cpu = CPUtype.A;
                        return;
                    case "B":
                        _cpu = CPUtype.A;
                        return;
                    case "C":
                        _cpu = CPUtype.C;
                        return;
                    case "D":
                        _cpu = CPUtype.D;
                        return;
                    case "F":
                        _cpu = CPUtype.F;
                        return;
                }
            }
            else
            {
                _cpu = CPUtype.NoMatter;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _camera = 0;
                cameraTextBox.Enabled = false;
            }
            else
            {
                _camera = Convert.ToInt32(cameraTextBox.Text);
                cameraTextBox.Enabled = true;
            }
        }

        private void cameraTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            _camera = Convert.ToInt32(text);
        }
        #endregion Обработка событий нажатия кнопок

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            int myInt;
            bool isNumerical = int.TryParse(text, out myInt);
            if (isNumerical)
            {
                _price = Convert.ToInt32(text);
            }
            else
            {
                _price = 0;
            }
        }
    }
}
