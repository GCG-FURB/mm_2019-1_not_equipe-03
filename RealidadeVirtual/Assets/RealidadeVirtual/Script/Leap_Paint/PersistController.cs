using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistController : MonoBehaviour
{
    public static PersistController Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //LoadFromPersistedData();
    }

    public void PersistEverything()
    {
        UserPersistData userData = new UserPersistData();
        userData.Scenes = new ScenePersistData[1];
        userData.Scenes[0] = ScenePaintLeap.Instance.GetPersistData();

        //Debug.Log(JsonUtility.ToJson(userData, true));
        //PlayerPrefs.SetString("data", JsonUtility.ToJson(userData, false));
        Debug.Log("Salvando: " + Application.persistentDataPath + "/data.json");
        File.WriteAllText(Application.persistentDataPath + "/data.json", JsonUtility.ToJson(userData, false));
    }

    public void LoadFromPersistedData()
    {
        var jsonData = File.ReadAllText(Application.persistentDataPath + "/data.json");
        if (!String.IsNullOrEmpty(jsonData))
        {
            UserPersistData userData = JsonUtility.FromJson<UserPersistData>(jsonData);
            ScenePaintLeap.Instance.Trails.Clear();
            ScenePaintLeap.Instance.LoadPersistData(userData.Scenes[0]);
        }
    }
}
