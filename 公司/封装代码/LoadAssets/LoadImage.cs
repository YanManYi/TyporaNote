using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;

public class LoadImage : MonoBehaviour
{
    #region YanManYi

    //Win平台 :在打包的内部文件Apk.Data/StreamingAssets目录下
    //filepath=Application.dataPath + "/StreamingAssets/My.jpg";

    //安卓平台： 在app创建的文件夹files目录下
    //filepath= "file://" + Application.persistentDataPath + "/My.jpg";

    //PC绝对路径:"C:\\Image\\";
    //安卓绝对路径："file://"+"/storage/emulated/0/待测。。。
    
    #endregion

    private string path;
    [Header("最大加载照片数量")]
    [Range(0, 1000)]
    public int maxSprite;

    public List<Sprite> sprites = new List<Sprite>();
    public bool IsOverLoad;


    void Start()
    {
        //需要把格式写进其他协程部分
        path = Application.dataPath + "/StreamingAssets/Image/";//pc
                                                                // path =Application.persistentDataPath + "/Image/";//安卓

        StartCoroutine("IELoadImage");
    }
    /// <summary>
    /// 等待上一张加载完成
    /// </summary>
    /// <returns></returns>
    IEnumerator IELoadImage()
    {
        for (int i = 1; i < maxSprite + 1; i++)
        {
            yield return StartCoroutine(DownSprite01(i));
        }

        yield break;

    }


    //默认.jpg格式
    #region Method

    /// <summary>
    /// 默认：第一种加载图片
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    IEnumerator DownSprite01(int filename)
    {
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("file://" + path + filename.ToString() + ".jpg"))
        {
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {


                IsOverLoad = true;
                yield break;
            }
            else
            {
                Texture2D texture = DownloadHandlerTexture.GetContent(uwr);
                Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

                sprites.Add(sprite);
                Resources.UnloadUnusedAssets();


            }
        }
    }

    /// <summary>
    /// 第二种加载图片，设置固定宽高
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    IEnumerator DownSprite02(int filename)
    {
        UnityWebRequest wr = new UnityWebRequest("file://" + path + filename.ToString() + ".jpg");
        DownloadHandlerTexture texD1 = new DownloadHandlerTexture(true);
        wr.downloadHandler = texD1;
        yield return wr.SendWebRequest();

        int width = 1920;
        int high = 1080;

        if (wr.isNetworkError)
        {


            IsOverLoad = true;
            yield break;
        }
        else
        {
            Texture2D tex = new Texture2D(width, high);
            tex = texD1.texture;

            Sprite sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));
            sprites.Add(sprite);
            Resources.UnloadUnusedAssets();

        }
    }

    /// <summary>
    /// 按照固定高同等比例缩小宽
    /// </summary>
    /// <param name="img">Iamge组件</param>
    /// <param name="sprite">Image组件上呈现的精灵图</param>
    private void SetSprite(Image img, Sprite sprite)
    {
        RectTransform rectTrans = img.GetComponent<RectTransform>();
        float rate = (float)sprite.texture.width / (float)sprite.texture.height;

        //同高改宽
        rectTrans.sizeDelta = new Vector2(rectTrans.rect.height * rate, rectTrans.rect.height);

        //同宽改高
        // rectTrans.sizeDelta = new Vector2(rectTrans.rect.width, rectTrans.rect.width / rate);

        img.sprite = sprite;

        //博客地址：https://blog.csdn.net/yy763496668/article/details/114326600
    }

    #endregion
}

