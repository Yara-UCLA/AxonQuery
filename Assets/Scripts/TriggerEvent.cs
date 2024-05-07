using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    
    private enum TriggerType
    {
        Particle,
        OnOff
    } 
    [SerializeField] private TriggerType type;
    [SerializeField] private GameObject target;

    private void Awake()
    {
        switch (type)
        {
            case TriggerType.Particle:
                target.GetComponent<ParticleSystem>().Stop();
                break;        
            case TriggerType.OnOff:
                target.SetActive(false);
                break;
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
        }
    }
}
