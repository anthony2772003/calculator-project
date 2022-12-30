using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ---------- made by Anthony Nabil farag  ---------------------
// ---------- code: 20210065 -----------------------------------



namespace calculators
{
    class Screen
    {

        static string value1 = "00000000";
        static string value2 = "00000000";
        static string result = "00000000";

        static Screen()
        {
            value1 = "00000000";
            value2 = "00000000";
        }


        static public void SetValue(string s)
        {
            if (value2 == "00000000")
            {
                value2 = s;
            }

            else if (value1 == "00000000")
            {
                value1 = s;
            }

            if (value1 != "00000000" && value2 != "00000000")
            {
                calc();
                value1 = result;
                value2 = "00000000";
            }

        }


        static public string SetValue2(string s)
        {
            if (value1 == "00000000")
            {
                value1 = s;
            }

            else if (value2 == "00000000")
            {
                value2 = s;
            }

            if (value1 != "00000000" && value2 != "00000000")
            {
                result = Calculate.Calculation(GetValue2(), GetValue1(), Calculate._operation);
                value1 = "00000000";
                value2 = "00000000";
                return GetResult();
            }

            else
            {
                return "";
            }
        }

        static public void ClearValue()
        {
            Screen.value1 = "00000000";
            Screen.value2 = "00000000";
            Screen.result = "00000000";
        }


        static public string calc()
        {
            return result = Calculate.Calculation(GetValue1(), GetValue2(), Calculate._operation);
        }

        static public string GetResult()
        {
            return result;
        }


        static public string GetValue1()
        {
            return value1;
        }

        static public string GetValue2()
        {
            return value2;
        }

    }

}
