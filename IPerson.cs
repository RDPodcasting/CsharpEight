using NUnit.Framework;
using System;

namespace CsharpNewVersion
{
     
    interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        class User: IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }

        }

        [TestFixture]
        class TestePerson
        {
            [Test]
            public void InterfaceImplementacaoMetodoComRetornoPadrao()
            {
                IPerson person = new User();
                person.BirthDate = Convert.ToDateTime("05/10/1993");

                Assert.That((DateTime.Now.Year - person.BirthDate.Year), Is.EqualTo(person.GetAge()));
            }
        }
    }
}
