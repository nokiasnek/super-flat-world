using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public string playerName;
    public int playerLevel;
    public int playerHealth;
    public int playerEnergy;
    public int playerExp;
   

    public PlayerData (Player _player)
    {
        playerName = _player.player;
        playerLevel = _player.level;
        playerHealth = _player.health;
        playerEnergy = _player.energy;
        playerExp = _player.exp;
    }
}
