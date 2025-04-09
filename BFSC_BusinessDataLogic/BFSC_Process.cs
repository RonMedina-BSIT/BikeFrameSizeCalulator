using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFSC_BusinessDataLogic
{

    public class BFSC_Process
    {
         static double TBMultiplyer = 0.64;
         static double RBMultiplyer = 0.67;

     
        public static FrameSizes CalculateFrameSize(int inseam)
        {

            return new FrameSizes
            {
                TrekkingFrameSize = (int)(inseam * TBMultiplyer),
                RoadFrameSize = (int)(inseam * RBMultiplyer),
                MountainFrameSize = (int)((inseam * RBMultiplyer) - 11)
            }; 

        }


    }
}
