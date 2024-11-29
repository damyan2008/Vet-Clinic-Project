
namespace Vet_Clinic
{
    partial class VetClinic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetClinic));
            Title = new Label();
            ListView1 = new ListView();
            ImageListPets = new ImageList(components);
            Addpetbutton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(335, 12);
            Title.MaximumSize = new Size(11429, 13333);
            Title.Name = "Title";
            Title.Size = new Size(279, 81);
            Title.TabIndex = 0;
            Title.Text = "Vet Clinic";
            // 
            // ListView1
            // 
            ListView1.LargeImageList = ImageListPets;
            ListView1.Location = new Point(14, 103);
            ListView1.Margin = new Padding(3, 4, 3, 4);
            ListView1.Name = "ListView1";
            ListView1.Size = new Size(886, 417);
            ListView1.SmallImageList = ImageListPets;
            ListView1.TabIndex = 1;
            ListView1.UseCompatibleStateImageBehavior = false;
            ListView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            ListView1.MouseClick += ListView1_Click;
            // 
            // ImageListPets
            // 
            ImageListPets.ColorDepth = ColorDepth.Depth8Bit;
            ImageListPets.ImageStream = (ImageListStreamer)resources.GetObject("ImageListPets.ImageStream");
            ImageListPets.TransparentColor = Color.Transparent;
            ImageListPets.Images.SetKeyName(0, "cat.png");
            ImageListPets.Images.SetKeyName(1, "dog.png");
            // 
            // Addpetbutton
            // 
            Addpetbutton.BackColor = Color.FromArgb(0, 64, 0);
            Addpetbutton.Cursor = Cursors.Hand;
            Addpetbutton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Addpetbutton.ForeColor = Color.White;
            Addpetbutton.Location = new Point(685, 529);
            Addpetbutton.Margin = new Padding(3, 4, 3, 4);
            Addpetbutton.Name = "Addpetbutton";
            Addpetbutton.Size = new Size(216, 56);
            Addpetbutton.TabIndex = 2;
            Addpetbutton.Text = "Add New Pet";
            Addpetbutton.UseVisualStyleBackColor = false;
            Addpetbutton.Click += Addpetbutton_Click;
            // 
            // VetClinic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(914, 600);
            Controls.Add(Addpetbutton);
            Controls.Add(ListView1);
            Controls.Add(Title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VetClinic";
            Text = "Form1";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ListView ListView1;
        private ImageList ImageListPets;
        private Button Addpetbutton;
    }
}
