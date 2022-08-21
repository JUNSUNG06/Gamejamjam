using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public int money; 
    public List<OliveImage> cookImage = new List<OliveImage>();
    public List<OliveImage> sellImage = new List<OliveImage>();
    
    public PlayerInfo(int _money)
    {
        money = _money;
        cookImage.Clear();
        sellImage.Clear();
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

    public void Save()
    {
        playerInfo.cookImage = Inventory.Instance.cookImage;
        playerInfo.sellImage = Inventory.Instance.sellImage;
        
        PlayerPrefs.SetString("player", JsonUtility.ToJson(playerInfo));
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

