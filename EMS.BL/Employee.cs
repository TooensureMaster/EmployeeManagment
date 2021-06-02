using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BL
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public decimal Wage { get; set; }
        public int Last4SSN { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName
        {
            
            get {
                string fullName = LastName;
                string specialCharater = ", ";

                // Excute when first and middle name exist
                if (!string.IsNullOrWhiteSpace(MiddleName) && !string.IsNullOrWhiteSpace(FirstName))
                {
                    // Excute when fullname (which last name was stored into) exist.
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        // Append a special charater seperator (DRY CODE)
                        fullName += specialCharater;
                    }
                    //  Convert last name into initial (DRY CODE)
                    char middleInitial = MiddleName.First();
                    fullName += $"{char.ToUpper(middleInitial)}, {FirstName}";
                } // Excute when Middle exist and first name don't exist
                else if (!string.IsNullOrWhiteSpace(MiddleName) && string.IsNullOrWhiteSpace(FirstName))
                {
                    // Excute when fullname (which last name was stored into) exist.
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        // Append a special charater seperator (DRY CODE)
                        fullName += specialCharater;
                    }
                    //  Convert last name into initial (DRY CODE)
                    char middleInitial = MiddleName.First();
                    fullName += char.ToUpper(middleInitial);
                }
                return fullName;
            }
        }

        
    }
}
