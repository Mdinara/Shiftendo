using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightLordScript : MonoBehaviour
{
    public Transform pivotPoint;
    public float rotationSpeed = 10f;

    public GameObject GAH;

    public GameObject LightGhost;
    public GameObject HardGhost;

    public GameObject Ppreset1;
    public GameObject Ppreset2;

    bool Teleporting = false;

    bool secondPhase = false;

    public GameObject Beam;
    public GameObject Beam2;
    void Start()
    {
        StartCoroutine(ProjectileAttack());
    }

    void Update()
    {

    }

    private IEnumerator GhostAttack()
    {
        if (!secondPhase)
        {
            LightGhost.SetActive(true);
            yield return new WaitUntil(() => Teleporting);
            LightGhost.SetActive(false);
        }
        else
        {
            HardGhost.SetActive(true);
            yield return new WaitUntil(() => Teleporting);
            HardGhost.SetActive(false);
        }
    }
    
    private IEnumerator ProjectileAttack()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.6f);
            Instantiate(Ppreset1, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.6f);
            Instantiate(Ppreset2, transform.position, Quaternion.identity);
        }
    }

    private IEnumerator BeamAttack()
    {
        Instantiate(Beam, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(36f);

    }
}
