using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text contador_;
    public int score_;
     

    void Start()
    {
       

    }

    
    void Update()
    {
       contador_.text = score_.ToString();
    }
}
