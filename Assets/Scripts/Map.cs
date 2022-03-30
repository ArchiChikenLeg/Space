using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    Renderer rend;
    static bool Mapchoosed = false;
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
            Mapchoosed = true;
        }
            
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.white;
            Mapchoosed = false;
        }
            
    }

    public static bool getChose()
    {
        return Mapchoosed;
    }
}

