using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class WeatherManager : MonoBehaviour
{
    public GameObject Rain;
    public GameObject Snow;
    public GameObject Sun;
    
    private Color m_default_sun_color;
    private float m_default_sun_intensity;
    private static readonly Color WINTER_SUN_COLOR = new Color(0.6941177f, 0.8192417f, 0.8826951f, 1f);
    private static readonly Color BRIGHT_SUN_COLOR = new Color(0.8113208f, 0.8679245f, 0.5764329f, 1f);
    private static readonly float DARK_INTENSITY = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        m_default_sun_color = Sun.GetComponent<Light2D>().color;
        m_default_sun_intensity = Sun.GetComponent<Light2D>().intensity;
        Debug.Log(m_default_sun_color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveSnow(bool flag)
    {
        Snow.SetActive(flag);
    }

    public void SetActiveRain(bool flag)
    {
        Rain.SetActive(flag);
    }

    public void SetWinterSunColor()
    {
        Sun.GetComponent<Light2D>().color = WINTER_SUN_COLOR;
    }

    public void SetSummerSunColor()
    {
        Sun.GetComponent<Light2D>().color = BRIGHT_SUN_COLOR;
    }

    public void SetDefaultSunColor()
    {
        Sun.GetComponent<Light2D>().color = m_default_sun_color;
        Sun.GetComponent<Light2D>().intensity = m_default_sun_intensity;
    }

    public void SetDarkIntensity()
    {
        Sun.GetComponent<Light2D>().intensity = DARK_INTENSITY;
    }
}
