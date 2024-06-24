using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string player = "yume";
    public int level = 1;
    public int health = 100;
    public int energy = 100;
    public int exp = 0;

    public void ImportPlayer()
    {
        Debug.Log("Saved");
        SaveSystem.ImportPlayer(this);
    }

    public void LoadPlayer()
    {

        Debug.Log("check point for read log event");
        PlayerData data = SaveSystem.LoadPlayer();

        if (data != null)
        {
            player = data.playerName;
            level = data.playerLevel;
            health = data.playerHealth;
            energy = data.playerEnergy;
            exp = data.playerExp;
            Debug.Log("player name: " + player);
            Debug.Log("player level: " + level);
            Debug.Log("player health: " + health);
            Debug.Log("player energy: " + energy);
            Debug.Log("player exp: " + exp);
            Debug.Log("Player data successfully loaded");
        }
        else
        {
            Debug.LogError("Player data not found");
        }
    }

    public void ReadPlayerData()
    {
        
        PlayerData data = SaveSystem.LoadPlayer();

        if (data != null)
        {
            player = data.playerName;
            level = data.playerLevel;
            health = data.playerHealth;
            energy = data.playerEnergy;
            exp = data.playerExp;

            Debug.Log("Player: " + player + ", Level: " + level
                + ", Health: " + health + ", Energy: " + energy);
        }
        else
        {
            Debug.LogError("Player data not found");
        }
    }
}
