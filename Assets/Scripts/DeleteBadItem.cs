using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBadItem : MonoBehaviour
{
    public Storage infoStorage;
    public float time;
    public int amount;
    public Vector3 oldScale;
    public Vector3 newScale;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeleteOverTime());
        StartCoroutine(DeleteOverTime());
        oldScale = this.gameObject.transform.localScale;
        newScale = oldScale * Random.Range(1, 3);
        this.gameObject.transform.localScale = newScale;

    }

    private IEnumerator DeleteOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Object.Destroy(this.gameObject);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Object.Destroy(this.gameObject);
        infoStorage.score = infoStorage.score - amount;
        infoStorage.lives = infoStorage.lives - 1;
    }

    private void Update()
    {
        this.transform.Rotate(50 * Time.deltaTime, 0, 50 * Time.deltaTime);
    }
}
