namespace Lab2
{
    public class Lab2
    {
        public bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                throw new Exception("Strings length is not equal");

            if (s1 == s2)
                return true;

            var s1Array = s1.ToCharArray();
            var s2Array = s2.ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            s1 = new string(s1Array);
            s2 = new string(s2Array);
            return s1.Equals(s2); 
        }

        public string GetTimeOfDay(DateTime dateTime)
        {
            if (dateTime.Hour >= 0 && dateTime.Hour < 6)
            {
                return "Night"; 
            }
            else if (dateTime.Hour >= 6 && dateTime.Hour < 12)
            {
                return "Morning"; 
            }
            else if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return "Noon"; 
            }
            return "Evening"; 
        }

    }
}