using UnityEngine;

[CreateAssetMenu(fileName = "SummerSolstice", menuName = "ICalendarEvent/SummerSolstice")]
public class SummerSolsticeEvent : ICalendarEvent
{
    private bool m_is_active = false;
    private GameObject m_weather_manager;

    public override void Init()
    {
        m_weather_manager = GameObject.Find("WeatherManager");
    }

    public override void OnEvent(int currentDay)
    {
        if (currentDay < startDate || currentDay > endDate)
        {
            if (m_is_active)
            {
                m_is_active = false;
                m_weather_manager.GetComponent<WeatherManager>().SetDefaultSunColor();
            }
            return;
        }

        m_weather_manager.GetComponent<WeatherManager>().SetSummerSunColor();
        m_is_active = true;
    }
}
