using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadVideo : MonoBehaviour
{

    #region YanManYi

    //Winƽ̨ :�ڴ�����ڲ��ļ�Apk.Data/StreamingAssetsĿ¼�£�"file://"��winƽ̨�ɼӿɲ���
    //filepath="file://"+Application.dataPath + "/StreamingAssets/My.mp4";

    //��׿ƽ̨�� ��app�������ļ���filesĿ¼��,��Ƶ���ܼ�"file://"
    //filepath=  Application.persistentDataPath + "/My.mp4";

    //PC����·��:"C:\\Image\\";
    //��׿����·����"file://"+"/storage/emulated/0/���⡣����

    #endregion

    public VideoPlayer video;
    private string filepath;

    //Ĭ��.mp4��ʽ
    private void Start()
    {
        filepath = "";
        video.url = filepath;
    }



}
