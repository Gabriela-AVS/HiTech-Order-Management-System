using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace HiTechOrderManagementSystem.VALIDATOR
{
    public static class Validator
    {
        public static bool IsValidQuebecPostalCode(string postalCode)
        {
            string pattern = @"^[HhGgJj]\d[A-Za-z] ?\d[A-Za-z]\d$";
            return Regex.IsMatch(postalCode.Trim(), pattern);
        }


        public static bool IsValidPhone(string phone)
        {
            string pattern = @"^\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(phone.Trim(), pattern);
        }

        public static bool IsValidFax(string fax)
        {
            string pattern = @"^\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(fax.Trim(), pattern);
        }


        public static bool IsValidCreditLimit(string credit)
        {
            decimal value;
            return decimal.TryParse(credit, out value) && value >= 0;
        }

        public static string FormatPostalCode(string postalCode)
        {
           
            string clean = postalCode.Replace(" ", "").ToUpper();

            if (clean.Length == 6)
            {
                return clean.Insert(3, " ");  // H3Z2Y7 → H3Z 2Y7
            }

            return postalCode.ToUpper();
        }
    }

}