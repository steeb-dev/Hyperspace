using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Serialization
{
    //Create a binary formater
    public static BinaryFormatter binaryFormatter = new BinaryFormatter();

    //Save the file to a path
    public static void Save(string path)
    {
        //Create new save data
        SaveData save = new SaveData(GameInformation.Craft);

        //Create a new memory stream
        MemoryStream mem = new MemoryStream();

        //Serialize our save data to the memory stream
        binaryFormatter.Serialize(mem, save);

        //Convert our memory stream to a string
        string temp = System.Convert.ToBase64String(mem.ToArray());

        //If the file exists used as the path argument, delete it
        if (File.Exists(path))
            File.Delete(path);

        //Create a file as a filestream at the path we used as an argument
        FileStream file = File.Create(path);

        //Using a stream writer, write out memory stream string to the filestream
        using (StreamWriter stream = new StreamWriter(file))
        {
            //Write the file
            stream.WriteLine(temp);
        }

        //Close the filestream
        file.Close();
    }

    //Get the file from a path
    public static object Load(string path)
    {
        //If the file doesn't exist, return null
        if (!File.Exists(path))
            return null;

        //Create a temporary string value
        string temp;

        //Using a stream reader, get the file from the path used as an argument
        using (StreamReader reader = new StreamReader(path))
        {
            //Read the file
            temp = reader.ReadToEnd();
        }

        //If our temp string is empty, return null
        if (temp == string.Empty)
            return null;

        //Create a new memory stream, and initialize it as a deserialized memory stream from our temp string
        MemoryStream mem = new MemoryStream(System.Convert.FromBase64String(temp));

        //Return the memory stream
        return binaryFormatter.Deserialize(mem);
    }
}

//The class used to make saving/loading data easier
[System.Serializable]
public class SaveData
{
    //The data to be saved
    public CraftClassType player;

    //Constructor. Just sets the values
    public SaveData(CraftClassType player)
    {
        this.player = player;
    }
}