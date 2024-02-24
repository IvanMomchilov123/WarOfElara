using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState state;
    public GameObject sceneFader;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        DontDestroyOnLoad(sceneFader);
        DontDestroyOnLoad(gameObject);
        UpdateGameState(GameState.Login);
    }

    public void UpdateGameState(GameState newState)
    {
        this.state = newState;
        switch (newState)
        {
            case GameState.Login:
                break;
            case GameState.MainMenu:
                SceneFadeOut();
                break;
            default:
                break;
        }
    }

    public enum GameState
    {
        Login,
        MainMenu,
        Decks,

    }

    private void SceneFadeOut()
    {
        Animator animator = sceneFader.GetComponent<Animator>();
        animator.SetTrigger("fadeOut");
    }

    public void SceneFadeComplete()
    {
        string scene = "";
        switch (this.state)
        {
            case GameState.Login:
                scene = "LogInFormScene";
                break;
            case GameState.MainMenu:
                scene = "MainMenuScene";
                break;
        }

        SceneManager.LoadScene(scene);
    }
}
