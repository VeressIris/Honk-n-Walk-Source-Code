using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float backgroundSize;
    private float startPosX;
    [SerializeField] private GameObject cam;
    [SerializeField] private float effectStrength; //different values for each layer of the background

    void Start()
    {
        startPosX = transform.position.x;

        backgroundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float moveDist = cam.transform.position.x * effectStrength;
        transform.position = new Vector3(startPosX + moveDist, transform.position.y, transform.position.z);

        //loop background
        float temp = cam.transform.position.x * (1 - effectStrength);
        if (temp > startPosX + backgroundSize)
        {
            startPosX += backgroundSize;
        }
    }
}