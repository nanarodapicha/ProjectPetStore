using Project11d.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11d
{
    public partial class Form2 : Form
    {
        private AnimalTypeLogic animalTypeLogic = new AnimalTypeLogic();
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAnimalTypes();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Enter valid ID.");
                txtId.Focus();
                return;
            }

            string newName = txtTypeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Enter a new name.");
                txtTypeName.Focus();
                return;
            }

            using (AnimalsContext context = new AnimalsContext())
            {
                AnimalType typeToUpdate = context.AnimalTypes.Find(id);
                if (typeToUpdate == null)
                {
                    MessageBox.Show("No type found with this ID.");
                    return;
                }

                typeToUpdate.Name = newName;
                context.SaveChanges();
            }

            MessageBox.Show("Type updated successfully.");
            txtId.Clear();
            txtTypeName.Clear();
            LoadAnimalTypes();
        }
        private void LoadAnimalTypes()
        {
            lstTypes.Items.Clear();
            List<AnimalType> types = animalTypeLogic.GetAllAnimalTypes();
            foreach (var type in types)
            {
                lstTypes.Items.Add($"{type.Id}: {type.Name}");
            }
        }
        private void BtnAddType_Click(object sender, EventArgs e)
        {
            string name = txtTypeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a type name.");
                txtTypeName.Focus();
                return;
            }

            using (AnimalsContext context = new AnimalsContext())
            {
                AnimalType newType = new AnimalType { Name = name };
                context.AnimalTypes.Add(newType);
                context.SaveChanges();
            }

            MessageBox.Show("Type added successfully.");
            txtTypeName.Clear();
            LoadAnimalTypes();
        }
        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Enter valid ID.");
                txtId.Focus();
                return;
            }

            using (AnimalsContext context = new AnimalsContext())
            {
                AnimalType typeToDelete = context.AnimalTypes.Find(id);
                if (typeToDelete == null)
                {
                    MessageBox.Show("No type found with this ID.");
                    return;
                }

                context.AnimalTypes.Remove(typeToDelete);
                context.SaveChanges();
            }

            MessageBox.Show("Type deleted successfully.");
            txtId.Clear();
            LoadAnimalTypes();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
