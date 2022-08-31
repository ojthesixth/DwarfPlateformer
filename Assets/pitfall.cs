using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pitfall : MonoBehaviour
{
    public GameObject Dwarf _dwarf;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            if (_dwarf //touches sprite then dead )
            {
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
            }

        }
    }
