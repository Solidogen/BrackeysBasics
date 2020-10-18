using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPressDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool IsButtonPressed { get; set; }

    public void OnPointerDown(PointerEventData eventData)
    {
        IsButtonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        IsButtonPressed = false;
    }
}
