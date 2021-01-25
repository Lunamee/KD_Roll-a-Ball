using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    
    public float time;

    public Text TimeText;
    public Text GoalTimeText;

    public bool timerflag;

    // Start is called before the first frame update
    void Start()
    {
        timerflag = true;
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (timerflag)
        {
            time += Time.deltaTime;
            TimeText.GetComponent<Text>().text = time.ToString("F1");
        }
    }

    public void TimeShow()
    {
        GoalTimeText.text = "タイム : " + time.ToString("F1") + "秒";
    }
}
