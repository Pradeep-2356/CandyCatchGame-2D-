using UnityEngine;

public class CandyScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameManager.instance.AddScore();
            Destroy(gameObject);
        }

        else if(collider.gameObject.tag == "Boundary")
        {
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);

        }
    }
}
