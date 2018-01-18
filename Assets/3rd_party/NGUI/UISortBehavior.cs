using UnityEngine;

public class UISortBehavior : MonoBehaviour
{
  public UIWidget widgetInFrontOfMe;

  [System.NonSerialized]
  Renderer m_renderer;

  void Awake() {
    m_renderer = this.GetComponent<Renderer>();
  }

  void LateUpdate() {
    if (this.widgetInFrontOfMe != null && this.widgetInFrontOfMe.drawCall != null) {
      int rq = this.widgetInFrontOfMe.drawCall.renderQueue-1;
      foreach (Material material in m_renderer.materials) {
        material.renderQueue = rq;
      }
    }
  }
}
