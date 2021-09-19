using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Fanye : MonoBehaviour,IBeginDragHandler,IEndDragHandler {
    //public ScrollRect rect;
    float[] pageArray = { 0, 0.333f, 0.666f, 1 };
    float targetPosition = 0;
    ScrollRect rect;
    bool move = false;

    public void OnBeginDrag(PointerEventData eventData)
    {
        move = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        move = true;
        float posX = rect.horizontalNormalizedPosition;
        Debug.Log(posX);
        int index = 0;
        float offset = Mathf.Abs(pageArray[index] - posX);
        for(int i=1; i<pageArray.Length; i++)
        {
            float tmpoffset = Mathf.Abs(pageArray[i] - posX);
            if (tmpoffset< offset)
            {
                index = i;
                offset = tmpoffset;
            }
        }
        targetPosition = pageArray[index];
    }

    // Use this for initialization
    void Start () {
        rect = GetComponent<ScrollRect>();
    }
	
	// Update is called once per frame
	void Update () {
        if (move)
        {
            rect.horizontalNormalizedPosition = Mathf.Lerp(rect.horizontalNormalizedPosition, targetPosition, Time.deltaTime * 4);
            //move = false;
        }
        
    }
}
