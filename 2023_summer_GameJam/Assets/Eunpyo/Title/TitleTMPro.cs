using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleTMPro : MonoBehaviour
{
    [SerializeField]
    GameObject[] Text_canvas = new GameObject[3];
    [SerializeField] TextMeshProUGUI[] Title_text = new TextMeshProUGUI[3];
    void Start()
    {

    }
    void Update()
    {
        Vector3 mouse_Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D cursor_Hit = Physics2D.Raycast(mouse_Pos, Vector2.zero, 0f);
        if (cursor_Hit.collider != null)
        {
            GameObject cursor_Obj = cursor_Hit.transform.gameObject;
            for (int i = 0; i < 3; i++)
            {
                if (cursor_Obj == Text_canvas[i])
                {
                    if (i == 1 || i == 2)
                    {
                        Title_text[i].fontSize = 110;
                    }
                    if (i == 3)
                    {
                        Title_text[i].fontSize = 57;
                    }
                }
            }
        }
    }
}
