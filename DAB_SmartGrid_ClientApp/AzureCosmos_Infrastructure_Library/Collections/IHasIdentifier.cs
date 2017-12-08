using System;

namespace AzureCosmos_Infrastructure_Library.Collections
{
    public interface IHasIdentifier
    {
        string Id { get; set; }
    }
}