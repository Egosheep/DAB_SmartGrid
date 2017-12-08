using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class PowerInventoryRepo : GenericRepo<PowerInventory>, IPowerInventoryRepo
    {
        public PowerInventoryRepo(ICRUD<PowerInventory> crud) : base(crud)
        {
        }
    }
}