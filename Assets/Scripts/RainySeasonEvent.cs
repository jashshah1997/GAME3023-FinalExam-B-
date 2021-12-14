using UnityEngine;

[CreateAssetMenu(fileName = "RainySeason", menuName = "ICalendarEvent/RainySeason")]
public class RainySeasonEvent : ICalendarEvent
{
    public override void OnEvent(int currentDay)
    {
        if (currentDay < startDate || currentDay > endDate) return;
        Debug.Log("Doing the rainy season!");
    }
}
