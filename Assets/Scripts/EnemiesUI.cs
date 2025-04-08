using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemiesUI : MonoBehaviour
{
    TMP_Text text;

    void Start() {
        text = GetComponent<TMP_Text>();
        EnemiesManager.instance.onChanged.AddListener(RefreshText);
        text.text = "Remaining Enemies: " + EnemiesManager.instance.enemies.Count;
    }

    void RefreshText() {
        text.text = "Remaining Enemies: " + EnemiesManager.instance.enemies.Count;
    }
}
