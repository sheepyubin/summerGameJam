using UnityEngine;

public class SmoothScaleAnimation : MonoBehaviour
{
    public Vector3 targetScale = new Vector3(2f, 2f, 2f); // ��ǥ ������
    public float scaleSpeed = 1f; // ������ ���� �ӵ�

    private Vector3 originalScale;
    private bool isScalingUp = true;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        // �ε巴�� ������ ����
        float scaleStep = scaleSpeed * Time.deltaTime;
        if (isScalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, scaleStep);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, originalScale, scaleStep);
        }

        // �������� ��ǥ�� �������� �� ���� ����
        if (Vector3.Distance(transform.localScale, targetScale) < 0.01f)
        {
            isScalingUp = false;
        }
        else if (Vector3.Distance(transform.localScale, originalScale) < 0.01f)
        {
            isScalingUp = true;
        }
    }
}