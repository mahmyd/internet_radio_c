using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using InternetRadio.WorkingWithFiles;

namespace InternetRadio.Engine
{
    public class VersionHelper
    {
        private const string VersionFile = "files/Version.xml";

        public static void LoadVersion(out ListBox versionL, out  ListBox date, out ListBox changes)
        {
            versionL = new ListBox();
            date = new ListBox();
            changes = new ListBox();


            var version = WorkFromFiles.LoadDocument(VersionFile);

            if (version.Root != null)
                foreach (var el2 in version.Root.Elements().SelectMany(el => el.Elements()))
                {
                    if (el2.Name == "Ver")
                    { versionL.Items.Add(el2.Value); }
                    if (el2.Name == "Date")
                    { date.Items.Add(el2.Value); }
                    if (el2.Name == "Changes")
                    { changes.Items.Add(el2.Value); }

                }

        }

        public static void AddVersion(ListBox version, ListBox date, ListBox changes)
        {
            var addVersion = new XDocument(new XElement("Version", ""));
            for (int i = 0; i < version.Items.Count; i++)
            {
                var track = new XElement("Version",
                    new XAttribute("id", i),
                    new XElement("Ver",
                        version.Items[i]),
                        new XElement("Date",
                            date.Items[i]),
                        new XElement("Changes", changes.Items[i]));

                if (addVersion.Root != null) addVersion.Root.Add(track);
                WorkFromFiles.SaveDocument(addVersion, VersionFile);
            }
        }
    }
}
