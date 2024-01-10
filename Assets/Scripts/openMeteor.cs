using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMeteor : MonoBehaviour
{
    
    public SpriteRenderer _sprite ; // Сюда в инспекторе нужно перетащить спрайт.
    // [SerializeField] GameObject _sprite ; // Сюда в инспекторе нужно перетащить спрайт.
    public KeyCode _key = KeyCode.C; // Здесь в инспекторе нужно выбрать клавишу. 
    public float Speed = 0.00001f; // Задает скорость изменения цвета в единицах в секунду.
    // public class Color color = _sprite.color;
  
    void Start()
    {
      
    }

    void Update () 
    {
        // Получаем цвет спрайта.

    // var color = _sprite.color;
        // Проверяем, нажата ли клавиша.
        // Возможно, будет лучше настроить клавишу в Edit->Project Settings->Input и использовать GetButton. Потребуется изменить и поле _key.
        // if (Input.GetKey (_key)) 
        //     // Уменьшаем значение альфы с заданной скоростью. Не забываем Time.deltaTime.
        //     color.a -= Speed * Time.deltaTime;
        // else
        //     // Увеличиваем значение альфы с заданной скоростью. Не забываем Time.deltaTime.ssssss
        //     color.a += Speed * Time.deltaTime; 

        // // Не даем значению выйти за границы, для цвета это (0, 1).
        // color.a = Mathf.Clamp(color.a, 0, 1); 

        // // Задаем спрайту новый цвет.
        // _sprite.color = color; 
    

  
    }
    
      private void OnTriggerEnter(Collider other)
{
    var color = _sprite.color;
    if (other.gameObject.tag == "wholemet")
            color.a -= Speed * Time.deltaTime;
    // else
    //         color.a += Speed * Time.deltaTime; 
            // Увеличиваем значение альфы с заданной скоростью. Не забываем Time.deltaTime.
    color.a = Mathf.Clamp(color.a, 0, 1); 

        // Задаем спрайту новый цвет.
    _sprite.color = color; 
}
    
    
    }
