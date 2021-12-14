using UnityEngine;

[CreateAssetMenu(fileName = "RainySeason", menuName = "ICalendarEvent/RainySeason")]
public class RainySeasonEvent : ICalendarEvent
{
    private int m_last_day = -1;
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
                m_weather_manager.GetComponent<WeatherManager>().SetActiveRain(false);
            }
            return;
        }

        if (currentDay != m_last_day)
        {
            m_last_day = currentDay;
            Debug.Log("Rolling for rain!");

            bool check = Random.Range(1, 100) >= 50;
            m_weather_manager.GetComponent<WeatherManager>().SetActiveRain(check);
        }

        m_is_active = true;
    }
}
