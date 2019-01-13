using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{   
    [Header("NON MODIFICABILE MENTRE è IN ESECUZIONE")]
    [Tooltip("Inserisci la velocià di rotazione")]
    public float turnSpeed = 40f;
    [Tooltip("Inserisci per quanto tempo vuoi far girare la porta")]
    public float timeToClose = 5f;

    private bool isFullTurned = false;
    private bool isClosed = false;
    private float realCloseTime;

    // Start is called before the first frame update
    void Start()
    {
        realCloseTime = timeToClose;
    }

    // Update is called once per frame
    void Update()
    {

        OpenDoor();
    }

    private void OpenDoor()
    {
        if (isClosed)
        {
            timeToClose -= Time.deltaTime;
            if (timeToClose < 0) { timeToClose = 0; }

            if (timeToClose > 0)
            {
                transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
            }
        }
        if (timeToClose >= 0 && !isClosed)
        {

            timeToClose += Time.deltaTime;
            if (timeToClose > realCloseTime) { timeToClose = realCloseTime; }

            if (timeToClose < realCloseTime)
            {
                transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
            isClosed = !isClosed;
        }
    }
}

  