namespace Vet_Clinic
{
    public partial class VetClinic : Form
    {
        private readonly List<IAnimal> pets = new()
        {
            new Cat("Mittens", new DateTime(2019, 1, 1), "Siamese", 10, "Healthy", "White", "Yarn"),
            new Dog("Fido", new DateTime(2018, 1, 1), "Golden Retriever", 50, "Healthy", "Golden")
        };

        public VetClinic()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            this.ListView1.Clear();

            foreach (var pet in pets)
            {
                this.ListView1.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }

        private void ListView1_Click(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[this.ListView1.SelectedItems[0].Index];

            if (selectedPet != null)
            {
                using PetDetails detailsForm = new(selectedPet);
                detailsForm.ShowDialog();

            }
        }

        private void Addpetbutton_Click(object sender, EventArgs e)
        {
            using (NewPet newPetForm = new())
            {
                if (newPetForm.ShowDialog() == DialogResult.OK)
                {
                    this.pets.Add(newPetForm.Animal);
                }
            }

            LoadAllPets();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
