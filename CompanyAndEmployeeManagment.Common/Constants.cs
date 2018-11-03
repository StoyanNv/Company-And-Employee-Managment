namespace CompanyAndEmployeeManagment.Common
{
    public static class Constants
    {
        public static class SuccessMessages
        {
            public const string CompanyAdded = "Company added successfully.";
            public const string CompanyEdited = "Company edited successfully.";

            public const string EmployeeAdded = "Employee added successfully";
            public const string EmployeeEdited = "Employee edited successfully";
        }
        public static class ErrorMessages
        {
            public const string InvalidFormData = "You have entered invalid data.";
        }
        public static class AttributeConstraint
        {
            public const int CompanyNameMinLength = 3;
            public const int CompanyDescriptionMinLength = 10;

            public const int EmployeeNameMinLength = 3;
            public const int EmployeeMinSalary = 560;
            public const int EmployeeMinVacationDays = 30;

            public const string ExperienceLevelDisplay = "Experience Level";
            public const string StartDateDisplay = "Start Date";
            public const string VacationDaysDisplay = "Vacation Days";


        }
    }
}
