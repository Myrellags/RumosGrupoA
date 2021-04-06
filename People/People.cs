using System;

namespace People
{
    public class People
    {
        #region "atributos"
        private int _idPeople;       //private int _idPessoa;
        private int _idUser;         //private int _idUsuario;
        private string _surname;     //private string _apelido;
        private string _site;        //private string _site;
        private string _NIF;         //private string _NIF;
        private string _CC;          //private string _CC;
        private string _note;        //private string _observacao;
        private string _address;     //private string _logradouro;
        private string _number;      //private string _numero;
        private string _district;    //private string _bairro;
        private string _city;        //private string _cidade;
        private string _country;     //private string _pais;
        private string _postalCode;  //private string _codigoPostal;
        private string _socialMidia; //private string _redeSociais;
        private string _cellPhone;   //private string _telemovel;
        #endregion

        #region "propriedades"
        public int IdPeople
        {
            get { return _idPeople; }
            set { _idPeople = value; }
        }
        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Site
        {
            get { return _site; }
            set { _site = value; }
        }
        public string NIF
        {
            get { return _NIF; }
            set { _NIF = value; }
        }
        public string CC
        {
            get { return _CC; }
            set { _CC = value; }
        }
        public string Note        {
            get { return _note; }
            set { _note = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string District
        {
            get { return _district; }
            set { _district = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        public string SocialMidia
        {
            get { return _socialMidia; }
            set { _socialMidia = value; }
        }
        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }
        #endregion

        #region "construtores"
        public People()
        {

        }
        public People(int idPeople, int idUser, string surname, string site, string NIF, string CC, string note,
                        string address, string number, string district, string city, string country, string postalCode,
                        string socialMidia, string cellPhone)
        {
            _idPeople = idPeople;
            _idUser = idUser;
            _surname = surname;
            _site = site;
            _NIF = NIF;
            _CC = CC;
            _note = note;
            _address = address;
            _number = number;
            _district = district;
            _city = city;
            _country = country;
            _postalCode = postalCode;
            _socialMidia = socialMidia;
            _cellPhone = cellPhone;
        }
        #endregion

        #region "métodos"
        public void InserePessoa()
        {
            // Instanciando a classe people
            People people = new People();
            

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