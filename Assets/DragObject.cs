using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private float distanceBetCam = 0;

    public void OnDrag(PointerEventData data)
    {
        Vector2 touchPosition = data.position;

        Vector3 touchPositionInWorld = Camera.main.ScreenToWorldPoint(new Vector3(
            touchPosition.x,
            touchPosition.y,
            distanceBetCam)
            );

        transform.position = touchPositionInWorld;
    }

    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("Drag Begin!");
        distanceBetCam = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    public void OnEndDrag(PointerEventData data)
    {
    }
}