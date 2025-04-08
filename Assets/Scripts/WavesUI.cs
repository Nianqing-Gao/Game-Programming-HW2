using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WavesUI : MonoBehaviour
{
    TMP_Text text;

    void Start() {
        text = GetComponent<TMP_Text>();
        WavesManager.instance.onChanged.AddListener(RefreshText);

        void RefreshText() {
            text.text = "Remaining Waves: " + WavesManager.instance.waves.Count;
        }
    }
}
