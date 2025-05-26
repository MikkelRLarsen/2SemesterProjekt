using _2SemesterProjekt.Domain.Interfaces.ServiceInterfaces;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using _2SemesterProjekt.Pages.UserControls.UserControlInterfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
    public partial class FindMedicinePage : UserControl, IExaminationCardHost
    {
        private IExaminationService _examinationService;
        private List<ExaminationCardUpdated> _allExaminationCards = new List<ExaminationCardUpdated>();
        private ExaminationCardUpdated _selectedExaminationCard;
        private Panel _panel;

        public FindMedicinePage(Panel panel)
        {
            InitializeComponent();
            _panel = panel;
        }

		private async void findAllButton_Click(object sender, EventArgs e)
		{
            // Wait cursor (hourglass)
            Cursor = Cursors.WaitCursor;
            findAllButton.Enabled = false;

            await LoadAndShowExaminationCards(_allExaminationCards);

            // Wait cursor (pointer)
            Cursor = Cursors.Default;
            findAllButton.Enabled = true;
        }

        private async void FindMedicinPage_Load(object sender, EventArgs e)
        {
            _examinationService = ServiceProviderSingleton.GetServiceProvider().GetService<IExaminationService>()!;

            Task.Run(() => GetAllExaminationCardsAsync());
        }

        private async Task GetAllExaminationCardsAsync()
        {
            try
            {
                var allExaminations = await _examinationService.GetAllExaminationsAsync();

                // Adds exam to all examination if they are completed and have a Medicine Presription. For this page you shouldn't need exam which have yet to be completed and doesn't have medicine
                foreach (var exam in allExaminations.Where(ex => ex.Date < DateTime.Now && ex.MedicinePrescriptions.Count > 0))
                {
                    _allExaminationCards.Add(new ExaminationCardUpdated(exam, this));
                }
            }
            catch (Exception ex)
            {

				MessageBox.Show(ex.Message);
			}

            findAllButton.Image = Properties.Resources.FindAllButton;
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
                    // Search by phonenumber
                    IEnumerable<ExaminationCardUpdated> examinationCards = _allExaminationCards
                        .Where(ex => ex.Examination.Pet.Customer.PhoneNumber == customerPhoneNumber);

                    LoadAndShowExaminationCards(examinationCards);
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

        private async void changeButton_Click(object sender, EventArgs e)
        {
            // Picture is a place holder until better picture and refactoring of Medicine
            if (_selectedExaminationCard == null)
            {
                MessageBox.Show("Du skal vælge en konsultation for at se medicin detaljer");
                return;
            }
            _panel.Controls.Clear();
            _panel.Controls.Add(new SeeMedicineDetails(_selectedExaminationCard.Examination, this, _panel));

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

        private void textBoxCustomerPhoneNumberOrName_Click(object sender, EventArgs e)
        {
            if (textBoxCustomerPhoneNumberOrName.Text == "Søg på navn eller telefonnummer")
            {
                textBoxCustomerPhoneNumberOrName.Text = string.Empty;
                textBoxCustomerPhoneNumberOrName.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
