using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneChanger : MonoBehaviour
{
    public GameObject Baby;

    private void Update()
    {
        if (Baby.transform.position.x == 5.6f)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
