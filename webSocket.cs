using WebSocketSharp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webSocket : MonoBehaviour
{
    private WebSocket ws;//���� ����
    void Start()
    {
        ws = new WebSocket("ws://127.0.0.1:3000");// 127.0.0.1�� ������ ������ �ּ��̴�. 3000��Ʈ�� �����Ѵٴ� �ǹ��̴�.
        ws.OnMessage += ws_OnMessage; //�������� ����Ƽ ������ �޼����� �� ��� ������ �Լ��� ����Ѵ�.
        ws.OnOpen += ws_OnOpen;//������ ����� ��� ������ �Լ��� ����Ѵ�
        ws.OnClose += ws_OnClose;//������ ���� ��� ������ �Լ��� ����Ѵ�.
        ws.Connect();//������ �����Ѵ�.
        ws.Send("hello");//�������� "hello"��� �޼����� ������.
    }
    void ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log(e.Data);//���� �޼����� ����� �ֿܼ� ����Ѵ�.
    }
    void ws_OnOpen(object sender, System.EventArgs e)
    {
        Debug.Log("open"); //����� �ֿܼ� "open"�̶�� ��´�.
    }
    void ws_OnClose(object sender, CloseEventArgs e)
    {
        Debug.Log("close"); //����� �ֿܼ� "close"�̶�� ��´�.
    }
}