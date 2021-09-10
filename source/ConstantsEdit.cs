using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DKGThemeModifier
{
    class ConstantsEdit
    {
        public static object TrueFalse(string path, string search, bool replace)
        {
            string ConstantsLocation = path;
            string ReadConstants = File.ReadAllText(ConstantsLocation);
            if (replace == true)
            {
                ReadConstants = ReadConstants.Replace("<sys:Boolean x:Key=\"" + search + "\">false</sys:Boolean>", "<sys:Boolean x:Key=\"" + search + "\">true</sys:Boolean>");
            }
            else if (replace == false)
            {
                ReadConstants = ReadConstants.Replace("<sys:Boolean x:Key=\"" + search + "\">true</sys:Boolean>", "<sys:Boolean x:Key=\"" + search + "\">false</sys:Boolean>");
            }
            File.WriteAllText(ConstantsLocation, ReadConstants);
            return null;
        }

        public static object IntrroLength(string path, string sIntroLength)
        {
            string ConstantsLocation = path;
            string ConstantsRead = File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--IL--><sys:TimeSpan x:Key=\"IntroTimespan\">0:0:");
            int End = ConstantsRead.IndexOf("</sys:TimeSpan><!--IL-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--IL--><sys:TimeSpan x:Key=\"IntroTimespan\">0:0:" + sIntroLength + TextAfter;
            File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }

        public static object IntroVideoVulme(string path, string search, bool replace)
        {
            string ConstantsLocation = path;
            string ReadConstants = File.ReadAllText(ConstantsLocation);
            if (replace == true)
            {
                ReadConstants = ReadConstants.Replace("<!--IVV--><sys:Double x:Key=\"IntroVideoVolume\">0.5</sys:Double><!--IVV-->", "<!--IVV--><sys:Double x:Key=\"IntroVideoVolume\">0</sys:Double><!--IVV-->");
            }
            else if (replace == false)
            {
                ReadConstants = ReadConstants.Replace("<!--IVV--><sys:Double x:Key=\"IntroVideoVolume\">0</sys:Double><!--IVV-->", "<!--IVV--><sys:Double x:Key=\"IntroVideoVolume\">0.5</sys:Double><!--IVV-->");
            }
            File.WriteAllText(ConstantsLocation, ReadConstants);
            return null;
        }

        public static object ColourPicker(string path, string replace)
        {
            string ConstantsLocation = path;
            string ConstantsRead = File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<Color x:Key=\"UIColour\">#");
            int Length = Start + 30;
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(Length + 1);
            string Replaced = TextBefore + "<Color x:Key=\"UIColour\">#" + replace + TextAfter;
            File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }

        public static object FilterPresetSize(string path, string sFilterFontSmall, string sFilterFontLarge, string sFilterShoulderSize)
        {
            string ConstantsLocation = path;
            string ConstantsRead = File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--FFS--><sys:Double x:Key=\"FilterFontSmall\">");
            int End = ConstantsRead.IndexOf("</sys:Double><!--FFS-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--FFS--><sys:Double x:Key=\"FilterFontSmall\">" + sFilterFontSmall + TextAfter;
            File.WriteAllText(ConstantsLocation, Replaced);

            string ConstantsRead2 = File.ReadAllText(ConstantsLocation);
            int Start2 = ConstantsRead2.IndexOf("<!--FFL--><sys:Double x:Key=\"FilterFontLarge\">");
            int End2 = ConstantsRead2.IndexOf("</sys:Double><!--FFL-->");
            string TextBefore2 = ConstantsRead2.Substring(0, Start2);
            string TextAfter2 = ConstantsRead2.Substring(End2);
            string Replaced2 = TextBefore2 + "<!--FFL--><sys:Double x:Key=\"FilterFontLarge\">" + sFilterFontLarge + TextAfter2;
            File.WriteAllText(ConstantsLocation, Replaced2);

            string ConstantsRead3 = File.ReadAllText(ConstantsLocation);
            int Start3 = ConstantsRead3.IndexOf("<!--FF--><sys:Double x:Key=\"FilterShoulderSize\">");
            int End3 = ConstantsRead3.IndexOf("</sys:Double><!--FF-->");
            string TextBefore3 = ConstantsRead3.Substring(0, Start3);
            string TextAfter3 = ConstantsRead3.Substring(End3);
            string Replaced3 = TextBefore3 + "<!--FF--><sys:Double x:Key=\"FilterShoulderSize\">" + sFilterShoulderSize + TextAfter3;
            File.WriteAllText(ConstantsLocation, Replaced3);
            return null;
        }

        public static object DescriptionFontSize(string path, string sFontSize)
        {
            string ConstantsLocation = path;
            string ConstantsRead = File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--DFS--><sys:Double x:Key=\"DescriptionFont\">");
            int End = ConstantsRead.IndexOf("</sys:Double><!--DFS-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--DFS--><sys:Double x:Key=\"DescriptionFont\">" + sFontSize + TextAfter;
            File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }

        public static object RoundedCorners(string path, string sRoundedCorners)
        {
            string ConstantsLocation = path;
            string ConstantsRead = File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--CR--><Setter Property=\"CornerRadius\" Value=\"");
            int End = ConstantsRead.IndexOf("\"/><!--CR-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--CR--><Setter Property=\"CornerRadius\" Value=\"" + sRoundedCorners + TextAfter;
            File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }
    }
}
