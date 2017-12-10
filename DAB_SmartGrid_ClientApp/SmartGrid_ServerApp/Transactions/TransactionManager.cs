using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace SmartGrid_ServerApp
{
    public class TransactionManager : ITransactionManager
    {
        public void CreatePowerInventoryItem(Prosumer prosumer, string powerToSell)
        {
            var newItem = new PowerInventory()
            {
                PowerAmount = powerToSell,
                SellerId = prosumer.Id.ToString(),
                TransactionTime = DateTime.Now.ToLocalTime()
            };
            StorePowerInventoryItem(newItem);
        }

        public void CreateTransaction(Prosumer prosumer, string powerToBuy)
        {
            var inventory = GetPowerFromInventory(powerToBuy);
            var newPendingTransaction = new PendingTransaction()
            {
                SellerId = inventory.Id,
                BuyerId = prosumer.Id.ToString(),
                PowerAmount = powerToBuy,
                TransactionTime = DateTime.Now.ToLocalTime(),
            };
            var powerInventory = GetPowerFromInventory(powerToBuy);
            if (powerInventory == null)
            {
                newPendingTransaction.SellerId = "National Power Grid";
            }
            
            StoreTransaction(newPendingTransaction);
            inventory.PowerAmount = (int.Parse(inventory.PowerAmount) - int.Parse(powerToBuy)).ToString();
            if (int.Parse(inventory.PowerAmount) > 0)
            {
                UpdatePowerInventoryItem(inventory);
            }
            else
            {
                DeletePowerInventoryItem(inventory);
            }
        }

        private void StoreTransaction(PendingTransaction pendingTransaction)
        {
            var postPath = AzureWebApiCaller.Client.BaseAddress + "PendingTransactions/Post";
            AzureWebApiCaller.Client.PostAsJsonAsync(postPath, pendingTransaction);
        }

        private void StorePowerInventoryItem(PowerInventory itemToStore)
        {
            var postPath = AzureWebApiCaller.Client.BaseAddress + "PowerInventory/Post";
            AzureWebApiCaller.Client.PostAsJsonAsync(postPath, itemToStore);
        }

        private PowerInventory GetPowerFromInventory(string powerToBuy)
        {
            var getPath = AzureWebApiCaller.Client.BaseAddress + "PowerInventory/";
            var powerReturn = AzureWebApiCaller.Client.GetAsync(getPath);
            var powerList = powerReturn.Result.Content.ReadAsAsync<List<PowerInventory>>().Result;
            var powerAmountWhere = powerList.Where(f => int.Parse(f.PowerAmount) >= int.Parse(powerToBuy));
            return powerAmountWhere.First();
        }

        private void DeletePowerInventoryItem(PowerInventory item)
        {
            var deletePath = AzureWebApiCaller.Client.BaseAddress + "PowerInventory/Delete/" + item.Id;
            AzureWebApiCaller.Client.DeleteAsync(deletePath);
        }

        private void UpdatePowerInventoryItem(PowerInventory item)
        {
            var putPath = AzureWebApiCaller.Client.BaseAddress + "PowerInventory/Put/" + item.Id;
            AzureWebApiCaller.Client.PutAsJsonAsync(putPath, item);
        }
    }
}