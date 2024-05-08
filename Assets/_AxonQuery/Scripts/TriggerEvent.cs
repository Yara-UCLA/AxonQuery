using System.Collections.Generic;
using UnityEngine;

namespace _AxonQuery.Scripts
{
    public class TriggerEvent : MonoBehaviour
    {
        [HideInInspector] [SerializeField] private List<GameObject> gameObjects = new();
        [HideInInspector] [SerializeField] private List<ParticleSystem> particles = new();

        private void Start()
        {
            foreach (var particle in particles) particle.Stop();
            foreach (var obj in gameObjects) obj.SetActive(false);
        }

        private void OnTriggerEnter(Collider other)
        {
            foreach (var particle in particles) particle.Play();
            foreach (var obj in gameObjects) obj.SetActive(true);
        }

        private void OnValidate()
        {
            gameObjects.Clear();
            particles.Clear();

            var children = GetComponentsInChildren<Transform>();
            foreach (var child in children)
            {
                if (transform == child) continue;

                if (child.TryGetComponent<ParticleSystem>(out var particle))
                    particles.Add(particle);
                else
                    gameObjects.Add(child.gameObject);
            }
        }
    }
}