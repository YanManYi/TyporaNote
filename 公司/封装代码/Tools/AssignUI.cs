using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AssignUI : MonoBehaviour
{
    /// <summary>
    /// 判断UI是否在指定的UI上,根据Layer
    /// </summary>
    /// <param name="layer"></param>
    /// <returns></returns>
    public bool IsWantInUI(int layer)
    {


        GraphicRaycaster[] graphicRaycasters = FindObjectsOfType<GraphicRaycaster>();

        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.pressPosition = Input.mousePosition;
        eventData.position = Input.mousePosition;
        List<RaycastResult> list = new List<RaycastResult>();

        foreach (var item in graphicRaycasters)
        {
            item.Raycast(eventData, list);
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i].gameObject.layer == layer) return true;
                }
            }
        }

        return false;
    }


    public float touchScroll;
    public List<RectTransform> rectTransforms;

    private void OnEnable()
    {
        touchScroll = float.Parse(File.ReadAllText(Application.dataPath + "/StreamingAssets/Txt/TouchScroll.txt"));
    }


    private Vector2 first = Vector2.zero;
    private Vector2 second = Vector2.zero;
    // 鼠标左右滑动事件
    void OnGUI()
    {
        if (Event.current.type == EventType.MouseDown)

        {
            //记录鼠标按下的位置 　　

            first = Event.current.mousePosition;

        }

        if (Event.current.type == EventType.MouseDrag && IsWantInUI(6))
        {
            //记录鼠标拖动的位置 　　

            Debug.Log("我在拖动");
            second = Event.current.mousePosition;

            if (second.y < first.y)
            {
                //拖动的位置的x坐标比按下的位置的x坐标小时,响应向上事件 　　

                print("上");
                Shang();

            }

            if (second.y > first.y)
            {
                //拖动的位置的x坐标比按下的位置的x坐标大时,响应向下事件 　　

                print("下");

                Xia();

            }

            first = second;

        }

    }



    public void Shang()
    {

        for (int i = 0; i < rectTransforms.Count; i++)
        {
            rectTransforms[i].anchoredPosition = new Vector2(rectTransforms[i].anchoredPosition.x, rectTransforms[i].anchoredPosition.y + touchScroll);
        }

    }

    public void Xia()
    {

        for (int i = 0; i < rectTransforms.Count; i++)
        {
            rectTransforms[i].anchoredPosition = new Vector2(rectTransforms[i].anchoredPosition.x, rectTransforms[i].anchoredPosition.y - touchScroll);
        }

    }


    Vector2 pos1, pos2;

    private void Update()
    {

        for (int i = 0; i < rectTransforms.Count; i++)
        {
            if (rectTransforms[i].anchoredPosition.y >= 0)
            {              

                if (i == 0)
                {
                    rectTransforms[0].anchoredPosition = new Vector2(rectTransforms[rectTransforms.Count - 1].anchoredPosition.x, rectTransforms[rectTransforms.Count - 1].anchoredPosition.y - rectTransforms[0].sizeDelta.y * 1.1f);
                }
                else
                {
                        rectTransforms[i].anchoredPosition = new Vector2(rectTransforms[i - 1].anchoredPosition.x, rectTransforms[i - 1].anchoredPosition.y - rectTransforms[i].sizeDelta.y * 1.1f);                   
                }

            }

           

        }


        for (int i = (rectTransforms.Count-1); i >=0; i--)
        {


            if (rectTransforms[i].anchoredPosition.y <= -2000)
            {

                if (i == (rectTransforms.Count-1))
                {
                    rectTransforms[i].anchoredPosition = new Vector2(rectTransforms[0].anchoredPosition.x, rectTransforms[0].anchoredPosition.y + rectTransforms[i].sizeDelta.y * 1.1f);
                }
                else
                {
                    
                   
                        rectTransforms[i].anchoredPosition = new Vector2(rectTransforms[i +1].anchoredPosition.x, rectTransforms[i + 1].anchoredPosition.y + rectTransforms[i].sizeDelta.y * 1.1f);
                }

            }
        }

    

    }


}
