using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public interface ICar
    {
        // สตาร์ทรถ
        void StartEngine();

        // เคลื่อนที่
        void Move();

        // เติมน้ำมัน
        void FillUpFuel();

        // ชาร์จแบตเตอรี่
        void ChargeBattery();

    }

}
