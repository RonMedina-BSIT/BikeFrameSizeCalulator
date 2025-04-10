using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BFSC_Common;
using BFSC_DataService;

namespace BFSC_BusinessDataLogic
{

    public class BFSC_Service
    {
        

     
        public static FrameSizes CalculateFrameSize(int inseam)
        {

            return new FrameSizes
            {
                TrekkingFrameSize = (int)(inseam *BikeFrameDataService.TBMultiplyer),
                RoadFrameSize = (int)(inseam * BikeFrameDataService.RBMultiplyer),
                MountainFrameSize = (int)((inseam * BikeFrameDataService.RBMultiplyer) - 11)
            }; 

        }


    }
}
