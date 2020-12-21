using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [SerializeField]
    private Detail _detailPref;
    private Detail _detailObj;
    void Start()
    {

    }
    public void SpawnDetail()
    {
        _detailObj = Instantiate(_detailPref, transform.position, transform.rotation);
        _detailObj.transform.SetParent(transform);
        _detailObj.transform.localScale = new Vector3(1,0,1);
        _detailObj.transform.SetParent(null);
    }
    public void DetailScale()
    {
        StartCoroutine(_detailObj.ScaleY());
        
    }
    public void ActivationDetail()
    {
        _detailObj.ActivationBuilders();
    }
}
