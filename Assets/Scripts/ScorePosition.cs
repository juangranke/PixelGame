using UnityEngine;

public class ScorePosition : MonoBehaviour
{
    public Vector2 targetPosition; // Define a posi��o alvo relativa � tela (0,0 � o centro)
    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 normalizedPosition = new Vector2(
            targetPosition.x / screenSize.x,
            targetPosition.y / screenSize.y
        );

        rectTransform.anchorMin = normalizedPosition;
        rectTransform.anchorMax = normalizedPosition;
        rectTransform.anchoredPosition = Vector2.zero;
    }
}
