using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contagem : MonoBehaviour
{
    public static Contagem instance;

    [Header("Textos para ganahr e perder pontos")]
    public TextMeshProUGUI LoseText;
    public TextMeshProUGUI pointsText;

    [Header("Referenciar as opções de restart")]
    public GameObject restartOption;
    public GameObject spawnCoins;

    private int ganharPontos;
    private int perderPontos = 3;

    private void Start()
    {
        instance = this;

        ganharPontos = PlayerPrefs.GetInt("Save");
        pointsText.text = "Pontos: " + ganharPontos;
    }

    public int GetGanharPontos()
    {
        return ganharPontos;
    }

    public int GetPerderPontos()
    {
        return perderPontos;
    }

    public void AddPoints()
    {
        ganharPontos++;

        pointsText.text = "Pontos: " + ganharPontos;

        PlayerPrefs.SetInt("Save", ganharPontos);
    }

    public void DecreasePoints()
    {
        perderPontos--;
        LoseText.text = "Perdas: " + perderPontos;
    }

    public void ShowRestartOption()
    {
        restartOption.SetActive(true);
        Destroy(spawnCoins);
    }
}
