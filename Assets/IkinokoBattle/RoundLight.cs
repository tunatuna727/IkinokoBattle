using UnityEngine;

public class RoundLight : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0, -12)* Time.deltaTime);
    }
}
