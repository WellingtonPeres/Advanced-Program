using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coins;

    public float range;

    void Start()
    {
        StartCoroutine("Points", 1.5f);
    }

    private IEnumerator Points(float duration)
    {
        float normalizedTime = 0;

        while (normalizedTime <= 1f)
        {
            GameObject coin = Instantiate(coins, new Vector3(
                                          Random.Range(-range, range), transform.position.y, transform.position.z),
                                          Quaternion.identity);

            normalizedTime += Time.deltaTime / duration;
            yield return new WaitForSeconds(3f);
        }
    }
}
