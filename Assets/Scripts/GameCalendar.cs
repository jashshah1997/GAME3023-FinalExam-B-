using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameCalendar : MonoBehaviour
{
    private static readonly string[] SEASONS = { "Winter", "Spring", "Summer", "Autumn" };
    private static readonly float DAY_DURATION = 1f;
    private static readonly Color HIGHILIGHT_COLOR = new Color(255, 255, 255, 255);

    public List<ICalendarEvent> calendarEvents;

    private float m_cell_width;
    private float m_cell_height;
    private Color m_default_cell_color;

    private GameObject m_calendar_text;
    private int m_season = 0;
    private int m_day = 1;
    private float m_curr_day_counter = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        m_calendar_text = GameObject.Find("CalendarText");

        GridLayoutGroup lg = GetComponent<GridLayoutGroup>();
        m_cell_width = lg.cellSize.x;
        m_cell_height = lg.cellSize.y;

        foreach (ICalendarEvent calEvent in calendarEvents)
        {
            int curr = calEvent.startDate;
            while (curr <= calEvent.endDate)
            {
                var obj = Instantiate(calEvent.eventIconPrefab, this.transform.GetChild(curr-1).transform);
                obj.transform.localPosition = new Vector3(0, 0, obj.transform.position.z);
                curr++;
            }
        }

        // Get default cell color
        m_default_cell_color = transform.GetChild(0).GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        m_curr_day_counter += Time.deltaTime;
        if (m_curr_day_counter > DAY_DURATION)
        {
            m_curr_day_counter = 0;
            m_day++;
        }

        if (m_day > 7)
        {
            m_day = 1;
            m_season++;
        }

        if (m_season > 3)
        {
            m_season = 0;
        }

        m_calendar_text.GetComponent<TMP_Text>().text = SEASONS[m_season] + " - Day " + m_day;

        // Color the current day differently
        foreach(Transform child in transform)
        {
            child.GetComponent<Image>().color = m_default_cell_color;
        }
        transform.GetChild(m_season * 7 + (m_day - 1)).GetComponent<Image>().color = HIGHILIGHT_COLOR;
    }
}
