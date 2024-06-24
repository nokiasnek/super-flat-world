using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    
    public enum GameState { Start, Playing, Paused, Stopped }
    private GameState currentState;

    public UIManager uiManager; // Reference to the UIManager
    public Player player; // Reference Player 


    public Button LoadButton;
    public Button ImportButton;
    public Button JoinButton;
    

    // Called on the first frame when the script is enabled
    void Start()
    {

        Debug.Log("Session started");

        ChangeState(GameState.Start);

        // Assign button click events
        if (JoinButton != null)
        {
            JoinButton.onClick.AddListener(OnJoinButtonClick);
        }
        else
        {
            Debug.LogError("Join button is not assigned in the Inspector.");
        }

        if (LoadButton != null)
        {
            LoadButton.onClick.AddListener(OnLoadButtonClick);
        }
        else
        {
            Debug.LogError("Load button is not assigned in the Inspector.");
        }

        if (ImportButton != null)
        {
            ImportButton.onClick.AddListener(OnImportButtonClick);
        }
        else
        {
            Debug.LogError("Import Button is not assigned in the Inspector.");
        }

    }


    void ChangeState(GameState newState)
    {

        currentState = newState;
        switch (currentState)
        {
            case GameState.Start:
                uiManager.ShowStartPanel();
                break;
            case GameState.Playing:
                uiManager.ShowGameUIPanel();
                break;
            case GameState.Paused:
                break;
        }


    }


    // Update is called once per frame
    void Update()
    {

        // Handle state-specific updates
        switch (currentState)
        {
            case GameState.Start:
                // Update logic for Start state (if any)
                break;
            case GameState.Playing:
                // Update logic for Playing state
                //HandlePlayingState();
                break;
            case GameState.Paused:
                // Update logic for Paused state (if any)
                break;
            case GameState.Stopped:
                // Update logic for GameOver state (if any)
                break;
        }
    }


    void OnJoinButtonClick()
    {

        currentState = GameState.Playing;
        Debug.Log("Joining Session... Session Starting");

        ChangeState(currentState);
    }

    void OnLoadButtonClick()
    {

        Debug.Log("Loading Player data...");

        // Update: Find the Player instance in the scene
        player = FindObjectOfType<Player>();

        if (player != null)
        {
            // Call to load saved file
            player.LoadPlayer();
            Debug.Log("Player data: " + player.player + ", Level: " + player.level); // Confirm data
            // Update: Ensure UIManager knows the Player instance
            uiManager.player = player;
            uiManager.UpdatePlayerUI();
        }
        else
        {
            Debug.LogError("Player not found in the scene.");
        }
    }

    void OnImportButtonClick()
    {

        Debug.Log("OnImportButtonClick Event");
        player = FindAnyObjectByType<Player>();

        // import  file
        if (player != null)
        {
            // Import file
            player.ImportPlayer();
        }
        else
        {
            Debug.LogError("Player not found in the scene.");
        }
    }


}
