using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class buttonLeftLevel2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pressed = false;
    public playerScriptLevel2 player;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
        player.leftPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
        player.leftPressed = false;
    }
}
