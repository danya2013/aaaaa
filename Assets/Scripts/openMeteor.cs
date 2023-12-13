using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMeteor : MonoBehaviour
{
    [SerializeField] GameObject sprite; // Сюда в инспекторе нужно перетащить нужный вам спрайт (здание).
    [SerializeField] public float Speed = 1f; // Задает скорость изменения цвета в единицах в секунду.

    void Update ()
    {
    // Получаем цвет спрайта.
    }

    void OnTriggerEnter2D(Collider2D col)
    {
    var color = sprite.color;
    // Уменьшаем значение альфы с заданной скоростью. Не забываем Time.deltaTime.
    color.a -= Speed * Time.deltaTime;

    // Увеличиваем значение альфы с заданной скоростью. Не забываем Time.deltaTime.
    color.a += Speed * Time.deltaTime;

    // Не даем значению выйти за границы, для цвета это (0, 1).
    color.a = Mathf.Clamp(color.a, 0, 1);

    // Задаем спрайту новый цвет.
    sprite.color = color;
    }
}
