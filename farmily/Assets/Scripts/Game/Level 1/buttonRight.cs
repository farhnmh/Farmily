using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class buttonRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pressed = false;
    public playerScript player;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        player.rightPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        player.rightPressed = false;
    }
}
