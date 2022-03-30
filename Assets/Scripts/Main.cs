using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && Map.getChose())
            SceneManager.LoadScene(1);
        if (Input.GetKeyDown(KeyCode.Return) && Comp.choosed)
            SceneManager.LoadScene(3);
    }
}
