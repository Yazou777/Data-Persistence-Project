using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName;
    public string bestPlayerScored;
    public int bestScore;
    // Start is called before the first frame update
    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadPlayerName();
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public string bestPlayerScored;
        public int bestScore;
    }

    public void SavePlayerName()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.bestScore = bestScore;
        data.bestPlayerScored = bestPlayerScored;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            bestPlayerScored = data.bestPlayerScored;
            bestScore = data.bestScore;
        }
    }


}
