using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanwer : MonoBehaviour
{
    public GameObject Prefeb;
    public float Radius = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) SpawnObjectAtRandom();
    }
    void SpawnObjectAtRandom()
    {
        Vector2 randomPos = Random.insideUnitCircle * Radius;
        Instantiate(Prefeb, randomPos, Quaternion.identity);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
