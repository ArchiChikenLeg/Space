using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Saturn : MonoBehaviour
{
    public static int InventoryFull = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && Rocket.chose)
            SceneManager.LoadScene(0);
    }
}