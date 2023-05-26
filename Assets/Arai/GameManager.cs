using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    /// <summary> Scoreを表示するテキスト</summary>
    [Header("Scoreを表示するテキスト")]
    [SerializeField] Text _textPanel;
    [Header("Playerが獲得したscore")]
    [SerializeField] private int _score = 0;
    public int GetScore
    { 
        get { return _score; }
        set { _score = value; }
    }
    [Header("Playerのクリア判定")]
    [SerializeField] private bool _isClear = false;
    public bool GetClear
    {
        get { return _isClear; }
        set { _isClear = value; }
    }
    [Header("Playerのゲームオーバー判定")]
    [SerializeField] private bool _isGameOver = false;
    public bool GameOver
    {
        get { return _isGameOver; }
        set { _isGameOver = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (_textPanel != null)
        {
            _textPanel.text = _score.ToString();
        }

        if (_isClear)
        {
            _isClear = false;
            SceneChnager("Clear");
        }

        if(_isGameOver)
        {
            _isGameOver = false;
            SceneChnager("GameOver");
        }
    }

    public void SceneChnager(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
