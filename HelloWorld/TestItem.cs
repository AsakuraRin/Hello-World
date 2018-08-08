using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TestItem
    {
        int firstInfo;
        double secondInfo;

        public TestItem()
        {
            this.FirstInfo = 0;
            this.SecondInfo = 2.3;
        }

        public TestItem(int firstInfo, double secondInfo)
        {
            this.FirstInfo = firstInfo;
            this.SecondInfo = secondInfo;
        }

        public int FirstInfo { get => firstInfo; set => firstInfo = value; }
        public double SecondInfo { get => secondInfo; set => secondInfo = value; }

        public void Dis()
        {
            Console.WriteLine("{0}+{1}",firstInfo,secondInfo);
        }
    }
}
