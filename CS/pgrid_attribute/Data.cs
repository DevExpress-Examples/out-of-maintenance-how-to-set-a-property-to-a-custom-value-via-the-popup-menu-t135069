using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevExpress.Mvvm.DataAnnotations;

namespace pgrid_attribute {
    public class EmployeesViewModel {
        public virtual EmployeesData Data { get; protected set; }
        public EmployeesViewModel() {
            Data = new EmployeesData() {
                FirstName = "Anita",
                LastName = "Benson",
                Group = "Inventory Management",
                HireDate = new DateTime(2002, 2, 2),
                Salary = 65000m,
                Phone = "7138638137",
                Email = "Anita_Benson@example.com",
                AddressLine1 = "9602 South Main",
                AddressLine2 = "Seattle, 77025, USA",
                BirthDate = new DateTime(1985, 3, 18)
            };
        }
    }
    public class EmployeesData {
        const string JobGroup = "Job";
        const string ContactGroup = "Contact";
        const string AddressGroup = "Address";
        const string Personal = "Personal";
        const string NameGroup = "Name";

        [Display(GroupName = NameGroup, Name = "First name")]
        public string FirstName { get; set; }
        [Display(GroupName = NameGroup, Name = "Last name")]
        public string LastName { get; set; }

        [Display(GroupName = JobGroup)]
        public string Group { get; set; }
        [DisplayFormat(NullDisplayText = "Title not set"), Display(GroupName = JobGroup)]
        public string Title { get; set; }
        [Display(GroupName = JobGroup, Name = "Hire date")]
        public DateTime HireDate { get; set; }
        [Display(GroupName = JobGroup), DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Display(GroupName = JobGroup, Name = "Clients")]
        [InstanceInitializer(typeof(Clients), "New Client")]
        public object Clients { get; set; }

        [Display(GroupName = ContactGroup), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Display(GroupName = ContactGroup), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(GroupName = Personal, Name = "Birth date")]
        [DisplayFormat(DataFormatString = "m", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Display(GroupName = AddressGroup, Name = "Address line 1")]
        public string AddressLine1 { get; set; }
        [Display(GroupName = AddressGroup, Name = "Address line 2")]
        public string AddressLine2 { get; set; }
    }
    public class Client {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
    public class Clients : List<Client> { }
}