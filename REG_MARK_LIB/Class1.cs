using System;
using System.Linq;

namespace REG_MARK_LIB
{
    public class Class1
    {
        private char[] _acceptChars = new char[]
        {
            'A','B','E','K','M','H','O','P','C','T','Y','X'
        };

        public bool CheckMark(string mark)
        {
            if (mark.Length != 9)
            {
                return false;
            }

            if (!char.IsLetter(mark[0]) ||
                mark.Substring(1, 3).Any(m => !char.IsDigit(m)) ||
                mark.Substring(4, 2).Any(m => !char.IsLetter(m)) ||
                mark.Substring(6, 3).Any(m => !char.IsDigit(m)))
            {
                return false;
            }

            if (mark.Any(m => !char.IsDigit(m) && !_acceptChars.Contains(m)))
            {
                return false;
            }

            return true;
        }

        public string GetNextMarkAfter(string mark)
        {
            if (!CheckMark(mark))
            {
                return mark;
            }

            int serie = int.Parse(mark.Substring(1, 3));
            string regNum = mark.Substring(4, 2);
            ++serie;

            string firstLetter = mark[0].ToString();

            if (serie == 1000)
            {
                firstLetter = _acceptChars[Array.IndexOf(_acceptChars, mark[0]) + 1].ToString();
                serie = 000;
            }
            else if (regNum != "XX")
            {
                char newLettter = _acceptChars.ElementAtOrDefault(Array.IndexOf(_acceptChars, regNum[1]) + 1);
                regNum = newLettter == default(char) ? _acceptChars[Array.IndexOf(_acceptChars, regNum[0]) + 1].ToString() + regNum[1].ToString() : regNum[0].ToString() + newLettter.ToString();
                --serie;
            }
            else
            {

            }

            mark = firstLetter + serie + regNum + mark.Remove(0, 6);
            return mark;
        }

        public string GetNextMarkAfterInRange(string prevMark, string rangeStart, string rangeEnd)
        {
            return "";
        }

        public int GetCombinationsCountInRange(string mark1, string mark2)
        {
            return 0;
        }
    }
}