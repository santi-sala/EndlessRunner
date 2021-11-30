using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager _Instance { get { return instance; } }
    private static SaveManager instance;


    // Fields
    public SaveState save;
    private const string saveFileName = "data.runTiagorun";
    private BinaryFormatter formatter;


    // Actions
    public Action<SaveState> OnLoad;
    public Action<SaveState> OnSave;

    private void Awake()
    {
        instance = this;
        formatter = new BinaryFormatter();

        // Try and load previous save state
        Load();
    }

    public void Load()
    {
        try
        {
            FileStream file = new FileStream(Application.persistentDataPath + saveFileName, FileMode.Open, FileAccess.Read);

            // Deserializing
            //save = (SaveState)formatter.Deserialize(file);
            save = formatter.Deserialize(file) as SaveState;
            file.Close();

            OnLoad?.Invoke(save);
            Debug.Log("Loading Data!!");
        }
        catch
        {
            Debug.Log("There is no savefile, one will be created");
            Save();
        }
    }

    public void Save()
    {
        // If theres no save file, create a new one
        if (save == null)
        {
            save = new SaveState();
        }

        // Saving the time which save was created
        save.LastSaveTime = DateTime.Now;

        // Open file on our system and write to it.
        FileStream file = new FileStream(Application.persistentDataPath + saveFileName, FileMode.OpenOrCreate, FileAccess.Write);
        formatter.Serialize(file, save);
        file.Close();

        OnSave?.Invoke(save);
    }
}
