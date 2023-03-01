using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    public Text bestScoreText;
    public InputField playerNameIF;
    void Start()
    {
        if(DataManager.Instance.bestPlayerName != "")
        {
            bestScoreText.text = $"Best Score : {DataManager.Instance.bestPlayerName} : {DataManager.Instance.bestScore}";
        }
        else
        {
            bestScoreText.gameObject.SetActive(false);
        }
    }
    public void NewStart()
    {
        SceneManager.LoadScene(1);
    }

    public void NewPlayerNameEnter()
    {
        DataManager.Instance.playerName = playerNameIF.text;
    }
}
