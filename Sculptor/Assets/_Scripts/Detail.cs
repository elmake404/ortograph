using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detail : MonoBehaviour
{
    [SerializeField]
    private Builder[] _builders;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        
    }
    public IEnumerator ScaleY()
    {
        Vector3 Scale = transform.localScale;
        Scale.y = transform.localScale.x;
        while (transform.localScale.y < Scale.y)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, Scale,0.1f);
            yield return new WaitForSeconds(0.02f);
        }
        
    }
    public void ActivationBuilders()
    {
        if (transform.localScale.y >= 0.5f)
        {
            for (int i = 0; i < _builders.Length; i++)
            {
                _builders[i].gameObject.SetActive(true);
            }
        }
    }
}
