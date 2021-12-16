using UnityEngine;

/**
 * ICalendarEvent is an abstract scriptable object providing an interface for the user to implement calendar events.
 */
public abstract class ICalendarEvent : ScriptableObject
{
    // Start date for the event [1-28]
    public int startDate;

    // End date for the event [1-28]
    public int endDate;

    // Game event icon added as a prefab object
    public GameObject eventIconPrefab;

    // This method is called once at the start of the game. Do all object initialization here.
    public abstract void Init();

    // This method is called every game tick. The current day [1-28] is passed in as the only argument. 
    // If the current day is in range of the selected dates the event should activated,
    // otherwise the method should immediately return.
    public abstract void OnEvent(int currentDay);
}
