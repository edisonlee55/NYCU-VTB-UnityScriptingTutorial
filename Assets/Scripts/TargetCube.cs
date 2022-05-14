using UnityEngine;

public class TargetCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            ScoreManager.AddScore(1);
            Destroy(collision.gameObject);
        }
    }
}