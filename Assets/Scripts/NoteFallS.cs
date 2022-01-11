using UnityEngine;

public class NoteFallS : MonoBehaviour
{
    public float speed;

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}