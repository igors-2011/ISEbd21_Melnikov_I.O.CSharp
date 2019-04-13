using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTraktor
{
    public class MultiLevelTraktorParking
    {
        List<TraktorParking<ITransport>> ParkingLevels;

        private const int Places = 20;

        public MultiLevelTraktorParking(int LevelsNumber, int picwidth, int picheight)
        {
            ParkingLevels = new List<TraktorParking<ITransport>>();
            for (int i = 0; i < LevelsNumber; i++)
            {
                ParkingLevels.Add(new TraktorParking<ITransport>(Places, picwidth, picheight));
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
    }
}
