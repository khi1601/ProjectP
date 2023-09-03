using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
	private List<GameEventListener> listeners =
		new List<GameEventListener>(); //리스너들을 담아둘리스트

	public void Raise()
	{
		for (int i = listeners.Count - 1; i >= 0; i--)
			listeners[i].OnEventRaised();
	}

	public void RegisterListener(GameEventListener listener) //리스너등록하는함수
	{ listeners.Add(listener); }

	public void UnregisterListener(GameEventListener listener)//리스너삭제하는함수
	{ listeners.Remove(listener); }
}