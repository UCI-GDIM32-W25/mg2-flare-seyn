using UnityEngine;

public class DestroyOffscreen : MonoBehaviour
{
    public float destroyX = -12f;

    void Update()
    {
        if (transform.position.x < destroyX)
            Destroy(gameObject);
    }
}
