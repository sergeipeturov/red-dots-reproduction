using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManagerScript : MonoBehaviour
{
    //public delegate void Event();
    //public event Event TimerEvent;

    public GameObject RedPrefab;
    public Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        //curr_time = repeat_time;
        //reds.Add(Instantiate(RedPrefab, new Vector3(0.0f, 0.0f, 0.0f), new Quaternion()));
        Instantiate(RedPrefab, new Vector3(0.0f, 0.0f, 0.0f), new Quaternion());
    }

    // Update is called once per frame
    void Update()
    {
        //curr_time -= Time.deltaTime;
        //if (curr_time <= 0)
        //{
        //    TimerEvent?.Invoke();
        //    curr_time = repeat_time;
        //}
    }

    public void OnGoButtonClick()
    {
        //TimerEvent?.Invoke();
        var reds = GameObject.FindGameObjectsWithTag("red");
        foreach(var item in reds)
        {
            Instantiate(RedPrefab, new Vector3(item.transform.position.x + 0.1f, item.transform.position.y + 0.1f, 0.0f), item.transform.rotation);
            Instantiate(RedPrefab, new Vector3(item.transform.position.x - 0.1f, item.transform.position.y + 0.1f, 0.0f), item.transform.rotation);
            redsCount++;
            redsCount++;
            textUI.text = redsCount.ToString();
        }
    }

    int redsCount = 1;
    //List<GameObject> reds = new List<GameObject>();
    //float repeat_time = 1;
    //float curr_time;
}
