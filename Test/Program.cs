﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using Tibos.Test;
using Newtonsoft.Json;
using Test.Model;
using System.Diagnostics;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace Test
{

    class Program
    {

        static void Main(string[] args)
        {

            

           

            //string url = "http://193.112.104.103:9222/api/values";
            //var res = HttpCommon.Get(url);

            //var pythonPath = @"F:\PythonProject\test\test3.py";

            //ScriptRuntime scriptRuntime = Python.CreateRuntime();
            //ScriptEngine pythEng = scriptRuntime.GetEngine("Python");
            //ScriptSource scriptSource = pythEng.CreateScriptSourceFromFile(pythonPath);
            //ScriptScope scope = pythEng.CreateScope();
            //scope.SetVariable("prodCount", Convert.ToInt32("34343"));
            //scope.SetVariable("amt", Convert.ToDecimal("434"));




            //scope.SetVariable("argv", new string[] { "haha", "6666" });
            //scriptSource.Execute(scope);
            //dynamic a = scope.GetVariable("retAmt");




            //Test t = new Test() { Name = "ttt" };

            //List<Test> list = new List<Test>();

            //list.Add(t);
            //list.Add(new Test() { Name = "2" });

            //var list2 = list;

            //list2.Remove(t);

            //Console.WriteLine(list);



            Console.Read();
        }

        /// <summary>
        /// 日期转换成unix时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            double intResult = 0;
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            intResult = (dateTime - startTime).TotalMilliseconds;
            return  Convert.ToInt64(Math.Round(intResult, 0).ToString());
        }
    }
    class Test
    {
        public string Name { get; set; }
    }
}
