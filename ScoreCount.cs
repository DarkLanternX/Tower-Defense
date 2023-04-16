using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public GameObject ScrObj;
    ScoreManager scoreManager;
    Text scoreText;


    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreManager = ScrObj.GetComponent<ScoreManager>();
    }

    private void Update()
    {
        scoreText.text = scoreManager.totalscore.ToString(); 
    }

}
