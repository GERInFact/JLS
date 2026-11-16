using UnityEngine;

namespace Core._scripts
{
    //TODO: Introduce Generics with Lerp Class to Lerp Generic Types using the current Math etc.
    public class DayNightCycle : MonoBehaviour
    {
        [SerializeField] private float speedDelta;
        private float timePassed;
        private Camera mainCam;
        private Color skyColor;

        private void Awake()
        {
            this.mainCam = this.GetComponent<Camera>();
        }

        private void Start()
        {
            this.skyColor = this.mainCam.backgroundColor;
        }

        private void Update()
        {
            this.TrackTime();
            this.mainCam.backgroundColor = new Color(
                this.skyColor.r * this.GetLerpFactor(),
                this.skyColor.g * this.GetLerpFactor(),
                this.skyColor.b * this.GetLerpFactor(),
                1);
        }
        private void TrackTime() => this.timePassed += Time.deltaTime;
        private float GetLerpFactor() => Mathf.Sin(this.timePassed * (Mathf.PI / 180) * this.speedDelta) / 2 + .5f;
    }
}