using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int enemyCount;
    public int scene;
    bool onlyone = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onlyone)
        {
            ShootSling.shoot = true;
            onlyone = false;
        }
        check();
    }

    void check()
    {
        if(enemyCount == PlayerMovement.count)
        {
            PlayerMovement.count = 0;
            
            SceneManager.LoadScene(scene);
            
        }
    }
}
