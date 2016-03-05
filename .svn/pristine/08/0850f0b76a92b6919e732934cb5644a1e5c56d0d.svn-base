using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using InternetRadio.WorkingWithFiles;
using InternetRadio.Common;

namespace InternetRadio.Engine
{
    public class SettingsHelper
    {

        private const string SettingFile = "files/Setting.xml";

        public static Settings LoadSetting()
        {
            bool cSaveChecked = true;
            int volum = 100;
            bool mutee = false;
            int selectIndex = -1;
            bool isPlay = false;

            try
            {
                var setting = WorkFromFiles.LoadDocument(SettingFile);
                foreach (var el in setting.Root.Elements())
                {
                    {
                        switch (el.Name.ToString())
                        {
                            case "Save":
                            {
                                cSaveChecked = Convert.ToBoolean(el.Value);
                                break;
                            }
                            case "Volum":
                            {
                                volum = Convert.ToInt32(el.Value);
                                break;
                            }
                            case "Mute":
                            {
                                mutee = Convert.ToBoolean(el.Value);
                                break;
                            }
                            case "SelectIndex":
                            {
                                selectIndex = Convert.ToInt32(el.Value);
                                break;
                            }
                            case "IsPlay":
                            {
                                isPlay = Convert.ToBoolean(el.Value);
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
                WorkFromFiles.SaveDocument(new XDocument(new XElement("Setting", "")),SettingFile);
            }
            return new Settings(cSaveChecked, volum, mutee, selectIndex, isPlay);

        }

        public static void SaveSetting(Settings settings)
        {
            var satting = new XDocument(new XElement("Setting",
                new XElement("Save", settings.SaveChecked.ToString()),
                new XElement("Volum", settings.Volum.ToString()),
                new XElement("Mute", settings.Mutee.ToString()),
                new XElement("SelectIndex", settings.SelectIndex.ToString()),
                new XElement("IsPlay", settings.IsPlay.ToString())));

            WorkFromFiles.SaveDocument(satting, SettingFile);
        }


        }
}
