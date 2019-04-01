using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControllerDraw : MonoBehaviour {

   
    public Animator anim;
    public static bool playDraw = false;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playDraw == true)
        {
            anim.Play("drawOpen");
            //playDraw = false;
        }

    }
}
