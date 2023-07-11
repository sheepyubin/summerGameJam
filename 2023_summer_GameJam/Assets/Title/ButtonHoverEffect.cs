using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI textMeshProGUI;

    private Color originalColor; //���� �ؽ�Ʈ ����
    private Color hoverColor; //���콺�� �÷��� �� �ٲ�� ����
    public float hoverScale = 1.1f; // ���콺 �ø� �� ũ�� ���� ����
    private Vector3 originalScale; // ���� ũ��
    private Vector3 targetScale; // ��ǥ ũ��


    void Start()
    {
        textMeshProGUI = GetComponent<TextMeshProUGUI>();
        originalColor = textMeshProGUI.color; //���� �ؽ�Ʈ ���� ����
        hoverColor = new Color(originalColor.r, originalColor.g, originalColor.b, 0.8f); //���콺�� �÷��� �� �ٲ�� ���� ����
        textMeshProGUI = GetComponent<TextMeshProUGUI>();
        originalScale = transform.localScale; //���� ũ�� ����
        targetScale = originalScale * hoverScale; // �������� �ٲ� ����
    }

    public void OnPointerEnter(PointerEventData eventData) //���콺�� �ö���� ��ȭ
    {
        textMeshProGUI.color = hoverColor;
        LeanTween.scale(gameObject, targetScale, 0.2f);
    }

    public void OnPointerExit(PointerEventData eventData) //���콺�� �������� ������ ����
    {
        textMeshProGUI.color = originalColor;
        LeanTween.scale(gameObject, originalScale, 0.2f);
    }

}