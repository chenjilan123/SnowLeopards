using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard.Model
{
    public class LonLatCalculate 
    {
        private const double EARTH_RADIUS = 6378137;//赤道半径(单位m)  

        public double GetDistance(double dBeginLon, double dBeginLat, double dEndLon, double dEndLat)
        {
            return Dist(dBeginLon, dBeginLat, dEndLon, dEndLat);
        }

        /** 
         * 转化为弧度(rad) 
         * */
        private double Rad(double d)
        {
            return d * Math.PI / 180.0;
        }

        /** 
         * 基于余弦定理求两经纬度距离 
         * @param lon1 第一点的精度 
         * @param lat1 第一点的纬度 
         * @param lon2 第二点的精度 
         * @param lat3 第二点的纬度 
         * @return 返回的距离，单位km 
         * */
        public double Dist(double lon1, double lat1, double lon2, double lat2)
        {
            double radLat1 = Rad(lat1);
            double radLat2 = Rad(lat2);

            double radLon1 = Rad(lon1);
            double radLon2 = Rad(lon2);

            if (radLat1 < 0)
                radLat1 = Math.PI / 2 + Math.Abs(radLat1);// south  
            if (radLat1 > 0)
                radLat1 = Math.PI / 2 - Math.Abs(radLat1);// north  
            if (radLon1 < 0)
                radLon1 = Math.PI * 2 - Math.Abs(radLon1);// west  
            if (radLat2 < 0)
                radLat2 = Math.PI / 2 + Math.Abs(radLat2);// south  
            if (radLat2 > 0)
                radLat2 = Math.PI / 2 - Math.Abs(radLat2);// north  
            if (radLon2 < 0)
                radLon2 = Math.PI * 2 - Math.Abs(radLon2);// west  
            double x1 = EARTH_RADIUS * Math.Cos(radLon1) * Math.Sin(radLat1);
            double y1 = EARTH_RADIUS * Math.Sin(radLon1) * Math.Sin(radLat1);
            double z1 = EARTH_RADIUS * Math.Cos(radLat1);

            double x2 = EARTH_RADIUS * Math.Cos(radLon2) * Math.Sin(radLat2);
            double y2 = EARTH_RADIUS * Math.Sin(radLon2) * Math.Sin(radLat2);
            double z2 = EARTH_RADIUS * Math.Cos(radLat2);

            double d = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
            //余弦定理求夹角  
            double theta = Math.Acos((EARTH_RADIUS * EARTH_RADIUS + EARTH_RADIUS * EARTH_RADIUS - d * d) / (2 * EARTH_RADIUS * EARTH_RADIUS));
            double dist = theta * EARTH_RADIUS;
            return dist;
        }
    }
}
