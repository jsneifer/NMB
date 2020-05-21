using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    float player1Health;
    public GameObject completeLevelUI;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        player1Health = GameObject.Find("Player1").GetComponent<HealthBar>().slider.value;
        Debug.Log(player1Health);
        if (player1Health == 0)
        {
            DisplayEndGame();
        }

    }

    void DisplayEndGame()
    {
        completeLevelUI.SetActive(true);
    }
}
