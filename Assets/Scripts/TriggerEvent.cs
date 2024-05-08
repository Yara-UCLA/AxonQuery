using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    private readonly List<GameObject> _gameObjects = new();
    private readonly List<ParticleSystem> _particles = new();

    private void Start()
    {
        var children = GetComponentsInChildren<Transform>();
        foreach (var child in children)
        {
            if (transform == child) continue;

            if (child.TryGetComponent<ParticleSystem>(out var particle))
            {
                _particles.Add(particle);
                particle.Stop();
            }
            else
            {
                _gameObjects.Add(child.gameObject);
                child.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var particle in _particles) particle.Play();
        foreach (var obj in _gameObjects) obj.SetActive(true);
    }
}