using System.Reflection;
using _2SemesterProjekt.BlazorWebAssembly.Models;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Forms;

namespace _2SemesterProjekt.BlazorWebAssembly.Services
{
    public class EmployeeService
    {
        private readonly ILocalStorageService _localStorage;

        private List<Employee> _employees = new();

        // Key used to store/retrieve employee data from local storage
        private const string StorageKey = "employeeData";

        public EmployeeService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        /// <summary>
        /// Initializes the service by loading employees from default string
        /// </summary>
        public async Task InitializeAsync()
        {
            var content = await _localStorage.GetItemAsStringAsync(StorageKey);

            if (string.IsNullOrWhiteSpace(content))
            {
                // Use standard string if nothing is saved
                content = GetDefaultEmployeeString();
                await _localStorage.SetItemAsStringAsync(StorageKey, content);
            }

            await LoadFromStringAsync(content);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employees;
        }

        /// <summary>
        /// Loads destinations from default
        /// </summary>
        public async Task LoadFromStringAsync(string content)
        {
            var lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var newList = new List<Employee>();

            foreach (var line in lines)
            {
                // Create a new Employee object from each line
                newList.Add(new Employee(line));
            }

            _employees = newList;
        }

        /// <summary>
        /// Proof of concept database
        /// </summary>
        private string GetDefaultEmployeeString()
        {
            return "Mikkel Jensen\n" +
                   "Sofie Hansen\n" +
                   "Jonas Petersen\n";
        }
    }
}

