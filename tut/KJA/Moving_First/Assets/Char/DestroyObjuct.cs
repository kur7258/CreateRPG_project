using UnityEngine;

public class DestroyObjuct : MonoBehaviour
{
    private Vector2 limitMin = new Vector2(-9.5f, -4.5f);
    private Vector2 limitMax = new Vector2(9.5f, 4.5f);

    private void Update()
    {
        if(transform.position.x < limitMin.x || transform.position.x > limitMax.x ||
           transform.position.y < limitMin.y || transform.position.y > limitMax.y)
        {
            Destroy(gameObject);
        }
    }
}
