using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Personal
{
    public class Person
    {

        #region "propriedades"
        [StringLength(60)]
        public string Surname { get; set; }
        public string Site { get; set; }
        [StringLength(11)]
        public string NIF { get; set; }
        [StringLength(15)]
        public string CC { get; set; }
        [StringLength(200)]
        public string Note { get; set; }
        [StringLength(100)]
        public string Morada { get; set; }
        [StringLength(10)]
        public string Number { get; set; }
        [StringLength(60)]
        public string District { get; set; }
        [StringLength(60)]
        public string City { get; set; }
        [StringLength(60)]
        public string Country { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(60)]
        public string SocialMidia { get; set; }
        [StringLength(15)]
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
    }
}
