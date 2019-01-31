using System.Collections;
using UnityEngine;

public class Corutinier:MonoBehaviour,ICorutinier{

    public void CorutineStart(IEnumerator enumerator)
    {

        StartCoroutine(enumerator);
    }

    public void CorutineStop(IEnumerator enumerator)
    {
        StopCoroutine(enumerator);
    }
    
}