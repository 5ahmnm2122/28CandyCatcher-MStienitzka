using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public Storage infoStorage;
    private float oldTime;
    public float addedTime;
    public float time = 8;

    Timer timer;
    void Start()
    {
        StartCoroutine(DeleteOverTime());

    }

    private IEnumerator DeleteOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Object.Destroy(this.gameObject);

        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        timer = GameObject.Find("GameManager").GetComponent<Timer>();
        oldTime = timer.timeRemaining;
        timer.timeRemaining = oldTime + addedTime;
        infoStorage.score += 1;
        Destroy(this.gameObject);
    }
    private void Update()
    {
        this.transform.Rotate(50 * Time.deltaTime, 0, 50 * Time.deltaTime);
    }

}
