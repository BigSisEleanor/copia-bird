using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovement : MonoBehaviour
{

    float speed;
    public ScoreManager scoreManager;
    public Script ScriptCounter;

    void Start()
    {
        scoreManager = FindFirstObjectByType(typeof(ScoreManager)) as ScoreManager;
        ScriptCounter = FindFirstObjectByType(typeof(Script)) as Script;
        Destroy(this.gameObject, 15);
    }

    
    void FixedUpdate()
    {
        ObsMov();
    }

    void ObsMov()
    {
        transform.position += new Vector3(-aumentaSpeed() * Time.deltaTime, 0, 0);
    }

    float aumentaSpeed()
    {
        int score = ScriptCounter.getCurrentScore();
        float baseSpeed = 1f;
        if (score != 0)
        {
            float speedMultiplica = 0.04f * score;
            float speed = baseSpeed * (1f + speedMultiplica);
            return speed;

        }
        else
        {
            float speed = 1f;
            return speed;
        }
        
        
    }
}
