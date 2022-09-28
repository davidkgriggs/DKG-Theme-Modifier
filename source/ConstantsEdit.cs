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

        public static object Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), true);

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));

            return null;
        }

        public static object RestoreDefaults(string path, string sStart, string sEnd)
        {
            string ConstantsLocation = path;
            string ConstantsRead = System.IO.File.ReadAllText(ConstantsLocation);
            int Start = ConstantsRead.IndexOf(sStart);
            int End = ConstantsRead.IndexOf(sEnd);
            string TextBefore = ConstantsRead.Substring(0, Start);
            string TextAfter = ConstantsRead.Substring(End);
            string Replaced = TextBefore + sStart + TextAfter;
            System.IO.File.WriteAllText(ConstantsLocation, Replaced);
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

        public static object EleganceColours(string path, string C3, string C4, string C5, string C6, string C8)
        {
            string ConstantsLocation = path;

            string ConstantsRead_C3 = File.ReadAllText(ConstantsLocation);            
            int Start_C3 = ConstantsRead_C3.IndexOf("<Color x:Key=\"UIColour\">#");
            int Length_C3 = Start_C3 + 31;
            string TextBefore_C3 = ConstantsRead_C3.Substring(0, Start_C3);
            string TextAfter_C3 = ConstantsRead_C3.Substring(Length_C3);
            string Replaced_C3 = TextBefore_C3 + "<Color x:Key=\"UIColour\">#" + C3 + TextAfter_C3;
            File.WriteAllText(ConstantsLocation, Replaced_C3);

            string ConstantsRead_C4 = File.ReadAllText(ConstantsLocation);
            int Start_C4 = ConstantsRead_C4.IndexOf("<Color x:Key=\"UIColourDark\">#");
            int Length_C4 = Start_C4 + 35;
            string TextBefore_C4 = ConstantsRead_C4.Substring(0, Start_C4);
            string TextAfter_C4 = ConstantsRead_C4.Substring(Length_C4);
            string Replaced_C4 = TextBefore_C4 + "<Color x:Key=\"UIColourDark\">#" + C4 + TextAfter_C4;
            File.WriteAllText(ConstantsLocation, Replaced_C4);

            string ConstantsRead_C5 = File.ReadAllText(ConstantsLocation);
            int Start_C5 = ConstantsRead_C5.IndexOf("<Color x:Key=\"GlyphColor\">#");
            int Length_C5 = Start_C5 + 33;
            string TextBefore_C5 = ConstantsRead_C5.Substring(0, Start_C5);
            string TextAfter_C5 = ConstantsRead_C5.Substring(Length_C5);
            string Replaced_C5 = TextBefore_C5 + "<Color x:Key=\"GlyphColor\">#" + C5 + TextAfter_C5;
            File.WriteAllText(ConstantsLocation, Replaced_C5);

            string ConstantsRead_C6 = File.ReadAllText(ConstantsLocation);
            int Start_C6 = ConstantsRead_C6.IndexOf("<Color x:Key=\"GlyphLightColor\">#");
            int Length_C6 = Start_C6 + 38;
            string TextBefore_C6 = ConstantsRead_C6.Substring(0, Start_C6);
            string TextAfter_C6 = ConstantsRead_C6.Substring(Length_C6);
            string Replaced_C6 = TextBefore_C6 + "<Color x:Key=\"GlyphLightColor\">#" + C6 + TextAfter_C6;
            File.WriteAllText(ConstantsLocation, Replaced_C6);

            string ConstantsRead_C8 = File.ReadAllText(ConstantsLocation);
            int Start_C8 = ConstantsRead_C8.IndexOf("<Color x:Key=\"UIColourDarker\">#");
            int Length_C8 = Start_C8 + 37;
            string TextBefore_C8 = ConstantsRead_C8.Substring(0, Start_C8);
            string TextAfter_C8 = ConstantsRead_C8.Substring(Length_C8);
            string Replaced_C8 = TextBefore_C8 + "<Color x:Key=\"UIColourDarker\">#" + C8 + TextAfter_C8;
            File.WriteAllText(ConstantsLocation, Replaced_C8);

            return null;
        }

        public static object EleganceDTColours(string path, string C1, string C2, string C3, string C4, string C5, string C6, string C9, string C10)
        {
            string ConstantsLocation = path;

            string ConstantsRead_C1 = File.ReadAllText(ConstantsLocation);
            int Start_C1 = ConstantsRead_C1.IndexOf("<Color x:Key=\"MainColor\">#");
            int Length_C1 = Start_C1 + 32;
            string TextBefore_C1 = ConstantsRead_C1.Substring(0, Start_C1);
            string TextAfter_C1 = ConstantsRead_C1.Substring(Length_C1);
            string Replaced_C1 = TextBefore_C1 + "<Color x:Key=\"MainColor\">#" + C1 + TextAfter_C1;
            File.WriteAllText(ConstantsLocation, Replaced_C1);

            string ConstantsRead_C2 = File.ReadAllText(ConstantsLocation);
            int Start_C2 = ConstantsRead_C2.IndexOf("<Color x:Key=\"MainColorDark\">#");
            int Length_C2 = Start_C2 + 36;
            string TextBefore_C2 = ConstantsRead_C2.Substring(0, Start_C2);
            string TextAfter_C2 = ConstantsRead_C2.Substring(Length_C2);
            string Replaced_C2 = TextBefore_C2 + "<Color x:Key=\"MainColorDark\">#" + C2 + TextAfter_C2;
            File.WriteAllText(ConstantsLocation, Replaced_C2);

            string ConstantsRead_C3 = File.ReadAllText(ConstantsLocation);
            int Start_C3 = ConstantsRead_C3.IndexOf("<Color x:Key=\"HoverColor\">#");
            int Length_C3 = Start_C3 + 33;
            string TextBefore_C3 = ConstantsRead_C3.Substring(0, Start_C3);
            string TextAfter_C3 = ConstantsRead_C3.Substring(Length_C3);
            string Replaced_C3 = TextBefore_C3 + "<Color x:Key=\"HoverColor\">#" + C3 + TextAfter_C3;
            File.WriteAllText(ConstantsLocation, Replaced_C3);

            string ConstantsRead_C4 = File.ReadAllText(ConstantsLocation);
            int Start_C4 = ConstantsRead_C4.IndexOf("<Color x:Key=\"GlyphColor\">#");
            int Length_C4 = Start_C4 + 33;
            string TextBefore_C4 = ConstantsRead_C4.Substring(0, Start_C4);
            string TextAfter_C4 = ConstantsRead_C4.Substring(Length_C4);
            string Replaced_C4 = TextBefore_C4 + "<Color x:Key=\"GlyphColor\">#" + C4 + TextAfter_C4;
            File.WriteAllText(ConstantsLocation, Replaced_C4);

            string ConstantsRead_C5 = File.ReadAllText(ConstantsLocation);
            int Start_C5 = ConstantsRead_C5.IndexOf("<Color x:Key=\"UIColour\">#");
            int Length_C5 = Start_C5 + 31;
            string TextBefore_C5 = ConstantsRead_C5.Substring(0, Start_C5);
            string TextAfter_C5 = ConstantsRead_C5.Substring(Length_C5);
            string Replaced_C5 = TextBefore_C5 + "<Color x:Key=\"UIColour\">#" + C5 + TextAfter_C5;
            File.WriteAllText(ConstantsLocation, Replaced_C5);

            string ConstantsRead_C6 = File.ReadAllText(ConstantsLocation);
            int Start_C6 = ConstantsRead_C6.IndexOf("<Color x:Key=\"HighlightGlyphColor\">#");
            int Length_C6 = Start_C6 + 44;
            string TextBefore_C6 = ConstantsRead_C6.Substring(0, Start_C6);
            string TextAfter_C6 = ConstantsRead_C6.Substring(Length_C6);
            string Replaced_C6 = TextBefore_C6 + "<Color x:Key=\"HighlightGlyphColor\">#" + C6 + TextAfter_C6;
            File.WriteAllText(ConstantsLocation, Replaced_C6);

            string ConstantsRead_C9 = File.ReadAllText(ConstantsLocation);
            int Start_C9 = ConstantsRead_C9.IndexOf("<Color x:Key=\"BackgroundToneColor\">#");
            int Length_C9 = Start_C9 + 42;
            string TextBefore_C9 = ConstantsRead_C9.Substring(0, Start_C9);
            string TextAfter_C9 = ConstantsRead_C9.Substring(Length_C9);
            string Replaced_C9 = TextBefore_C9 + "<Color x:Key=\"BackgroundToneColor\">#" + C9 + TextAfter_C9;
            File.WriteAllText(ConstantsLocation, Replaced_C9);

            string ConstantsRead_C10 = File.ReadAllText(ConstantsLocation);
            int Start_C10 = ConstantsRead_C10.IndexOf("<Color x:Key=\"GridItemBackgroundColor\">#");
            int Length_C10 = Start_C10 + 46;
            string TextBefore_C10 = ConstantsRead_C10.Substring(0, Start_C10);
            string TextAfter_C10 = ConstantsRead_C10.Substring(Length_C10);
            string Replaced_C10 = TextBefore_C10 + "<Color x:Key=\"GridItemBackgroundColor\">#" + C10 + TextAfter_C10;
            File.WriteAllText(ConstantsLocation, Replaced_C10);

            return null;
        }

        public static object PlayniteModernUIColours(string path, string C3, string C4, string C5, string C6, string C8)
        {
            string ConstantsLocation = path;

            string ConstantsRead_C3 = File.ReadAllText(ConstantsLocation);
            int Start_C3 = ConstantsRead_C3.IndexOf("<Color x:Key=\"UIColour\">#");
            int Length_C3 = Start_C3 + 31;
            string TextBefore_C3 = ConstantsRead_C3.Substring(0, Start_C3);
            string TextAfter_C3 = ConstantsRead_C3.Substring(Length_C3);
            string Replaced_C3 = TextBefore_C3 + "<Color x:Key=\"UIColour\">#" + C3 + TextAfter_C3;
            File.WriteAllText(ConstantsLocation, Replaced_C3);

            string ConstantsRead_C4 = File.ReadAllText(ConstantsLocation);
            int Start_C4 = ConstantsRead_C4.IndexOf("<Color x:Key=\"UIColourDark\">#");
            int Length_C4 = Start_C4 + 35;
            string TextBefore_C4 = ConstantsRead_C4.Substring(0, Start_C4);
            string TextAfter_C4 = ConstantsRead_C4.Substring(Length_C4);
            string Replaced_C4 = TextBefore_C4 + "<Color x:Key=\"UIColourDark\">#" + C4 + TextAfter_C4;
            File.WriteAllText(ConstantsLocation, Replaced_C4);

            string ConstantsRead_C5 = File.ReadAllText(ConstantsLocation);
            int Start_C5 = ConstantsRead_C5.IndexOf("<Color x:Key=\"GlyphColor\">#");
            int Length_C5 = Start_C5 + 33;
            string TextBefore_C5 = ConstantsRead_C5.Substring(0, Start_C5);
            string TextAfter_C5 = ConstantsRead_C5.Substring(Length_C5);
            string Replaced_C5 = TextBefore_C5 + "<Color x:Key=\"GlyphColor\">#" + C5 + TextAfter_C5;
            File.WriteAllText(ConstantsLocation, Replaced_C5);

            string ConstantsRead_C6 = File.ReadAllText(ConstantsLocation);
            int Start_C6 = ConstantsRead_C6.IndexOf("<Color x:Key=\"GlyphLightColor\">#");
            int Length_C6 = Start_C6 + 38;
            string TextBefore_C6 = ConstantsRead_C6.Substring(0, Start_C6);
            string TextAfter_C6 = ConstantsRead_C6.Substring(Length_C6);
            string Replaced_C6 = TextBefore_C6 + "<Color x:Key=\"GlyphLightColor\">#" + C6 + TextAfter_C6;
            File.WriteAllText(ConstantsLocation, Replaced_C6);

            string ConstantsRead_C8 = File.ReadAllText(ConstantsLocation);
            int Start_C8 = ConstantsRead_C8.IndexOf("<Color x:Key=\"UIColourDarker\">#");
            int Length_C8 = Start_C8 + 37;
            string TextBefore_C8 = ConstantsRead_C8.Substring(0, Start_C8);
            string TextAfter_C8 = ConstantsRead_C8.Substring(Length_C8);
            string Replaced_C8 = TextBefore_C8 + "<Color x:Key=\"UIColourDarker\">#" + C8 + TextAfter_C8;
            File.WriteAllText(ConstantsLocation, Replaced_C8);

            return null;
        }
    }
}
