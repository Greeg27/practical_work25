using UnityEngine;
using UnityEngine.Playables;

public class TimelineStart : MonoBehaviour
{
    [SerializeField] PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
    }
}
