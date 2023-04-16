using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject gM;
    GameManager gameManager;
    public GameObject highScrObj;
    Text highScr;
    public int totalscore;

    public static int highScore;
  


    private void Start()
    {
        gameManager = gM.GetComponent<GameManager>();
        highScr = highScrObj.GetComponent<Text>();
        highScr.text = PlayerPrefs.GetInt("highScore", 0).ToString();


    }

    public void Update()
    {
        totalscore = gameManager.killcount * 5;

        if (totalscore > highScore)
        {
            highScore = totalscore;
            

            PlayerPrefs.SetInt("highScore", highScore);
            PlayerPrefs.Save();

            
        }
        
    }
}

