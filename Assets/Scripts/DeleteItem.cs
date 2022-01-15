using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : MonoBehaviour
{
    public Storage infoStorage;
    public float time;
    public Vector3 oldScale;
    public Vector3 newScale;
    public int amount;
    public SpawnObjects spawnObjects;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeleteOverTime());
        oldScale = this.gameObject.transform.localScale;
        newScale = oldScale * Random.Range(1, 3);

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
        infoStorage.score = infoStorage.score + amount;
    }

    private void Update()
    {
        this.transform.Rotate(50 *Time.deltaTime, 0, 50 * Time.deltaTime);
    }
}
