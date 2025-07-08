using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    float cool_down = 0;
    public GameObject objt;
    ScoreManager score_manager;

    void Start()
    {

        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();

    }


    void Update()
    {
        CoolDown();
    }


    void spawnObs()
    {
        Instantiate(objt, new Vector3(5, Random.Range(-1, 6), 0), Quaternion.identity);
    }
    void CoolDown()
    {

        

        if (cool_down > 0)
        {
            cool_down -= Time.deltaTime;

        }
        else
        {
            spawnObs();
            cool_down = (3 - (score_manager.score_ / 100));
        }
    }
}
