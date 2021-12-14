using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public GameObject Rain;
    public GameObject Snow;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
