
namespace Vet_Clinic
{
    partial class NewPet
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
            Title = new Label();
            RadioButtonCat = new RadioButton();
            RadioButtonDog = new RadioButton();
            labelName = new Label();
            labelBirthday = new Label();
            labelBreed = new Label();
            labelMedHist = new Label();
            labelWeight = new Label();
            labelColor = new Label();
            labelImage = new Label();
            labelFavToy = new Label();
            textBoxName = new TextBox();
            textBoxBreed = new TextBox();
            textBoxMed = new TextBox();
            textBoxColor = new TextBox();
            textBoxImage = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonAdd = new Button();
            labelNameValidation = new Label();
            labelBreedValidation = new Label();
            labelMedValidation = new Label();
            labelColorValidation = new Label();
            labelImageVal = new Label();
            textBoxWeight = new TextBox();
            textBoxFavToy = new TextBox();
            labelWeightVal = new Label();
            labelFavToyVal = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(339, 12);
            Title.Name = "Title";
            Title.Size = new Size(253, 81);
            Title.TabIndex = 0;
            Title.Text = "New Pet";
            // 
            // RadioButtonCat
            // 
            RadioButtonCat.AutoSize = true;
            RadioButtonCat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioButtonCat.Location = new Point(206, 140);
            RadioButtonCat.Margin = new Padding(3, 4, 3, 4);
            RadioButtonCat.Name = "RadioButtonCat";
            RadioButtonCat.Size = new Size(62, 32);
            RadioButtonCat.TabIndex = 1;
            RadioButtonCat.TabStop = true;
            RadioButtonCat.Text = "Cat";
            RadioButtonCat.UseVisualStyleBackColor = true;
            RadioButtonCat.CheckedChanged += RadioButtonCat_CheckedChanged;
            // 
            // RadioButtonDog
            // 
            RadioButtonDog.AutoSize = true;
            RadioButtonDog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RadioButtonDog.Location = new Point(315, 140);
            RadioButtonDog.Margin = new Padding(3, 4, 3, 4);
            RadioButtonDog.Name = "RadioButtonDog";
            RadioButtonDog.Size = new Size(71, 32);
            RadioButtonDog.TabIndex = 2;
            RadioButtonDog.TabStop = true;
            RadioButtonDog.Text = "Dog";
            RadioButtonDog.UseVisualStyleBackColor = true;
            RadioButtonDog.CheckedChanged += RadioButtonDog_CheckedChanged;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(86, 220);
            labelName.Name = "labelName";
            labelName.Size = new Size(62, 25);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // labelBirthday
            // 
            labelBirthday.Anchor = AnchorStyles.Top;
            labelBirthday.AutoSize = true;
            labelBirthday.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBirthday.Location = new Point(72, 295);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(82, 25);
            labelBirthday.TabIndex = 4;
            labelBirthday.Text = "Birthday";
            labelBirthday.Click += labelBirthday_Click;
            // 
            // labelBreed
            // 
            labelBreed.AutoSize = true;
            labelBreed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBreed.Location = new Point(87, 365);
            labelBreed.Name = "labelBreed";
            labelBreed.Size = new Size(61, 25);
            labelBreed.TabIndex = 5;
            labelBreed.Text = "Breed";
            labelBreed.Click += labelBreed_Click;
            // 
            // labelMedHist
            // 
            labelMedHist.AutoSize = true;
            labelMedHist.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMedHist.Location = new Point(13, 439);
            labelMedHist.Name = "labelMedHist";
            labelMedHist.Size = new Size(143, 25);
            labelMedHist.TabIndex = 6;
            labelMedHist.Text = "Medical History";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeight.Location = new Point(538, 220);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(72, 25);
            labelWeight.TabIndex = 7;
            labelWeight.Text = "Weight";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(551, 295);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(58, 25);
            labelColor.TabIndex = 8;
            labelColor.Text = "Color";
            // 
            // labelImage
            // 
            labelImage.AutoSize = true;
            labelImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelImage.Location = new Point(544, 365);
            labelImage.Name = "labelImage";
            labelImage.Size = new Size(64, 25);
            labelImage.TabIndex = 9;
            labelImage.Text = "Image";
            // 
            // labelFavToy
            // 
            labelFavToy.AutoSize = true;
            labelFavToy.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFavToy.Location = new Point(502, 439);
            labelFavToy.Name = "labelFavToy";
            labelFavToy.Size = new Size(111, 25);
            labelFavToy.TabIndex = 10;
            labelFavToy.Text = "Favorite Toy";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(153, 216);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(292, 32);
            textBoxName.TabIndex = 1;
            // 
            // textBoxBreed
            // 
            textBoxBreed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBreed.Location = new Point(153, 360);
            textBoxBreed.Margin = new Padding(3, 4, 3, 4);
            textBoxBreed.Name = "textBoxBreed";
            textBoxBreed.Size = new Size(292, 32);
            textBoxBreed.TabIndex = 2;
            // 
            // textBoxMed
            // 
            textBoxMed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMed.Location = new Point(153, 439);
            textBoxMed.Margin = new Padding(3, 4, 3, 4);
            textBoxMed.Name = "textBoxMed";
            textBoxMed.Size = new Size(292, 32);
            textBoxMed.TabIndex = 3;
            // 
            // textBoxColor
            // 
            textBoxColor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxColor.Location = new Point(609, 285);
            textBoxColor.Margin = new Padding(3, 4, 3, 4);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(252, 32);
            textBoxColor.TabIndex = 5;
            // 
            // textBoxImage
            // 
            textBoxImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImage.Location = new Point(609, 361);
            textBoxImage.Margin = new Padding(3, 4, 3, 4);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.Size = new Size(252, 32);
            textBoxImage.TabIndex = 6;
            textBoxImage.TextChanged += textBoxImage_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(153, 295);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(725, 511);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 73);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // labelNameValidation
            // 
            labelNameValidation.AutoSize = true;
            labelNameValidation.ForeColor = Color.Red;
            labelNameValidation.Location = new Point(153, 256);
            labelNameValidation.Name = "labelNameValidation";
            labelNameValidation.Size = new Size(291, 20);
            labelNameValidation.TabIndex = 19;
            labelNameValidation.Text = "Name should be at least 3 charecters long!";
            // 
            // labelBreedValidation
            // 
            labelBreedValidation.AutoSize = true;
            labelBreedValidation.ForeColor = Color.Red;
            labelBreedValidation.Location = new Point(153, 400);
            labelBreedValidation.Name = "labelBreedValidation";
            labelBreedValidation.Size = new Size(290, 20);
            labelBreedValidation.TabIndex = 20;
            labelBreedValidation.Text = "Breed should be at least 5 charecters long!";
            // 
            // labelMedValidation
            // 
            labelMedValidation.AutoSize = true;
            labelMedValidation.ForeColor = Color.Red;
            labelMedValidation.Location = new Point(153, 479);
            labelMedValidation.Name = "labelMedValidation";
            labelMedValidation.Size = new Size(363, 20);
            labelMedValidation.TabIndex = 21;
            labelMedValidation.Text = "Medical History should be at least 10 charecters long!";
            // 
            // labelColorValidation
            // 
            labelColorValidation.AutoSize = true;
            labelColorValidation.ForeColor = Color.Red;
            labelColorValidation.Location = new Point(609, 325);
            labelColorValidation.Name = "labelColorValidation";
            labelColorValidation.Size = new Size(123, 20);
            labelColorValidation.TabIndex = 22;
            labelColorValidation.Text = "Color is required!";
            // 
            // labelImageVal
            // 
            labelImageVal.AutoSize = true;
            labelImageVal.ForeColor = Color.Red;
            labelImageVal.Location = new Point(609, 401);
            labelImageVal.Name = "labelImageVal";
            labelImageVal.Size = new Size(129, 20);
            labelImageVal.TabIndex = 23;
            labelImageVal.Text = "Image is required!";
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeight.Location = new Point(609, 215);
            textBoxWeight.Margin = new Padding(3, 4, 3, 4);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(251, 34);
            textBoxWeight.TabIndex = 4;
            // 
            // textBoxFavToy
            // 
            textBoxFavToy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFavToy.Location = new Point(609, 440);
            textBoxFavToy.Margin = new Padding(3, 4, 3, 4);
            textBoxFavToy.Name = "textBoxFavToy";
            textBoxFavToy.Size = new Size(246, 34);
            textBoxFavToy.TabIndex = 7;
            // 
            // labelWeightVal
            // 
            labelWeightVal.AutoSize = true;
            labelWeightVal.ForeColor = Color.Red;
            labelWeightVal.Location = new Point(609, 256);
            labelWeightVal.Name = "labelWeightVal";
            labelWeightVal.Size = new Size(134, 20);
            labelWeightVal.TabIndex = 26;
            labelWeightVal.Text = "Weight is required!";
            // 
            // labelFavToyVal
            // 
            labelFavToyVal.AutoSize = true;
            labelFavToyVal.ForeColor = Color.Red;
            labelFavToyVal.Location = new Point(614, 484);
            labelFavToyVal.Name = "labelFavToyVal";
            labelFavToyVal.Size = new Size(164, 20);
            labelFavToyVal.TabIndex = 27;
            labelFavToyVal.Text = "Favorite toy is required!";
            labelFavToyVal.Click += label2_Click;
            // 
            // NewPet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(914, 600);
            Controls.Add(labelFavToyVal);
            Controls.Add(labelWeightVal);
            Controls.Add(textBoxFavToy);
            Controls.Add(textBoxWeight);
            Controls.Add(labelImageVal);
            Controls.Add(labelColorValidation);
            Controls.Add(labelMedValidation);
            Controls.Add(labelBreedValidation);
            Controls.Add(labelNameValidation);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxImage);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxMed);
            Controls.Add(textBoxBreed);
            Controls.Add(textBoxName);
            Controls.Add(labelFavToy);
            Controls.Add(labelImage);
            Controls.Add(labelColor);
            Controls.Add(labelWeight);
            Controls.Add(labelMedHist);
            Controls.Add(labelBreed);
            Controls.Add(labelBirthday);
            Controls.Add(labelName);
            Controls.Add(RadioButtonDog);
            Controls.Add(RadioButtonCat);
            Controls.Add(Title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewPet";
            Text = "NewPet";
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Title;
        private RadioButton RadioButtonCat;
        private RadioButton RadioButtonDog;
        private Label labelName;
        private Label labelBirthday;
        private Label labelBreed;
        private Label labelMedHist;
        private Label labelWeight;
        private Label labelColor;
        private Label labelImage;
        private Label labelFavToy;
        private TextBox textBoxName;
        private TextBox textBoxBreed;
        private TextBox textBoxMed;
        private TextBox textBoxColor;
        private TextBox textBoxImage;
        private DateTimePicker dateTimePicker1;
        private Button buttonAdd;
        private Label labelNameValidation;
        private Label labelBreedValidation;
        private Label labelMedValidation;
        private Label labelColorValidation;
        private Label labelImageVal;
        private TextBox textBoxWeight;
        private TextBox textBoxFavToy;
        private Label labelWeightVal;
        private Label labelFavToyVal;
    }
}