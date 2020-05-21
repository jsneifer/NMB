using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerwalk : MonoBehaviour
{
    private bool isWalking = false;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("LeftArrow"))
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
        anim.SetBool("IsWalking", isWalking);

    }
}
