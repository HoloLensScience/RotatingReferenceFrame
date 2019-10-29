using UnityEngine;

public class Earth2D : MonoBehaviour
{
    public float RevolutionPeriod;
    private float previousTime;
    Vector3 RotationAxis = new Vector3(0f, 1f, 0f);

    void Start()
    {
        previousTime = Time.time;
    }

    void Update()
    {
        float angle = 360f * (Time.time - previousTime) / RevolutionPeriod;
        previousTime = Time.time;
        this.transform.Rotate(RotationAxis, angle);
    }
}
