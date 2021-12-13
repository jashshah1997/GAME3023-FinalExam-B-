using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCalendar : MonoBehaviour
{
    public List<ICalendarEvent> calendarEvents;

    private float m_cell_width;
    private float m_cell_height;

    // Start is called before the first frame update
    void Start()
    {
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


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
