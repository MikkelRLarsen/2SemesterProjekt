using _2SemesterProject.Domain.Interfaces.ServiceInterfaces.Core;
using _2SemesterProject.Domain.Models.Core;
using _2SemesterProjekt.DTO;
using _2SemesterProjekt.Pages.User_Controls.UpdateCustomerCardUserControls;
using Microsoft.Extensions.DependencyInjection;

namespace _2SemesterProjekt.Pages.User_Controls
{
	public partial class UpdateCustomerCard : UserControl
	{
		private readonly ServiceProvider _serviceProviderSingleton;
		private readonly ICustomerService _customerService;

		private readonly CustomerPage _customerPage;
		private readonly CustomerDTO _customerDTO;
		private Customer _customer;

		private LinkedList<AddPetToCustomerCard> _pets = new LinkedList<AddPetToCustomerCard>();
		private LinkedListNode<AddPetToCustomerCard> _currentPetNode;


		public UpdateCustomerCard(CustomerPage customerPage)
		{
			InitializeComponent();
			_customerDTO = new CustomerDTO();
			_customerPage = customerPage;
			_customerService = ServiceProviderSingleton.GetServiceProvider().GetService(typeof(ICustomerService)) as ICustomerService;
		}

		public UpdateCustomerCard(Customer customer, CustomerPage customerPage)
		{
			InitializeComponent();
			_customerPage = customerPage;
			_customerDTO = new CustomerDTO(customer);
			_customer = customer;
			_customerService = ServiceProviderSingleton.GetServiceProvider().GetService(typeof(ICustomerService)) as ICustomerService;

			customerNameTextBox.Text = customer.CustomerName;
			customerAdressTextBox.Text = customer.CustomerAdress;
			customerTlfTextBox.Text = customer.CustomerPhoneNumber.ToString();
			customerEmailTextBox.Text = customer.CustomerEmail;

			if (customer.Pets != null)
			{
				foreach (var pet in customer.Pets)
				{
					_pets.AddLast(new AddPetToCustomerCard(new PetDTO(pet)));
				}
				_currentPetNode = _pets.First;

				PetPanal.Controls.Add(_currentPetNode.Value);
			}

			CheckButtonStatus();
		}

		private void customerNameTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerName = customerNameTextBox.Text;
		}

		private void customerAdressTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerAdress = customerAdressTextBox.Text;
		}

		private void customerTlfTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerPhoneNumber = Convert.ToInt32(customerTlfTextBox.Text);
		}

		private void customerEmailTextBox_TextChanged(object sender, EventArgs e)
		{
			_customerDTO.CustomerEmail = customerEmailTextBox.Text;
		}

		private void DoneButton_Click(object sender, EventArgs e)
		{

			if (_customer == null)
			{
				var customer = new Customer();
				_customer = customer;
			}

			_customer.UpdateCustomer(_customerDTO.CustomerName, _customerDTO.CustomerEmail, _customerDTO.CustomerAdress, _customerDTO.CustomerPhoneNumber);

		}

		private void PrevButton_Click(object sender, EventArgs e)
		{
			try
			{
				PetPanal.Controls.Clear();
				_currentPetNode = _currentPetNode.Previous;
				PetPanal.Controls.Add(_currentPetNode.Value);
			}
			catch (Exception)
			{
			}

			CheckButtonStatus();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{


			try
			{
				PetPanal.Controls.Clear();
				_currentPetNode = _currentPetNode.Next;
				PetPanal.Controls.Add(_currentPetNode.Value);
			}
			catch (Exception)
			{
			}
			CheckButtonStatus();
		}

		private void AddPetButton_Click(object sender, EventArgs e)
		{
			_pets.AddLast(new AddPetToCustomerCard());
			_currentPetNode = _pets.Last;

			PetPanal.Controls.Clear();
			PetPanal.Controls.Add(_currentPetNode.Value);

			CheckButtonStatus();
		}


		private void CheckButtonStatus()
		{
			if (_currentPetNode == null || _currentPetNode.Previous == null ) PrevButton.Enabled = false;
			else PrevButton.Enabled = true;

			if (_currentPetNode == null || _currentPetNode.Next == null) NextButton.Enabled = false;
			else NextButton.Enabled = true;

		}
	}
}
