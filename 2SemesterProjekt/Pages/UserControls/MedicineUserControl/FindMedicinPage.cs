using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using _2SemesterProjekt.Pages.UserControls.UserControlInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
	public partial class FindMedicinPage : UserControl, IExaminationCardHost
	{
		private IExaminationService _examinationService;
		private List<ExaminationCardUpdated> _allExaminationCards = new List<ExaminationCardUpdated>();
		private ExaminationCardUpdated _selectedExaminationCard;

		public FindMedicinPage()
		{
			InitializeComponent();
		}

		private async void findAllButton_Click(object sender, EventArgs e)
		{
			await LoadAndShowExaminationCards(_allExaminationCards);
		}

		private async void FindMedicinPage_Load(object sender, EventArgs e)
		{
			_examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;

			Task.Run(() => GetAllExaminationCardsAsync());
		}

		private async Task GetAllExaminationCardsAsync()
		{
			var allExaminations = await _examinationService.GetAllExaminationsAsync();

			foreach (var exam in allExaminations.Where(ex => ex.Date < DateTime.Now))
			{
				_allExaminationCards.Add(new ExaminationCardUpdated(exam, this));
			}
		}

		public async Task LoadAndShowExaminationCards(IEnumerable<ExaminationCardUpdated> examinationCardsToBeLoaded)
		{
			flowPanel.Controls.Clear();
			flowPanel.Controls.AddRange(examinationCardsToBeLoaded.ToArray());
		}

		private void customerSearchButton_Click(object sender, EventArgs e)
		{
			try
			{
				string input = textBoxCustomerPhoneNumberOrName.Text.Trim();

				if (Int32.TryParse(input, out int customerPhoneNumber))
				{
					// Search by ID
					ExaminationCardUpdated examinationCard = _allExaminationCards
						.First(ex => ex.Examination.Pet.Customer.PhoneNumber == customerPhoneNumber);

					flowPanel.Controls.Clear();

					flowPanel.Controls.Add(examinationCard);
				}
				else
				{
					// Search by name
					IEnumerable<ExaminationCardUpdated> examinationCards = _allExaminationCards
						.Where(ex => ex.Examination.Pet.Customer.FirstName.Contains(textBoxCustomerPhoneNumberOrName.Text, StringComparison.OrdinalIgnoreCase) ||
									ex.Examination.Pet.Customer.LastName.Contains(textBoxCustomerPhoneNumberOrName.Text, StringComparison.OrdinalIgnoreCase));

					LoadAndShowExaminationCards(examinationCards);
				}

				// No hits - show user
				if (flowPanel.Controls.Count == 0)
				{
					MessageBox.Show($"Ingen hits på \"{textBoxCustomerPhoneNumberOrName.Text}\"", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				textBoxCustomerPhoneNumberOrName.Text = string.Empty;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBoxCustomerPhoneNumberOrName_Enter(object sender, EventArgs e)
		{
			textBoxCustomerPhoneNumberOrName.Text = String.Empty;
		}

		private void textBoxCustomerPhoneNumberOrName_Leave(object sender, EventArgs e)
		{
			if (textBoxCustomerPhoneNumberOrName.Text == String.Empty)
			{
				textBoxCustomerPhoneNumberOrName.Text = "Søg på telefonnummer eller navn";
			}
		}

		public void OnCardSelected(ExaminationCardUpdated selectedCard)
		{
			if (_selectedExaminationCard != null)
			{
				_selectedExaminationCard.SetSelected(false);
			}

			_selectedExaminationCard = selectedCard;
			_selectedExaminationCard.SetSelected(true);
		}
	}
}
