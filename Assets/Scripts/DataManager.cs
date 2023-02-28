using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string playerName;

    public void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
