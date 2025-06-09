using GarbageCollector.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector;

class Store : IDisposable
{
    public string StoreName { get; set; }
    public string StoreAdress { get; set; } 
    public TypeOfStore StoreType { get; set; }

    public Store(string storeName, string storeAdress, TypeOfStore storeType) 
    {
        StoreName = storeName;
        StoreAdress = storeAdress;
        StoreType = storeType;
    }
    public void InfoAboutStore()
    {
        Console.WriteLine($"New Store opened: Store name: {StoreName}, Adress: {StoreAdress}, Store Type: {StoreType} store");
    }
    public void Dispose()
    {
        Console.WriteLine("Information read and deleted");
    }
    ~Store()
    { Console.WriteLine("Store is finalized"); }
}
