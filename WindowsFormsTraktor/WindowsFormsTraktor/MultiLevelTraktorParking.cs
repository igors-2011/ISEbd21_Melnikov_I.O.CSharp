using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WindowsFormsTraktor
{
    public class MultiLevelTraktorParking
    {
        List<TraktorParking<ITransport>> ParkingLevels;

        private const int Places = 20;

        private int PictureWidth;
        private int PictureHeight;

        public MultiLevelTraktorParking(int LevelsNumber, int picwidth, int picheight)
        {
            this.PictureWidth = picwidth;
            this.PictureHeight = picheight;
            ParkingLevels = new List<TraktorParking<ITransport>>();
            for (int i = 0; i < LevelsNumber; i++)
            {
                ParkingLevels.Add(new TraktorParking<ITransport>(Places, PictureWidth, PictureHeight));
            }
        }

        public TraktorParking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind <ParkingLevels.Count)
                {
                    return ParkingLevels[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile("LevelsNumber:" + ParkingLevels.Count + Environment.NewLine, fs);
                foreach (var level in ParkingLevels)
                {
                    WriteToFile("Level" + Environment.NewLine, fs);
                    for (int i = 0; i < Places; i++)
                    {
                        var traktor = level[i];
                        if (traktor != null)
                        {
                            if (traktor.GetType().Name == "Traktor")
                            {
                                WriteToFile(i + ":Traktor:", fs);
                            }
                            if (traktor.GetType().Name == "TraktorExcavator")
                            {
                                WriteToFile(i + ":TraktorExcavator:", fs);
                            }
                            WriteToFile(traktor + Environment.NewLine, fs);
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("LevelsNumber"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (ParkingLevels != null)
                {
                    ParkingLevels.Clear();
                }
                ParkingLevels = new List<TraktorParking<ITransport>>(count);
            }
            else
            {
                return false;
            }
            int counter = -1;
            ITransport traktor = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    ParkingLevels.Add(new TraktorParking<ITransport>(Places, PictureWidth, PictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Traktor")
                {
                    traktor = new Traktor(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "TraktorExcavator")
                {
                    traktor = new TraktorExcavator(strs[i].Split(':')[2]);
                }
                ParkingLevels[counter][Convert.ToInt32(strs[i].Split(':')[0])] = traktor;
            }
            return true;
        }
    }
}