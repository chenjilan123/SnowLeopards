using SnowLeopard.Core.Bll;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SnowLeopard.Test
{
    public class GeohashTest
    {
        [Theory]
        [InlineData(115.354312, 23.504863, "ws4j8yymy213")]
        public void GeohashEncode(double lon, double lat, string exceptGeohash)
        {
            var geohash = Geohash.Encode(lat, lon);

            Assert.Equal(exceptGeohash, geohash);
        }

        [Theory]
        [InlineData("ws4j8yymy213", 115.354312, 23.504863)]
        //[InlineData("WX4ER", 121.504041, 27.505555)]
        public void GeohashDecode(string geohash, double exceptLon, double exceptLat)
        {
            var location = Geohash.Decode(geohash);
            var lat = location[0];
            var lon = location[1];

            Assert.Equal(exceptLon.ToString("0.00000"), lon.ToString("0.00000"));
            Assert.Equal(exceptLat.ToString("0.00000"), lat.ToString("0.00000"));
        }
    }
}
