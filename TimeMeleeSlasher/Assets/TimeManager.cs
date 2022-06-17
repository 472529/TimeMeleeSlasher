using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float slowDownFactor = 0.05f;
    public float slowDownLength = 2;

    void BulletTime()
    {
        Time.timeScale = slowDownFactor;
    }
}
