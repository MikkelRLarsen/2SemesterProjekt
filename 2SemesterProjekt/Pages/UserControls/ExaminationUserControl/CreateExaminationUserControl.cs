using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProject.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProject.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.ExaminationUserControl
{
    public partial class CreateExaminationUserControl : UserControl
    {

        // To use GetAllCustomersAsync();
        private readonly ICustomerService _customerService;

        // To use GetAllPetsAsync();
        private readonly IPetService _petService;

        // To use GetAllExaminationsAsync();
        private readonly IExaminationService _examinationService;

        // To use GetAllEmployeesAsync();
        private readonly IEmployeeService _employeeService;

        public CreateExaminationUserControl()
        {
            InitializeComponent();

            
            CustomerExaminationDropdown.DataSource = _customerService.GetAllCustomersAsync();
            CustomerExaminationDropdown.DisplayMember = "FirstName";

            PetExaminationDropdown.DataSource = _petService.GetAllPetsAsync();
            PetExaminationDropdown.DisplayMember = "Name";

            ExaminationDropdown.DataSource = _examinationService.GetAllExaminationsAsync();
            ExaminationDropdown.DisplayMember = "Type";

            PriceExaminationDropdown.DataSource = _examinationService.GetAllExaminationsAsync();
            PriceExaminationDropdown.DisplayMember = "Price";

            EmployeeExaminationDropdown.DataSource = _employeeService.GetAllEmployeeAsync();
            EmployeeExaminationDropdown.DisplayMember = "FirstName";
            


            
            //Test customer:
            List<Customer> customers = new List<Customer>();
            Customer customer1 = new Customer(1, "Allan", "Allansen", "aa@aa.dk", "Allansvej 11", "Privat", 25262728);
            Customer customer2 = new Customer(2, "Charlie", "Charliesen", "cc@cc.dk", "Charlievej 12", "Erhverv", 12131415);
            customers.Add(customer1);
            customers.Add(customer2);

            //Test pet:
            List<Pet> pets = new List<Pet>();
            Pet pet1 = new Pet(1, 1, "Andy", "Hund", DateTime.Today);
            pets.Add(pet1);

            //Test Employee
            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee(1, "Beate", "Beatesen", "Dyrlæge");
            employees.Add(employee1);

            //Test examination
            List<Examination> examinations = new List<Examination>();
            Examination examination1 = new Examination(1, 1, 1, DateTime.Today, "Konsultation", 100);
            examinations.Add(examination1);

            CustomerExaminationDropdown.DataSource = customers
            .Select(c => new
            {
                c,
                FullName = $"{c.FirstName} {c.LastName}"
            })
            .ToList();
            CustomerExaminationDropdown.DisplayMember = "FullName";

            PetExaminationDropdown.DataSource = pets;
            PetExaminationDropdown.DisplayMember = "Name";

            ExaminationDropdown.DataSource = examinations;
            ExaminationDropdown.DisplayMember = "Type";

            PriceExaminationDropdown.DataSource = examinations;
            PriceExaminationDropdown.DisplayMember = "Price";

            EmployeeExaminationDropdown.DataSource = employees;
            EmployeeExaminationDropdown.DisplayMember = "FirstName";
            

        }

        private void CustomerExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Customer customerChoice = CustomerExaminationDropdown.SelectedItem as Customer;

            //string customerChoice = CustomerExaminationDropdown.SelectedItem.ToString();
        }

        private void PetExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string petChoice = PetExaminationDropdown.SelectedItem.ToString();
        }

        private void ExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string examinationChoice = ExaminationDropdown.SelectedItem.ToString();
        }

        private void PriceExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            double priceChoice = (double)PriceExaminationDropdown.SelectedValue;
        }

        private void DateTimePickerExamination_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateChoice = DateTimePickerExamination.Value;
        }

        private void EmployeeExaminationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string employeeChoice = EmployeeExaminationDropdown.SelectedItem.ToString();
        }

        private void CreateExaminationButton_Click(object sender, EventArgs e)
        {
            //Customer selectedCustomer = CustomerExaminationDropdown.SelectedItem as Customer;

            Pet selectedPet = PetExaminationDropdown.SelectedItem as Pet;

            Employee selectedEmployee = EmployeeExaminationDropdown.SelectedItem as Employee;

            DateTime selectedDate = DateTimePickerExamination.Value;

            Examination selectedExamination = ExaminationDropdown.SelectedItem as Examination;

            Examination newExamination = new Examination(
                examinationID: 0,
                petID: selectedPet.PetID,
                employeeID: selectedEmployee.EmployeeID,
                date: selectedDate,
                type: selectedExamination.Type,
                price: selectedExamination.Price
                );

            _examinationService.CreateExamination(newExamination);
        }

        private void CancelExaminationButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
