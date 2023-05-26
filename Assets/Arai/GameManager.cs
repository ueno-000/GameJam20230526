using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Common;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    /// <summary> Score��\������e�L�X�g</summary>
    [Header("Score��\������e�L�X�g")]
    [SerializeField] Text _textPanel;

    //[Header("Player���l������score")]
    //[SerializeField] private int _score = 0;
    static public int GetScore{ get; set; }
    
    //[Header("Player�̃N���A����")]
    //[SerializeField] private bool _isClear = false;
    static public bool GetClear { get; set; }

    //[Header("Player�̃Q�[���I�[�o�[����")]
    //[SerializeField] private bool _isGameOver = false;
    static public bool GameOver { get; set; }

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
            _textPanel.text = GetScore.ToString();
        }

        if (GetClear)
        {
            if (SceneManager.GetActiveScene().name == Define.SCENENAME_MASTERGAME)
            {
                SceneChnager(Define.SCENENAME_CLEAR_RESULT);
            }

            GetClear = false;
        }


        if(GameOver)
        {
            Debug.Log("���[�ނ��[�΁[�[");
            if (SceneManager.GetActiveScene().name == Define.SCENENAME_MASTERGAME)
            {
                SceneChnager(Define.SCENENAME_GAMEOVER_RESULT);
            }

            GameOver = false;
        }
    }

    public void SceneChnager(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
