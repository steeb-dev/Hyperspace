using UnityEngine;
using System.Collections;

public class LoadInformation
{
    //Loads the information from a file
    public static void LoadAllInformation()
    {
        //Creates a new savedata which we load from a file, needs to be typecasted to savedata because it returns a memory stream
        SaveData data = (SaveData)Serialization.Load(Application.streamingAssetsPath + "/TestSave.sav");

        //If the data loaded correctly set the values
        if (data != null)
        {
            GameInformation.Craft = data.player;
        }
        else
            Debug.Log("Error loading file");        //Just alert the debug log the file wasn't loaded correctly
    }
}