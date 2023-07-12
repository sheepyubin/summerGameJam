using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecenChanger : MonoBehaviour
{
    public Image fadePanel;
    public float fadeDuration = 2.0f;

    private void Start()
    {
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1f);
        fadePanel.gameObject.SetActive(false);
    }

    private void FadeIn(System.Action onComplete = null)
    {
        Debug.Log("IN");
        fadePanel.gameObject.SetActive(true);
        LeanTween.alpha(fadePanel.rectTransform, 0f, fadeDuration)
            .setEase(LeanTweenType.linear)
            .setOnComplete(() => fadePanel.gameObject.SetActive(false));
        Debug.Log("END");
    }
    public void SceneChange()
    {
        FadeIn();
    }

}
