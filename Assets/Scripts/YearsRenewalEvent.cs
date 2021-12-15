using UnityEngine;

[CreateAssetMenu(fileName = "YearsRenewal", menuName = "ICalendarEvent/YearsRenewal")]
public class YearsRenewalEvent : ICalendarEvent
{
    private AudioSource m_fireworks_audio;
    private bool m_is_active = false;

    public override void Init()
    {
        m_fireworks_audio = GameObject.Find("Fireworks").GetComponent<AudioSource>();
    }

    public override void OnEvent(int currentDay)
    {
        if (currentDay < startDate || currentDay > endDate)
        {
            if (m_is_active)
            {
                m_is_active = false;
                m_fireworks_audio.Stop();
            }
            return;
        }

        if (!m_is_active)
        {
            Debug.Log("Playing fireworks");
            m_fireworks_audio.Play();
            m_is_active = true;
        }
    }
}
