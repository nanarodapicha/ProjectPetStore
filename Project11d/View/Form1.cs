using Project11d.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11d
{
    public partial class Form1 : Form
    {
        AnimalLogic animalLogic = new AnimalLogic();
        AnimalTypeLogic animalTypeLogic = new AnimalTypeLogic();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            btnGetAll_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter name");
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Invalid age!");
                txtAge.Focus();
                return;
            }

            Animal animal = new Animal
            {
                Name = txtName.Text,
                Age = age,
                AnimalTypeId = (int)cmbType.SelectedValue,
                Description = txtInfo.Text 
            };

            animalLogic.AddAnimal(animal);
            MessageBox.Show("Successfully added animal!");
            ClearScreen();
            btnGetAll_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid ID");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            int findId = int.Parse(txtId.Text);
            Animal foundAnimal = animalLogic.GetAnimalById(findId);

            if (foundAnimal == null)
            {
                MessageBox.Show("There is no such ID!\nEnter ID again!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            LoadRecord(foundAnimal);

            DialogResult answer = MessageBox.Show(
                $"Do you really want to delete animal No {findId}?",
                "CONFIRM DELETE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                try
                {
                    animalLogic.DeleteAnimal(findId);
                    MessageBox.Show("Animal deleted successfully.");
                    ClearScreen();
                    btnGetAll_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting animal: " + ex.Message);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid ID!");
                txtId.Focus();
                return;
            }

            int findId = int.Parse(txtId.Text);
            Animal findAnimal = animalLogic.GetAnimalById(findId);

            if (findAnimal == null)
            {
                MessageBox.Show("There is no such ID!\nEnter ID again!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            LoadRecord(findAnimal);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Enter valid ID");
                txtId.Focus();
                return;
            }

            int findId = int.Parse(txtId.Text);
            Animal foundAnimal = animalLogic.GetAnimalById(findId);

            if (foundAnimal == null)
            {
                MessageBox.Show("There is no such ID!\nEnter ID again!");
                txtId.BackColor = Color.Red;
                txtId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter name");
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Invalid age!");
                txtAge.Focus();
                return;
            }

            Animal updatedAnimal = new Animal
            {
                Name = txtName.Text,
                Age = age,
                AnimalTypeId = (int)cmbType.SelectedValue,
                Description = txtInfo.Text
            };

            animalLogic.UpdateAnimal(findId, updatedAnimal);
            MessageBox.Show("Animal updated successfully!");
            btnGetAll_Click(sender, e);
            LoadRecord(updatedAnimal);
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            List<Animal> animals = animalLogic.GetAllAnimals();
            lstAnimals.Items.Clear();

            foreach (Animal a in animals)
            {
                lstAnimals.Items.Add($"{a.Id}  {a.Name}  {a.Age}  {a.AnimalTypes.Name}");
            }
        }

        private void LoadRecord(Animal animal)
        {
            txtId.BackColor = Color.White;
            txtId.Text = animal.Id.ToString();
            txtName.Text = animal.Name;
            txtAge.Text = animal.Age.ToString();
            txtInfo.Text = animal.Description ?? "";
            cmbType.SelectedValue = animal.AnimalTypeId;
        }

        private void ClearScreen()
        {
            txtId.BackColor = Color.White;
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtInfo.Clear();
            cmbType.SelectedIndex = 0;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog(); 
            }
            this.Show();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            List<AnimalType> types = animalTypeLogic.GetAllAnimalTypes();
            cmbType.DataSource = types;
            cmbType.DisplayMember = "Name";
            cmbType.ValueMember = "Id";
        }
    }
}
