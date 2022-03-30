using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Animka : MonoBehaviour
{
    Renderer rend;
    float y;
    void Start()
    {
        rend = GetComponent<Renderer>();
            Anim();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Anim()
    {
        for (int i = 1; i < 4; i++)
        {
            Thread.Sleep(100);
            //y = -0.35 - 0.5 * i;
            transform.position = new Vector3(1.75f, -0.35f - 0.5f * i, 0.0f);
        }
        for (int i = 1; i < 4; i++)
        {
            Thread.Sleep(100);
            //y = -0.35 + 0.5 * i;
            transform.position = new Vector3(1.75f, -0.35f + 0.5f * i, 0.0f);
        }
    }
}
