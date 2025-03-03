using Microsoft.Win32;
using System.Diagnostics;

while (true)
{
    Console.Title = "winedit";
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@"           _                _ _ _   
          (_)              | (_) |  
 __      ___ _ __   ___  __| |_| |_ 
 \ \ /\ / / | '_ \ / _ \/ _` | | __|
  \ V  V /| | | | |  __/ (_| | | |_ 
   \_/\_/ |_|_| |_|\___|\__,_|_|\__|                                    
                                    ");

    Console.WriteLine("\nChoose an option below:");
    Console.WriteLine("\n1.) Enable Dark Mode in Windows");
    Console.WriteLine("2.) Enable Light Mode in Windows");
    Console.WriteLine("3.) Enable Dark Mode in apps");
    Console.WriteLine("4.) Enable Light Mode in apps");
    Console.WriteLine("5.) Restart Explorer");
    Console.WriteLine("6.) Exit");
    Console.WriteLine("\n");


    var option = Console.ReadLine();


    if (option == "1")
    {
        Console.Clear();
        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", 0, RegistryValueKind.DWord);
        Thread.Sleep(500);
        System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe >nul 2>&1 & start explorer.exe >nul 2>&1");
        Thread.Sleep(3000);
        Console.WriteLine("Dark mode enabled.");
        Console.WriteLine("\nPress any key to return to the selection menu...");
        Console.ReadKey();
        Console.Clear();
    }

    else if (option == "2")
    {
        Console.Clear();
        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "SystemUsesLightTheme", 1, RegistryValueKind.DWord);
        Thread.Sleep(500);
        System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe >nul 2>&1 & start explorer.exe >nul 2>&1");
        Thread.Sleep(3000);
        Console.WriteLine("Light mode enabled.");
        Console.WriteLine("\nPress any key to return to the selection menu...");
        Console.ReadKey();
        Console.Clear();
    }

    else if (option == "3")
    {
        Console.Clear();
        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", 0, RegistryValueKind.DWord);
        Thread.Sleep(500);
        System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe >nul 2>&1 & start explorer.exe >nul 2>&1");
        Thread.Sleep(3000);
        Console.WriteLine("Dark mode in apps enabled.");
        Console.WriteLine("\nPress any key to return to the selection menu...");
        Console.ReadKey();
        Console.Clear();
    }

    else if (option == "4")
    {
        Console.Clear();
        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", 1, RegistryValueKind.DWord);
        Thread.Sleep(500);
        System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe >nul 2>&1 & start explorer.exe >nul 2>&1");
        Thread.Sleep(3000);
        Console.WriteLine("Light mode in apps enabled.");
        Console.WriteLine("\nPress any key to return to the selection menu...");
        Console.ReadKey();
        Console.Clear();
    }

    else if (option == "5")
    {
        Console.Clear();
        Thread.Sleep(500);
        System.Diagnostics.Process.Start("cmd.exe", "/C taskkill /f /im explorer.exe >nul 2>&1 & start explorer.exe >nul 2>&1");
        Thread.Sleep(3000);
        Console.WriteLine("Restarted explorer.");
        Console.WriteLine("\nPress any key to return to the selection menu...");
        Console.ReadKey();
        Console.Clear();
    }

    else if (option == "6")
    {
        Environment.Exit(0);
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid choice.");
        Thread.Sleep(1000);
        Console.Clear();
    }
}