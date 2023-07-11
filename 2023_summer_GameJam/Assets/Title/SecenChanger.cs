using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecenChanger : MonoBehaviour
{
    public Image fadePanel;
    public float fadeDuration = 1.0f;

    private void Start()
    {
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 1f);
        fadePanel.gameObject.SetActive(true);
    }

    public void FadeOutAndLoadScene(string sceneName)
    {
        // ÆäÀÌµå ¾Æ¿ô ÈÄ ¾À ÀüÈ¯
        FadeOut(() =>
        {
            SceneManager.LoadScene("loding");
        });
    }

    private void FadeIn()
    {
        LeanTween.alpha(fadePanel.rectTransform, 0f, fadeDuration)
            .setEase(LeanTweenType.linear)
            .setOnComplete(() => fadePanel.gameObject.SetActive(false));
    }

    private void FadeOut(System.Action onComplete = null)
    {
        fadePanel.gameObject.SetActive(true);
        LeanTween.alpha(fadePanel.rectTransform, 1f, fadeDuration)
            .setEase(LeanTweenType.linear)
            .setOnComplete(() => onComplete?.Invoke());
    }

    public void SceneChange()
    {
        FadeIn();
    }

}
