using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveManager 
{
    public static void SavePlayerData(GIroscopio player)
    {
        ScoreManager jugador = new ScoreManager(player);
        jugador.addScore(player.score);
        jugador.OrdenarPuntaje();
        string dataPath = Application.persistentDataPath + "/player.save";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryFormater = new BinaryFormatter();
        binaryFormater.Serialize(fileStream, jugador);
        fileStream.Close();
    }
    public static ScoreManager LoadPLayerData()
    {
        string dataPath = Application.persistentDataPath + "/player.save";
        if(File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter binaryFormater = new BinaryFormatter();
            ScoreManager scoreManager =(ScoreManager) binaryFormater.Deserialize(fileStream);
            fileStream.Close();
            return scoreManager;
        }
        else
        {
            Debug.LogError("No se encontro archivo de guardado");
            return null;
        }
    }

}
