using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image fadePanel;
    public float fadeDuration = 1.0f;

    private void Start()
    {
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1f);
        fadePanel.gameObject.SetActive(true);

        Fade();
    }

    private void Fade()
    {
        LeanTween.alpha(fadePanel.rectTransform, 0f, fadeDuration)
            .setEase(LeanTweenType.linear)
            .setOnComplete(() => fadePanel.gameObject.SetActive(false));
    }
}
