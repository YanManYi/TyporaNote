

# 时间戳

协程加载URL

```
 UnityWebRequest request = UnityWebRequest.Get(timeURL);
        request.SendWebRequest();//读取数据
        while (!request.downloadHandler.isDone)
        {          
               yield  return request.downloadHandler.text;          
        }
        
        //把加载的字符串转长整型
     long Readtime=   Int64.Parse(request.downloadHandler.text);
     
     //获取自身时间戳
  Long currentTime=
  new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
     
```



# 当网络不可用时               

```
if (Application.internetReachability == NetworkReachability.NotReachable)
{
//执行网络不可用部分
}

```



# 网络唤醒：Mac地址



重载一个函数，发送的一样是16进制形式，但需要**广播**

```
MAC：7C 2B E1 10 B8 69
```

MAC要以16进制形式的情况，也就是重复写16次(至于有没有12个F，看厂商)

```
FF FF FF FF FF FF 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69 7C 2B E1 10 B8 69
```





