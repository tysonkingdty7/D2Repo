

    public class Userorder
    {
        public static void Display()
        {
            System.Console.WriteLine("V 2");
            UserManger mgr
                 = new UserManger();
            System.Console.WriteLine(mgr.Get()[0].ToString());
        }
    }

