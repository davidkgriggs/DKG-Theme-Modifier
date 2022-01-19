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
        public static object DKGThemeModifierDirectory(string path, string DKGThemeModifierPath)
        {
            string ConstantsLocation = path;
            string ReadConstants = File.ReadAllText(ConstantsLocation);
            ReadConstants = ReadConstants.Replace("<sys:String x:Key=\"DKGThemeModifierPath\">.</sys:String>", "<sys:String x:Key=\"DKGThemeModifierPath\">" + DKGThemeModifierPath + "</sys:String>");
            File.WriteAllText(ConstantsLocation, ReadConstants);
            return null;
        }

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

        public static object DarkMode(string path)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"DarkLightBackground\">#cbcbcb</Color>", "<Color x:Key=\"DarkLightBackground\">#1E1E1C</Color>");
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"SelectedColour\">#d8d8d8</Color>", "<Color x:Key=\"SelectedColour\">#262724</Color>");
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"TabsColour\">#e1e1e1</Color>", "<Color x:Key=\"TabsColour\">#2F2F2C</Color>");
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"TextColor\">#101010</Color>", "<Color x:Key=\"TextColor\">#FFEBEBEB</Color>");
            ConstantsRead = ConstantsRead.Replace("<GradientStop Color=\"#e1e1e1\" Offset=\"0\"/>", "<GradientStop Color=\"#404040\" Offset=\"0\"/>");
            ConstantsRead = ConstantsRead.Replace("<GradientStop Color=\"#D0D0D0\" Offset=\"0.5\"/>", "<GradientStop Color=\"#303030\" Offset=\"0.5\"/>");

            System.IO.File.WriteAllText(ConstantsLocation, ConstantsRead);
            return null;
        }

        public static object LightMode(string path)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"DarkLightBackground\">#1E1E1C</Color>", "<Color x:Key=\"DarkLightBackground\">#cbcbcb</Color>");
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"SelectedColour\">#262724</Color>", "<Color x:Key=\"SelectedColour\">#d8d8d8</Color>");
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"TabsColour\">#2F2F2C</Color>", "<Color x:Key=\"TabsColour\">#e1e1e1</Color>");
            ConstantsRead = ConstantsRead.Replace("<Color x:Key=\"TextColor\">#FFEBEBEB</Color>", "<Color x:Key=\"TextColor\">#101010</Color>");
            ConstantsRead = ConstantsRead.Replace("<GradientStop Color=\"#404040\" Offset=\"0\"/>", "<GradientStop Color=\"#e1e1e1\" Offset=\"0\"/>");
            ConstantsRead = ConstantsRead.Replace("<GradientStop Color=\"#303030\" Offset=\"0.5\"/>", "<GradientStop Color=\"#D0D0D0\" Offset=\"0.5\"/>");

            System.IO.File.WriteAllText(ConstantsLocation, ConstantsRead);
            return null;
        }

        public static object ProfileName(string path, string ProfileN)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--PN--><sys:String x:Key=\"ProfileName\">");
            int End = ConstantsRead.IndexOf("</sys:String><!--PN-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--PN--><sys:String x:Key=\"ProfileName\">" + ProfileN + TextAfter;
            System.IO.File.WriteAllText(ConstantsLocation, Replaced);
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

        public static object ListGameHeight(string path, string sIntroLength)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf("<!--LGH--><sys:Double x:Key=\"ListGamesHeight\">");
            int End = ConstantsRead.IndexOf("</sys:Double><!--LGH-->");
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + "<!--LGH--><sys:Double x:Key=\"ListGamesHeight\">" + sIntroLength + TextAfter;
            System.IO.File.WriteAllText(ConstantsLocation, Replaced);
            return null;
        }

        public static object FilterPresetWidth(string path, bool replace)
        {
            string ConstantsLocation = path;
            string ReadConstants = File.ReadAllText(ConstantsLocation);
            if (replace == true)
            {
                ReadConstants = ReadConstants.Replace("<!--FPW--><sys:Double x:Key=\"FilterWidth\">1920</sys:Double><!--FPW-->", "<!--FPW--><sys:Double x:Key=\"FilterWidth\">2580</sys:Double><!--FPW-->");
            }
            else if (replace == false)
            {
                ReadConstants = ReadConstants.Replace("<!--FPW--><sys:Double x:Key=\"FilterWidth\">2580</sys:Double><!--FPW-->", "<!--FPW--><sys:Double x:Key=\"FilterWidth\">1920</sys:Double><!--FPW-->");
            }
            File.WriteAllText(ConstantsLocation, ReadConstants);
            return null;
        }
    }
}
