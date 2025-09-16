using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Tooltip("Units per second")]
    [Range(0f, 20f)]
    public float speed = 5f;   

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0f, v);
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }
}
