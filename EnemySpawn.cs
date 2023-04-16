using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] public GameObject[] enemy;  //Enemies variants can have different hp and speed
    public float counter = 0f;  //Checks number of enemies
    public float maxEnemy;         //Max number of enemy in a single wave 
    public int wave = 1;
    public int score = 0;
    [SerializeField] GameObject waveScreen;
    EnemyController controller;
    public GameObject enemyObj;
    GameManager gameManager;

    public GameObject player;
    PlayerHP playerhP;

    EnemyAttack enemyAttack;
    bool playerStatus;




    public Transform[] spawnPt;

    private void Start()
    {
        //int random = Random.Range(0, 2); //multiple enemy variant
        StartCoroutine(Spawn(PoolObjectType.Enemy));
        controller = enemyObj.GetComponent<EnemyController>();
        enemyAttack = enemyObj.GetComponent<EnemyAttack>();
        gameManager = GetComponent<GameManager>();
        playerhP = player.GetComponent<PlayerHP>();
        playerStatus = playerhP.isAlive;

    }

    private void Update()
    {
        score = gameManager.killcount*5;
        playerStatus = playerhP.isAlive;
    }

    IEnumerator Spawn(PoolObjectType type)
    {
        while (true)
        {
            if (playerStatus != false)
            {
                //Instantiate(enemy[Random.Range(0, enemy.Length)], spawnPt[(Random.Range(0, spawnPt.Length))], Quaternion.identity);      //Fixed multiple Spawn Points with instantiate

                GameObject ob = PoolManager.Instance.GetPoolObject(type);  //object pooling with random spawnpts
                ob.transform.position = spawnPt[(Random.Range(0, spawnPt.Length))].transform.position;  
                ob.gameObject.SetActive(true);
                //counter++; //set enemy limit
               // Debug.Log("Enemy count :" + counter);

                
            }

            if ((score/5) >= maxEnemy)
            {
                wave++;
                controller.speed ++;            //Enemy speed and fire rate increases with wave count
               // counter = 0;          
                score = 0;
                maxEnemy += 20;
                waveScreen.SetActive(true);
                yield return new WaitForSeconds(5f);
                waveScreen.SetActive(false);





            } 
  
            yield return new WaitForSeconds(1.5f);


        }
      

    }
}
