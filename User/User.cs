using System;

namespace User
{
    public class User
    {
        int _idUser;
        string _nameUser;
        string _passUser;
        string _emailUser;
        string _subnameUser;
        string _adressUser;
        string _countryUser;
        string _contact1User;
        string _contact2User;
        string _nifUser;

        #region "PROPRIEDADES USER"

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        public string NameUser
        {
            get { return _nameUser ; }
            set { _nameUser = value; }
        }
        public string PassUser
        {
            get { return _passUser; }
            set { _passUser = value; }
        }
        public string EmailUser
        {
            get { return _emailUser; }
            set { _emailUser = value; }
        }
        public string AdressUser
        {
            get { return _adressUser; }
            set { _adressUser = value; }
        }
        public string CountryUser
        {
            get { return _countryUser; }
            set { _countryUser = value; }
        }
        public string Contact1User
        {
            get { return _contact1User; }
            set { _contact1User = value; }
        }
        public string Contact2User
        {
            get { return _contact2User; }
            set { _contact2User = value; }
        }
        public string NifUser
        {
            get { return _nifUser; }
            set { _nifUser = value; }
        }
        #endregion


    }
}
