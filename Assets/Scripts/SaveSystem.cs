using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[System.Serializable]
public class GameSystemData
{
    public int stage = 1;
    public int current_stage = 1;
    
    public GameSystemData (Game_System gameSystem)
    {
        stage = gameSystem.stage;
        current_stage = gameSystem.current_stage;
    }
}

public static class SaveSystem
{
    public static void SavePlayer (Game_System gameSystem)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        GameSystemData data = new GameSystemData(gameSystem);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameSystemData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameSystemData data = formatter.Deserialize(stream) as GameSystemData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
