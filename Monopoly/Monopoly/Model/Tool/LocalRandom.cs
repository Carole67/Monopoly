using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Model.Tool
{
    public static class LocalRandom
    {
        private static readonly Random globalRandom = new Random();
        private static readonly object globalLock = new object();

        public static int Next() { return globalRandom.Next(); }
        public static int Next(int max) { return globalRandom.Next(max); }
        public static int Next(int min, int max) { return globalRandom.Next(min, max); }
    }
}
