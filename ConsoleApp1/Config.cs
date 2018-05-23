
namespace AutotestFramework
{
    public static class Config
    {
        public static string HomePage = "http://testing.todvachev.com";

        public static class Credentials
        {
            public static class Valid
            {
                public static string username = "Fmchora";
                public static string password = "Paswword1234";
                public static string repeatPassword = "Paswword1234";
                public static string email = "fmchora@gmail.com";
            }  

            public static class Invalid
            {
                public static string username = "";
                public static string password = "";
                public static string repeatPassword = "";
                public static string email = ""; 


                public static class Username
                {
                    public static string FourCharacters = "Fmch";
                    public static string FiftheenCharacters = "kdjeirolskemfks";
                }
                public static class Password
                {
                    public static string TwoCharacters = "pi";
                    public static string AllLowerCase = "hello";
                }
                public static class Email
                {
                    public static string InvalidProvider = "fmchora@1111.com";
                    public static string NotAndEmail = "helloWorld";
                }

            }
        }
    }
}
