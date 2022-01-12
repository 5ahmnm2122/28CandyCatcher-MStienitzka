using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public Storage infoStorage;

    private void OnTriggerEnter(Collider other)
    {
        infoStorage.time = +2;
    }

}
