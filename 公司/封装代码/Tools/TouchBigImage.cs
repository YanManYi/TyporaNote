using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchBigImage : MonoBehaviour
{
    Vector2 oldPos1;
    Vector2 oldPos2;

    RectTransform rectTransform;

    //原始大小
    Vector2 startVect;


    private void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
        startVect = rectTransform.sizeDelta;
    }



    void Update()
    {
        if (Input.touchCount == 2)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                Vector2 newPos1 = Input.GetTouch(0).position;
                Vector2 newPos2 = Input.GetTouch(1).position;
                if (IsEnlarge(oldPos1, oldPos2, newPos1, newPos2))
                {
                    float oldScale = rectTransform.sizeDelta.x;
                    float newScale = oldScale * 1.025f;

                    float oldScale2 = rectTransform.sizeDelta.y;
                    float newScale2 = oldScale2 * 1.025f;

                    rectTransform.sizeDelta = new Vector2(newScale, newScale2);

                }
                else
                {
                    float oldScale = rectTransform.sizeDelta.x;
                    float newScale = oldScale / 1.025f;

                    float oldScale2 = rectTransform.sizeDelta.y;
                    float newScale2 = oldScale2 / 1.025f;


                    rectTransform.sizeDelta = new Vector2(newScale, newScale2);

                    //小于一定范围：
                    if (rectTransform.sizeDelta.y <= (startVect.y / 4.0f))
                    {

                        transform.GetComponent<Button>().onClick.Invoke();

                    }
                }
                oldPos1 = newPos1;
                oldPos2 = newPos2;
            }
        }

    }
    //手势判断
    bool IsEnlarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        float length1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        float length2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));
        if (length1 < length2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnDisable()
    {
        //隐藏的时候恢复默认大小，如果位置有变，用scroll Rect 固定位置但不拖动
        rectTransform.sizeDelta = startVect;
    }
}
