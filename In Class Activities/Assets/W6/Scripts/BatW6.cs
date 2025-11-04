using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField]public float speed = 3f;
    [SerializeField]public Transform target;
    bool IsChasing = false;

    void Update()
    {
        if (IsChasing != false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
    public void StartChasing()
    {
        IsChasing = true;
    }
    public void StopChasing()
    {
        IsChasing = false;
    }
}
