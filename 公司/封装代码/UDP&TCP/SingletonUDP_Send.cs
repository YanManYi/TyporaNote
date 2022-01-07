using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class SingletonUDP_Send
{
    private static SingletonUDP_Send m_udp;//自身实例

    private SingletonUDP_Send() { }//私有构造
    /// <summary>
    /// 获取UDP的实例
    /// </summary>
    public static SingletonUDP_Send Instance()
    {
        if (m_udp == null)
        {
            m_udp = new SingletonUDP_Send();
        }
        return m_udp;
    }


    /// <summary>  
    /// 发送字符串类型的UDP消息
    /// <param name="_message">UDP消息</param>
    /// <param name="_ipStr">对方IP</param>
    /// <param name="_port">对方端口</param>
    /// </summary>
    public void SendUDPMessage(string _message, string _ipStr = "192.168.0.96", int _port = 8512)
    {
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//创建UDP服务
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse(_ipStr), _port);//定义一个IP地址和端口号
        server.SendTo(Encoding.UTF8.GetBytes(_message), ip);//发送消息
        server.Close();//关闭服务
    }

    /// <summary>  
    /// 发送十六进制的UDP消息
    /// <param name="_message">十六进制的消息string类型写进来</param>
    /// <param name="_ipStr">对方IP</param>
    /// <param name="_port">对方端口</param>
    /// </summary>
    public void SendUDPMessageHEX(string _message, string _ipStr = "192.168.0.96", int _port = 8512)
    {
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);//创建UDP服务
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse(_ipStr), _port);//定义一个IP地址和端口号
        server.SendTo(StrToHex(_message), ip);//发送消息
        server.Close();//关闭服务
    }

    /// <summary>
    /// MAC唤醒：发送十六进制的UDP消息，消息需要广播
    /// </summary>
    /// <param name="_message">MAC转成16进制的值，十六进制的消息string类型写进来</param>
    /// <param name="_port">端口</param>
    public void SendUDPMessageHEX_Broadcast(string _message, int _port = 8512)
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        //广播形式      Broadcast：广播
        IPEndPoint ip = new IPEndPoint(IPAddress.Broadcast, _port);       
        socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);

        socket.SendTo(StrToHex(_message), ip);//发送消息
        socket.Close();//关闭服务
    }


    /// <summary>
    /// 把字符串转成十六进制字节组
    /// </summary>
    /// <param name="strText"></param>
    /// <returns></returns>
    private byte[] StrToHex(string strText)
    {
        strText = strText.Replace(" ", "");
        byte[] bText = new byte[strText.Length / 2];
        for (int i = 0; i < strText.Length / 2; i++)
        {
            bText[i] = Convert.ToByte(Convert.ToInt32(strText.Substring(i * 2, 2), 16));
        }
        return bText;
    }





}
