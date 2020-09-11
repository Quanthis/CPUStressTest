using System;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections.Generic;

namespace CPUStressTest
{
    public class PerformTest
    {
        private ushort threadsNo;

        public PerformTest(ushort threadsNo)
        {
            this.threadsNo = threadsNo;
        }

        public async Task<bool> Perform()
        {
            return await Task.Run(async () =>
            {
                List<Task<BigInteger>> runningThreads = new List<Task<BigInteger>>();
                for(ushort i = 1; i <= threadsNo; ++i)
                {
                    runningThreads.Add(CalculateFactorialOf1Milion());
                }
                await Task.WhenAll(runningThreads);
                return true;
            });
        }

        private async Task<BigInteger> CalculateFactorialOf1Milion()
        {
            return await Task.Run(() =>
            {
                BigInteger result = 1;
                for(BigInteger i = 1; i <= 1000000; ++i)
                {
                    result *= i;
                }
                return result;
            });
        }


    }
}
