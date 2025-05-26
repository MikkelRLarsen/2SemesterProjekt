using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.MedicineUserControl
{
    public partial class SeeMedicineDetails : UserControl
    {
        private readonly FindMedicinePage _findMedicinePage;
        private readonly Panel _panel;
        private readonly Examination _examination;
        private Dictionary<string, MedicineCard> _medicineCards = new Dictionary<string, MedicineCard>();
        public SeeMedicineDetails(Examination examination, FindMedicinePage previousPage, Panel panel)
        {
            InitializeComponent();

            _examination = examination;
            _findMedicinePage = previousPage;
            _panel = panel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _panel.Controls.Clear();
            _panel.Controls.Add(_findMedicinePage);
        }

        private void MedicineSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Finds all MedicineCard where MedicinePrescriptions name is equal to SearchMedicineTextBox
                MedicineCard? medicineCardsWithMedicineName = _medicineCards.GetValueOrDefault(SearchMedicineTextBox.Text);

                // If there wasn't any MedicineCard
                if (medicineCardsWithMedicineName == null)
                {
                    throw new ArgumentException("Der er ikke nogen medicine detaljer med det navn");
                }

                // Adds all relevant MedicineCard to flowpanel and display them
                flowPanel.Controls.Clear();
                flowPanel.Controls.Add(medicineCardsWithMedicineName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SeeMedicineDetails_Load(object sender, EventArgs e)
        {
            foreach (MedicinePrescription medicinePrescription in _examination.MedicinePrescriptions)
            {
                _medicineCards.Add(medicinePrescription.MedicineDetails.MedicineType.Name, new MedicineCard(medicinePrescription));
            }

            LoadAndShow(_medicineCards.Values);
        }

        private void LoadAndShow(IEnumerable<MedicineCard> medicineCards)
        {
            flowPanel.Controls.Clear();
            flowPanel.Controls.AddRange(medicineCards.ToArray());
        }

        private void findAllButton_Click(object sender, EventArgs e)
        {
            LoadAndShow(_medicineCards.Values);
        }

        private void SearchMedicineTextBox_Click(object sender, EventArgs e)
        {
            if (SearchMedicineTextBox.Text == "Søg på medicin navn")
            {
                SearchMedicineTextBox.Text = string.Empty;
                SearchMedicineTextBox.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
