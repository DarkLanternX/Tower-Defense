using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpText : MonoBehaviour
{
    Text hpText;
    public GameObject hpObj;
    TowerHP towerhP;

    void Start()
    {
        hpText = GetComponent<Text>();
        towerhP = hpObj.GetComponent<TowerHP>();
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = towerhP.currentHealth.ToString();
    }

}

