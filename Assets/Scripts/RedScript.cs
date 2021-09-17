using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedScript : MonoBehaviour
{

    private void Awake()
    {
       // Debug.Log("im here");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Camera camera = GameObject.FindObjectOfType<Camera>();
        minX = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).x + 0.3f;
        maxX = -minX;
        minY = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y + 0.3f;
        maxY = -minY;
        //timerManager = FindObjectOfType<TimerManagerScript>();
        //timerManager.TimerEvent += TimerManager_TimerEvent;
    }

    // Update is called once per frame
    void Update()
    {
        float _x = Random.Range(-0.1f, 0.1f);
        float _y = Random.Range(-0.1f, 0.1f);
        transform.position = new Vector3(transform.position.x + _x, transform.position.y + _y, 0);
        
        if (transform.position.x > maxX) transform.position = new Vector2(maxX, transform.position.y);
        else if (transform.position.x < minX) transform.position = new Vector2(minX, transform.position.y);
        if (transform.position.y > maxY) transform.position = new Vector2(transform.position.x, maxY);
        else if (transform.position.y < minY) transform.position = new Vector2(transform.position.y, minY);
    }

    private void TimerManager_TimerEvent()
    {
        //Reproduce();
    }

    private void Reproduce()
    {
        //if (!was)
        //{
        //    Instantiate(RedPrefab, new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y + 0.1f, 0.0f), gameObject.transform.rotation);
        //    Instantiate(RedPrefab, new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y + 0.1f, 0.0f), gameObject.transform.rotation);
        //    was = true;
        //}
    }

    float maxX, minX;
    float maxY, minY;
    //TimerManagerScript timerManager;
    //bool was = false;
}
