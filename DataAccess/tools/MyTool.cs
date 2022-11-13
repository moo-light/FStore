using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DealersManagementProgram.tool
{
    public class MyTool
    {
        public static bool validStr(string str, string regex)
        {
            return Regex.Match(str, regex).Success;
        }
        public static bool validPassword(string str, int minLen)
        {
            if (str.Length < minLen) return false;
            return Regex.Match(str, ".*[a-zA-Z]+.*").Success//At Least 1 Character
                   && Regex.Match(str, ".*[\\d]+.*").Success // At Least 1 DIgit
                   && Regex.Match(str, "[\\W]").Success; //At least 1 Spec char
        }
        //Date Format: yyyy/MM/dd,MM/dd/yyyy , dd/MM/yyyy, ...
        public static DateTime parseDate(string dateStr, string dateFormat)
        {
            return DateTime.ParseExact(dateStr, dateFormat, new CultureInfo("en-US"));//tim hieu sau
        }

        public static string DateToStr(DateTime date, string dateFormat)
        {
            return date.ToString(dateFormat);
        }
        public static bool parseBool(string boolStr)
        {
            char c = boolStr.Trim().ToUpper()[0];
            return c.Equals('1') || c.Equals('Y') || c.Equals('T');
        }
        public static string readNonBlank(string msg)
        {
            String input = "";
            bool valid;
            do
            {
                Console.Write(msg);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("try again!");
                }
            } while (string.IsNullOrEmpty(input));
            return input;
        }
        public static string readPattern(string msg, string pattern)
        {
            String? input;
            bool valid;
            do
            {
                Console.Write($"{msg} [{pattern}]:");
                input = Console.ReadLine();
                if (!validStr(input, pattern))
                {
                    Console.WriteLine("try again!");
                }
            } while (!validStr(input, pattern));
            return input;
        }
        public static bool readBool(string msg)
        {
            String input;
            Console.WriteLine($"{msg} [1/0,Y/N,T/F]");
            input = Console.ReadLine().ToString();
            if (string.IsNullOrEmpty(input)) return false;
            return parseBool(input);
        }
        //method read line from file
        public static List<string> readLineFromFile(string filename)
        {
            List<string> list = new List<string>();
            try
            {
                // tao instance cua StreamReader de doc mot file.
                // lenh using cung duoc su dung de dong StreamReader.
                StreamReader sr = new StreamReader(filename);
                using (sr)
                {
                    string? line;
                    

                    // doc va hien thi cac dong trong file cho toi
                    // khi tien toi cuoi file. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                    sr.Close();
                    sr.Dispose();
                }
            }
            catch (Exception e)
            {
                // thong bao loi.
                Console.WriteLine("Khong the doc du lieu tu file da cho: ");
                Console.WriteLine(e.Message);
            }
            return list;
        }
        // ham nay chap nhan 2 parameter la filename va list
        public static void writeFile(string filename, List<string> list)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {

                foreach (string s in list)
                {
                    sw.Write(s);
                }
            }
            //inra textfile.txt ko phai dealers.txt haizzz
        }
    }
}
