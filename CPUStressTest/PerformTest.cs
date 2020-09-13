using System.Diagnostics;
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

        public async Task<bool> Perform(CancellationToken cancellation)
        {
            return await Task.Run(async () =>
            {
                List<Task<BigInteger>> runningThreads = new List<Task<BigInteger>>();
                for(ushort i = 1; i <= threadsNo; ++i)
                {
                    runningThreads.Add(CalculateFactorialOf1Milion(cancellation));
                }                
                
                List<BigInteger> results = new List<BigInteger>(await Task.WhenAll(runningThreads));
                foreach(var item in results)
                {
                    if (item == 0)
                    {
                        return false;
                    }
                }
                
                return true;
            });
        }

        private async Task<BigInteger> CalculateFactorialOf1Milion(CancellationToken cancellation)
        {
            return await Task.Run(() =>
            {
                Debug.WriteLine("Started");
                BigInteger result = 1;
                for(BigInteger i = 1; i <= 100000; ++i)
                {
                    result *= i;
                    if (i % 100 == 0)
                    {
                        if (cancellation.IsCancellationRequested)
                        {
                            return 0;
                        }
                    }
                }
                return result;
            });
        }
    }
}
