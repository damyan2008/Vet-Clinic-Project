using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class NewPet : Form
    {
        private string petImage;
        public NewPet()
        {
            InitializeComponent();
        }

        public IAnimal Animal { get; set; }

        private void RadioButtonDogCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = false;
            this.textBoxFavToy.Visible = false;
            this.labelFavToyVal.Visible = false;
        }

        private void RadioButtonCatCheckedChanged(object sender, EventArgs e)
        {
            this.labelFavToy.Visible = true;
            this.textBoxFavToy.Visible = true;
        }

        private void labelBirthday_Click(object sender, EventArgs e)
        {

        }

        private void labelBreed_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddClick(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid())
            {
                return;
            }

            IAnimal newAnimal = CreateNewAnimal();

            if (newAnimal != null) 
            { 
                this.Animal = newAnimal;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool CheckIfInputsAreValid() => CheckIfValid(this.textBoxName, 3, this.labelNameValidation) && CheckIfValid(this.textBoxBreed, 5, this.labelBreedValidation) && CheckIfValid(this.textBoxMed, 10, this.labelMedValidation) && CheckIfValid(this.textBoxColor, 3, this.labelColorValidation) && CheckIfValidDouble(this.textBoxWeight, this.labelWeightVal, 0.5) && CheckIfNotEmpty(this.petImage, this.labelImageVal);

        private static bool CheckIfValid(TextBox textBox, int minLength, Label errorLabel)
        {
            bool isValid = textBox.Text.Trim().Length >= minLength;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static void ShowValidationError(Label label, bool isValid)
        {
            label.Visible = !isValid;
        }

        private static bool CheckIfValidDouble(TextBox textBox, Label errorLabel, double min)
        {
            bool isValid = double.TryParse(textBox.Text.Trim(), out double resultValue) && resultValue >= min;
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private static bool CheckIfNotEmpty(string value, Label errorLabel)
        {
            bool isValid = !string.IsNullOrWhiteSpace(value?.Trim());
            ShowValidationError(errorLabel, isValid);
            return isValid;
        }

        private IAnimal CreateNewAnimal()
        {
            string name = this.textBoxName.Text.Trim();
            string breed = this.textBoxBreed.Text.Trim();
            string medicalHistory = this.textBoxMed.Text.Trim();
            string color = this.textBoxColor.Text.Trim();
            double weight = double.Parse(this.textBoxWeight.Text.Trim());
            DateTime birthday = DateTime.Parse(this.dateTimePicker1.Text.Trim());

            IAnimal animal;

            if (this.RadioButtonCat.Checked)
            {
                animal = CreateCat(name, birthday, breed, medicalHistory, weight, color);
            }
            else
            {
                animal = new Dog(name, birthday, breed, weight, medicalHistory, color);
            }

            animal.Image = this.petImage;
            return animal;
        }

        private Cat CreateCat(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color)
        {
            string favoriteToy = this.textBoxFavToy.Text.Trim();

            if (!CheckIfValid(this.textBoxFavToy, 3, this.labelFavToyVal))
            {
                return null;
            }

            return new Cat(name, birthday, breed, weight, medicalHistory, color, favoriteToy);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                petImage = openFileDialog.FileName;
                this.textBoxImage.Text = Path.GetFileName(petImage);
            }
        }

        private void textBoxImage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
