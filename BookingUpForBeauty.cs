using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime dt = DateTime.Parse("11/23/2021 11:00:00");
        string s2 = dt.ToString("dd/MM/yyyy HH:mm:ss");
        DateTime dtnew = DateTime.Parse(s2);
        return dtnew;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        DateTime todaysDate = DateTime.Today;
        int result = DateTime.Compare(appointmentDate, todaysDate);

        if(result < 0)
        {
            Console.WriteLine("The appointment is in the future");
            return true;
        }
        else
        {
            Console.WriteLine("The appointment date is in the past.");
            return false;
        }
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if(appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string Description(DateTime appointmentDate)
    {
        DateTime currentTime = DateTime.Now;
        string desc = "You have an appointment on " + appointmentDate;
        return desc;
    }

    public static DateTime AnniversaryDate()
    {
        DateTime anniversaryDate = DateTime.Parse("yyyy, MM, dd, HH, mm, ss");
        return anniversaryDate;
    }
}