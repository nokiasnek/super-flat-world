using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{

    public GameObject MainUIPanel;
    public GameObject StartPanel;
    public GameObject StartButtonPanel;
    public GameObject PlayerProfilePanel;
    public GameObject GameUIPanel;
    public GameObject WorldPanel;

    public TMP_Text PlayerNameText;
    public TMP_Text PlayerLevelText;
    public TMP_Text PlayerHealthText;
    public TMP_Text PlayerEnergyText;
    public TMP_Text PlayerExpText;

    public Player player; // Reference to the Player component

    // Show the start panel and hide the others
    public void ShowStartPanel()
    {

        StartPanel.SetActive(true);
        StartButtonPanel.SetActive(false);
        PlayerProfilePanel.SetActive(false);
        GameUIPanel.SetActive(false);
    }

    public void ShowPlayerProfilePanel()
    {
        PlayerProfilePanel.SetActive(true);
        GameUIPanel.SetActive(false);
    }

    // Show the world panel and hide the others
    public void ShowWorldPanel()
    {

        MainUIPanel.SetActive(false);
        WorldPanel.SetActive(true);
    }

    // Show the game UI panel and hide the others
    public void ShowGameUIPanel()
    {

        StartPanel.SetActive(false);
        StartButtonPanel.SetActive(false);
        PlayerProfilePanel.SetActive(false);
        MainUIPanel.SetActive(false);
        GameUIPanel.SetActive(true);
    }

    // Update the player's name and level in the UI
    public void UpdatePlayerUI()
    {
       
        if (player != null)
        {
            Debug.Log("Updating player UI with name: " + player.player + " and level: " + player.level);
            //Debug.Log("PlayerNameText is " + player.player);
            //Debug.Log("PlayerLevelText is " + player.level);
            PlayerNameText.text =   "player       " + player.player; 
            PlayerLevelText.text =  "Level        " + player.level.ToString();
            PlayerHealthText.text = "Health       " + player.health.ToString();
            PlayerEnergyText.text = "Energy       " + player.energy.ToString();
            PlayerExpText.text =    "Experience   " + player.exp.ToString();

            ShowPlayerProfilePanel();
        }
        else
        {
            Debug.LogError("Player does not exist.");
        }
    }
}
