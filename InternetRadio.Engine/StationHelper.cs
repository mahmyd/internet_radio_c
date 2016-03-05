using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using InternetRadio.WorkingWithFiles;

namespace InternetRadio.Engine
{
    public class StationHelper
    {

        const string FileStation = "files/Station.xml";
        public static void SaveStation(ListBox nameStation, ListBox lincStation, ListBox numbOfOpen, string operation, int index)
        {

            switch (operation)
            {

                case "Добавить":
                {

                    var doc = WorkFromFiles.LoadDocument(FileStation);

                    var station = new XElement("Station",
                        new XAttribute("id", index),
                        new XElement("Name", nameStation.Items[nameStation.Items.Count - 1]),
                        new XElement("Linq", lincStation.Items[lincStation.Items.Count - 1]),
                        new XElement("TimeOfPlay", 0),
                        new XElement("DateAdd", DateTime.Now.ToShortDateString()),
                        new XElement("TimeAdd", DateTime.Now.ToShortTimeString()),
                        new XElement("NumOfOpen", 0)
                        );
                                                  
                   doc.Root.Add(station); 
                   WorkFromFiles.SaveDocument(doc, FileStation);

                    break;
                    }

                case "Удалить":
                {
                    var station = WorkFromFiles.LoadDocument(FileStation);
                        foreach (var el in station.Root.Elements())
                        {
                            if (el.FirstAttribute.Name == "id" && el.FirstAttribute.Value == index.ToString())
                            { el.Remove(); }
                        }

                        WorkFromFiles.SaveDocument(station, FileStation);
                        nameStation.Items.RemoveAt(index);
                        lincStation.Items.RemoveAt(index);
                        {
                            //Перезаписываем индексы
                            var stationT = new XDocument(new XElement("Station", ""));
                            for (int i = 0; i < nameStation.Items.Count; i++)
                            {
                                var track = new XElement("Station",
                                                              new XAttribute("id", i),
                                                              new XElement("Name",
                                                                           nameStation.Items[i]),
                                                              new XElement("Linq",
                                                                           lincStation.Items[i]),
                                                              new XElement("TimeOfPlay",
                                                                           "0"),
                                                              new XElement("DateAdd", DateTime.Now.ToShortDateString()),
                                                              new XElement("TimeAdd", DateTime.Now.ToShortTimeString()),
                                                              new XElement("NumOfOpen", numbOfOpen.Items[i]));

                                if (stationT.Root != null) stationT.Root.Add(track);
                                WorkFromFiles.SaveDocument(stationT, FileStation);
                            }
                        }
                        break;
                    }
                case "Переименовать":
                    {
                        var station = WorkFromFiles.LoadDocument(FileStation);

                        foreach (var el in station.Root.Elements())
                        {
                            if (el.FirstAttribute.Name == "id" && el.FirstAttribute.Value == index.ToString())
                            {
                                foreach (var el2 in el.Elements())
                                {
                                    if (el2.Name != "Name") continue;
                                    el2.Value = nameStation.Items[index].ToString(); break;
                                }
                            }
                        }

                        WorkFromFiles.SaveDocument(station, FileStation);


                        break;
                    }

                case "Изменить":
                {
                    var station = WorkFromFiles.LoadDocument(FileStation);
                        foreach (var el in station.Root.Elements())
                        {
                            if (el.FirstAttribute.Name == "id" && el.FirstAttribute.Value == index.ToString())
                            {
                                foreach (var el2 in el.Elements())
                                {

                                    switch (el2.Name.ToString())
                                    {
                                        case "Name":
                                            {
                                                el2.Value = nameStation.Items[index].ToString();
                                                break;
                                            }
                                        case "Linq":
                                            {
                                                el2.Value = lincStation.Items[index].ToString();
                                                break;
                                            }

                                        case "NumOfOpen":
                                            {
                                                el2.Value = numbOfOpen.Items[index].ToString();
                                                break;
                                            }
                                    }
                                    
                                }
                            }
                        }

                        WorkFromFiles.SaveDocument(station, FileStation);
                        break;
                    }
            }
        }


        public static ListBox LoadStation(ListBox nameStation, ListBox lincStation, ListBox numbOfOpen)
        {

            nameStation.Items.Clear(); lincStation.Items.Clear();

            try
            {
                var station = WorkFromFiles.LoadDocument(FileStation);
                foreach (var el in station.Root.Elements())
                {

                    foreach (XElement el2 in el.Elements())
                    {
                        if (el2.Name == "Name")
                        {
                            nameStation.Items.Add(el2.Value);
                        }
                        if (el2.Name == "Linq")
                        {
                            lincStation.Items.Add(el2.Value);
                        }
                        if (el2.Name == "NumOfOpen")
                        {
                            numbOfOpen.Items.Add(el2.Value);
                        }
                    }
                }
            }

            catch
            {
                //TODO Refactor
               // var writ = new StreamWriter(FileStation, true);
                //writ.Dispose();
                var temp = new XDocument (new XElement("Station",""));
                
                WorkFromFiles.SaveDocument(temp, FileStation);
            }
            return nameStation;
        }



    }
}
