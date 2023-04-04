using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DbProject.Component
{
    public class validation
    {
        public static string FirstNameRegex = "^[A-Za-z]{1,11}$";
        public static string SecondNameRegex = "^[A-Za-z]{1,11}$";
        public static string EmailRegex = "^\\S+@\\S+\\.\\S+$";
        public static string GenderRegex = "^M(ale)?$|^F(emale)?$";
        public static string ContactRegex = "^[0-9]{11,11}$";
        public static string RegNoRegex = "^[0-9]{1,4}-[A-Za-z]{2}-[0-9]{1,3}$";
        public static string SalaryRegex = "^[0-9]{1,}$";
        public static string DesignationRegex = "^(Professor)?$|^(Associate Professor)?$|^(Assisstant Professor)?$|^(Lecturer)?$|^(Industry Professional)?$";
        //public static string NameRegex = "^[A-Za-z]{1,11}";
        public static string TotalWeightageregex = "^[1-9,0-9]{1,2}$";
        public static string totalmarksRegex = "^[1-9,0-9]{1,}$";
        public static string obtainmarksRegex = "^(\\d)*(\\.)?([0-9]{1})?$";

        public static bool CheckObtainMarks(string obtainmarks)
        {
            return Regex.IsMatch(obtainmarks, obtainmarksRegex);
        }
        public static bool Checkweightage(string weightage)
        {
            return Regex.IsMatch(weightage, TotalWeightageregex);
        }

        public static bool CheckMarks(string Marks)
        {
            return Regex.IsMatch(Marks, totalmarksRegex);
        }
        public static bool CheckSalary(string salary)
        {
            return Regex.IsMatch(salary, SalaryRegex);
        }
        public static bool CheckRegNo( string RegNo )
        {
            return Regex.IsMatch(RegNo, RegNoRegex);
        }
        public static bool CheckDesignation(string Designation)
        {
            return Regex.IsMatch(Designation, DesignationRegex);
        }
        public static bool CheckFirstName( string name )
        {
            return Regex.IsMatch( name, FirstNameRegex );
        }
        public static bool CheckSecondName(string name)
        {
            return Regex.IsMatch(name, SecondNameRegex);
        }
        public static bool CheckEmail( string Email )
        {
            return Regex.IsMatch ( Email, EmailRegex );
        }
        public static bool CheckContact( string rate )
        {
            return Regex.IsMatch(rate, ContactRegex);
        }

        public static bool CheckGender(string Gender)
        {
            return Regex.IsMatch(Gender,GenderRegex);
        }

       
    }
}
