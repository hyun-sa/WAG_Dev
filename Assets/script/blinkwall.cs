
using UnityEngine;

public class blinkwall : MonoBehaviour
{
    [SerializeField]
    private float BlinkTime=3;

    private bool b = false;
    private Vector3 pos;
    private Vector2 size;
    private GameObject player;
    private void Awake()
    {
        player = GetComponent<setting>().Return_player();
        size = gameObject.GetComponent<BoxCollider2D>().size/2;
        check_time();
    }


    private void check_time()
    {
        b = !b;
        gameObject.SetActive(b);
        if (b)
        {
            pos = player.transform.position;
            if (System.Math.Abs(transform.position.x-pos.x)<size.x&& System.Math.Abs(transform.position.y - pos.y) < size.y)
            {
                Debug.Log("끼어죽음");
            }
        }
        Invoke("check_time", BlinkTime);
    }
}
