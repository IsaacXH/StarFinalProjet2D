using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool GameOver = false;
    public float scrollSpeed = -1.5f;
    public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.instance.CurrentHealth == 0)
        {
            GameOver = true;
        }
    }
    public void PlayerDied()
    { 

        GameOver = true;
    }
    }
