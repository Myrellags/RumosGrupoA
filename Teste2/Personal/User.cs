using System;

namespace Ecommerce.Personal
{
    public class User
    {
        #region "ATRIBUTOS USER" 
        private int _idUser;
        private int _idPerson;
        private string _passUser;
        

        #endregion
        #region "PROPRIEDADES USER"
        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        public int idPerson
        {
            get { return _idPerson; }
            set { _idPerson = value; }
        }
        public string PassUser
        {
            get { return _passUser; }
            set { _passUser = value; }
        }
       
        #endregion
        #region "CONSTRUTORES USER"
        public User()
        {

        }
        public User(int idUser, int idPerson, string passUser)
        {
            _idUser = idUser;
            _idPerson = idPerson;
            _passUser = passUser;
        }
        #endregion

    }
}

