using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AzureCosmos_Infrastructure_Library;
using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;
using AzureCosmos_Infrastructure_Library.Repositories;

namespace AzureCosmos_RestApi_Client
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IPowerInventoryRepo PowerInventoryRepo;
        public static ICompletedTransactionsRepo CompletedTransactionsRepo;
        public static IPendingTransactionsRepo PendingTransactionsRepo;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            PowerInventoryRepo = new PowerInventoryRepo(new CRUD<PowerInventory>(CosmosConnection.databaseName, CosmosConnection.powerInventoryCollection));
            CompletedTransactionsRepo = new CompletedTransactionsRepo(new CRUD<CompletedTransactions>(CosmosConnection.databaseName, CosmosConnection.completedTransactionsCollection));
            PendingTransactionsRepo = new PendingTransactionsRepo(new CRUD<PendingTransactions>(CosmosConnection.databaseName, CosmosConnection.pendingTransactionCollection));
        }
    }
}
