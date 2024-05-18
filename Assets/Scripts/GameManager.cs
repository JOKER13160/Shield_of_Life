using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public enum GameState
    {
        start,
        play,
        story,
        pause,
        win,
        lose
    }
    [SerializeField]public GameState gameState;

    private void Start()
    {
        SetGameState(GameState.start);
        Debug.Log("GameState : "+ gameState);
        StartCoroutine(PauseGame(gameState));
    }

    public void SetGameState(GameState state)
    {
        gameState = state;
    }

    private IEnumerator PauseGame(GameState state)
    {
        while (true)
        {
            if (gameState == GameState.play)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SetGameState(GameState.pause);
                    Debug.Log("GameState : " + gameState);
                }
            }
            yield return new WaitForFixedUpdate();
        }
    }
}
