using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuUIHandler : MonoBehaviour
{
    public InputField playerNameIF;
    void Start()
    {

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
