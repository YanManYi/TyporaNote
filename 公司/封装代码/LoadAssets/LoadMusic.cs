using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadMusic : MonoBehaviour
{

    #region YanManYi

    //Win平台 :在打包的内部文件Apk.Data/StreamingAssets目录下
    //filepath=Application.dataPath + "/StreamingAssets/My.mp3";

    //安卓平台： 在app创建的文件夹files目录下
    //filepath= "file://" + Application.persistentDataPath + "/My.mp3";

    //PC绝对路径:"C:\\Image\\";
    //安卓绝对路径："file://"+"/storage/emulated/0/待测。。。

    #endregion


    public AudioSource audioSource;

    private string filepath;

    void Start()
    {
        filepath = "";
        StartCoroutine("GetAudioClip", filepath);

    }



    /// <summary>
    /// 声音加载，默认.mp3
    /// </summary>
    /// <param name="path">路径</param>
    /// <returns></returns>
    IEnumerator GetAudioClip(string path)
    {

        using (var uwr = UnityWebRequestMultimedia.GetAudioClip(path, AudioType.MPEG))
        {
            yield return uwr.SendWebRequest();

            if (uwr.isNetworkError)
            {
                Debug.LogError("uwrERROR:" + uwr.error);
            }
            else
            {
                audioSource.clip = DownloadHandlerAudioClip.GetContent(uwr);
            }

        }

        audioSource.Play();
        yield break;

    }

}
