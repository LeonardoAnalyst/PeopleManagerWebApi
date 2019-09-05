using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleManagerWebapi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Address { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }

    }
}