using System;
using System.Collections.Generic;

namespace Calendar
{
  public class LeapYear
  {
    public bool IsLeapYear(int year)
    {
      // if year is valid number: year > 0
      if (year > 0)
      {
        // if year is not divisible by 4
        if (year % 4 != 0)
        {
          return false;
        }
        // if year divisible by four not by 100
        else if (year % 100 != 0)
        {
          return true;
        }
        // if year not divisible by 400
        else if (year % 400 != 0)
        {
          return false;
        }
        else
        {
          return true;
        }
      }
      else
      {
        Console.WriteLine("Enter a valid year.");
        return false;
      }

    }
  }
}
