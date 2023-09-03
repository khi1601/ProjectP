using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameEventListener : MonoBehaviour
{
    public GameEvent Event; //so ������Ʈ�� �����ϱ� ���� ����
    public UnityEvent Response; //����Ƽ�̺�Ʈ������ ���� ����,�ν�����â�����̺�Ʈ�Ҵ��Ҷ�������

    private void OnEnable()
    { Event.RegisterListener(this); } //��ũ��Ʈ����������Ŭ�������

    private void OnDisable()
    { Event.UnregisterListener(this); }

    public void OnEventRaised() //�̺�Ʈ�߻���
    { Response?.Invoke(); } //UnityEvent�����Ǻ���Response�� �������ִ¸����ʵ鿡���̺�Ʈ�߻�
}