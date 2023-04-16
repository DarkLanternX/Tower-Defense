using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WaveCount : MonoBehaviour
{
    Text WaveText;
    public GameObject waveObj;
    EnemySpawn waveCount;

    void Start()
    {
        WaveText = GetComponent<Text>();
        waveCount = waveObj.GetComponent<EnemySpawn>();
    }

    // Update is called once per frame
    void Update()
    {
        WaveText.text = waveCount.wave.ToString();
    }

}
