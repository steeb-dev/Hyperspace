using UnityEngine;
using System.Collections;

public class SaveInformation
{
    //Saves the information to a file
    public static void SaveAllInformation()
    {
        //Actually save TEMP PATH FOR DEBUG PURPOSES
        Save(Application.streamingAssetsPath + "/TestSave.sav");
    }

    public static void Save(string path)
    {
        Serialization.Save(path);
    }
}