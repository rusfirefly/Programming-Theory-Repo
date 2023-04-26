using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{

    public static GameManeger Instance;
    public GameObject selectedObj { get; set; }
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Select(GameObject obj)
    {
        selectedObj = obj;
    }

    void Update()
    {
        
    }

}
