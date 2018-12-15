using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowLeopard
{
    public class Model
    {
        private static int idBase = 1;
        private static int orderBase = 0;

        public int Id { get; } = idBase++;
        public int Order { get; } = orderBase++;
        public int Type { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        /// <summary>
        /// 自动属性
        /// </summary>
        public DateTime CreateTime { get; } = DateTime.Now;
        //private DateTime _createTime = DateTime.Now;
        /// <summary>
        /// 完整属性(表达式主体)
        /// </summary>
        //public DateTime CreateTime => _createTime;
        /// <summary>
        /// 完整属性(程序块主体)
        /// </summary>
        //public DateTime CreateTime { get => _createTime; }

        public Model(int type, string name, decimal value)
        {
            //this.Id = id; //仍可以Set？
            //this.Order = order;
            this.Type = type;
            this.Name = name;
            this.Value = value;
        }
    }
}
