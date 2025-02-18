using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustController : MonoBehaviour
{
    [SerializeField] private bool createDustOnWalk = true;          // 플레이어가 걸을때마다 생성
    [SerializeField] private ParticleSystem dustParticleSystem;

    // 파티클 생성 조건
    public void CreateDustParticles()
    {
        if (createDustOnWalk)
        {
            dustParticleSystem.Stop();
            dustParticleSystem.Play();
        }
    }
}
