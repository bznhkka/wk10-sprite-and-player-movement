using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // walking
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            playerAnim.SetBool("walk", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("walk", false);

        }

        //jump

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.SetBool("jump", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.SetBool("jump", false);

        }
    }
}
