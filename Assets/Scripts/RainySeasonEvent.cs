using UnityEngine;

[CreateAssetMenu(fileName = "RainySeason", menuName = "ICalendarEvent/RainySeason")]
public class RainySeasonEvent : ICalendarEvent
{
    public override void OnEvent()
    {
        Debug.Log("Doing the rainy season!");
    }
}
