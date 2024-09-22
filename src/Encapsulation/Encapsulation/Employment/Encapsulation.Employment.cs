using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string? _firstName;
        private string? _lastName;
        private double _monthlySalary;

        public Employee(string? firstName, string? lastName, double monthlySalary)
        {
            FirstName = !string.IsNullOrEmpty(firstName) ? firstName : "Unknown";
            LastName = !string.IsNullOrEmpty(lastName) ? lastName : "Unknown";

            MonthlySalary = monthlySalary >= 0 ? monthlySalary : 0.0;
        }

        public string FirstName
        {
#pragma warning disable CS8603 // Possible null reference return.
            get => _firstName;
#pragma warning restore CS8603 // Possible null reference return.
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
#pragma warning disable CS8603 // Possible null reference return.
            get => _lastName;
#pragma warning restore CS8603 // Possible null reference return.

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _lastName = value;
                }
            }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value >= 0)
                {
                    _monthlySalary = value;
                }
            }
        }

        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage <= 20 && raisePercentage >= 0)
            {
                _monthlySalary += (_monthlySalary * raisePercentage) / 100;
            }
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}