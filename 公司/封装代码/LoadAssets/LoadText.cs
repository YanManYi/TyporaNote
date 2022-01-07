using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadText : MonoBehaviour
{
    #region YanManYi

    //txt�ļ������ UTF-8 �ı����ʽ  ������

    //Winƽ̨ :�ڴ�����ڲ��ļ�Apk.Data/StreamingAssetsĿ¼��
    //filepath=Application.dataPath + "/StreamingAssets/My.txt";

    //��׿ƽ̨�� ��app�������ļ���filesĿ¼��
    //filepath= "file://" + Application.persistentDataPath + "/My.txt";

    //PC����·��:"C:\\Text\\";
    //��׿����·����"file://"+"/storage/emulated/0/���⡣���� 

    #endregion

    string filepath;

    private void Start()
    {
        //ʾ����
        filepath = "C:\\Text\\text.txt";
        //float  number =float.Parse(ReadText01(filepath)) ;
        //string text = ReadText02(filepath)[0]; //��һ������
        //string text = ReadText03(filepath)[0]; //��һ����������       

    }

    //��ʽTXT�ı���UF-8����
    #region Method

    /// <summary>
    ///��ȡ�ļ����������ݡ������ַ���ת������ float.Parse()
    /// </summary>
    /// <param name="filepath">��ַ·��</param>
    /// <returns></returns>
    string ReadText01(string filepath)
    {
        return File.ReadAllText(filepath);
    }


    /// <summary>
    ///��ȡ�ļ���ÿһ�����ݣ�������ʽ�������顣
    /// </summary>
    /// <param name="filepath">��ַ·��</param>
    /// <returns></returns>
    string[] ReadText02(string filepath)
    {
        return File.ReadAllLines(filepath);
    }

    /// <summary>
    ///��ȡ�ļ������ݣ����ַ����������Զ���(���ĵ�)��Ϊ�ָ��,Ȼ��������顣
    /// </summary>
    /// <param name="filepath">��ַ·��</param>
    /// <returns></returns>
    string[] ReadText03(string filepath)
    {
        string text = File.ReadAllText(filepath);


        string[] textArray = text.Split('��');

        return textArray;
    }

    #endregion

}
