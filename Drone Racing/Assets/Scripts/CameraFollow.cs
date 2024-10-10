using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraFollow : MonoBehaviour
{
    public Transform target; // Ссылка на трансформ дрона, за которым будет следовать камера
    public Vector3 offset;   // Смещение камеры относительно цели

    void LateUpdate()
    {
        if (target != null)
        {
            // // Установка позиции камеры на той же высоте, что и дрон, с учетом смещения
            // transform.position = target.position + offset;

            // // Настройка направления, куда смотрит камера
            // transform.LookAt(target);
            
            Vector3 newPosition = target.position - target.forward * offset.z + target.up * offset.y;

            // Направление камеры смотрит на дрона
            transform.LookAt(target);

            // Установка позиции и поворота камеры
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, target.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
    }
}