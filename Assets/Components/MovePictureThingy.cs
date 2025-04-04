using System.Collections;
using UnityEngine;

public class MovePictureThingy : MonoBehaviour
{

    public enum OccilationFuntion { Sine, Cosine }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        //to start at zero
        StartCoroutine(Oscillate(OccilationFuntion.Sine, 1f));
        //to start at scalar value
        //StartCoroutine (Oscillate (OccilationFuntion.Cosine, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private IEnumerator Oscillate(OccilationFuntion method, float scalar)
    {
        while (true)
        {
            if (method == OccilationFuntion.Sine)
            {
                transform.position = new Vector3(Mathf.Sin(Time.time) * scalar, 0, 0);
            }
            else if (method == OccilationFuntion.Cosine)
            {
                transform.position = new Vector3(Mathf.Cos(Time.time) * scalar, 0, 0);
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
