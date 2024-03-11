using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static AppleStore_DLinkedList_SSule.Devices<T>;

namespace AppleStore_DLinkedList_SSule
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create instances of devices
            Devices<string> iphone13 = new Devices<string>("iPhone 13", 256, "Blue", 999.99, "ABC123", 2020);
            Devices<string> iPadAir = new Devices<string>("iPad Air", 512, "Space Gray", 499, "DEF456", 2020);
            Devices<string> MacBookPro = new Devices<string>("MacBook Pro", 1000, "Silver", 1999.99, "GHI789", 2022);
            Devices<string> iPhone12 = new Devices<string>("iPhone 12", 128, "Black", 799, "ID123", 2020);
            Devices<string> iPadPro = new Devices<string>("iPad Pro", 256, "Silver", 999, "ID456", 2021);
            Devices<string> MacBookAir = new Devices<string>("MacBook Air", 512, "Gold", 1199.99, "ID789", 2020);

            // Create a doubly linked list
            Devices<string>.DoublyLinkedList deviceList = new Devices<string>.DoublyLinkedList();

            // Add devices to the list
            deviceList.Add(iphone13);
            deviceList.Add(iPadAir);
            deviceList.Add(MacBookPro);
            deviceList.Add(iPhone12);
            deviceList.Add(iPadPro);
            deviceList.Add(MacBookAir);

            // Print out the list
            Console.WriteLine("Devices in the list:");
            deviceList.PrintList();

            // This is an example of InsertAfter method
            Devices<string> deviceToInsertAfter = deviceList.Search("iPad Pro").Device; // Access the Device property
            Devices<string> deviceToInsert = new Devices<string>("iPhone 14", 256, "Green", 1099.99, "JKL101", 2024);
            deviceList.InsertAfter(deviceToInsertAfter, deviceToInsert);

            // This is an example of InsertBefore method
            Devices<string> deviceToInsertBefore = deviceList.Search("iPhone 12").Device; //It should access the Device property
            Devices<string> deviceToInsert2 = new Devices<string>("iPhone 13 Mini", 128, "Red", 699.99, "MNO202", 2024);
            deviceList.InsertBefore(deviceToInsertBefore, deviceToInsert2);


            // Search for a device
            string searchModel = "iPhone 15 Pro Max";
            Devices<string>.Node foundDeviceNode = deviceList.Search(searchModel);
            if (foundDeviceNode != null)
            {
                Console.WriteLine($"Found device with model '{searchModel}': {foundDeviceNode.Device}");
            }
            else
            {
                Console.WriteLine($"Device with model '{searchModel}' not found.");
            }

            // Remove a device
            string removeId = "DEF456";
            bool removed = deviceList.Remove(removeId);
            if (removed)
            {
                Console.WriteLine($"Device with ID '{removeId}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Device with ID '{removeId}' not found.");
            }

            deviceList.MergeSort();
            Console.WriteLine("\nDevices in the sorted list:");
            deviceList.PrintList();

            // Lets print out the updated list
            Console.WriteLine("\nDevices in the list after removal:");
            deviceList.PrintList();

            // Example usage of Clear method
            deviceList.Clear();
            Console.WriteLine("\nDevices in the list after clearing:");
            deviceList.PrintList(); // Should print nothing

        }
    }
    
}
