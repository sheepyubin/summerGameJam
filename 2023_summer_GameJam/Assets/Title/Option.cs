using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public GameObject popupPrefab;
    public GameObject Panel;

    public void ShowPopup() //팝업 활성화 함수
    {
            GameObject popup = Instantiate(popupPrefab, transform.position, Quaternion.identity);
            popup.SetActive(true);
    }

    public void DisablePopup() //팝업 활성화 함수
    {
        popupPrefab.SetActive(false);
    }
}

