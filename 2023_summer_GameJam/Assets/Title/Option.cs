using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    public GameObject popupPrefab;
    public GameObject Panel;

    public void ShowPopup() //�˾� Ȱ��ȭ �Լ�
    {
            GameObject popup = Instantiate(popupPrefab, transform.position, Quaternion.identity);
            popup.SetActive(true);
    }

    public void DisablePopup() //�˾� Ȱ��ȭ �Լ�
    {
        popupPrefab.SetActive(false);
    }
}

