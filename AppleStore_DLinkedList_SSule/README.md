
# AppleStore


## Apple Store - Device Management System

```csharp
This project implements a device management system for an Apple Store using a doubly linked list data structure. 
The system allows the store to manage its inventory of electronic devices efficiently. 
Each device in the store, such as iPhones, iPads, and MacBooks, is represented as an object of the Devices<T> class.

## Devices<T> Class
Represents an electronic device with properties such as Model, Storage, Color, Price, ID, Year, and InStore status.
Provides a constructor to initialize device properties and methods for validation.
Implements the ToString() method to convert device information to a string format.

## DoublyLinkedList Class
Implements a doubly linked list to manage devices.
Provides methods to add, remove, search for, print, merge sort, insert after, insert before, and clear the list.


## Program Class
a. Contains the Main method to demonstrate the functionality of the implemented doubly linked list.
b. Creates instances of various devices and adds them to the list.
c. Demonstrates inserting a device after and before a specified device.
d. Searches for a device and removes it from the list.
e. Performs merge sort on the list.
f. Prints the list before and after operations, including clearing the list.

```
###  Features: Sorting

## Device Representations

```csharp

Users can sort the list of devices by various criteria such as Model, Color, Year, Price, and Storage.

Users can input details of a new devices (Model, Color, Year, Price, and Storage) and add it to the inventory. 
The new devices is inserted at the correct position based on the sorting criteria. Saving to Store:

Users can save the current list of Devices to a store file. 
The system prompts users to enter a file name, 
and the list is saved with that name in store format. Preloaded Data:

## Device Representation
  i.   Model: Represents the model or type of the device (e.g., iPhone 13, iPad Pro).
  ii.  Storage: Indicates the storage capacity of the device in gigabytes.
  iii. Color: Specifies the color variant of the device.
  iv.   Price: Represents the retail price of the device.
  v.  ID: Unique identifier for each device.
  vi. Year: Year of release for the device.
  vii.  InStore: Boolean flag indicating whether the device is currently available in the store.


 ## Doubly Linked List Implementation

 . Add Device: Enables adding new devices to the inventory.
 . Remove Device: Allows removing devices from the inventory by ID.
 . Search Device: Provides functionality to search for devices by model and optional storage.
 . Insert After/Before: Allows inserting a new device after or before a specified device.
 . Merge Sort: Sorts the devices in the inventory based on their model using merge sort algorithm.
 . Print Inventory: Prints the list of devices in the inventory.

 ## Usage

 1. Adding Devices: Instantiate Devices<T> objects with device details and add them to the inventory using the Add method.

 2. Removing Devices: Remove devices from the inventory by providing their unique ID using the Remove method.

 3. Searching for Devices: Search for devices by model and optional storage using the Search method.

 4. Inserting Devices: Insert new devices after or before a specified device using the Insert After or Insert Before methods.

 4. Sorting Devices: Sort the devices in the inventory based on their model using the MergeSort method.

 5. Clearing Inventory: Clear the entire inventory using the Clear method.

 ## Future Enhancements

 . User Interface: Develop a graphical user interface (GUI) to interact with the device management system.
 . Database Integration: Integrate a database to persist device inventory data.
 . Additional Sorting Options: Implement sorting based on different criteria such as price or release year.

 ## The system outlined in the provided code includes the following components and functionalities:
    Devices<T> Class: Represents electronic devices and 
    provides properties for model, storage, color, price, ID, year, and availability status. 
    It also includes methods for validation and converting device information to string format.
    DoublyLinkedList Class implements a doubly linked list data structure to manage the devices. 
    It includes methods for adding, removing, searching, printing, sorting, 
    inserting devices after or before a specified device,and clearing the list.
    Program Class contains the Main method to demonstrate the functionality of the device management system. 
    It creates instances of various devices, adds them to the list, performs operations such as inserting 
    and removing devices, searches for devices, sorts the list, and prints the inventory.
    Usage Instructions provides usage guidelines for adding, removing, searching, inserting, sorting,
    and clearing the device inventory.All in all the project has no external dependencies and is built using C# and .NET framework.

    These components collectively form a system for managing an inventory of electronic devices in an Apple Store, 
    facilitating tasks such as adding new devices, removing existing ones, searching for specific models, 
    sorting the inventory, and more.