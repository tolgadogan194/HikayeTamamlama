using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SureMananager : MonoBehaviour
{
    public static float kalansure = 0;
    [SerializeField]
    private Text timetext;
    float kalansureżnt;
    public static bool timerActive = true;
    // Start is called before the first frame update
    void Start()
    {
        timetext.text = kalansure.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            kalansure += Time.deltaTime;
            kalansureżnt = Mathf.Round(kalansure);
            timetext.text = kalansureżnt.ToString();
        }
    }
}
