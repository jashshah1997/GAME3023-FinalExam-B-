using UnityEngine;

[CreateAssetMenu(fileName = "SpookyTime", menuName = "ICalendarEvent/SpookyTime")]
public class SpookyTimeEvent : ICalendarEvent
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

        m_weather_manager.GetComponent<WeatherManager>().SetDarkIntensity();
        m_is_active = true;
    }
}
