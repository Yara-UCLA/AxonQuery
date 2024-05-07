using System;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] private TriggerType type;
    [SerializeField] private GameObject target;

    private void Start()
    {
        switch (type)
        {
            case TriggerType.Particle:
                target.GetComponent<ParticleSystem>().Stop();
                break;
            case TriggerType.OnOff:
                target.SetActive(false);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (type)
        {
            case TriggerType.Particle:
                target.GetComponent<ParticleSystem>().Play();
                break;
            case TriggerType.OnOff:
                target.SetActive(true);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private enum TriggerType
    {
        Particle,
        OnOff
    }
}