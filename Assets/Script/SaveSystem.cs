using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public static class SaveSystem
{
    
    public static void ImportPlayer (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.babe";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);

        stream.Close();

    }


    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.babe";
        if (File.Exists(path))
        {
            Debug.Log("file found");
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData; // read PlayerData as PlayerData type

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("save file not found, please check --> " + path);

            return null;
        }

    }
}
