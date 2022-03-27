using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;
    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;
    public float speedMultiplier;

    void Awake()
    {
        currentSpeed = minSpeed;
        generateSpike();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += speedMultiplier;
        }
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateSpike", randomWait);
    }

    private void generateSpike()
    {
        GameObject spikeIns = Instantiate(spike, transform.position, transform.rotation);
        spikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }
}
