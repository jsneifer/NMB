using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger2 : MonoBehaviour
{
    float player2Health;
    public GameObject completeLevelUI2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player2Health = GameObject.Find("Player2").GetComponent<HealthBar2>().slider2.value;
        Debug.Log(player2Health);
        if (player2Health == 0)
        {
            DisplayEndGame2();
        }

    }

    void DisplayEndGame2()
    {
        completeLevelUI2.SetActive(true);
    }
}
