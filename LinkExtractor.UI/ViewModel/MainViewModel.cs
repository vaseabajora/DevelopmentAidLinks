﻿using LinkExtractor.Models;
using LinkExtractor.UI.DataServices;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace LinkExtractor.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IEmployeeDataService _employeeDataService;
        private Employee _selectedEmployee;


        public MainViewModel(IEmployeeDataService employeeDataService)
        {
            Employees = new ObservableCollection<Employee>();
            _employeeDataService = employeeDataService;
        }

        public async Task LoadAsync()
        {
            var employees = await _employeeDataService.GetAllAsync();
            Employees.Clear();
            foreach (var employee in employees)
            {
                Employees.Add(employee);
            }
        }

        public ObservableCollection<Employee> Employees { get; set; }


        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }


    }
}


