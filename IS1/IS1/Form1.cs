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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace IS1
{
    public partial class Form1 : Form
    {
        private ListModel _models;
        private string _chosenType;
        private int _price;
        public Form1()
        {
            InitializeComponent();
            _price = Convert.ToInt32(textBox1.Text);
            string json = File.ReadAllText("модели.json");
            _models = JsonConvert.DeserializeObject<ListModel>(json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var models = new List<Model>(_models.models);

            models.RemoveAll(r => r.price >= _price);
            if (models.Count != 0)
            {
                if (_chosenType == "Пользовательский")
                {
                    Predicate<Model> pred = r =>
                        (r.cpu == CPUtype.B || r.cpu == CPUtype.C || r.cpu == CPUtype.D && r.camera < 30 && r.ram < 8);
                    HandleUserModel(models, pred);
                    return;
                }
                if (_chosenType == "Игровой")
                {
                    Predicate<Model> pred = r =>
                        r.cpu == CPUtype.A && r.battery >= 4000 && r.ram >= 4;
                    HandleGamerModel(models, pred);
                    return;
                }
                if (_chosenType == "Мультимедийный")
                {
                    Predicate<Model> pred = r =>
                        r.cpu == CPUtype.A && r.ram >= 4 && r.drive >= 256;
                    HandleMultiMediaModel(models, pred);
                    return;
                }
                if (_chosenType == "Рабочий")
                {
                    Predicate<Model> pred = r =>
                     ((r.cpu == CPUtype.B || r.cpu == CPUtype.C || r.cpu == CPUtype.D) && r.camera < 50
                        && r.battery >= 3500);
                    HandleWorkingModel(models, pred);
                    return;
                }
                else
                    MessageBox.Show("Выберите категорию!");
            }
            else if (_chosenType != null)
                MessageBox.Show($"Не удалось подобрать {_chosenType.ToLower()} смартфон");
            else MessageBox.Show("Введите цену!");

        }
        private void HandleGamerModel(List<Model> models, Predicate<Model> pred)
        {
            if (models.Exists(pred))
            {
                models.RemoveAll(m => !pred(m));
            }
            else
            { 
                MessageBox.Show("Не удалось подобрать игровой смартфон");
                return;
            }
            var max = models.Max(a => a.price);
            var result = models.FirstOrDefault(a => a.price == max);
            ChooseModel(result);
        }
        private void HandleUserModel(List<Model> models, Predicate<Model> pred)
        {
            if (models.Exists(pred))
            {
                models.RemoveAll(m => !pred(m));
            }
            else
            {
                MessageBox.Show("Не удалось подобрать пользовательский смартфон");
                return;
            }
            var max = models.Max(a => a.price);
            var result = models.FirstOrDefault(a => a.price == max);
            ChooseModel(result);
        }
        private void HandleMultiMediaModel(List<Model> models, Predicate<Model> pred)
        {
            if (models.Exists(pred))
            {
                models.RemoveAll(m => !pred(m));
            }
            else
            {
                MessageBox.Show("Не удалось мультимедийный смартфон");
                return;
            }
            var max = models.Max(a => a.price);
            var result = models.FirstOrDefault(a => a.price == max);
            ChooseModel(result);
        }
        private void HandleWorkingModel(List<Model> models, Predicate<Model> pred)
        {
            if (models.Exists(pred))
            {
                models.RemoveAll(m => !pred(m));
            }
            else
            {
                MessageBox.Show("Не удалось рабочий игровой смартфон");
                return;
            }
            var min = models.Min(a => a.price);
            var result = models.FirstOrDefault(a => a.price == min);
            ChooseModel(result);
        }

        private void ChooseModel(Model model)
        {
            label9.Text = model.name;
            label10.Text = model.camera.ToString();
            label11.Text = model.battery.ToString();
            label12.Text = model.cpu.ToString();
            label13.Text = model.drive.ToString();
            label14.Text = model.ram.ToString();
            label15.Text = model.price.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (sender as ComboBox);
            _chosenType = comboBox.SelectedItem.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox.Text == "")
            {
                _price = 0;
            }
            else 
            { 
                _price = Convert.ToInt32(textBox.Text);
            }
        }
    }
}
