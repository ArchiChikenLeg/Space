using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    Renderer rend;
    [SerializeField] private float speed = 3f;
    private Rigidbody2D rb;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody2D>();
        rend.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Run();
        if (Input.GetButton("Vertical"))
            Fly();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }

    private void Fly()
    {
        Vector3 dir = transform.up * Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Map")|| collision.gameObject.name.Equals("Rocket")|| collision.gameObject.name.Equals("Rock")|| collision.gameObject.name.Equals("Aster") || collision.gameObject.name.Equals("Trash") || collision.gameObject.name.Equals("Comp"))
            rend.material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Map") || collision.gameObject.name.Equals("Rocket") || collision.gameObject.name.Equals("Rock") || collision.gameObject.name.Equals("Aster") || collision.gameObject.name.Equals("Trash")|| collision.gameObject.name.Equals("Comp"))
            rend.material.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
    }
}
