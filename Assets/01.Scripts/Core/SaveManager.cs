using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo
{
    public int money; 
    public List<Turtle> turtleList = new List<Turtle>();
    
    public PlayerInfo(int _money)
    {
        money = _money;
        turtleList.Clear();
    }
}

public class SaveManager 
{
    public static SaveManager Instance = null;

    public PlayerInfo playerInfo;

    public SaveManager() 
    {
        string playerjson = PlayerPrefs.GetString("player", "");

        if(playerjson == "")
        {
            playerInfo = new PlayerInfo(0);
            Debug.Log("Create PlayerInfo");
        }
        else 
        {
            playerInfo = JsonUtility.FromJson<PlayerInfo>(playerjson);
        }
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetString("player", JsonUtility.ToJson(playerInfo));
            Debug.Log(PlayerPrefs.GetString("player", ""));
        }
    }
}

