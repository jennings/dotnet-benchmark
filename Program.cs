using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Platform>();
        }
    }

    public class Platform
    {
        [Benchmark]
        public int[] Array()
        {
            var arr = new int[200];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        [Benchmark]
        public List<int> List()
        {
            var list = new List<int>(200);
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = i;
            }
            return list;
        }
    }
}
