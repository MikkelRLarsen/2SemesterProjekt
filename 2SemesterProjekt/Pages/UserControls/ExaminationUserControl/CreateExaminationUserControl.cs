using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

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
            
            ServiceProvider allServices = ServiceProviderSingleton.GetServiceProvider();

            _examinationService = allServices.GetService<IExaminationService>();
            
            _employeeService = allServices.GetService<IEmployeeService>();
            
            _customerService = allServices.GetService<ICustomerService>();

            _petService = allServices.GetService<IPetService>();

            CustomerExaminationDropdown.DataSource = _customerService.GetAllCustomersAsync();
            CustomerExaminationDropdown.DisplayMember = "FirstName";

            PetExaminationDropdown.DataSource = _petService.GetAllPetsByCustomerIdAsync();
            PetExaminationDropdown.DisplayMember = "Name";

            ExaminationDropdown.DataSource = _examinationService.GetAllExaminationsAsync();
            ExaminationDropdown.DisplayMember = "Type";

            PriceExaminationDropdown.DataSource = _examinationService.GetAllExaminationsAsync();
            PriceExaminationDropdown.DisplayMember = "Price";

            EmployeeExaminationDropdown.DataSource = _employeeService.GetAllEmployeeAsync();
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
