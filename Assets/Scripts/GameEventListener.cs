using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameEventListener : MonoBehaviour
{
    public GameEvent Event; //so 오브젝트에 접근하기 위한 변수
    public UnityEvent Response; //유니티이벤트접근을 위한 변수,인스펙터창에서이벤트할당할때생성됨

    private void OnEnable()
    { Event.RegisterListener(this); } //스크립트켜지면현재클래스등록

    private void OnDisable()
    { Event.UnregisterListener(this); }

    public void OnEventRaised() //이벤트발생시
    { Response?.Invoke(); } //UnityEvent형식의변수Response가 가지고있는리스너들에게이벤트발생
}