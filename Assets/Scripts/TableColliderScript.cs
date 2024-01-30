using UnityEngine;

public class TableColliderScript : MonoBehaviour
{
    public GameObject winMenuScript; // Reference to the win menu script
    private int boxesTouched = 0;

    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Object"))
    {
        if (boxesTouched == 0)
        {
            // First box touched, start counting
            boxesTouched++;
        }
        else if (boxesTouched < 3)
        {
            // More than one box touched, keep counting
            boxesTouched++;
        }
        else
        {
            // All boxes touched, show table collider and win menu
            gameObject.SetActive(true); // Activate table collider
            winMenuScript.SetActive(true);
        }
    }
}
}
