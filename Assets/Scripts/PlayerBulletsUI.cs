using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBulletsUI : MonoBehaviour
{
    TMP_Text text;
    public PlayerShooting targetShooting;

    void Awake() {
        text = GetComponent<TMP_Text>();
    }

    void Update() {
        text.text = "Bullets: " + targetShooting.bulletAmount;
    }
}
