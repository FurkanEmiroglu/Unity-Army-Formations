using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public GameObject leader;
    [SerializeField] RadialFormation formation;

    private void Start()
    {
        formation = leader.GetComponent<RadialFormation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        formation._amount--;
    }
}
