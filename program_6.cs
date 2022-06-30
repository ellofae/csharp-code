using System;

class Program
{
    public struct Phone
    {
        public int CityCode;
        public int StationCode;
        public int UsersNum;

        public Phone(int citycode, int stationcode, int usersnum)
        {
            CityCode = citycode;
            StationCode = stationcode;
            UsersNum = usersnum;
        }

        public readonly void DisplayNumber()
        {
            Console.WriteLine($"Phone number: {CityCode.ToString()} {StationCode.ToString()}-{UsersNum.ToString()}");
        }
    }

    public static void Main()
    {
        Phone phoneNum1 = new Phone(412, 767, 8900);
        Phone phoneNum2 = new Phone();
        
        string[] tempNumber = new string[3];

        Console.Write("Type in your phone number(with spaces): ");
        string phoneNumberInput = Console.ReadLine();
        tempNumber = phoneNumberInput.Split(' ');

        for(int i = 0; i < 3; i++)
        {
            phoneNum2.CityCode = Convert.ToInt32(tempNumber[0]);
            phoneNum2.StationCode = Convert.ToInt32(tempNumber[1]);
            phoneNum2.UsersNum = Convert.ToInt32(tempNumber[2]);
        }

        phoneNum1.DisplayNumber();
        phoneNum2.DisplayNumber();
    }
}
