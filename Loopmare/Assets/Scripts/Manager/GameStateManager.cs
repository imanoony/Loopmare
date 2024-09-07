using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    Ready,
    Running,
    Clear
}
public class GameStateManager : MonoBehaviour
{
    public GameState State { get; private set; }
    public static float _time = 0f;
    private AudioManager _audioManager;
    public void PrepareGame()
    {
        Time.timeScale = 0f;
        State = GameState.Ready;
        _time = 0f;
        SceneManager.LoadScene("Scenes/Main");
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        State = GameState.Running;
    }
    public void ClearGame()
    {
        Time.timeScale = 0f;
        State = GameState.Clear;
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    // Start is called before the first frame update
    void Start()
    {
        _audioManager = GameManager.Instance.AudioManager;
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (State == GameState.Ready)
        {
            StartGame();
        }

        if (State == GameState.Running)
        {
            _time += Time.deltaTime;

            if (_time > 75f && _time < 76f)
            {
                UseManager._pC = 2;
            }

            if (_time > 150f)
            {
                ClearGame();
            }
        }

        if (State == GameState.Clear)
        {
            Time.timeScale = 0f;
            _audioManager.PlaySfx(2);
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                QuitGame();
            }
        }
    }
}
