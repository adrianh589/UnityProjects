using UnityEngine;
using System.Collections;
public class MobileInput : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(5, 5, 200, 20), "Accelerometer X: " + Input.acceleration.x);
        GUI.Label(new Rect(5, 25, 200, 20), "Accelerometer Y: " + Input.acceleration.y);
        GUI.Label(new Rect(5, 45, 200, 20), "Accelerometer Z: " + Input.acceleration.z);
        GUI.Label(new Rect(5, 100, 200, 20), "Number of touches: " + Input.touchCount);
        for (int i = 0; i < Input.touchCount; i++)
        {
            PrintTouchData(Input.touches[i]);
        }
    }
    void PrintTouchData(Touch t)
    {
        GUI.Label(new Rect(t.position.x, Screen.height - t.position.y, 100, 20), t.position.ToString());
        GUI.Label(new Rect(t.position.x, Screen.height - t.position.y + 20, 100, 20), "Finger: " + t.fingerId.ToString());
        GUI.Label(new Rect(t.position.x, Screen.height - t.position.y + 40, 100, 20), "Tap count: " + t.tapCount.ToString());
    }
}

/*
 Cuando el jugador toca la pantalla Input.touchCount nos va a devolver el número de dedos (toques) 
 que están sobre la pantalla. En el array Input.touches vamos a tener cada uno de esos toques del tipo Touch. 
 Lo que hacemos es mostrar en un bucle la información de cada uno de los toques en pantalla.

La información que imprimimos de cada toque es su posición en coordenadas x,y de pantalla (t.position), 
el identificador de dedo (t.fingerId) y el número de 'taps' de ese dedo. Un 'tap' no es más que la acción de 
tocar y dejar de tocar la pantalla de forma rápida, de forma que Unity nos permite detectar si estamos haciendo un 
toque, un doble toque etc. con objeto de poder asociar diferentes acciones a estos toques.
     
     */
