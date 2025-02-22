using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemiesManager : MonoBehaviour
{
    public static EnemiesManager instance;
    public UnityEvent onChanged;
    public List<Enemy> enemies;

    public void AddEnemy(Enemy enemy) {
        enemies.Add(enemy);
        onChanged.Invoke();
    }

    public void RemoveEnemy(Enemy enemy) {
        enemies.Remove(enemy);
        onChanged.Invoke();
    }
    void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Debug.LogError("Duplicated EnemiesManager, ignoring this one", gameObject);
        }
    }
}
