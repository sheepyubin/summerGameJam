using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lodingTXT : MonoBehaviour
{
    TextMeshProUGUI lodingTMPro;
    string[] lodingString = new string[4];
    float time;
    int i;
    void Start()
    {
        lodingTMPro = GetComponent<TextMeshProUGUI>();
        lodingString[0] = "Loding";
        lodingString[1] = "Loding .";
        lodingString[2] = "Loding . .";
        lodingString[3] = "Loding . . .";
        time = 0.0f;
        i = 0;
    }
    void Update()
    {
        time += Time.deltaTime;
        if(time > 0.14f)
        {
            time = 0.0f;
            lodingTMPro.text = lodingString[i];
            i++;
            i %= 4;
        }
    }
}
