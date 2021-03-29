using System;

namespace People
{
    public class People
    {
        #region "atributos"
        private int _idPessoa;
        private int _idUsuario;
        private string _apelido;
        private string _site;
        private string _NIF;
        private string _CC;
        private string _observacao;
        private string _logradouro;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _pais;
        private string _codigoPostal;
        private string _redeSociais;
        private string _telemovel;
        #endregion

        #region "propriedades"
        public int IdPessoa
        {
            get { return _idPessoa; }
            set { _idPessoa = value; }
        }
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        public string Apelido
        {
            get { return _apelido; }
            set { _apelido = value; }
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
        public string Obeservacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
        public string Logradouro
        {
            get { return _logradouro; }
            set { _logradouro = value; }
        }
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }
        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }
        public string RedesSociais
        {
            get { return _redeSociais; }
            set { _redeSociais = value; }
        }
        public string Telemovel
        {
            get { return _telemovel; }
            set { _telemovel = value; }
        }
        #endregion

        #region "construtores"
        public People()
        {

        }
        public People(int idPessoa, int idUsuario, string apelido, string site, string NIF, string CC, string observacao,
                        string logradouro, string numero, string bairro, string cidade, string pais, string codigoPostal,
                        string redeSociais, string telemovel)
        {
            _idPessoa = idPessoa;
            _idUsuario = idUsuario;
            _apelido = apelido;
            _site = site;
            _NIF = NIF;
            _CC = CC;
            _observacao = observacao;
            _logradouro = logradouro;
            _numero = numero;
            _bairro = bairro;
            _cidade = cidade;
            _pais = pais;
            _codigoPostal = codigoPostal;
            _redeSociais = redeSociais;
            _telemovel = telemovel;
        }
        #endregion

        #region "métodos"
        public void InserePessoa()
        {
            // Instanciando a classe people
            People people = new People();
            

            //Gravando no batabase
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
            db.SubmitChanges();*/

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