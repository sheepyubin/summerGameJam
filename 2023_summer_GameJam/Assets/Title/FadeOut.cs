using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    public Image fadePanel; //���̵� �ǳ�
    public float fadeDuration = 1.0f; //���̵� ���� �ð�
    public float delay = 2f; //�ڷ�ƾ ������
    public string scene; //�ٲ� ��

    private void Start()
    {
        fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, 0f);
        fadePanel.gameObject.SetActive(true);
    }

    public void Fade()
    {
        LeanTween.alpha(fadePanel.rectTransform, 1f, fadeDuration)
            .setEase(LeanTweenType.linear)
            .setOnComplete(() => fadePanel.gameObject.SetActive(false));
        StartCoroutine(DelayCoroutine(delay));
    }

    private IEnumerator DelayCoroutine(float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
        SceneManager.LoadScene(scene);
    }
}
