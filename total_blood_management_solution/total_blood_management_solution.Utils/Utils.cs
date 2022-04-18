using System;

namespace total_blood_management_solution_Utils
{
    public class Utils
    {

        public static string getObjectToString(object obj)
        {
            string str = obj.ToString();
            string result = str;
            if(obj == null)
            {
                result = "";
            }
            else
            {
            }
            return result;
        }
        
        
        public static bool passwordVerified(string in_pw ,string db_pw)
        {
            bool result = false;
            result = BCrypt.Net.BCrypt.Verify(in_pw, db_pw );
            return result;
        }
    }
}
