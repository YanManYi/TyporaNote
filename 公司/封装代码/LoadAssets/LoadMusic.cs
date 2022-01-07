using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadMusic : MonoBehaviour
{

    #region YanManYi

    //Winƽ̨ :�ڴ�����ڲ��ļ�Apk.Data/StreamingAssetsĿ¼��
    //filepath=Application.dataPath + "/StreamingAssets/My.mp3";

    //��׿ƽ̨�� ��app�������ļ���filesĿ¼��
    //filepath= "file://" + Application.persistentDataPath + "/My.mp3";

    //PC����·��:"C:\\Image\\";
    //��׿����·����"file://"+"/storage/emulated/0/���⡣����

    #endregion


    public AudioSource audioSource;

    private string filepath;

    void Start()
    {
        filepath = "";
        StartCoroutine("GetAudioClip", filepath);

    }



    /// <summary>
    /// �������أ�Ĭ��.mp3
    /// </summary>
    /// <param name="path">·��</param>
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
