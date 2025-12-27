using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
  public string nomedacena;

  public void carregar()

  {
      SceneManager.LoadScene(nomedacena);
  }
}
