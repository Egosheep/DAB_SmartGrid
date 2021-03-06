﻿using System.Collections.Generic;
using AzureCosmos_Infrastructure_Library.Collections;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public interface IPowerInventoryRepo : IGenericRepo<PowerInventory>
    {
        List<PowerInventory> GetAllInventoryItems();
    }
}