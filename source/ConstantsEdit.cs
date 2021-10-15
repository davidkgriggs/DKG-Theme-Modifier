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

        public static object IntroLength(string path, string sIntroLength)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--IL--><sys:TimeSpan x:Key=\"IntroTimespan\">0:0:");
            int End = ConstantsRead.IndexOf("</sys:TimeSpan><!--IL-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--IL--><sys:TimeSpan x:Key=\"IntroTimespan\">0:0:" + sIntroLength + TextAfter;
            System.IO.File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }

        public static object IntroVideoVolume(string path, string search, bool replace)
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
            int Length = Start + 31;
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(Length);
            string Replaced = TextBefore + "<Color x:Key=\"UIColour\">#" + replace + TextAfter;
            File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }

        public static object RoundedCorners(string path, string sRoundedCorners)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--CR--><Setter Property=\"CornerRadius\" Value=\"");
            int End = ConstantsRead.IndexOf("\"/><!--CR-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--CR--><Setter Property=\"CornerRadius\" Value=\"" + sRoundedCorners + TextAfter;
            System.IO.File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }
    }
}
