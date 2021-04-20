using System;

namespace User
{
    public class User
    {
        #region "ATRIBUTOS USER" 
        private int _idUser;
        private int _idPeople;
        private string  _passUser;
        

        #endregion
        #region "PROPRIEDADES USER"
        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        public int idPeople
        {
            get { return _idPeople; }
            set { _idPeople = value; }
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
        public User(int idUser, int idPeople, string passUser)
        {
            _idUser = idUser;
            _idPeople = idPeople;
            _passUser = passUser;
        }
        #endregion

    }
}

