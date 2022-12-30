using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// ---------- made by Anthony Nabil farag  ---------------------
// ---------- code: 20210065 -----------------------------------





namespace calculators
{
    class Calculate
    {
        public static int _operation;


        public static void Setoperation(string operation)
        {
            if(operation == "NULL")
            {
                _operation = 0;
            }

            if (operation == "+")
            {
                _operation = 1;
            }

            else if (operation == "-")
            {
                _operation = 2;
            }

            else if (operation == "x")
            {
                _operation = 3;
            }

            else if (operation == "/")
            {
                _operation = 4;
            }
        }


        public static string Calculation(string value1, string value2, int operation)
        {
            if(_operation == 0)
            {
                return "nothing to compute";
            }

            if (_operation == 1)
            {
                try
                {
                    return (float.Parse(value1) + float.Parse(value2)).ToString();
                }
                catch(Exception e)
                {
                    return e.Message;
                }
            }

            else if (_operation == 2)
            {
                try
                {
                    return (float.Parse(value1) - float.Parse(value2)).ToString();
                }
                catch(Exception e)
                {
                    return e.Message;
                }
            }

            else if (_operation == 3)
            {
                try
                {
                    return (float.Parse(value1) * float.Parse(value2)).ToString();
                }

                catch(Exception e)
                {
                    return e.Message;
                }
            }

            else if (_operation == 4)
            {
                float y = float.Parse(value1);

                if (y == 0.0 || y == 0 || (float.Parse(value2) / float.Parse(value1)).ToString() == "0")
                {
                    return "Error: division by zero";
                }

                try
                {
                    return (float.Parse(value2) / int.Parse(value1)).ToString();
                }
                catch(Exception e)
                {
                    return "couldn't parse the string, please try again";
                }
            }

            else
            {
                return "something went wrong";
            }
        }


    }
}

