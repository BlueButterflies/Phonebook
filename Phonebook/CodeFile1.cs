using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Phonebook;

static class Variable
{
    public static string variableDatabase = Environment
        .GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
        @"\Projects\Phonebook\Database\";

    public static string variableDatabasePicture = variableDatabase + @"\Picture\";

    public static string verisonSoftware = "0.17";
    public static string nameSoftware = "Phonebook";

    public static void ControlDatabaseUser()
    {
        if (Phonebook.Properties.Settings.Default.DatabasePath != "")
        {
            variableDatabase = Phonebook.Properties.Settings.Default.DatabasePath + @"\Projects\Phonebook\Database\";

            variableDatabasePicture = variableDatabase + @"\Picture\";
        }
    }

    public static void ControlRouteDatabase()
    {
        if (Directory.Exists(variableDatabase) == false || Directory.Exists(variableDatabasePicture) == false)
        {
            Directory.CreateDirectory(variableDatabase);
            Directory.CreateDirectory(variableDatabasePicture);
        }
    }

    public static int CounterNumberElement() => Directory.GetFiles(variableDatabase).Length;

    public static string[] ChargeItems()
    {
        string[] foundElements = Directory.GetFiles(variableDatabase);

        return foundElements;
    }

    public static string ZodiacSign(string dateBirthday)
    {
        string zodiacSign = " ";

        //Format 01/01/1900
        int dayBirth = int.Parse(dateBirthday.Substring(0, 2));
        int monthBirth = int.Parse(dateBirthday.Substring(3, 2));

        if ((dayBirth >= 21 && monthBirth == 03) || (dayBirth <= 19 && monthBirth == 04))
        {
            zodiacSign = "Aries";
        }
        else if ((dayBirth >= 20 && monthBirth == 04) || (dayBirth <= 20 && monthBirth == 05))
        {
            zodiacSign = "Taurus";
        }
        else if ((dayBirth >= 21 && monthBirth == 05) || (dayBirth <= 20 && monthBirth == 06))
        {
            zodiacSign = "Gemini";
        }
        else if ((dayBirth >= 21 && monthBirth == 06) || (dayBirth <= 22 && monthBirth == 07))
        {
            zodiacSign = "Cancer";
        }
        else if ((dayBirth >= 23 && monthBirth == 07) || (dayBirth <= 23 && monthBirth == 08))
        {
            zodiacSign = "Leo";
        }
        else if ((dayBirth >= 24 && monthBirth == 08) || (dayBirth <= 22 && monthBirth == 09))
        {
            zodiacSign = "Vergo";
        }
        else if ((dayBirth >= 23 && monthBirth == 09) || (dayBirth <= 22 && monthBirth == 10))
        {
            zodiacSign = "Libra";
        }
        else if ((dayBirth >= 23 && monthBirth == 10) || (dayBirth <= 21 && monthBirth == 11))
        {
            zodiacSign = "Scorpio";
        }
        else if ((dayBirth >= 22 && monthBirth == 11) || (dayBirth <= 21 && monthBirth == 12))
        {
            zodiacSign = "Sagittarius";
        }
        else if ((dayBirth >= 22 && monthBirth == 12) || (dayBirth <= 19 && monthBirth == 01))
        {
            zodiacSign = "Capricorn";
        }
        else if ((dayBirth >= 20 && monthBirth == 01) || (dayBirth <= 19 && monthBirth == 02))
        {
            zodiacSign = "Aquarius";
        }
        else if ((dayBirth >= 20 && monthBirth == 02) || (dayBirth <= 20 && monthBirth == 03))
        {
            zodiacSign = "Pisces";
        }

        return zodiacSign;
    }

    public static string CalcoleteAge(string dateBirth)
    {
        DateTime dateNow = DateTime.Now;
        DateTime dateBirths = Convert.ToDateTime(dateBirth);

        int diff = dateNow.Year - dateBirths.Year;

        if (dateBirths.Month >= dateNow.Month && dateBirths.Day > dateNow.Day)
        {
            diff -= 1;
        }

        string age = diff.ToString();

        return age;
    }
}
