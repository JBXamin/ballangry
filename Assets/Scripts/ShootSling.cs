using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSling : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    public Transform ballPos;
    public static bool shoot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shoot)
        {
            shoot = false;
            Invoke("ballsSpawn", 3f);
        }
    }

    void ballsSpawn()
    {
        
        Instantiate(Ball, ballPos.position, transform.rotation);
    }
}
