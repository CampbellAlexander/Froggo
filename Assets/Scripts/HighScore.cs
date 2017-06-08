using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public static int highScore = 0;
    private Text highScoreText;

    //auto-save & load
    private void OnEnable() { Load(); }
    private void OnDisable() { Save(); }
    
    void Start () {
        highScoreText = GetComponent<Text>();
	}
	
	void Update () {
        highScoreText.text = "highscore " + highScore.ToString();
	}



    public void Save()
    {
        HighScoreData data = new HighScoreData();
        data.highScore = HighScore.highScore;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save.data");
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/save.data"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.data", FileMode.Open);
            HighScoreData data = (HighScoreData)bf.Deserialize(file);
            file.Close();

            HighScore.highScore = data.highScore;
        }
    }
}


[Serializable]
class HighScoreData
{
    public int highScore;
}
