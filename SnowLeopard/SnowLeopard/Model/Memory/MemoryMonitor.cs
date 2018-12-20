﻿using SnowLeopard.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace SnowLeopard.Model.Memory
{
    public class MemoryMonitor<T>
    {
        public void Test(int count)
        {
            GC.Collect();
            var type = typeof(T);
            var assembly = Assembly.GetAssembly(type);

            var lstInstance = new List<T>();
            for (int i = 0; i < count; i++)
            {
                lstInstance.Add((T)assembly.CreateInstance(type.FullName));
            }
            var diag = new MemoryDiagnostics();
            Console.WriteLine(
                $"Type       : {type.FullName}\r\n" +
                $"Count      : {count}\r\n" +
                $"WorkingSet : {diag.WorkingSet / 1024 / 1024}MB");

            List<MemoryInfo> lstMemory=null;
            if (File.Exists("memoryinfo.json"))
            {
                try
                {
                    var sJson = File.ReadAllText("memoryinfo.json");
                    lstMemory = JsonSerializer.Deserialize<List<MemoryInfo>>(sJson);
                }
                catch  { }
            }
            if (lstMemory == null)
            {
                lstMemory = new List<MemoryInfo>();
            }
            var memInfo = new MemoryInfo()
            {
                TypeName = type.FullName,
                Count = count,
                WorkingSet = (double)diag.WorkingSet / 1024D / 1024D,
            };
            lstMemory.Add(memInfo);

            var sJs = JsonSerializer.Serialize(lstMemory);
            File.WriteAllText("memoryinfo.json", sJs);
        }
    }
}