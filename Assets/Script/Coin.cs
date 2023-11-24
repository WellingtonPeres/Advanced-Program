using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject VFX_Explosion;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Contagem.instance.AddPoints();
            Destroy(gameObject);
        }
        else
        {
            Instantiate(VFX_Explosion, transform.position, transform.rotation);

            Contagem.instance.DecreasePoints();
            Destroy(gameObject);

            if (Contagem.instance.GetPerderPontos() <= 0)
            {
                Contagem.instance.ShowRestartOption();
            }
        }
    }
}
