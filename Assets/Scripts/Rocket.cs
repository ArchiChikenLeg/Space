using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Renderer rend;
    public static bool chose = false;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.yellow;
            chose = true;
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.white;
            chose = false;
        }

    }
}
