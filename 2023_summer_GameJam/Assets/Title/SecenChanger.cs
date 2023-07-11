using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SecenChanger : MonoBehaviour
{
    public void StartToLoading()
    {
        SceneManager.LoadScene("loding");
    }

}
