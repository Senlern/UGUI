using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Fanye : MonoBehaviour,IBeginDragHandler,IEndDragHandler {
    //public ScrollRect rect;

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        ScrollRect rect = GetComponent<ScrollRect>();
        Debug.Log(rect.horizontalNormalizedPosition);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
