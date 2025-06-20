﻿using _2SemesterProjekt.Pages.UserControls.CustomerUserControl;
using _2SemesterProjekt.Pages.UserControls.EmployeeUserControl;
using _2SemesterProjekt.Pages.UserControls.ExaminationUserControl;
using _2SemesterProjekt.Pages.UserControls.MainPageWallpaperControl;
using _2SemesterProjekt.Pages.UserControls.MedicineUserControl;
using _2SemesterProjekt.Pages.UserControls.NavigationButtons;
using _2SemesterProjekt.Pages.UserControls.PetUserControl;
using _2SemesterProjekt.Pages.UserControls.ProductUserControl;

namespace _2SemesterProjekt.Pages
{
    public partial class Page : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Page()
        {
            InitializeComponent();

            CreateAndSetKonsultationMenu();
            CreateAndSetMedicinMenu();
            CreateAndSetSalgMenu();
            CreateAndKundeMenu();
            CreateAndPetMenu();
            CreateAndSetStockMenu();
            CreateAndSetAdministrationMenu();

            AddMoveHandlers(NavPanel);
        }

        //KonsultationMenu
        private void CreateAndSetKonsultationMenu()
        {
            ExaminationNav.ButtonLabel.Text = "Konsultation";
            ExaminationNav.BringToFront();
            AddMoveHandlers(ExaminationNav);

            ExaminationNav.AddOption(new NavigationButtonOption(CreateKonsultationPage, "Opret"));
            ExaminationNav.AddOption(new NavigationButtonOption(FindKonsultationPage, "Find"));
            ExaminationNav.AddOption(new NavigationButtonOption(UpdateKonsultationPage, "Opdater"));
            ExaminationNav.AddOption(new NavigationButtonOption(RemoveKonsultationPage, "Fjern"));
        }
        private async void CreateKonsultationPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateExaminationPage(this.MainPanel));
        }
        private async void FindKonsultationPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new FindExaminationPage());
        }
        private async void UpdateKonsultationPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ChangeExaminationPage(this.MainPanel)); // Skal rettes til!!!
        }
        private async void RemoveKonsultationPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new RemoveExaminationPage(this.MainPanel));
        }


        //MedicinMenu
        private void CreateAndSetMedicinMenu()
        {
            MedicinNavn.ButtonLabel.Text = "Medicin";
            MedicinNavn.BringToFront();
            AddMoveHandlers(MedicinNavn);

            MedicinNavn.AddOption(new NavigationButtonOption(FindMedicinPage, "Find"));
        }
        private async void FindMedicinPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new FindMedicinePage(MainPanel));
        }


        //SalgMenu
        private void CreateAndSetSalgMenu()
        {
            SalesNav.ButtonLabel.Text = "Salg";
            SalesNav.BringToFront();
            AddMoveHandlers(SalesNav);

            SalesNav.AddOption(new NavigationButtonOption(CreateSalePage, "Opret"));
        }
        private async void CreateSalePage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateOrderPage(this.MainPanel)); // Mangler at opdatere når man går tilbage
        }


        //KundeMenu
        private void CreateAndKundeMenu()
        {
            CustomerNav.ButtonLabel.Text = "Kunde";
            CustomerNav.BringToFront();
            AddMoveHandlers(CustomerNav);

            CustomerNav.AddOption(new NavigationButtonOption(CreateCustomerPage, "Opret"));
            CustomerNav.AddOption(new NavigationButtonOption(FindCustomerPage, "Find"));
            CustomerNav.AddOption(new NavigationButtonOption(UpdateCustomerPage, "Opdater"));
        }
        private async void CreateCustomerPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateCustomerUpdate(this.MainPanel));
        }

        private async void FindCustomerPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new FindCustomerPage()); // Mangler søge mekanisme
        }

        private async void UpdateCustomerPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ChangeCustomerPage(MainPanel));
        }


        // PetMenu
        private void CreateAndPetMenu()
        {
            PetNav.ButtonLabel.Text = "Kæledyr";
            PetNav.BringToFront();
            AddMoveHandlers(PetNav);

            PetNav.AddOption(new NavigationButtonOption(CreatePetPage, "Opret"));
            PetNav.AddOption(new NavigationButtonOption(FindPetPage, "Find"));
            PetNav.AddOption(new NavigationButtonOption(UpdatePetPage, "Opdater"));
        }

        private async void CreatePetPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreatePetPage(MainPanel));
        }
        private async void FindPetPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new FindPetPage());
        }
        private async void UpdatePetPage(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ChangePetPage(MainPanel));
        }

        //StockMenu
        private void CreateAndSetStockMenu()
        {
            StockNav.ButtonLabel.Text = "Lagerbeholdning";
            StockNav.BringToFront();
            AddMoveHandlers(StockNav);

            StockNav.AddOption(new NavigationButtonOption(StorageStatus, "Lagerstatus"));
            StockNav.AddOption(new NavigationButtonOption(CreateProduct, "Opret produkt"));
        }
        private async void StorageStatus(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new AllProductsPage());
        }
        private async void CreateProduct(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateProductPage());
        }


        //AdministrationMenu
        private void CreateAndSetAdministrationMenu()
        {
            AdministrationNav.ButtonLabel.Text = "Administation";
            AdministrationNav.BringToFront();
            AddMoveHandlers(AdministrationNav);

            AdministrationNav.AddOption(new NavigationButtonOption(CreateEmployee, "Opret Ansat"));
            AdministrationNav.AddOption(new NavigationButtonOption(InactivePets, "Inaktive kæledyr"));
        }
        private async void CreateEmployee(object sender, EventArgs e)
        {
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(new CreateEmployeePage(MainPanel));
		}

        private async void InactivePets(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new InactivePetPage());
        }

        // MoveHandler
        private void AddMoveHandlers(Control control)
        {
            control.MouseDown += Page_MouseDown;
            control.MouseUp += Page_MouseUp;
            control.MouseMove += Page_MouseMove;

            // Add the same handler to each of the control.Controls, so that you can also move if mousedown on labels
            foreach (Control child in control.Controls)
            {
                AddMoveHandlers(child);
            }
        }

        private void Page_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void Page_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }

        private void Page_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Page_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(new MainPageWallpaper());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
