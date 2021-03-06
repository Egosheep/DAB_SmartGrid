﻿using System.Collections.Generic;
using System.Linq;
using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class PendingTransactionRepo : GenericRepo<PendingTransaction>, IPendingTransactionRepo
    {
        public PendingTransactionRepo(ICRUD<PendingTransaction> crud) : base(crud)
        {
        }

        public List<PendingTransaction> GetAllPendingTransactions()
        {
            return _crud.Query().ToList();
        }

        public List<PendingTransaction> WhereQuery(string options)
        {
            return _crud.Query().Where(f => f.BuyerId == options || f.SellerId == options).ToList();
        }
    }
}