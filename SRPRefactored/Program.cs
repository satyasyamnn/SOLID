using System;
using System.Reflection;

namespace SRPRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SingleResponsibilityPrinciple.trades.txt");
            var tradeProcessor = new TradeProcessor();
            tradeProcessor.ProcessTrades(tradeStream);
            Console.ReadKey();
        }
    }
}
