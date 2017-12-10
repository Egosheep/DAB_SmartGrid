using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace SmartGrid_ServerApp
{
    public class PriceRegulator : IPriceRegulator
    {
        private SmartGridInfo _smartGridInfo;

        public PriceRegulator()
        {
            _smartGridInfo = ReadLatestSmartGridInfo();
        }

        public double CalculateToken(PendingTransaction transaction)
        {
            return double.Parse(transaction.PowerAmount) * _smartGridInfo.KiloWattPrice;
        }

        public void UpdateCurrentMarketValue()
        {
            var random = new Random();
            int cointoss = random.Next(1, 100);
            if (cointoss < 50)
            {
                _smartGridInfo.KiloWattPrice += 1;
                _smartGridInfo.TokenPrice += 1;
            }
            else
            {
                _smartGridInfo.KiloWattPrice += 1;
                _smartGridInfo.TokenPrice += 1;
            }
            _smartGridInfo.TimeStamp = DateTime.Now.ToLocalTime();
            _smartGridInfo.Id += 1;
            SaveSmartGridInfo();
        }

        private SmartGridInfo ReadLatestSmartGridInfo()
        {
            var getPath = SqlWebApiCaller.Client.BaseAddress + "SmartGridInfoes/Get";
            var receive = SqlWebApiCaller.Client.GetAsync(getPath);
            return receive.Result.Content.ReadAsAsync<List<SmartGridInfo>>().Result.Last();
        }

        private void SaveSmartGridInfo()
        {
            var postPath = SqlWebApiCaller.Client.BaseAddress + "SmartGridInfoes/Post";
            SqlWebApiCaller.Client.PostAsJsonAsync(postPath, _smartGridInfo);
        }
    }
}