using System;

namespace dotNetMVC
{
    public class PersonModel 
    {
        public string firstName{set; get;}
        public string lastName{set; get;}
        public DateTime dateOfBirth{set; get;}
        public string gender{set; get;}
        public int phoneNumber{set; get;}
        public string emailAddress{set; get;}
        public string birthPlace{set; get;}
        public int age{set; get;}
        public bool isGraduated{set; get;}

        public PersonModel(string firstName, string lastName, DateTime dateOfBirth, string gender,string emailAddress, int phoneNumber, string birthPlace, int age, bool isGraduated)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.birthPlace = birthPlace;
            this.age = age;
            this.isGraduated = isGraduated;
        }
    }
}
