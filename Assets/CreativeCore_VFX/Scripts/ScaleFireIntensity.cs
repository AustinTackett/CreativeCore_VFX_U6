using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScaleFireIntensity : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private float rateOverTime;
    private ParticleSystem particleSys;

    void Start()
    {
        rateOverTime = 20;
        particleSys = GetComponent<ParticleSystem>();

        slider.onValueChanged.AddListener( (v) => {
            rateOverTime = v;
        });
        
    }

    // Update is called once per frame
    void Update()
    {
        var emission = particleSys.emission;
        emission.rateOverTime = rateOverTime;
    }
}
