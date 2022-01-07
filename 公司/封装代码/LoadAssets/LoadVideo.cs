using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadVideo : MonoBehaviour
{

    #region YanManYi

    //Win平台 :在打包的内部文件Apk.Data/StreamingAssets目录下，"file://"在win平台可加可不加
    //filepath="file://"+Application.dataPath + "/StreamingAssets/My.mp4";

    //安卓平台： 在app创建的文件夹files目录下,视频不能加"file://"
    //filepath=  Application.persistentDataPath + "/My.mp4";

    //PC绝对路径:"C:\\Image\\";
    //安卓绝对路径："file://"+"/storage/emulated/0/待测。。。

    #endregion

    public VideoPlayer video;
    private string filepath;

    //默认.mp4格式
    private void Start()
    {
        filepath = "";
        video.url = filepath;
    }



}
