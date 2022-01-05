using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample
{
    interface ITelePhone
    {
        void makeCall(string phoneNumber);

        void receiveCall();

    }

    public class LandLine: ITelePhone
    {
        public void makeCall(string phoneNumber)
        {
            //Write code here to make call
        }

        public void receiveCall()
        {
            //Write code here
        }
    }

    public class Mobile : ITelePhone
    {
        public void makeCall(string phoneNumber)
        {
            //Write code here to make call
        }

        public void receiveCall()
        {
            //Write code here
        }

        public void sendText(string textMsg)
        {
            //write code here
        }

        public void ReceiveText(string textMsg)
        {
            //write code here
        }

    }

    class SamsungGalaxy: Mobile
    {
        public void Camera()
        {

        }
    }

    public class OustideProgram
    {
        public static void main()
        {
            SamsungGalaxy samsungGalaxy = new SamsungGalaxy();
            ITelePhone landLine = new LandLine();
            ITelePhone mobile = new Mobile();

        }
    }

}
