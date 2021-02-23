using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAksi : MonoBehaviour
{
    // Start is called before the first frame update
    public void Menu_Aksi_GoToPage(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
