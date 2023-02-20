using Microsoft.Win32;
using System;
using System.IO;

namespace GOI_Cheat
{
    class Program
    {
        private static string SaveGame(string saveName, RegistryEditor registryEditor)
        {
            try
            {
                File.WriteAllBytes($"saves/{saveName}.xml", registryEditor.ReadRegistryKey<byte[]>("SaveGame1_h1867918427"));
                File.WriteAllBytes($"saves/{saveName}.xml", registryEditor.ReadRegistryKey<byte[]>("SaveGame0_h1867918426"));
                return null;
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        private static string LoadGame(string saveName, RegistryEditor registryEditor)
        {
            try
            {
                registryEditor.ChangeRegistryKey("SaveGame1_h1867918427", File.ReadAllBytes($"saves/{saveName}.xml"), RegistryValueKind.Binary);
                registryEditor.ChangeRegistryKey("SaveGame0_h1867918426", File.ReadAllBytes($"saves/{saveName}.xml"), RegistryValueKind.Binary);
                return null;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 2)
                {
                    RegistryEditor editor = new RegistryEditor(Constants.BasePath);

                    string status = null;
                    if (args[0] == "save")
                        status = SaveGame(args[1], editor);
                    else if (args[0] == "load")
                        status = LoadGame(args[1], editor);

                    string message = status == null ? "[Info]: Operation performed successfully!" : "[Error]: " + status;
                    Console.WriteLine(message);
                }
                else
                    Console.WriteLine("[Error]: Arguments supplied does not match regestered argument handler");
            }
            catch(Exception e)
            {
                Console.WriteLine("[Error]: " + e.ToString());
            }
        }
    }
}
