using UnityEngine;

public abstract class ICalendarEvent : ScriptableObject
{
    public int startDate;
    public int endDate;
    public GameObject eventIconPrefab;

    public abstract void Init();
    public abstract void OnEvent(int currentDay);
}
