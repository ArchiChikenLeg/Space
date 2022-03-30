using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comp : MonoBehaviour
{
    Renderer rend;
    public static bool choosed = false;
    public static bool rocket = false;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.yellow;
            choosed = true;
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.white;
            choosed = false;
        }

    }
}

