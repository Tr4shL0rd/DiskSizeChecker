using System;
using System.IO;

class Kodify_Example
{
    static void Main()
    {
        // Create a DriveInfo instance of the D:\ drive
        DriveInfo dDrive = new DriveInfo("C");

        // When the drive is accessible..
        if (dDrive.IsReady)
        {
            // Calculate the percentage free space
            double freeSpacePerc =
                (dDrive.AvailableFreeSpace / (float)dDrive.TotalSize) * 100;

            // Ouput drive information
            Console.WriteLine("Drive: {0} ({1}, {2})",
                dDrive.Name, dDrive.DriveFormat, dDrive.DriveType);

            Console.WriteLine("\tFree space ca:\t{0}",
                dDrive.AvailableFreeSpace / 1024 / 1024 / 1024 + "GB");
            Console.WriteLine("\tTotal space ca:\t{0}",
                dDrive.TotalSize / 1024 / 1024 / 1024 + "GB");

            Console.WriteLine("\n\tPercentage free space: {0:0.00}%.",
                freeSpacePerc);
        }

        Console.WriteLine("\nPress a key to close this window..");
        Console.ReadKey();
    }
}
