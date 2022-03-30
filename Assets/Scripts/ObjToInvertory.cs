using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjToInvertory : MonoBehaviour
{
    Renderer rend;
    bool chosen;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && chosen)
            Picked();
            
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.yellow;
            chosen = true;
        }
            

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Enter"))
        {
            rend.material.color = Color.white;
            chosen = false;
        }
            
    }

    void Picked()
    {
        rend.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        transform.position = new Vector3(8.0f - Saturn.InventoryFull,-4.3f, -7.0f);
        transform.localScale = new Vector3(0.95f, 0.95f, 0.95f);
        Saturn.InventoryFull++;
        //transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
