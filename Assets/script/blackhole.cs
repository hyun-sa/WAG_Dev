using UnityEngine;

public class blackhole : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("블랙홀에 닿아서 죽음");
        }
    }
}
