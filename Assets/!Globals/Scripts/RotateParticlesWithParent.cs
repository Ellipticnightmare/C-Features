using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateParticlesWithParent : MonoBehaviour
{
    public float emitInterval = 1f;

    private float emitTimer = 0f;
    private ParticleSystem ps;
        
    // Use this for initialization
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        emitTimer += Time.deltaTime;
        if(emitTimer > emitInterval)
        {
            Emit();
            emitTimer = 0f;
        }
    }

    void Emit()
    {
        Vector3 dir = transform.parent.eulerAngles;
        float angle = -dir.z;
        ParticleSystem.EmitParams emitParams = new ParticleSystem.EmitParams();
        emitParams.rotation = angle;
        ps.Emit(emitParams, 10);
    }
}
