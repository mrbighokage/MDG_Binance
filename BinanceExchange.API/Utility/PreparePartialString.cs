using BinanceExchange.API.Enums;
using System.Collections.Generic;

namespace BinanceExchange.API.Utility
{
    public class PrepareCombinedSymbols
    {
        public static string CombinedPartialDepth(string allPairs, string depth)
        {
            string[] allPairsArray = allPairs.Split(',');
            for (int i = 0; i < allPairsArray.Length; i++)
            {
                allPairsArray[i] = allPairsArray[i].ToLower() + "@depth" + depth + "/";
            }
            
            return allPairs = string.Join("", allPairsArray);
        }

        public static string CombinedDepth(string allPairs)
        {
            string[] allPairsArray = allPairs.Split(',');
            for (int i = 0; i < allPairsArray.Length; i++)
            {
                allPairsArray[i] = allPairsArray[i].ToLower() + "@depth" + "/";
            }
            
            return allPairs = string.Join("", allPairsArray);
        }

        public static string CombinedTrade(string allPairs)
        {
            string[] allPairsArray = allPairs.Split(',');
            for (int i = 0; i < allPairsArray.Length; i++)
            {
                allPairsArray[i] = allPairsArray[i].ToLower() + "@trade" + "/";
            }

            return allPairs = string.Join("", allPairsArray);
        }

        public static string CombinedDepthAndTrade(List<string> instruments)
        {
            var list = new List<string>();
            foreach (var instrument in instruments)
            {
                list.Add($"{instrument.ToLower()}@depth/{instrument.ToLower()}@trade/");
            }
            return string.Join("", list);
        }
    }
}
