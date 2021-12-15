using UnityEngine;

[CreateAssetMenu(fileName = "SnowySeason", menuName = "ICalendarEvent/SnowySeason")]
public class SnowySeasonEvent : ICalendarEvent
{
    private bool m_is_active = false;
    private GameObject m_weather_manager;
    private GameObject m_bob_bobski;

    public override void Init()
    {
        m_weather_manager = GameObject.Find("WeatherManager");
        m_bob_bobski = GameObject.Find("Bob Bobski");
    }

    public override void OnEvent(int currentDay)
    {
        if (currentDay < startDate || currentDay > endDate)
        {
            if (m_is_active)
            {
                m_is_active = false;
                m_weather_manager.GetComponent<WeatherManager>().SetActiveSnow(false);
                m_weather_manager.GetComponent<WeatherManager>().SetDefaultSunColor();
                m_bob_bobski.GetComponent<FootstepSounds>().SetBellsActive(false);
            }
            return;
        }
        
        m_weather_manager.GetComponent<WeatherManager>().SetActiveSnow(true);
        m_bob_bobski.GetComponent<FootstepSounds>().SetBellsActive(true);
        m_weather_manager.GetComponent<WeatherManager>().SetWinterSunColor();
        m_is_active = true;
    }
}
