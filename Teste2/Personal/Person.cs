using System;

namespace Ecommerce.Personal
{
    public class Person
    {

        #region "propriedades"
        public int PersonID { get; set; }
        public string Surname { get; set; }
        public string Site { get; set; }
        public string NIF { get; set; }
        public string CC { get; set; }
        public string Note { get; set; }
        public string Morada { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string SocialMidia { get; set; }
        public string CellPhone { get; set; }
        #endregion

        #region "construtores"
        public Person()
        {

        }
        public Person(string surname, string site, string nif, string cc, string note,
                        string morada, string number, string district, string city, string country, string postalCode,
                        string socialMidia, string cellPhone)
        {
            Surname = surname;
            Site = site;
            NIF = NIF;
            CC = CC;
            Note = note;
            Morada = morada;
            Number = number;
            District = district;
            City = city;
            Country = country;
            PostalCode = postalCode;
            SocialMidia = socialMidia;
            CellPhone = cellPhone;
        }
        #endregion

        #region "métodos"
        public void InserePessoa()
        {
            // Instanciando a classe people
            Person people = new Person();


            //Gravando no database
            try
            {
                //db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //db.SubmitChanges();
            }

        }
        #endregion
    }
}
//EXAMPLES
/* ----------INSERT
            EmployeeDBDataContext db = new EmployeeDBDataContext();
            EmployeeDetail emp = new EmployeeDetail();
            emp.EmpName = txtname.Text;
            emp.Location = txtlocation.Text;
            db.EmployeeDetails.InsertOnSubmit(emp);
            db.SubmitChanges();
*/

/*----------DELETE
            EmployeeDBDataContext db = new EmployeeDBDataContext();
            EmployeeDetail emp = new EmployeeDetail();
            emp = db.EmployeeDetails.Single(x => x.EmpId == empid);
            db.EmployeeDetails.DeleteOnSubmit(emp);
            db.SubmitChanges();
*/

/*----------UPDATE
            EmployeeDBDataContext db = new EmployeeDBDataContext();
            EmployeeDetail emp = new EmployeeDetail();
            emp = db.EmployeeDetails.Single(x => x.EmpId == empid);
            emp.EmpName = txtname.Text;
            emp.Location = txtlocation.Text;
            emp.Gender = txtgender.Text;
            db.SubmitChanges();
*/

/*----------READ
*/