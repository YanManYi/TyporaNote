using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadText : MonoBehaviour
{
    #region YanManYi

    //txt文件保存成 UTF-8 的编码格式  ！！！

    //Win平台 :在打包的内部文件Apk.Data/StreamingAssets目录下
    //filepath=Application.dataPath + "/StreamingAssets/My.txt";

    //安卓平台： 在app创建的文件夹files目录下
    //filepath= "file://" + Application.persistentDataPath + "/My.txt";

    //PC绝对路径:"C:\\Text\\";
    //安卓绝对路径："file://"+"/storage/emulated/0/待测。。。 

    #endregion

    string filepath;

    private void Start()
    {
        //示例：
        filepath = "C:\\Text\\text.txt";
        //float  number =float.Parse(ReadText01(filepath)) ;
        //string text = ReadText02(filepath)[0]; //第一行内容
        //string text = ReadText03(filepath)[0]; //第一个逗号内容       

    }

    //格式TXT文本的UF-8编码
    #region Method

    /// <summary>
    ///读取文件的所有内容。例：字符串转浮点型 float.Parse()
    /// </summary>
    /// <param name="filepath">地址路径</param>
    /// <returns></returns>
    string ReadText01(string filepath)
    {
        return File.ReadAllText(filepath);
    }


    /// <summary>
    ///读取文件的每一行内容，按行形式加入数组。
    /// </summary>
    /// <param name="filepath">地址路径</param>
    /// <returns></returns>
    string[] ReadText02(string filepath)
    {
        return File.ReadAllLines(filepath);
    }

    /// <summary>
    ///读取文件的内容，将字符串的内容以逗号(中文的)作为分割点,然后加入数组。
    /// </summary>
    /// <param name="filepath">地址路径</param>
    /// <returns></returns>
    string[] ReadText03(string filepath)
    {
        string text = File.ReadAllText(filepath);


        string[] textArray = text.Split('，');

        return textArray;
    }

    #endregion

}
