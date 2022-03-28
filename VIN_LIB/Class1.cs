using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        private char[] _acceptChars = new char[]
        {
            'A','B','C','D','E','F','G','H','J','K','L','M','N','P','R','S','T','U','V','W','X','Y','Z'
        };

        private string[] _lands = new string[]
        {
            "Африка", "Азия", "Европа", "Северная", "Америка", "Океания", " Южная Америка"
        };

        private Dictionary<string, string> _countries = new Dictionary<string, string>()
        {
            ["AA-AH"] = "ЮАР",
            ["AJ-AN"] = "Кот-ид’Ивуар",
            ["AP-A0"] = "не используется",
            ["BA-BE"] = "Ангола",
            ["BF-BK"] = "Кения",
            ["BL-BR"] = "Танзания",
            ["BS-B0"] = "не используется",
            ["CA-CE"] = "Бенин",
            ["CF-CK"] = "Мадагаскар",
            ["CL-CR"] = "Тунис",
            ["CS-C0"] = "не используется",
            ["DA-DE"] = "Египет",
            ["DF-DK"] = "Марокко",
            ["DL-DR"] = "Замбия",
            ["DS-D0"] = "не используется",
            ["EA-EE"] = "Эфиопия",
            ["EF-EK"] = "Мозамбик",
            ["EL-E0"] = "не используется",
            ["FA-FE"] = "Гана",
            ["FF-FK"] = "Нигерия",
            ["FL-F0"] = "не используется",
            ["GA-G0"] = "не используется",
            ["HA-H0"] = "не используется",
            ["JA-JT"] = "Япония",
            ["KA-KE"] = "Шри Ланка",
            ["KF-KK"] = "Израиль",
            ["KL-KR"] = "Южная Корея",
            ["KS-K0"] = "Казахстан",
            ["LA-L0"] = "Китай",
            ["MA-ME"] = "Индия",
            ["MF-MK"] = "Индонезия",
            ["ML-MR"] = "Таиланд",
            ["MS-M0"] = "не используется",
            ["NF-NK"] = "Пакистан",
            ["NL-NR"] = "Турция",
            ["NT-N0"] = "не используется",
            ["PA-PE"] = "Филиппины",
            ["PF-PK"] = "Сингапур",
            ["PL-PR"] = "Малайзия",
            ["PS-P0"] = "не используется",
            ["RA-RE"] = "ОАЭ",
            ["RF-RK"] = "Тайвань",
            ["RL-RR"] = "Вьетнам",
            ["RS-R0"] = "Саудовская Аравия",
            ["SA-SM"] = "Великобритания",
            ["SN-ST"] = "Германия",
            ["SU-SZ"] = "Польша",
            ["S1-S4"] = "Латвия",
            ["TA-TH"] = "Швейцария",
            ["TJ-TP"] = "Чехия",
            ["TR-TV"] = "Венгрия",
            ["TW-T1"] = "Португалия",
            ["UH-UM"] = "Дания",
            ["UN-UT"] = "Ирландия",
            ["UU-UZ"] = "Румыния",
            ["U5-U7"] = "Словакия",
            ["VA-VE"] = "Австрия",
            ["VF-VR"] = "Франция",
            ["VS-VW"] = "Испания",
            ["VX-V2"] = "Сербия",
            ["V3-V5"] = "Хорватия",
            ["V6-V0"] = "Эстония",
            ["W"] = "Германия",
            ["XA-XE"] = "Болгария",
            ["XF-XK"] = "Греция",
            ["XL-XR"] = "Нидерланды",
            ["XS-XW"] = "Россия(бывший СССР)",
            ["XX-X2"] = "Люксембург",
            ["X3-X0"] = "Россия",
            ["YA-YE"] = "Бельгия",
            ["YF-YK"] = "Финляндия",
            ["YL-YR"] = "Мальта",
            ["YS-YW"] = "Швеция",
            ["YX-Y2"] = "Норвегия",
            ["Y3-Y5"] = "Беларусь",
            ["Y6-Y0"] = "Украина",
            ["ZA-ZR"] = "Италия",
            ["ZX-Z2"] = "Словения",
            ["Z3-Z5"] = "Литва",
        };

        public bool CheckVIN(string vin)
        {
            if (vin.Any(v => !char.IsDigit(v) && !_acceptChars.Contains(v)))
            {
                return false;
            }
            return true;
        }

        public string GetVINCountry(string vin)
        {
            return "";
        }

        public int GetTransportYear(string vin)
        {
            if (vin.Length != 17)
            {
                return -1;
            }

            int result = 0;

            char yearCode = vin[9];

            if (char.IsDigit(yearCode))
            {
                result = 2001 - 49 + (int)yearCode;
            }
            else if (char.IsLetter(yearCode))
            {
                result = 1980 - 65 + (int)yearCode;
            }

            return result;
        }
    }
}